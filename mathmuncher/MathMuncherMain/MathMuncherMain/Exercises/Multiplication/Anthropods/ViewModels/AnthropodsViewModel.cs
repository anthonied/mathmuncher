using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Expression.Interactivity.Core;
using Math_Muncher;
using System.ComponentModel;
using MathMuncherMain.Exercises.Multiplication.Tafels.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Collections.Generic;

namespace MathMuncherMain.Multiplication.Tafels.ViewModels
{

    public class Anthropod1ViewModel: INotifyPropertyChanged
    {
        private List<string> lAnthropodPrefix = new List<string>(new string []{"a","b", "c","d"} );
        private const string _sCompletedBackGroundColor = "#FFAA7622"; 
        private const string _sActiveBackGroundColor = "#FFFFFFFF";
        private const string _sOutstandingGroundColor = "#FFE77C7C";        
        private const string _sInactiveOpacity = "0.2";
        private int _iTotalCorrect = 0;
        private int _iTotalSecondsSpend;
        private DateTime _dtExerciseTimeStart;
        private string _sTables = "";

        public Anthropod1ViewModel()
        {
            //this.ImageConverter = new ImageConverter();
            this.FormData = new FormData();            
            this._ServerData = new ServerData();          
        }

        //Bind properties
        private int _iActiveLeg = 1;
        private int _iActiveAnthropodIndex = 0;
       
        public FormData FormData { get; set; }
        private ServerData _ServerData { get; set; }

        private int? _iInputValue;              
        public int? iInputValue
        {
            get
            {
                return this._iInputValue;
            }
            set
            {
                if (this._iInputValue != value)
                {                    
                    this._iInputValue = value;
                    if (value != null)
                    {
                        SetNextLeg();
                    }
                    
                   this.RaisePropertyChanged("iInputValue");
                }
            }
        }

        private string _StartState;
        public string StartState
        {
            get
            {
                return this._StartState;
            }
            set
            {
                this._StartState = value;
                this.RaisePropertyChanged("StartState");
            }
        }

        private string _viewState;
        public string ViewState
        {
            get
            {
                return this._viewState;
            }
            set
            {
                this._viewState = value;
                this.RaisePropertyChanged("ViewState");
            }
        }


        private bool _SetEnterActive;
        public bool SetEnterActive
        {
            get
            {
                return this._SetEnterActive;
            }
            set
            {
                this._SetEnterActive = value;
                this.RaisePropertyChanged("SetEnterActive");
            }
        }

        private bool _DisableEnterActive;
        public bool DisableEnterActive
        {
            get
            {
                return this._DisableEnterActive;
            }
            set
            {
                this._DisableEnterActive = value;
                this.RaisePropertyChanged("DisableEnterActive");
            }
        }

        private bool _SetInputFocus;
        public bool SetInputFocus
        {
            get
            {
                return this._SetInputFocus;
            }
            set
            {
                this._SetInputFocus = value;
                this.RaisePropertyChanged("SetInputFocus");
            }
        }

        private bool _bIsBusy = false;
        public bool bIsBusy
        {
            get
            {
                return this._bIsBusy;
            }
            set
            {
                this._bIsBusy = value;
                this.RaisePropertyChanged("bIsBusy");
            }
        }

        private string _sExerciseResult;
        public string sExerciseResult
        {
            get
            {
                return this._sExerciseResult;
            }

            set
            {
                if (this._sExerciseResult != value)
                {
                    this._sExerciseResult = value;
                    this.RaisePropertyChanged("sExerciseResult");
                }
            }
        }

        private string _sExerciseTimeSpent;
        public string sExerciseTimeSpent
        {
            get
            {
                return this._sExerciseTimeSpent;
            }

            set
            {
                if (this._sExerciseTimeSpent != value)
                {
                    this._sExerciseTimeSpent = value;
                    this.RaisePropertyChanged("sExerciseTimeSpent");
                }
            }
        }

        private string _sExerciseTables;
        public string sExerciseTables
        {
            get
            {
                return this._sExerciseTables;
            }

            set
            {
                if (this._sExerciseTables != value)
                {
                    this._sExerciseTables = value;
                    this.RaisePropertyChanged("sExerciseTables");
                }
            }
        }

        private ActionCommand _beginExercise;
        public ActionCommand beginExercise
        {
            get
            {
                if (_beginExercise == null)
                {
                    this._beginExercise = new ActionCommand(
                       () =>
                       {                           
                           StartExercise();
                       }
                        );

                }
                return _beginExercise;
            }
        }

        private ActionCommand _nextExercise;
        public ActionCommand nextExercise
        {
            get
            {
                if (_nextExercise == null)
                {
                    this._nextExercise = new ActionCommand(
                       () =>
                       {
                           this.bIsBusy = true;
                           NextExercise();
                       }
                        );

                }
                return _nextExercise;
            }            
        }

        public void StartExercise()
        {
            _iTotalCorrect = 0;
            StartState = lAnthropodPrefix[_iActiveAnthropodIndex] + "Start";
            ManageActiveStyles();
            this.bIsBusy = true;
            for (int iStart = 2; iStart <= 5; iStart++)
            {
                FormData.GetType().GetProperty("sLinkerPootOpacity" + iStart.ToString()).SetValue(FormData, _sInactiveOpacity, null);
                FormData.GetType().GetProperty("sRegterPootOpacity" + iStart.ToString()).SetValue(FormData, _sInactiveOpacity, null);
            }
            this._ServerData.DataCollected += (sender, e) =>
            {
                FillAnthropodData(0); //Fill the first Anthropod with data
                this.SetInputFocus = true;
            }
            ;
            this._ServerData.GetServerData();
            //Start Timer For The First Time
            _dtExerciseTimeStart = DateTime.Now;
        }  

        private void FillAnthropodData(int iExerciseIndex)
        {            
            this.FormData.iLinkerPoot1 = this._ServerData.lAnthropodExercises[iExerciseIndex].lAnthropodLegs[0];
            this.FormData.iLinkerPoot2 = this._ServerData.lAnthropodExercises[iExerciseIndex].lAnthropodLegs[1];
            this.FormData.iLinkerPoot3 = this._ServerData.lAnthropodExercises[iExerciseIndex].lAnthropodLegs[2];
            this.FormData.iLinkerPoot4 = this._ServerData.lAnthropodExercises[iExerciseIndex].lAnthropodLegs[3];
            this.FormData.iLinkerPoot5 = this._ServerData.lAnthropodExercises[iExerciseIndex].lAnthropodLegs[4];
            this.FormData.iModifier = this._ServerData.lAnthropodExercises[iExerciseIndex].iModifier;
            this.bIsBusy = false;            
        }

        private void ManageActiveStyles()
        {
            //Set Completed Legs
            for (int iCompleted = 1; iCompleted < _iActiveLeg; iCompleted++)
            {
                FormData.GetType().GetProperty("sLinkerPootBG" + iCompleted.ToString()).SetValue(FormData, _sCompletedBackGroundColor, null);
                FormData.GetType().GetProperty("sRegterPootBG" + iCompleted.ToString()).SetValue(FormData, _sCompletedBackGroundColor, null);
                FormData.GetType().GetProperty("sLinkerPootOpacity" + iCompleted.ToString()).SetValue(FormData, _sInactiveOpacity, null);
                FormData.GetType().GetProperty("sRegterPootOpacity" + iCompleted.ToString()).SetValue(FormData, _sInactiveOpacity, null);
            }

            //Set Active Leg
            FormData.GetType().GetProperty("sLinkerPootBG" + _iActiveLeg.ToString()).SetValue(FormData, _sActiveBackGroundColor, null);
            FormData.GetType().GetProperty("sRegterPootBG" + _iActiveLeg.ToString()).SetValue(FormData, _sActiveBackGroundColor, null);
            FormData.GetType().GetProperty("sLinkerPootOpacity" + _iActiveLeg.ToString()).SetValue(FormData, "1", null);

            //Set Outstanding Legs
            for (int iOustanding = _iActiveLeg + 1; iOustanding <= 5; iOustanding++)
            {
                FormData.GetType().GetProperty("sLinkerPootBG" + iOustanding.ToString()).SetValue(FormData, _sOutstandingGroundColor, null);
                FormData.GetType().GetProperty("sRegterPootBG" + iOustanding.ToString()).SetValue(FormData, _sOutstandingGroundColor, null);
                FormData.GetType().GetProperty("sLinkerPootOpacity" + iOustanding.ToString()).SetValue(FormData, _sInactiveOpacity, null);
            }
        }

        /// <summary>
        /// Get value from exerices input and update active leg
        /// </summary>
        private void SetNextLeg()
        {            
            FormData.GetType().GetProperty("iRegterPoot" + _iActiveLeg.ToString()).SetValue(FormData, (int)this.iInputValue, null);
            if (_iActiveLeg == 5) //Last Leg
            {
                iInputValue = null;
                this.ViewState = lAnthropodPrefix[_iActiveAnthropodIndex] + "Results";
                _iActiveLeg = 1;
                _iActiveAnthropodIndex++;
                _MarkExercise();
               SetEnterActive = true;
                return;
            }
            iInputValue = null;
            _iActiveLeg++;
            this.SetInputFocus = true;
            ManageActiveStyles();   

        }

        private void _MarkExercise()
        {
            //Stop timer and add time to exercise total            
            TimeSpan tsDuration = DateTime.Now.Subtract(_dtExerciseTimeStart);            
            _iTotalSecondsSpend += tsDuration.Seconds;

            // Configure Results For Backend
            /*
            AnthroPodExerciseResult _thisResult = new AnthroPodExerciseResult();
            _thisResult.iModifier = FormData.iModifier;
            _thisResult.iCorrect = 0;
            // _thisResult.iSecondsSpend = _iAnthropodTimeSec;
            */

            for (int i = 1; i <= 5; i++)
            {
                //set style
                FormData.GetType().GetProperty("sLinkerPootBG" + i.ToString()).SetValue(FormData, _sActiveBackGroundColor, null);
                FormData.GetType().GetProperty("sLinkerPootOpacity" + i.ToString()).SetValue(FormData, "1", null); //Make font opage
                FormData.GetType().GetProperty("sRegterPootOpacity" + i.ToString()).SetValue(FormData, "1", null); //Make font opage

                int iAnswer = ((int)FormData.GetType().GetProperty("iLinkerPoot" + i.ToString()).GetValue(FormData, null) * FormData.iModifier);
                if ((int)FormData.GetType().GetProperty("iRegterPoot" + i.ToString()).GetValue(FormData, null) == iAnswer)
                {
                    FormData.GetType().GetProperty("sRegterPootBG" + i.ToString()).SetValue(FormData, Session.sCorrectBackGroundColor, null);
                    _iTotalCorrect++;
                }
                else
                {
                    FormData.GetType().GetProperty("sRegterPootBG" + i.ToString()).SetValue(FormData, Session.sWrongBackGroundColor, null);
                }
            }


            _sTables += " x " + FormData.iModifier.ToString() + ", ";
            

            //////Result actions
            ////_iTotalMarks += _thisResult.iCorrect;
            
            ////_lResults.Add(_thisResult);
        }

        public void NextExercise()
        {
            //Cancel Enter Event On Root
            DisableEnterActive = true;
            //Reset Timer
            _dtExerciseTimeStart = DateTime.Now;
            if (_iActiveAnthropodIndex < lAnthropodPrefix.Count)
            {
                ManageActiveStyles();
                ClearExerciseData();
                FillAnthropodData(_iActiveAnthropodIndex);
                this.ViewState = lAnthropodPrefix[_iActiveAnthropodIndex] + "Start";
            }
            else
            {
                FormatResults();
                this.ViewState = "ExerciseResults";
            }
        }

        public void InputExcepted(string sInputValue)
        {
            try
            {
                iInputValue = Convert.ToInt32(sInputValue);
            }
            catch
            {
            //Handle invalid string 
            }
        }

        private void ClearExerciseData()
        {
            this.FormData.iLinkerPoot1 = null;
            this.FormData.iLinkerPoot2 = null;
            this.FormData.iLinkerPoot3 = null;
            this.FormData.iLinkerPoot4 = null;
            this.FormData.iLinkerPoot5 = null;
            this.FormData.iRegterPoot1 = null;
            this.FormData.iRegterPoot2 = null;
            this.FormData.iRegterPoot3 = null;
            this.FormData.iRegterPoot4 = null;
            this.FormData.iRegterPoot5 = null;
        }

        private void FormatResults()
        {
            sExerciseResult = _iTotalCorrect.ToString() + " / " + (lAnthropodPrefix.Count * 5).ToString();
            TimeSpan tsTotalSec = new TimeSpan(0, 0, _iTotalSecondsSpend);
            sExerciseTimeSpent = string.Format("{0:D2}:{1:D2}:{2:D2}",
                        tsTotalSec.Hours,
                        tsTotalSec.Minutes,
                        tsTotalSec.Seconds);
            sExerciseTables = _sTables.Remove(_sTables.Length-2,1);
            DisableEnterActive = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
