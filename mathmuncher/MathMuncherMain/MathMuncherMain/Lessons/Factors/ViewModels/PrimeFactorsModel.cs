using System;
using System.Net;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using MathMuncherMain.Classes;
using MathMuncherMain.Exercises.Factors.ViewModels;

namespace MathMuncherMain.Lessons.Factors.ViewModels
{
	public class PrimeFactorsModel : INotifyPropertyChanged
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
		private PrimeFactor_Messages PrimeFactor_Messages { get; set; }

        private int? _iPrimeValue1;
        private int? _iPrimeValue2;
        private int? _iPrimeValue3;
        private int? _iPrimeValue4;
        private int? _iPrimeValue5;
        private int? _iPrimeValue6;
        private int? _iPrimeValue7;
        private int? _iPrimeValue8;
        private int? _iPrimeValue9;
        
        public int? iPrimeValue1
        {
            get { return _iPrimeValue1; }
            set
            {
                _iPrimeValue1 = value;
                this.RaisePropertyChanged("iPrimeValue1");
            }
        }
        public int? iPrimeValue2
        {
            get { return _iPrimeValue2; }
            set { _iPrimeValue2 = value;
                this.RaisePropertyChanged("iPrimeValue2");
            }
        }
        public int? iPrimeValue3
        {
            get { return _iPrimeValue3; }
            set
            {
                _iPrimeValue3 = value;
                this.RaisePropertyChanged("iPrimeValue3");
            }
        }
        public int? iPrimeValue4
        {
            get { return _iPrimeValue4; }
            set
            {
                _iPrimeValue4 = value;
                this.RaisePropertyChanged("iPrimeValue4");
            }
        }
        public int? iPrimeValue5
        {
            get { return _iPrimeValue5; }
            set
            {
                _iPrimeValue5 = value;
                this.RaisePropertyChanged("iPrimeValue5");
            }
        }
        public int? iPrimeValue6
        {
            get { return _iPrimeValue6; }
            set
            {
                _iPrimeValue6 = value;
                this.RaisePropertyChanged("iPrimeValue6");
            }
        }
        public int? iPrimeValue7
        {
            get { return _iPrimeValue7; }
            set
            {
                _iPrimeValue7 = value;
                this.RaisePropertyChanged("iPrimeValue7");
            }
        }
        public int? iPrimeValue8
        {
            get { return _iPrimeValue8; }
            set
            {
                _iPrimeValue8 = value;
                this.RaisePropertyChanged("iPrimeValue8");
            }
        }
        public int? iPrimeValue9
        {
            get { return _iPrimeValue9; }
            set
            {
                _iPrimeValue9 = value;
                this.RaisePropertyChanged("iPrimeValue9");
            }
        }

private string _sPrimeBackColor1 = "transparent";
public string sPrimeBackColor1
{
    get { return _sPrimeBackColor1; }
    set
    {
        _sPrimeBackColor1 = value;
        this.RaisePropertyChanged("sPrimeBackColor1");
    }
}

private string _sPrimeBackColor2 = "transparent";
public string sPrimeBackColor2
{
    get { return _sPrimeBackColor2; }
    set
    {
        _sPrimeBackColor2 = value;
        this.RaisePropertyChanged("sPrimeBackColor2");
    }
}

private string _sPrimeBackColor3 = "transparent";

public string sPrimeBackColor3
{
    get { return _sPrimeBackColor3; }
    set
    {
        _sPrimeBackColor3 = value;
        this.RaisePropertyChanged("sPrimeBackColor3");
    }
}
private string _sPrimeBackColor4 = "transparent";

public string sPrimeBackColor4
{
    get { return _sPrimeBackColor4; }
    set
    {
        _sPrimeBackColor4 = value;
        this.RaisePropertyChanged("sPrimeBackColor4");
    }
}
private string _sPrimeBackColor5 = "transparent";

public string sPrimeBackColor5
{
    get { return _sPrimeBackColor5; }
    set
    {
        _sPrimeBackColor5 = value;
        this.RaisePropertyChanged("sPrimeBackColor5");
    }
}
private string _sPrimeBackColor6 = "transparent";

public string sPrimeBackColor6
{
    get { return _sPrimeBackColor6; }
    set
    {
        _sPrimeBackColor6 = value;
        this.RaisePropertyChanged("sPrimeBackColor6");
    }
}
private string _sPrimeBackColor7 = "transparent";

public string sPrimeBackColor7
{
    get { return _sPrimeBackColor7; }
    set
    {
        _sPrimeBackColor7 = value;
        this.RaisePropertyChanged("sPrimeBackColor7");
    }
}
private string _sPrimeBackColor8 = "transparent";

public string sPrimeBackColor8
{
    get { return _sPrimeBackColor8; }
    set { _sPrimeBackColor8 = value; 
    this.RaisePropertyChanged("sPrimeBackColor8");
    }
}
private string _sPrimeBackColor9 = "transparent";

public string sPrimeBackColor9
{
    get { return _sPrimeBackColor9; }
    set { _sPrimeBackColor9 = value;
    this.RaisePropertyChanged("sPrimeBackColor9");
    }
}
		//End Properties
		
		public PrimeFactorsModel()
		{
			MessageBundles = new MessageBundles();
            PrimeFactor_Messages = new PrimeFactor_Messages();
            ViewState = "BaseState";
		}
		public void startLesson()
        {
			PrimeFactor_Messages = MessageBundles.Set_G7_PF_Afrikaans();
            LoadText();
		}

		private void LoadText()
		{
			sMainHeading = PrimeFactor_Messages.sMainHeading;
			sMessageIntroduction = PrimeFactor_Messages.sMessageIntroduction;
			sLessonState1Heading = PrimeFactor_Messages.sLessonState1Heading;
		}
		public void NextState()
		{
			_iActiveState++;
			if (_iActiveState < 8)
			{
				ViewState = "LessonState" + _iActiveState.ToString();
			}
			else
			{
				Session.sActiveExercise = "PrimeFactors";
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

        //=======================================================
        //=======================================================
        public ServerData_PF ServerData { get; set; }

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


        private int _iActiveInput = 1;

        public void NextAnswer(int iActiveInput)
        {
            iActiveInput++;
            _iActiveInput = iActiveInput;
            SetInputFocus = "txtPrimeFactor_" + iActiveInput.ToString();
        }

        public void MarkExercise(List<string> lAnswers)
        {
            bool bPass = true;
            List<string> lFactorsNumbers_PF_1 = new List<string>(new string[] { "3", "5", "7", "11", "13", "17", "19", "23", "29" });
   
            for (int i = 1; i <= 9; i++)
            {
                if (lAnswers[i-1] == (lFactorsNumbers_PF_1[i - 1].ToString()))
                    this.GetType().GetProperty("sPrimeBackColor" + i.ToString()).SetValue(this, "#5000FF33", null);
                else
                {
                    this.GetType().GetProperty("sPrimeBackColor" + i.ToString()).SetValue(this, "#6CFF5D00", null);
                    bPass = false;
                }
            }

            if (bPass)
            {
                for (int i = 1; i <= 9; i++)
                    this.GetType().GetProperty("sPrimeBackColor" + i.ToString()).SetValue(this, "transparent", null);

                NextState();
            }

        }


		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(String info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

		#endregion
	}
}