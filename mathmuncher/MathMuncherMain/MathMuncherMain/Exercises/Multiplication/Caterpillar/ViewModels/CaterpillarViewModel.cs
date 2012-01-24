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
using System.ComponentModel.DataAnnotations;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Collections.Generic;

namespace MathMuncherMain.Exercises.Multiplication.Caterpillar.ViewModels
{

    public class CaterpillarViewModel : INotifyPropertyChanged
    {        
        private List<string> _lRedArrowMargins = new List<string>(new string[] { "159,489,0,514", "286,610,0,375", "524,589,0,487", "560,585,0,413", "820,600,490,390"});
        private List<string> _lRedArrowAngles = new List<string>(new string[] { "-31", "-47", "-125", "-45", "-128" });        
        private const string _sCompletedBackGroundColor = "#FF0D006E"; 
        private const string _sOutstandingColor = "#FF8B8B8B";
        private const string _sActiveBackGroundColor = "White";
        private const string _sModifierColor = "#FFB80B0B";
        private const string _sSystemDataColor = "#FF000000";        
        private const string _sExerciseDataColor = "White";
        private const string _sInactiveOpacity = "0.2";
        private int _iActiveLeg = 3;
        private int _iActiveCaterpillarIndex = 0;
        private DateTime _dtExerciseTimeStart;
        private int _iBestSeconds = 0;
        private int _iTotalSeconds;

        //Properties
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

        private string _ViewState;
        public string ViewState
        {
            get
            {
                return this._ViewState;
            }
            set
            {
                this._ViewState = value;
                this.RaisePropertyChanged("ViewState");
            }
        }

        private string _SetInputFocus;
        public string SetInputFocus
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

        private string _sExerciseTotalTimeSpent;
        public string sExerciseTotalTimeSpent
        {
            get
            {
                return this._sExerciseTotalTimeSpent;
            }

            set
            {
                if (this._sExerciseTotalTimeSpent != value)
                {
                    this._sExerciseTotalTimeSpent = value;
                    this.RaisePropertyChanged("sExerciseTotalTimeSpent");
                }
            }
        }

        private string _sExerciseBestTimeSpent;
        public string sExerciseBestTimeSpent
        {
            get
            {
                return this._sExerciseBestTimeSpent;
            }

            set
            {
                if (this._sExerciseBestTimeSpent != value)
                {
                    this._sExerciseBestTimeSpent = value;
                    this.RaisePropertyChanged("sExerciseBestTimeSpent");
                }
            }
        }
        
        public FormData FormData { get; set; }
        public ServerData ServerData { get; set; }

        //End Properties

        public CaterpillarViewModel()
        {            
            this.FormData = new FormData();
            this.ServerData = new ServerData();            
            
        }

        public void startExercise()
        {
            
            StartState = "aStart";            
            ManageActiveStyles();
            ServerData.GetServerData();
            FillCaterpillarData();
            SetExerciseDataStyles();
            _dtExerciseTimeStart = DateTime.Now;
            /*this.ServerData.DataCollected += (sender, e) =>
                {
                   
                };*/
        }

        private void FillCaterpillarData()
        {
            FormData.iValue1 = ServerData.lCaterpillerData[_iActiveCaterpillarIndex].iStartingValue;
            FormData.iValue2 = ServerData.lCaterpillerData[_iActiveCaterpillarIndex].iModifier1;
            FormData.iValue4 = ServerData.lCaterpillerData[_iActiveCaterpillarIndex].iModifier2;
            FormData.iValue6 = ServerData.lCaterpillerData[_iActiveCaterpillarIndex].iModifier3;
            FormData.iValue8 = ServerData.lCaterpillerData[_iActiveCaterpillarIndex].iModifier4;
            FormData.iValue10 = ServerData.lCaterpillerData[_iActiveCaterpillarIndex].iModifier5;
            FormData.sValue2 = "x" + FormData.iValue2.ToString();
            FormData.sValue4 = "x" + FormData.iValue4.ToString();
            FormData.sValue6 = "x" + FormData.iValue6.ToString();
            FormData.sValue8 = "x" + FormData.iValue8.ToString();
            FormData.sValue10 = "x" + FormData.iValue10.ToString();
            
        }

        public void SetActiveFocus()
        {
            SetInputFocus = ServerData.lCaterpillarPrefix[_iActiveCaterpillarIndex] + "txtSircle" + _iActiveLeg.ToString();
        }
        
        private void SetExerciseDataStyles()
        {
            FormData.sSircleBG1 = _sExerciseDataColor;
            FormData.sSircleBG2 = _sExerciseDataColor;
            FormData.sSircleBG4 = _sExerciseDataColor;
            FormData.sSircleBG6 = _sExerciseDataColor;
            FormData.sSircleBG8 = _sExerciseDataColor;
            FormData.sSircleBG10 = _sExerciseDataColor;
            FormData.sSircleTextColor1 = _sSystemDataColor;
            FormData.sSircleTextColor2 = _sModifierColor;
            FormData.sSircleTextColor3 = _sSystemDataColor;
            FormData.sSircleTextColor4 = _sModifierColor;
            FormData.sSircleTextColor6 = _sModifierColor;
            FormData.sSircleTextColor8 = _sModifierColor;
            FormData.sSircleTextColor10 = _sModifierColor;
            FormData.sSircleViewTextVisibility3 = "Collapsed";
            FormData.sSircleInputTextVisibility3 = "Visible";
            FormData.sSircleViewTextVisibility5 = "Collapsed";
            FormData.sSircleInputTextVisibility5 = "Collapsed";
            FormData.sSircleViewTextVisibility7 = "Collapsed";
            FormData.sSircleInputTextVisibility7 = "Collapsed";
            FormData.sSircleViewTextVisibility9 = "Collapsed";
            FormData.sSircleInputTextVisibility9 = "Collapsed";
            FormData.sSircleViewTextVisibility11 = "Collapsed";
            FormData.sSircleInputTextVisibility11 = "Collapsed";
            FormData.sRedArrowMargin = _lRedArrowMargins[((_iActiveLeg - 1) / 2) - 1];
            FormData.sRedArrowAngle = _lRedArrowAngles[((_iActiveLeg - 1) / 2) - 1];
        }

        private void ManageActiveStyles()
        {            
            //Set Active Leg
            FormData.GetType().GetProperty("sSircleBG" + _iActiveLeg.ToString()).SetValue(FormData, _sActiveBackGroundColor, null);         

            //Set Outstanding Legs
            for (int iOustanding = _iActiveLeg+2; iOustanding <= 11; iOustanding+=2)
            {
                FormData.GetType().GetProperty("sSircleBG" + iOustanding.ToString()).SetValue(FormData, _sOutstandingColor, null);                
            }
              
        }
        
        public void NextNode(int iValue)
        {
                FormData.GetType().GetProperty("iValue" + _iActiveLeg.ToString()).SetValue(FormData, iValue, null);
                FormData.GetType().GetProperty("sSircleInputTextVisibility" + _iActiveLeg.ToString()).SetValue(FormData, "Collapsed", null);
                FormData.GetType().GetProperty("sSircleViewTextVisibility" + _iActiveLeg.ToString()).SetValue(FormData, "Vissible", null);
                FormData.GetType().GetProperty("sSircleBG" + _iActiveLeg.ToString()).SetValue(FormData, _sCompletedBackGroundColor, null);
                FormData.GetType().GetProperty("sSircleTextColor" + _iActiveLeg.ToString()).SetValue(FormData, "White", null);
                if (_iActiveLeg != 11)
                {
                    _iActiveLeg += 2;
                    FormData.GetType().GetProperty("sRedArrowMargin").SetValue(FormData, _lRedArrowMargins[((_iActiveLeg - 1) / 2) - 1], null);
                    FormData.GetType().GetProperty("sRedArrowAngle").SetValue(FormData, _lRedArrowAngles[((_iActiveLeg - 1) / 2) - 1], null);
                    FormData.GetType().GetProperty("sSircleBG" + _iActiveLeg.ToString()).SetValue(FormData, _sActiveBackGroundColor, null);
                    FormData.GetType().GetProperty("sSircleInputTextVisibility" + _iActiveLeg.ToString()).SetValue(FormData, "Vissible", null);
                    SetInputFocus = ServerData.lCaterpillarPrefix[_iActiveCaterpillarIndex] + "txtSircle" + _iActiveLeg.ToString();
                }
                else
                { 
                    MarkExercise();
                }
        }

        private void MarkExercise()
        {            
            for (int iAnswer = 3; iAnswer <= 11; iAnswer += 2)
            {
                FormData.GetType().GetProperty("sSircleTextColor" + iAnswer.ToString()).SetValue(FormData, "White", null);
                if ((int)FormData.GetType().GetProperty("iValue" + (iAnswer - 2).ToString()).GetValue(FormData, null) * (int)FormData.GetType().GetProperty("iValue" + (iAnswer - 1).ToString()).GetValue(FormData, null) == (int)FormData.GetType().GetProperty("iValue" + iAnswer.ToString()).GetValue(FormData, null))
                {
                    FormData.GetType().GetProperty("sSircleBG" + iAnswer.ToString()).SetValue(FormData, Session.sCorrectBackGroundColor, null);

                }
                else
                {
                    FormData.GetType().GetProperty("sSircleBG" + iAnswer.ToString()).SetValue(FormData, Session.sWrongBackGroundColor, null);
                    _iActiveLeg = iAnswer;
                    SetWrongState();
                    return;
                }
            }
            //if you get to this point, the exercise is completed
            TimeSpan tsDuration = DateTime.Now.Subtract(_dtExerciseTimeStart);
            _iTotalSeconds += tsDuration.Seconds;
            if (_iBestSeconds == 0  || tsDuration.Seconds < _iBestSeconds)
            {
                _iBestSeconds = tsDuration.Seconds;
            }            

            ViewState = ServerData.lCaterpillarPrefix[_iActiveCaterpillarIndex] + "Results";
            SetEnterActive = true;
        }

        private void SetWrongState()
        {
            FormData.GetType().GetProperty("sRedArrowMargin").SetValue(FormData, _lRedArrowMargins[((_iActiveLeg - 1) / 2) - 1], null);
            FormData.GetType().GetProperty("sRedArrowAngle").SetValue(FormData, _lRedArrowAngles[((_iActiveLeg - 1) / 2) - 1], null);            
            FormData.GetType().GetProperty("sSircleInputTextVisibility" + _iActiveLeg.ToString()).SetValue(FormData, "Vissible", null);
            for (int iAnswer = _iActiveLeg; iAnswer <= 11; iAnswer += 2)
            {
                FormData.GetType().GetProperty("sSircleViewTextVisibility" + iAnswer.ToString()).SetValue(FormData, "Collapsed", null);
            }
            SetInputFocus = ServerData.lCaterpillarPrefix[_iActiveCaterpillarIndex] + "txtSircle" + _iActiveLeg.ToString();
        }

        public void NextExercise()
        {
            DisableEnterActive = true;
            _iActiveCaterpillarIndex++;
            if (_iActiveCaterpillarIndex < ServerData.lCaterpillarPrefix.Count) // Next Exercis
            {                
                _iActiveLeg = 3;
                ManageActiveStyles();
                SetExerciseDataStyles();
                ClearExerciseData();
                FillCaterpillarData();
                ViewState = ServerData.lCaterpillarPrefix[_iActiveCaterpillarIndex] + "Start";
                _dtExerciseTimeStart = DateTime.Now;
            }
            else //Final - Show results
            {
                FormatResults();
                ViewState = "ExerciseResults";
            }            
        }

        private void FormatResults()
        {

            DisableEnterActive = true;
           TimeSpan tsTotalSec = new TimeSpan(0, 0, _iTotalSeconds);
           sExerciseTotalTimeSpent = string.Format("{0:D2}:{1:D2}:{2:D2}",
                        tsTotalSec.Hours,
                        tsTotalSec.Minutes,
                        tsTotalSec.Seconds);
           TimeSpan tsBestSec = new TimeSpan(0, 0, _iBestSeconds);
           sExerciseBestTimeSpent = string.Format("{0:D2}:{1:D2}:{2:D2}",
                        tsBestSec.Hours,
                        tsBestSec.Minutes,
                        tsBestSec.Seconds);
            
            
        }

        private void ClearExerciseData()
        {
            FormData.iValue3 = null;
            FormData.iValue5 = null;
            FormData.iValue7 = null;
            FormData.iValue9 = null;
            FormData.iValue11 = null;

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