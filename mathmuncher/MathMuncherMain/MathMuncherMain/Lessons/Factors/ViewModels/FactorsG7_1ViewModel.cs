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
using System.ComponentModel;

namespace MathMuncherMain.Lessons.Factors.ViewModels
{
    public class FactorsG7_1ViewModel : INotifyPropertyChanged
    {
        private int _iActiveState = 0;
        //Properties

        private string _Navigate;
        public string Navigate
        {
            get
            {
                return this._Navigate;
            }

            set
            {
                if (this._Navigate != value)
                {
                    this._Navigate = value;
                    this.RaisePropertyChanged("Navigate");
                }
            }
        }

        private string _sMainHeading;
        public string sMainHeading
        {
            get
            {
                return this._sMainHeading;
            }

            set
            {
                if (this._sMainHeading != value)
                {
                    this._sMainHeading = value;
                    this.RaisePropertyChanged("sMainHeading");
                }
            }
        }

        private string _sMessageIntroduction;
        public string sMessageIntroduction
        {
            get
            {
                return this._sMessageIntroduction;
            }

            set
            {
                if (this._sMessageIntroduction != value)
                {
                    this._sMessageIntroduction = value;
                    this.RaisePropertyChanged("sMessageIntroduction");
                }
            }
        }

        private string _sLessonState1Heading;
        public string sLessonState1Heading
        {
            get
            {
                return this._sLessonState1Heading;
            }

            set
            {
                if (this._sLessonState1Heading != value)
                {
                    this._sLessonState1Heading = value;
                    this.RaisePropertyChanged("sLessonState1Heading");
                }
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

        private MessageBundles MessageBundles { get; set; }
        private FactorG7_1_Messages FactorG7_1_Messages { get; set; }
        //End Properties

        public FactorsG7_1ViewModel()
        {
            MessageBundles = new MessageBundles();
            FactorG7_1_Messages = new FactorG7_1_Messages();
        }
        public void startLesson()
        {
            FactorG7_1_Messages = MessageBundles.Set_G7_1_Afrikaans();
            LoadText();
        }

        private void LoadText()
        {            
            sMainHeading = FactorG7_1_Messages.sMainHeading;
            sMessageIntroduction = FactorG7_1_Messages.sMessageIntroduction;
            sLessonState1Heading = FactorG7_1_Messages.sLessonState1Heading;
        }
        public void NextState()
        {
            _iActiveState++;
            if (_iActiveState < 4)
            {
                ViewState = "LessonState" + _iActiveState.ToString();
            }
            else
            {
                Session.sActiveExercise = "FactorsG7_1";
                Navigate = "/Exercises/Views/ExerciseStart";
            }
            
        }

        public void PreviousState()
        {
           
            if (_iActiveState > 1)
            {
                _iActiveState--;
                ViewState = "LessonState" + _iActiveState.ToString();
            }
            else if (_iActiveState == 1)
            {
                _iActiveState--;
                ViewState = "BaseState";
            }            
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
