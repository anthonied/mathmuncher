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
using System.ServiceModel.DomainServices.Client;

namespace MathMuncherMain.Exercises.Multiplication.Caterpillar.ViewModels
{
    public class FormData : ComplexObject
    {
        private string _sSircleBG1;
        private string _sSircleBG2;
        private string _sSircleBG3;
        private string _sSircleBG4;
        private string _sSircleBG5;
        private string _sSircleBG6;
        private string _sSircleBG7;
        private string _sSircleBG8;
        private string _sSircleBG9;
        private string _sSircleBG10;
        private string _sSircleBG11;        
        private string _sSircleInputTextVisibility3;        
        private string _sSircleInputTextVisibility5;        
        private string _sSircleInputTextVisibility7;        
        private string _sSircleInputTextVisibility9;        
        private string _sSircleInputTextVisibility11;
        private string _sSircleViewTextVisibility3;
        private string _sSircleViewTextVisibility5;
        private string _sSircleViewTextVisibility7;
        private string _sSircleViewTextVisibility9;
        private string _sSircleViewTextVisibility11;
        private string _sSircleTextColor1;
        private string _sSircleTextColor2;
        private string _sSircleTextColor3;
        private string _sSircleTextColor4;
        private string _sSircleTextColor5;
        private string _sSircleTextColor6;
        private string _sSircleTextColor7;
        private string _sSircleTextColor8;
        private string _sSircleTextColor9;
        private string _sSircleTextColor10;
        private string _sSircleTextColor11;
        private int _iValue1;
        private int _iValue2;
        private int? _iValue3;
        private int _iValue4;
        private int? _iValue5;
        private int _iValue6;
        private int? _iValue7;
        private int _iValue8;
        private int? _iValue9;
        private int _iValue10;
        private int? _iValue11;
        private string _sValue2;
        private string _sValue4;
        private string _sValue6;
        private string _sValue8;
        private string _sValue10;
        private string _sRedArrowMargin;
        private string _sRedArrowAngle;

        public string sSircleBG1
        {
            get
            {
                return this._sSircleBG1;
            }
            set
            {
                if (this._sSircleBG1 != value)
                {
                    this.ValidateProperty("sSircleBG1", value);
                    this._sSircleBG1 = value;
                    this.RaisePropertyChanged("sSircleBG1");
                }

            }
        }

        public string sSircleBG2
        {
            get
            {
                return this._sSircleBG2;
            }
            set
            {
                if (this._sSircleBG2 != value)
                {
                    this.ValidateProperty("sSircleBG2", value);
                    this._sSircleBG2 = value;
                    this.RaisePropertyChanged("sSircleBG2");
                }

            }
        }

        public string sSircleBG3
        {
            get
            {
                return this._sSircleBG3;
            }
            set
            {
                if (this._sSircleBG3 != value)
                {
                    this.ValidateProperty("sSircleBG3", value);
                    this._sSircleBG3 = value;
                    this.RaisePropertyChanged("sSircleBG3");
                }

            }
        }

        public string sSircleBG4
        {
            get
            {
                return this._sSircleBG4;
            }
            set
            {
                if (this._sSircleBG4 != value)
                {
                    this.ValidateProperty("sSircleBG4", value);
                    this._sSircleBG4 = value;
                    this.RaisePropertyChanged("sSircleBG4");
                }

            }
        }

        public string sSircleBG5
        {
            get
            {
                return this._sSircleBG5;
            }
            set
            {
                if (this._sSircleBG5 != value)
                {
                    this.ValidateProperty("sSircleBG5", value);
                    this._sSircleBG5 = value;
                    this.RaisePropertyChanged("sSircleBG5");
                }

            }
        }

        public string sSircleBG6
        {
            get
            {
                return this._sSircleBG6;
            }
            set
            {
                if (this._sSircleBG6 != value)
                {
                    this.ValidateProperty("sSircleBG6", value);
                    this._sSircleBG6 = value;
                    this.RaisePropertyChanged("sSircleBG6");
                }

            }
        }

        public string sSircleBG7
        {
            get
            {
                return this._sSircleBG7;
            }
            set
            {
                if (this._sSircleBG7 != value)
                {
                    this.ValidateProperty("sSircleBG7", value);
                    this._sSircleBG7 = value;
                    this.RaisePropertyChanged("sSircleBG7");
                }

            }
        }

        public string sSircleBG8
        {
            get
            {
                return this._sSircleBG8;
            }
            set
            {
                if (this._sSircleBG8 != value)
                {
                    this.ValidateProperty("sSircleBG8", value);
                    this._sSircleBG8 = value;
                    this.RaisePropertyChanged("sSircleBG8");
                }

            }
        }

        public string sSircleBG9
        {
            get
            {
                return this._sSircleBG9;
            }
            set
            {
                if (this._sSircleBG9 != value)
                {
                    this.ValidateProperty("sSircleBG9", value);
                    this._sSircleBG9 = value;
                    this.RaisePropertyChanged("sSircleBG9");
                }

            }
        }

        public string sSircleBG10
        {
            get
            {
                return this._sSircleBG10;
            }
            set
            {
                if (this._sSircleBG10 != value)
                {
                    this.ValidateProperty("sSircleBG10", value);
                    this._sSircleBG10 = value;
                    this.RaisePropertyChanged("sSircleBG10");
                }

            }
        }

        public string sSircleBG11
        {
            get
            {
                return this._sSircleBG11;
            }
            set
            {
                if (this._sSircleBG11 != value)
                {
                    this.ValidateProperty("sSircleBG11", value);
                    this._sSircleBG11 = value;
                    this.RaisePropertyChanged("sSircleBG11");
                }

            }
        }
        

        public string sSircleInputTextVisibility3
        {
            get
            {
                return this._sSircleInputTextVisibility3;
            }
            set
            {
                if (this._sSircleInputTextVisibility3 != value)
                {
                    this.ValidateProperty("sSircleInputTextVisibility3", value);
                    this._sSircleInputTextVisibility3 = value;
                    this.RaisePropertyChanged("sSircleInputTextVisibility3");
                }

            }
        }        

        public string sSircleInputTextVisibility5
        {
            get
            {
                return this._sSircleInputTextVisibility5;
            }
            set
            {
                if (this._sSircleInputTextVisibility5 != value)
                {
                    this.ValidateProperty("sSircleInputTextVisibility5", value);
                    this._sSircleInputTextVisibility5 = value;
                    this.RaisePropertyChanged("sSircleInputTextVisibility5");
                }

            }
        }

        public string sSircleInputTextVisibility7
        {
            get
            {
                return this._sSircleInputTextVisibility7;
            }
            set
            {
                if (this._sSircleInputTextVisibility7 != value)
                {
                    this.ValidateProperty("sSircleInputTextVisibility7", value);
                    this._sSircleInputTextVisibility7 = value;
                    this.RaisePropertyChanged("sSircleInputTextVisibility7");
                }

            }
        }
        
        public string sSircleInputTextVisibility9
        {
            get
            {
                return this._sSircleInputTextVisibility9;
            }
            set
            {
                if (this._sSircleInputTextVisibility9 != value)
                {
                    this.ValidateProperty("sSircleInputTextVisibility9", value);
                    this._sSircleInputTextVisibility9 = value;
                    this.RaisePropertyChanged("sSircleInputTextVisibility9");
                }

            }
        }
        
        public string sSircleInputTextVisibility11
        {
            get
            {
                return this._sSircleInputTextVisibility11;
            }
            set
            {
                if (this._sSircleInputTextVisibility11 != value)
                {
                    this.ValidateProperty("sSircleInputTextVisibility11", value);
                    this._sSircleInputTextVisibility11 = value;
                    this.RaisePropertyChanged("sSircleInputTextVisibility11");
                }

            }
        }

        public string sSircleViewTextVisibility3
        {
            get
            {
                return this._sSircleViewTextVisibility3;
            }
            set
            {
                if (this._sSircleViewTextVisibility3 != value)
                {
                    this.ValidateProperty("sSircleViewTextVisibility3", value);
                    this._sSircleViewTextVisibility3 = value;
                    this.RaisePropertyChanged("sSircleViewTextVisibility3");
                }

            }
        }

        public string sSircleViewTextVisibility5
        {
            get
            {
                return this._sSircleViewTextVisibility5;
            }
            set
            {
                if (this._sSircleViewTextVisibility5 != value)
                {
                    this.ValidateProperty("sSircleViewTextVisibility5", value);
                    this._sSircleViewTextVisibility5 = value;
                    this.RaisePropertyChanged("sSircleViewTextVisibility5");
                }

            }
        }

        public string sSircleViewTextVisibility7
        {
            get
            {
                return this._sSircleViewTextVisibility7;
            }
            set
            {
                if (this._sSircleViewTextVisibility7 != value)
                {
                    this.ValidateProperty("sSircleViewTextVisibility7", value);
                    this._sSircleViewTextVisibility7 = value;
                    this.RaisePropertyChanged("sSircleViewTextVisibility7");
                }

            }
        }

        public string sSircleViewTextVisibility9
        {
            get
            {
                return this._sSircleViewTextVisibility9;
            }
            set
            {
                if (this._sSircleViewTextVisibility9 != value)
                {
                    this.ValidateProperty("sSircleViewTextVisibility9", value);
                    this._sSircleViewTextVisibility9 = value;
                    this.RaisePropertyChanged("sSircleViewTextVisibility9");
                }

            }
        }

        public string sSircleViewTextVisibility11
        {
            get
            {
                return this._sSircleViewTextVisibility11;
            }
            set
            {
                if (this._sSircleViewTextVisibility11 != value)
                {
                    this.ValidateProperty("sSircleViewTextVisibility11", value);
                    this._sSircleViewTextVisibility11 = value;
                    this.RaisePropertyChanged("sSircleViewTextVisibility11");
                }

            }
        }

        public string sSircleTextColor1
        {
            get
            {
                return this._sSircleTextColor1;
            }
            set
            {
                if (this._sSircleTextColor1 != value)
                {
                    this.ValidateProperty("sSircleTextColor1", value);
                    this._sSircleTextColor1 = value;
                    this.RaisePropertyChanged("sSircleTextColor1");
                }

            }
        }

        public string sSircleTextColor2
        {
            get
            {
                return this._sSircleTextColor2;
            }
            set
            {
                if (this._sSircleTextColor2 != value)
                {
                    this.ValidateProperty("sSircleTextColor2", value);
                    this._sSircleTextColor2 = value;
                    this.RaisePropertyChanged("sSircleTextColor2");
                }

            }
        }

        public string sSircleTextColor3
        {
            get
            {
                return this._sSircleTextColor3;
            }
            set
            {
                if (this._sSircleTextColor3 != value)
                {
                    this.ValidateProperty("sSircleTextColor3", value);
                    this._sSircleTextColor3 = value;
                    this.RaisePropertyChanged("sSircleTextColor3");
                }

            }
        }

        public string sSircleTextColor4
        {
            get
            {
                return this._sSircleTextColor4;
            }
            set
            {
                if (this._sSircleTextColor4 != value)
                {
                    this.ValidateProperty("sSircleTextColor4", value);
                    this._sSircleTextColor4 = value;
                    this.RaisePropertyChanged("sSircleTextColor4");
                }

            }
        }

        public string sSircleTextColor5
        {
            get
            {
                return this._sSircleTextColor5;
            }
            set
            {
                if (this._sSircleTextColor5 != value)
                {
                    this.ValidateProperty("sSircleTextColor5", value);
                    this._sSircleTextColor5 = value;
                    this.RaisePropertyChanged("sSircleTextColor5");
                }

            }
        }

        public string sSircleTextColor6
        {
            get
            {
                return this._sSircleTextColor6;
            }
            set
            {
                if (this._sSircleTextColor6 != value)
                {
                    this.ValidateProperty("sSircleTextColor6", value);
                    this._sSircleTextColor6 = value;
                    this.RaisePropertyChanged("sSircleTextColor6");
                }

            }
        }

        public string sSircleTextColor7
        {
            get
            {
                return this._sSircleTextColor7;
            }
            set
            {
                if (this._sSircleTextColor7 != value)
                {
                    this.ValidateProperty("sSircleTextColor7", value);
                    this._sSircleTextColor7 = value;
                    this.RaisePropertyChanged("sSircleTextColor7");
                }

            }
        }

        public string sSircleTextColor8
        {
            get
            {
                return this._sSircleTextColor8;
            }
            set
            {
                if (this._sSircleTextColor8 != value)
                {
                    this.ValidateProperty("sSircleTextColor8", value);
                    this._sSircleTextColor8 = value;
                    this.RaisePropertyChanged("sSircleTextColor8");
                }

            }
        }

        public string sSircleTextColor9
        {
            get
            {
                return this._sSircleTextColor9;
            }
            set
            {
                if (this._sSircleTextColor9 != value)
                {
                    this.ValidateProperty("sSircleTextColor9", value);
                    this._sSircleTextColor9 = value;
                    this.RaisePropertyChanged("sSircleTextColor9");
                }

            }
        }

        public string sSircleTextColor10
        {
            get
            {
                return this._sSircleTextColor10;
            }
            set
            {
                if (this._sSircleTextColor10 != value)
                {
                    this.ValidateProperty("sSircleTextColor10", value);
                    this._sSircleTextColor10 = value;
                    this.RaisePropertyChanged("sSircleTextColor10");
                }

            }
        }

        public string sSircleTextColor11
        {
            get
            {
                return this._sSircleTextColor11;
            }
            set
            {
                if (this._sSircleTextColor11 != value)
                {
                    this.ValidateProperty("sSircleTextColor11", value);
                    this._sSircleTextColor11 = value;
                    this.RaisePropertyChanged("sSircleTextColor11");
                }

            }
        }

        public int iValue1
        {
            get
            {
                return this._iValue1;
            }
            set
            {
                if (this._iValue1 != value)
                {
                    this.ValidateProperty("iValue1", value);
                    this._iValue1 = value;
                    this.RaisePropertyChanged("iValue1");
                }

            }
        }

        public int iValue2
        {
            get
            {
                return this._iValue2;
            }
            set
            {
                if (this._iValue2 != value)
                {
                    this.ValidateProperty("iValue2", value);
                    this._iValue2 = value;
                    this.RaisePropertyChanged("iValue2");
                }

            }
        }

        public int? iValue3
        {
            get
            {
                return this._iValue3;
            }
            set
            {
                if (this._iValue3 != value)
                {
                    this.ValidateProperty("iValue3", value);
                    this._iValue3 = value;
                    this.RaisePropertyChanged("iValue3");
                }

            }
        }

        public int iValue4
        {
            get
            {
                return this._iValue4;
            }
            set
            {
                if (this._iValue4 != value)
                {
                    this.ValidateProperty("iValue4", value);
                    this._iValue4 = value;
                    this.RaisePropertyChanged("iValue4");
                }

            }
        }

        public int? iValue5
        {
            get
            {
                return this._iValue5;
            }
            set
            {
                if (this._iValue5 != value)
                {
                    this.ValidateProperty("iValue5", value);
                    this._iValue5 = value;
                    this.RaisePropertyChanged("iValue5");
                }

            }
        }

        public int iValue6
        {
            get
            {
                return this._iValue6;
            }
            set
            {
                if (this._iValue6 != value)
                {
                    this.ValidateProperty("iValue6", value);
                    this._iValue6 = value;
                    this.RaisePropertyChanged("iValue6");
                }

            }
        }

        public int? iValue7
        {
            get
            {
                return this._iValue7;
            }
            set
            {
                if (this._iValue7 != value)
                {
                    this.ValidateProperty("iValue7", value);
                    this._iValue7 = value;
                    this.RaisePropertyChanged("iValue7");
                }

            }
        }

        public int iValue8
        {
            get
            {
                return this._iValue8;
            }
            set
            {
                if (this._iValue8 != value)
                {
                    this.ValidateProperty("iValue8", value);
                    this._iValue8 = value;
                    this.RaisePropertyChanged("iValue8");
                }

            }
        }

        public int? iValue9
        {
            get
            {
                return this._iValue9;
            }
            set
            {
                if (this._iValue9 != value)
                {
                    this.ValidateProperty("iValue9", value);
                    this._iValue9 = value;
                    this.RaisePropertyChanged("iValue9");
                }

            }
        }

        public int iValue10
        {
            get
            {
                return this._iValue10;
            }
            set
            {
                if (this._iValue10 != value)
                {
                    this.ValidateProperty("iValue10", value);
                    this._iValue10 = value;
                    this.RaisePropertyChanged("iValue10");
                }

            }
        }

        public int? iValue11
        {
            get
            {
                return this._iValue11;
            }
            set
            {
                if (this._iValue11 != value)
                {
                    this.ValidateProperty("iValue11", value);
                    this._iValue11 = value;
                    this.RaisePropertyChanged("iValue11");
                }

            }
        }

        public string sValue2
        {
            get
            {
                return this._sValue2;
            }
            set
            {
                if (this._sValue2 != value)
                {
                    this.ValidateProperty("sValue2", value);
                    this._sValue2 = value;
                    this.RaisePropertyChanged("sValue2");
                }

            }
        }

        public string sValue4
        {
            get
            {
                return this._sValue4;
            }
            set
            {
                if (this._sValue4 != value)
                {
                    this.ValidateProperty("sValue4", value);
                    this._sValue4 = value;
                    this.RaisePropertyChanged("sValue4");
                }

            }
        }

        public string sValue6
        {
            get
            {
                return this._sValue6;
            }
            set
            {
                if (this._sValue6 != value)
                {
                    this.ValidateProperty("sValue6", value);
                    this._sValue6 = value;
                    this.RaisePropertyChanged("sValue6");
                }

            }
        }

        public string sValue8
        {
            get
            {
                return this._sValue8;
            }
            set
            {
                if (this._sValue8 != value)
                {
                    this.ValidateProperty("sValue8", value);
                    this._sValue8 = value;
                    this.RaisePropertyChanged("sValue8");
                }

            }
        }

        public string sValue10
        {
            get
            {
                return this._sValue10;
            }
            set
            {
                if (this._sValue10 != value)
                {
                    this.ValidateProperty("sValue10", value);
                    this._sValue10 = value;
                    this.RaisePropertyChanged("sValue10");
                }

            }
        }

        public string sRedArrowMargin
        {
            get
            {
                return this._sRedArrowMargin;
            }
            set
            {
                if (this._sRedArrowMargin != value)
                {
                    this.ValidateProperty("sRedArrowMargin", value);
                    this._sRedArrowMargin = value;
                    this.RaisePropertyChanged("sRedArrowMargin");
                }
            }
        }

        public string sRedArrowAngle
        {
            get
            {
                return this._sRedArrowAngle;
            }
            set
            {
                if (this._sRedArrowAngle != value)
                {
                    this.ValidateProperty("sRedArrowAngle", value);
                    this._sRedArrowAngle = value;
                    this.RaisePropertyChanged("sRedArrowAngle");
                }

            }
        }

        

    }
}
