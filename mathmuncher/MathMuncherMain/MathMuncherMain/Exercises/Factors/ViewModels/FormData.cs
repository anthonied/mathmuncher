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

namespace MathMuncherMain.Exercises.Factors.ViewModels
{
    public class FormData : ComplexObject
    {
        private string _sFactorVisibility4 = "Collapsed";
        private string _sFactorVisibility8 = "Collapsed";
        private string _sFactorVisibility10 = "Collapsed";
        private string _sFactorVisibility16 = "Collapsed";
        private string _sFactorVisibility18 = "Collapsed";
        private string _sFactorVisibility20 = "Collapsed";
        private string _sFactorVisibility24 = "Collapsed";
        private string _sFactorVisibility30 = "Collapsed";
        private string _sFactorVisibility40 = "Collapsed";
        private string _sFactorVisibility81 = "Collapsed";
        private string _sFactorVisibility75 = "Collapsed";
        private string _sFactorVisibility56 = "Collapsed";
        private string _sFactorVisibility100 = "Collapsed";
        private string _sFactorVisibility64 = "Collapsed";
        private string _sFactorVisibility144 = "Collapsed";
        private string _sFactorInputVisibility4 = "Collapsed";
        private string _sFactorInputVisibility8 = "Collapsed";
        private string _sFactorInputVisibility10 = "Collapsed";
        private string _sFactorInputVisibility16 = "Collapsed";
        private string _sFactorInputVisibility18 = "Collapsed";
        private string _sFactorInputVisibility20 = "Collapsed";
        private string _sFactorInputVisibility24 = "Collapsed";
        private string _sFactorInputVisibility30 = "Collapsed";
        private string _sFactorInputVisibility40 = "Collapsed";
        private string _sFactorInputVisibility81 = "Collapsed";
        private string _sFactorInputVisibility75 = "Collapsed";
        private string _sFactorInputVisibility56 = "Collapsed";
        private string _sFactorInputVisibility100 = "Collapsed";
        private string _sFactorInputVisibility64 = "Collapsed";
        private string _sFactorInputVisibility144 = "Collapsed";
        private string _sFactorTop4;
        private string _sFactorTop8;
        private string _sFactorTop10;
        private string _sFactorTop16;
        private string _sFactorTop18;
        private string _sFactorTop20;
        private string _sFactorTop24;
        private string _sFactorTop30;
        private string _sFactorTop40;
        private string _sFactorTop81;
        private string _sFactorTop75;
        private string _sFactorTop56;
        private string _sFactorTop100;
        private string _sFactorTop64;
        private string _sFactorTop144;
        private string _sFactorOpacity4;
        private string _sFactorOpacity8;
        private string _sFactorOpacity10;
        private string _sFactorOpacity16;
        private string _sFactorOpacity18;
        private string _sFactorOpacity20;
        private string _sFactorOpacity24;
        private string _sFactorOpacity30;
        private string _sFactorOpacity40;
        private string _sFactorOpacity81;
        private string _sFactorOpacity75;
        private string _sFactorOpacity56;
        private string _sFactorOpacity100;
        private string _sFactorOpacity64;
        private string _sFactorOpacity144;
        private string _sFactorReadOnly4 = "False";
        private string _sFactorReadOnly8 = "False";
        private string _sFactorReadOnly10 = "False";
        private string _sFactorReadOnly16= "False";
        private string _sFactorReadOnly18= "False";
        private string _sFactorReadOnly20 = "False";
        private string _sFactorReadOnly24= "False";
        private string _sFactorReadOnly30= "False";
        private string _sFactorReadOnly40= "False";
        private string _sFactorReadOnly81= "False";
        private string _sFactorReadOnly75= "False";
        private string _sFactorReadOnly56= "False";
        private string _sFactorReadOnly100= "False";
        private string _sFactorReadOnly64= "False";
        private string _sFactorReadOnly144= "False";
        private int? _iValue4_1;
        private int? _iValue4_2;
        private int? _iValue4_3;
        private int? _iValue8_1;
        private int? _iValue8_2;
        private int? _iValue8_3;
        private int? _iValue8_4;
        private int? _iValue10_1;
        private int? _iValue10_2;
        private int? _iValue10_3;
        private int? _iValue10_4;
        private int? _iValue16_1;
        private int? _iValue16_2;
        private int? _iValue16_3;
        private int? _iValue16_4;
        private int? _iValue16_5;
        private int? _iValue18_1;
        private int? _iValue18_2;
        private int? _iValue18_3;
        private int? _iValue18_4;
        private int? _iValue18_5;
        private int? _iValue18_6;
        private int? _iValue20_1;
        private int? _iValue20_2;
        private int? _iValue20_3;
        private int? _iValue20_4;
        private int? _iValue20_5;
        private int? _iValue20_6;
        private int? _iValue24_1;
        private int? _iValue24_2;
        private int? _iValue24_3;
        private int? _iValue24_4;
        private int? _iValue24_5;
        private int? _iValue24_6;
        private int? _iValue24_7;
        private int? _iValue24_8;
        private int? _iValue30_1;
        private int? _iValue30_2;
        private int? _iValue30_3;
        private int? _iValue30_4;
        private int? _iValue30_5;
        private int? _iValue30_6;
        private int? _iValue30_7;
        private int? _iValue30_8;
        private int? _iValue40_1;
        private int? _iValue40_2;
        private int? _iValue40_3;
        private int? _iValue40_4;
        private int? _iValue40_5;
        private int? _iValue40_6;
        private int? _iValue40_7;
        private int? _iValue40_8;
        private int? _iValue81_1;
        private int? _iValue81_2;
        private int? _iValue81_3;
        private int? _iValue81_4;
        private int? _iValue81_5;
        private int? _iValue75_1;
        private int? _iValue75_2;
        private int? _iValue75_3;
        private int? _iValue75_4;
        private int? _iValue75_5;
        private int? _iValue75_6;
        private int? _iValue56_1;
        private int? _iValue56_2;
        private int? _iValue56_3;
        private int? _iValue56_4;
        private int? _iValue56_5;
        private int? _iValue56_6;
        private int? _iValue56_7;
        private int? _iValue56_8;
        private int? _iValue100_1;
        private int? _iValue100_2;
        private int? _iValue100_3;
        private int? _iValue100_4;
        private int? _iValue100_5;
        private int? _iValue100_6;
        private int? _iValue100_7;
        private int? _iValue100_8;
        private int? _iValue100_9;
        private int? _iValue64_1;
        private int? _iValue64_2;
        private int? _iValue64_3;
        private int? _iValue64_4;
        private int? _iValue64_5;
        private int? _iValue64_6;
        private int? _iValue64_7;
        private int? _iValue144_1;
        private int? _iValue144_2;
        private int? _iValue144_3;
        private int? _iValue144_4;
        private int? _iValue144_5;
        private int? _iValue144_6;
        private int? _iValue144_7;
        private int? _iValue144_8;
        private int? _iValue144_9;
        private int? _iValue144_10;
        private int? _iValue144_11;
        private int? _iValue144_12;
        private int? _iValue144_13;
        private int? _iValue144_14;
        private int? _iValue144_15;
        private string _sValueBG4_1 = "transparent";
        private string _sValueBG4_2 = "transparent";
        private string _sValueBG4_3 = "transparent";
        private string _sValueBG8_1 = "transparent";
        private string _sValueBG8_2 = "transparent";
        private string _sValueBG8_3 = "transparent";
        private string _sValueBG8_4 = "transparent";
        private string _sValueBG10_1= "transparent";
        private string _sValueBG10_2= "transparent";
        private string _sValueBG10_3= "transparent";
        private string _sValueBG10_4= "transparent";
        private string _sValueBG16_1= "transparent";
        private string _sValueBG16_2= "transparent";
        private string _sValueBG16_3= "transparent";
        private string _sValueBG16_4= "transparent";
        private string _sValueBG16_5= "transparent";
        private string _sValueBG18_1= "transparent";
        private string _sValueBG18_2= "transparent";
        private string _sValueBG18_3= "transparent";
        private string _sValueBG18_4= "transparent";
        private string _sValueBG18_5= "transparent";
        private string _sValueBG18_6= "transparent";
        private string _sValueBG20_1 = "transparent";
        private string _sValueBG20_2 = "transparent";
        private string _sValueBG20_3 = "transparent";
        private string _sValueBG20_4 = "transparent";
        private string _sValueBG20_5 = "transparent";
        private string _sValueBG20_6 = "transparent";
        private string _sValueBG24_1= "transparent";
        private string _sValueBG24_2= "transparent";
        private string _sValueBG24_3= "transparent";
        private string _sValueBG24_4= "transparent";
        private string _sValueBG24_5= "transparent";
        private string _sValueBG24_6= "transparent";
        private string _sValueBG24_7= "transparent";
        private string _sValueBG24_8 = "transparent";
        private string _sValueBG30_1= "transparent";
        private string _sValueBG30_2= "transparent";
        private string _sValueBG30_3= "transparent";
        private string _sValueBG30_4= "transparent";
        private string _sValueBG30_5= "transparent";
        private string _sValueBG30_6= "transparent";
        private string _sValueBG30_7= "transparent";
        private string _sValueBG30_8= "transparent";
        private string _sValueBG40_1= "transparent";
        private string _sValueBG40_2= "transparent";
        private string _sValueBG40_3= "transparent";
        private string _sValueBG40_4= "transparent";
        private string _sValueBG40_5= "transparent";
        private string _sValueBG40_6= "transparent";
        private string _sValueBG40_7= "transparent";
        private string _sValueBG40_8= "transparent";
        private string _sValueBG81_1= "transparent";
        private string _sValueBG81_2= "transparent";
        private string _sValueBG81_3= "transparent";
        private string _sValueBG81_4= "transparent";
        private string _sValueBG81_5= "transparent";
        private string _sValueBG75_1= "transparent";
        private string _sValueBG75_2= "transparent";
        private string _sValueBG75_3= "transparent";
        private string _sValueBG75_4= "transparent";
        private string _sValueBG56_1= "transparent";
        private string _sValueBG56_2= "transparent";
        private string _sValueBG56_3= "transparent";
        private string _sValueBG56_4= "transparent";
        private string _sValueBG56_5= "transparent";
        private string _sValueBG56_6= "transparent";
        private string _sValueBG56_7= "transparent";
        private string _sValueBG56_8= "transparent";
        private string _sValueBG100_1= "transparent";
        private string _sValueBG100_2= "transparent";
        private string _sValueBG100_3= "transparent";
        private string _sValueBG100_4= "transparent";
        private string _sValueBG100_5= "transparent";
        private string _sValueBG100_6= "transparent";
        private string _sValueBG100_7= "transparent";
        private string _sValueBG100_8= "transparent";
        private string _sValueBG100_9 = "transparent";
        private string _sValueBG64_1= "transparent";
        private string _sValueBG64_2= "transparent";
        private string _sValueBG64_3= "transparent";
        private string _sValueBG64_4= "transparent";
        private string _sValueBG64_5= "transparent";
        private string _sValueBG64_6= "transparent";
        private string _sValueBG64_7= "transparent";
        private string _sValueBG144_1= "transparent";
        private string _sValueBG144_2= "transparent";
        private string _sValueBG144_3= "transparent";
        private string _sValueBG144_4= "transparent";
        private string _sValueBG144_5= "transparent";
        private string _sValueBG144_6= "transparent";
        private string _sValueBG144_7= "transparent";
        private string _sValueBG144_8= "transparent";
        private string _sValueBG144_9= "transparent";
        private string _sValueBG144_10= "transparent";
        private string _sValueBG144_11= "transparent";
        private string _sValueBG144_12= "transparent";
        private string _sValueBG144_13= "transparent";
        private string _sValueBG144_14 = "transparent";
        private string _sValueBG144_15 = "transparent";
        private string _sExerciseHeading1;
        private string _sExerciseHeading2;
        private string _sExerciseHeading3;
        private string _sExerciseHeading4;
        private string _sExerciseHeading5;
        private string _sExerciseHeading6;
        private string _sExerciseHeading7;
        private string _sExerciseHeading8;
        private string _sExerciseHeading9;
        private string _sExerciseHeading10;
        private string _sExerciseVisibility1= "Collapsed";
        private string _sExerciseVisibility2= "Collapsed";
        private string _sExerciseVisibility3= "Collapsed";
        private string _sExerciseVisibility4= "Collapsed";
        private string _sExerciseVisibility5= "Collapsed";
        private string _sExerciseVisibility6= "Collapsed";
        private string _sExerciseVisibility7= "Collapsed";
        private string _sExerciseVisibility8= "Collapsed";
        private string _sExerciseVisibility9= "Collapsed";
        private string _sExerciseVisibility10= "Collapsed";
        private string _sExerciseOpacity1;
        private string _sExerciseOpacity2;
        private string _sExerciseOpacity3;
        private string _sExerciseOpacity4;
        private string _sExerciseOpacity5;
        private string _sExerciseOpacity6;
        private string _sExerciseOpacity7;
        private string _sExerciseOpacity8;
        private string _sExerciseOpacity9;
        private string _sExerciseOpacity10;
        private int? _iExerciseValue1;
        private int? _iExerciseValue2;
        private int? _iExerciseValue3;
        private int? _iExerciseValue4;
        private int? _iExerciseValue5;
        private int? _iExerciseValue6;
        private int? _iExerciseValue7;
        private int? _iExerciseValue8;
        private int? _iExerciseValue9;
        private int? _iExerciseValue10;
        private string _sExerciseBG1;
        private string _sExerciseBG2;
        private string _sExerciseBG3;
        private string _sExerciseBG4;
        private string _sExerciseBG5;
        private string _sExerciseBG6;
        private string _sExerciseBG7;
        private string _sExerciseBG8;
        private string _sExerciseBG9;
        private string _sExerciseBG10;


        public string sFactorVisibility4
        {
            get
            {
                return this._sFactorVisibility4;
            }
            set
            {
                if (this._sFactorVisibility4 != value)
                {
                    this.ValidateProperty("sFactorVisibility4", value);
                    this._sFactorVisibility4 = value;
                    this.RaisePropertyChanged("sFactorVisibility4");
                }

            }
        }

        public string sFactorVisibility8
        {
            get
            {
                return this._sFactorVisibility8;
            }
            set
            {
                if (this._sFactorVisibility8 != value)
                {
                    this.ValidateProperty("sFactorVisibility8", value);
                    this._sFactorVisibility8 = value;
                    this.RaisePropertyChanged("sFactorVisibility8");
                }

            }
        }

        public string sFactorVisibility10
        {
            get
            {
                return this._sFactorVisibility10;
            }
            set
            {
                if (this._sFactorVisibility10 != value)
                {
                    this.ValidateProperty("sFactorVisibility10", value);
                    this._sFactorVisibility10 = value;
                    this.RaisePropertyChanged("sFactorVisibility10");
                }

            }
        }

        public string sFactorVisibility16
        {
            get
            {
                return this._sFactorVisibility16;
            }
            set
            {
                if (this._sFactorVisibility16 != value)
                {
                    this.ValidateProperty("sFactorVisibility16", value);
                    this._sFactorVisibility16 = value;
                    this.RaisePropertyChanged("sFactorVisibility16");
                }

            }
        }

        public string sFactorVisibility18
        {
            get
            {
                return this._sFactorVisibility18;
            }
            set
            {
                if (this._sFactorVisibility18 != value)
                {
                    this.ValidateProperty("sFactorVisibility18", value);
                    this._sFactorVisibility18 = value;
                    this.RaisePropertyChanged("sFactorVisibility18");
                }

            }
        }

        public string sFactorVisibility20
        {
            get
            {
                return this._sFactorVisibility20;
            }
            set
            {
                if (this._sFactorVisibility20 != value)
                {
                    this.ValidateProperty("sFactorVisibility20", value);
                    this._sFactorVisibility20 = value;
                    this.RaisePropertyChanged("sFactorVisibility20");
                }

            }
        }

        public string sFactorVisibility24
        {
            get
            {
                return this._sFactorVisibility24;
            }
            set
            {
                if (this._sFactorVisibility24 != value)
                {
                    this.ValidateProperty("sFactorVisibility24", value);
                    this._sFactorVisibility24 = value;
                    this.RaisePropertyChanged("sFactorVisibility24");
                }

            }
        }

        public string sFactorVisibility30
        {
            get
            {
                return this._sFactorVisibility30;
            }
            set
            {
                if (this._sFactorVisibility30 != value)
                {
                    this.ValidateProperty("sFactorVisibility30", value);
                    this._sFactorVisibility30 = value;
                    this.RaisePropertyChanged("sFactorVisibility30");
                }

            }
        }

        public string sFactorVisibility40
        {
            get
            {
                return this._sFactorVisibility40;
            }
            set
            {
                if (this._sFactorVisibility40 != value)
                {
                    this.ValidateProperty("sFactorVisibility40", value);
                    this._sFactorVisibility40 = value;
                    this.RaisePropertyChanged("sFactorVisibility40");
                }

            }
        }

        public string sFactorVisibility81
        {
            get
            {
                return this._sFactorVisibility81;
            }
            set
            {
                if (this._sFactorVisibility81 != value)
                {
                    this.ValidateProperty("sFactorVisibility81", value);
                    this._sFactorVisibility81 = value;
                    this.RaisePropertyChanged("sFactorVisibility81");
                }

            }
        }

        public string sFactorVisibility75
        {
            get
            {
                return this._sFactorVisibility75;
            }
            set
            {
                if (this._sFactorVisibility75 != value)
                {
                    this.ValidateProperty("sFactorVisibility75", value);
                    this._sFactorVisibility75 = value;
                    this.RaisePropertyChanged("sFactorVisibility75");
                }

            }
        }

        public string sFactorVisibility56
        {
            get
            {
                return this._sFactorVisibility56;
            }
            set
            {
                if (this._sFactorVisibility56 != value)
                {
                    this.ValidateProperty("sFactorVisibility56", value);
                    this._sFactorVisibility56 = value;
                    this.RaisePropertyChanged("sFactorVisibility56");
                }

            }
        }

        public string sFactorVisibility100
        {
            get
            {
                return this._sFactorVisibility100;
            }
            set
            {
                if (this._sFactorVisibility100 != value)
                {
                    this.ValidateProperty("sFactorVisibility100", value);
                    this._sFactorVisibility100 = value;
                    this.RaisePropertyChanged("sFactorVisibility100");
                }

            }
        }

        public string sFactorVisibility64
        {
            get
            {
                return this._sFactorVisibility64;
            }
            set
            {
                if (this._sFactorVisibility64 != value)
                {
                    this.ValidateProperty("sFactorVisibility64", value);
                    this._sFactorVisibility64 = value;
                    this.RaisePropertyChanged("sFactorVisibility64");
                }

            }
        }

        public string sFactorVisibility144
        {
            get
            {
                return this._sFactorVisibility144;
            }
            set
            {
                if (this._sFactorVisibility144 != value)
                {
                    this.ValidateProperty("sFactorVisibility144", value);
                    this._sFactorVisibility144 = value;
                    this.RaisePropertyChanged("sFactorVisibility144");
                }

            }
        }

        public string sFactorInputVisibility4
        {
            get
            {
                return this._sFactorInputVisibility4;
            }
            set
            {
                if (this._sFactorInputVisibility4 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility4", value);
                    this._sFactorInputVisibility4 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility4");
                }

            }
        }

        public string sFactorInputVisibility8
        {
            get
            {
                return this._sFactorInputVisibility8;
            }
            set
            {
                if (this._sFactorInputVisibility8 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility8", value);
                    this._sFactorInputVisibility8 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility8");
                }

            }
        }

        public string sFactorInputVisibility10
        {
            get
            {
                return this._sFactorInputVisibility10;
            }
            set
            {
                if (this._sFactorInputVisibility10 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility10", value);
                    this._sFactorInputVisibility10 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility10");
                }

            }
        }

        public string sFactorInputVisibility16
        {
            get
            {
                return this._sFactorInputVisibility16;
            }
            set
            {
                if (this._sFactorInputVisibility16 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility16", value);
                    this._sFactorInputVisibility16 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility16");
                }

            }
        }

        public string sFactorInputVisibility18
        {
            get
            {
                return this._sFactorInputVisibility18;
            }
            set
            {
                if (this._sFactorInputVisibility18 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility18", value);
                    this._sFactorInputVisibility18 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility18");
                }

            }
        }

        public string sFactorInputVisibility20
        {
            get
            {
                return this._sFactorInputVisibility20;
            }
            set
            {
                if (this._sFactorInputVisibility20 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility20", value);
                    this._sFactorInputVisibility20 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility20");
                }

            }
        }

        public string sFactorInputVisibility24
        {
            get
            {
                return this._sFactorInputVisibility24;
            }
            set
            {
                if (this._sFactorInputVisibility24 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility24", value);
                    this._sFactorInputVisibility24 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility24");
                }

            }
        }

        public string sFactorInputVisibility30
        {
            get
            {
                return this._sFactorInputVisibility30;
            }
            set
            {
                if (this._sFactorInputVisibility30 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility30", value);
                    this._sFactorInputVisibility30 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility30");
                }

            }
        }

        public string sFactorInputVisibility40
        {
            get
            {
                return this._sFactorInputVisibility40;
            }
            set
            {
                if (this._sFactorInputVisibility40 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility40", value);
                    this._sFactorInputVisibility40 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility40");
                }

            }
        }

        public string sFactorInputVisibility81
        {
            get
            {
                return this._sFactorInputVisibility81;
            }
            set
            {
                if (this._sFactorInputVisibility81 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility81", value);
                    this._sFactorInputVisibility81 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility81");
                }

            }
        }

        public string sFactorInputVisibility75
        {
            get
            {
                return this._sFactorInputVisibility75;
            }
            set
            {
                if (this._sFactorInputVisibility75 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility75", value);
                    this._sFactorInputVisibility75 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility75");
                }

            }
        }

        public string sFactorInputVisibility56
        {
            get
            {
                return this._sFactorInputVisibility56;
            }
            set
            {
                if (this._sFactorInputVisibility56 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility56", value);
                    this._sFactorInputVisibility56 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility56");
                }

            }
        }

        public string sFactorInputVisibility100
        {
            get
            {
                return this._sFactorInputVisibility100;
            }
            set
            {
                if (this._sFactorInputVisibility100 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility100", value);
                    this._sFactorInputVisibility100 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility100");
                }

            }
        }

        public string sFactorInputVisibility64
        {
            get
            {
                return this._sFactorInputVisibility64;
            }
            set
            {
                if (this._sFactorInputVisibility64 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility64", value);
                    this._sFactorInputVisibility64 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility64");
                }

            }
        }

        public string sFactorInputVisibility144
        {
            get
            {
                return this._sFactorInputVisibility144;
            }
            set
            {
                if (this._sFactorInputVisibility144 != value)
                {
                    this.ValidateProperty("sFactorInputVisibility144", value);
                    this._sFactorInputVisibility144 = value;
                    this.RaisePropertyChanged("sFactorInputVisibility144");
                }

            }
        }

        public string sFactorTop4
        {
            get
            {
                return this._sFactorTop4;
            }
            set
            {
                if (this._sFactorTop4 != value)
                {
                    this.ValidateProperty("sFactorTop4", value);
                    this._sFactorTop4 = value;
                    this.RaisePropertyChanged("sFactorTop4");
                }

            }
        }

        public string sFactorTop8
        {
            get
            {
                return this._sFactorTop8;
            }
            set
            {
                if (this._sFactorTop8 != value)
                {
                    this.ValidateProperty("sFactorTop8", value);
                    this._sFactorTop8 = value;
                    this.RaisePropertyChanged("sFactorTop8");
                }

            }
        }

        public string sFactorTop10
        {
            get
            {
                return this._sFactorTop10;
            }
            set
            {
                if (this._sFactorTop10 != value)
                {
                    this.ValidateProperty("sFactorTop10", value);
                    this._sFactorTop10 = value;
                    this.RaisePropertyChanged("sFactorTop10");
                }

            }
        }

        public string sFactorTop16
        {
            get
            {
                return this._sFactorTop16;
            }
            set
            {
                if (this._sFactorTop16 != value)
                {
                    this.ValidateProperty("sFactorTop16", value);
                    this._sFactorTop16 = value;
                    this.RaisePropertyChanged("sFactorTop16");
                }

            }
        }

        public string sFactorTop18
        {
            get
            {
                return this._sFactorTop18;
            }
            set
            {
                if (this._sFactorTop18 != value)
                {
                    this.ValidateProperty("sFactorTop18", value);
                    this._sFactorTop18 = value;
                    this.RaisePropertyChanged("sFactorTop18");
                }

            }
        }

        public string sFactorTop20
        {
            get
            {
                return this._sFactorTop20;
            }
            set
            {
                if (this._sFactorTop20 != value)
                {
                    this.ValidateProperty("sFactorTop20", value);
                    this._sFactorTop20 = value;
                    this.RaisePropertyChanged("sFactorTop20");
                }

            }
        }

        public string sFactorTop24
        {
            get
            {
                return this._sFactorTop24;
            }
            set
            {
                if (this._sFactorTop24 != value)
                {
                    this.ValidateProperty("sFactorTop24", value);
                    this._sFactorTop24 = value;
                    this.RaisePropertyChanged("sFactorTop24");
                }

            }
        }

        public string sFactorTop30
        {
            get
            {
                return this._sFactorTop30;
            }
            set
            {
                if (this._sFactorTop30 != value)
                {
                    this.ValidateProperty("sFactorTop30", value);
                    this._sFactorTop30 = value;
                    this.RaisePropertyChanged("sFactorTop30");
                }

            }
        }

        public string sFactorTop40
        {
            get
            {
                return this._sFactorTop40;
            }
            set
            {
                if (this._sFactorTop40 != value)
                {
                    this.ValidateProperty("sFactorTop40", value);
                    this._sFactorTop40 = value;
                    this.RaisePropertyChanged("sFactorTop40");
                }

            }
        }

        public string sFactorTop81
        {
            get
            {
                return this._sFactorTop81;
            }
            set
            {
                if (this._sFactorTop81 != value)
                {
                    this.ValidateProperty("sFactorTop81", value);
                    this._sFactorTop81 = value;
                    this.RaisePropertyChanged("sFactorTop81");
                }

            }
        }

        public string sFactorTop75
        {
            get
            {
                return this._sFactorTop75;
            }
            set
            {
                if (this._sFactorTop75 != value)
                {
                    this.ValidateProperty("sFactorTop75", value);
                    this._sFactorTop75 = value;
                    this.RaisePropertyChanged("sFactorTop75");
                }

            }
        }

        public string sFactorTop56
        {
            get
            {
                return this._sFactorTop56;
            }
            set
            {
                if (this._sFactorTop56 != value)
                {
                    this.ValidateProperty("sFactorTop56", value);
                    this._sFactorTop56 = value;
                    this.RaisePropertyChanged("sFactorTop56");
                }

            }
        }

        public string sFactorTop100
        {
            get
            {
                return this._sFactorTop100;
            }
            set
            {
                if (this._sFactorTop100 != value)
                {
                    this.ValidateProperty("sFactorTop100", value);
                    this._sFactorTop100 = value;
                    this.RaisePropertyChanged("sFactorTop100");
                }

            }
        }

        public string sFactorTop64
        {
            get
            {
                return this._sFactorTop64;
            }
            set
            {
                if (this._sFactorTop64 != value)
                {
                    this.ValidateProperty("sFactorTop64", value);
                    this._sFactorTop64 = value;
                    this.RaisePropertyChanged("sFactorTop64");
                }

            }
        }

        public string sFactorTop144
        {
            get
            {
                return this._sFactorTop144;
            }
            set
            {
                if (this._sFactorTop144 != value)
                {
                    this.ValidateProperty("sFactorTop144", value);
                    this._sFactorTop144 = value;
                    this.RaisePropertyChanged("sFactorTop144");
                }

            }
        }

        public string sFactorOpacity4
        {
            get
            {
                return this._sFactorOpacity4;
            }
            set
            {
                if (this._sFactorOpacity4 != value)
                {
                    this.ValidateProperty("sFactorOpacity4", value);
                    this._sFactorOpacity4 = value;
                    this.RaisePropertyChanged("sFactorOpacity4");
                }

            }
        }

        public string sFactorOpacity8
        {
            get
            {
                return this._sFactorOpacity8;
            }
            set
            {
                if (this._sFactorOpacity8 != value)
                {
                    this.ValidateProperty("sFactorOpacity8", value);
                    this._sFactorOpacity8 = value;
                    this.RaisePropertyChanged("sFactorOpacity8");
                }

            }
        }

        public string sFactorOpacity10
        {
            get
            {
                return this._sFactorOpacity10;
            }
            set
            {
                if (this._sFactorOpacity10 != value)
                {
                    this.ValidateProperty("sFactorOpacity10", value);
                    this._sFactorOpacity10 = value;
                    this.RaisePropertyChanged("sFactorOpacity10");
                }

            }
        }

        public string sFactorOpacity16
        {
            get
            {
                return this._sFactorOpacity16;
            }
            set
            {
                if (this._sFactorOpacity16 != value)
                {
                    this.ValidateProperty("sFactorOpacity16", value);
                    this._sFactorOpacity16 = value;
                    this.RaisePropertyChanged("sFactorOpacity16");
                }

            }
        }

        public string sFactorOpacity18
        {
            get
            {
                return this._sFactorOpacity18;
            }
            set
            {
                if (this._sFactorOpacity18 != value)
                {
                    this.ValidateProperty("sFactorOpacity18", value);
                    this._sFactorOpacity18 = value;
                    this.RaisePropertyChanged("sFactorOpacity18");
                }

            }
        }

        public string sFactorOpacity20
        {
            get
            {
                return this._sFactorOpacity20;
            }
            set
            {
                if (this._sFactorOpacity20 != value)
                {
                    this.ValidateProperty("sFactorOpacity20", value);
                    this._sFactorOpacity20 = value;
                    this.RaisePropertyChanged("sFactorOpacity20");
                }

            }
        }

        public string sFactorOpacity24
        {
            get
            {
                return this._sFactorOpacity24;
            }
            set
            {
                if (this._sFactorOpacity24 != value)
                {
                    this.ValidateProperty("sFactorOpacity24", value);
                    this._sFactorOpacity24 = value;
                    this.RaisePropertyChanged("sFactorOpacity24");
                }

            }
        }

        public string sFactorOpacity30
        {
            get
            {
                return this._sFactorOpacity30;
            }
            set
            {
                if (this._sFactorOpacity30 != value)
                {
                    this.ValidateProperty("sFactorOpacity30", value);
                    this._sFactorOpacity30 = value;
                    this.RaisePropertyChanged("sFactorOpacity30");
                }

            }
        }

        public string sFactorOpacity40
        {
            get
            {
                return this._sFactorOpacity40;
            }
            set
            {
                if (this._sFactorOpacity40 != value)
                {
                    this.ValidateProperty("sFactorOpacity40", value);
                    this._sFactorOpacity40 = value;
                    this.RaisePropertyChanged("sFactorOpacity40");
                }

            }
        }

        public string sFactorOpacity81
        {
            get
            {
                return this._sFactorOpacity81;
            }
            set
            {
                if (this._sFactorOpacity81 != value)
                {
                    this.ValidateProperty("sFactorOpacity81", value);
                    this._sFactorOpacity81 = value;
                    this.RaisePropertyChanged("sFactorOpacity81");
                }

            }
        }

        public string sFactorOpacity75
        {
            get
            {
                return this._sFactorOpacity75;
            }
            set
            {
                if (this._sFactorOpacity75 != value)
                {
                    this.ValidateProperty("sFactorOpacity75", value);
                    this._sFactorOpacity75 = value;
                    this.RaisePropertyChanged("sFactorOpacity75");
                }

            }
        }

        public string sFactorOpacity56
        {
            get
            {
                return this._sFactorOpacity56;
            }
            set
            {
                if (this._sFactorOpacity56 != value)
                {
                    this.ValidateProperty("sFactorOpacity56", value);
                    this._sFactorOpacity56 = value;
                    this.RaisePropertyChanged("sFactorOpacity56");
                }

            }
        }

        public string sFactorOpacity100
        {
            get
            {
                return this._sFactorOpacity100;
            }
            set
            {
                if (this._sFactorOpacity100 != value)
                {
                    this.ValidateProperty("sFactorOpacity100", value);
                    this._sFactorOpacity100 = value;
                    this.RaisePropertyChanged("sFactorOpacity100");
                }

            }
        }

        public string sFactorOpacity64
        {
            get
            {
                return this._sFactorOpacity64;
            }
            set
            {
                if (this._sFactorOpacity64 != value)
                {
                    this.ValidateProperty("sFactorOpacity64", value);
                    this._sFactorOpacity64 = value;
                    this.RaisePropertyChanged("sFactorOpacity64");
                }

            }
        }

        public string sFactorOpacity144
        {
            get
            {
                return this._sFactorOpacity144;
            }
            set
            {
                if (this._sFactorOpacity144 != value)
                {
                    this.ValidateProperty("sFactorOpacity144", value);
                    this._sFactorOpacity144 = value;
                    this.RaisePropertyChanged("sFactorOpacity144");
                }

            }
        }

        public string sFactorReadOnly4
        {
            get
            {
                return this._sFactorReadOnly4;
            }
            set
            {
                if (this._sFactorReadOnly4 != value)
                {
                    this.ValidateProperty("sFactorReadOnly4", value);
                    this._sFactorReadOnly4 = value;
                    this.RaisePropertyChanged("sFactorReadOnly4");
                }

            }
        }

        public string sFactorReadOnly8
        {
            get
            {
                return this._sFactorReadOnly8;
            }
            set
            {
                if (this._sFactorReadOnly8 != value)
                {
                    this.ValidateProperty("sFactorReadOnly8", value);
                    this._sFactorReadOnly8 = value;
                    this.RaisePropertyChanged("sFactorReadOnly8");
                }

            }
        }

        public string sFactorReadOnly10
        {
            get
            {
                return this._sFactorReadOnly10;
            }
            set
            {
                if (this._sFactorReadOnly10 != value)
                {
                    this.ValidateProperty("sFactorReadOnly10", value);
                    this._sFactorReadOnly10 = value;
                    this.RaisePropertyChanged("sFactorReadOnly10");
                }

            }
        }

        public string sFactorReadOnly16
        {
            get
            {
                return this._sFactorReadOnly16;
            }
            set
            {
                if (this._sFactorReadOnly16 != value)
                {
                    this.ValidateProperty("sFactorReadOnly16", value);
                    this._sFactorReadOnly16 = value;
                    this.RaisePropertyChanged("sFactorReadOnly16");
                }

            }
        }

        public string sFactorReadOnly18
        {
            get
            {
                return this._sFactorReadOnly18;
            }
            set
            {
                if (this._sFactorReadOnly18 != value)
                {
                    this.ValidateProperty("sFactorReadOnly18", value);
                    this._sFactorReadOnly18 = value;
                    this.RaisePropertyChanged("sFactorReadOnly18");
                }

            }
        }

        public string sFactorReadOnly20
        {
            get
            {
                return this._sFactorReadOnly20;
            }
            set
            {
                if (this._sFactorReadOnly20 != value)
                {
                    this.ValidateProperty("sFactorReadOnly20", value);
                    this._sFactorReadOnly20 = value;
                    this.RaisePropertyChanged("sFactorReadOnly20");
                }

            }
        }

        public string sFactorReadOnly24
        {
            get
            {
                return this._sFactorReadOnly24;
            }
            set
            {
                if (this._sFactorReadOnly24 != value)
                {
                    this.ValidateProperty("sFactorReadOnly24", value);
                    this._sFactorReadOnly24 = value;
                    this.RaisePropertyChanged("sFactorReadOnly24");
                }

            }
        }

        public string sFactorReadOnly30
        {
            get
            {
                return this._sFactorReadOnly30;
            }
            set
            {
                if (this._sFactorReadOnly30 != value)
                {
                    this.ValidateProperty("sFactorReadOnly30", value);
                    this._sFactorReadOnly30 = value;
                    this.RaisePropertyChanged("sFactorReadOnly30");
                }

            }
        }

        public string sFactorReadOnly40
        {
            get
            {
                return this._sFactorReadOnly40;
            }
            set
            {
                if (this._sFactorReadOnly40 != value)
                {
                    this.ValidateProperty("sFactorReadOnly40", value);
                    this._sFactorReadOnly40 = value;
                    this.RaisePropertyChanged("sFactorReadOnly40");
                }

            }
        }

        public string sFactorReadOnly81
        {
            get
            {
                return this._sFactorReadOnly81;
            }
            set
            {
                if (this._sFactorReadOnly81 != value)
                {
                    this.ValidateProperty("sFactorReadOnly81", value);
                    this._sFactorReadOnly81 = value;
                    this.RaisePropertyChanged("sFactorReadOnly81");
                }

            }
        }

        public string sFactorReadOnly75
        {
            get
            {
                return this._sFactorReadOnly75;
            }
            set
            {
                if (this._sFactorReadOnly75 != value)
                {
                    this.ValidateProperty("sFactorReadOnly75", value);
                    this._sFactorReadOnly75 = value;
                    this.RaisePropertyChanged("sFactorReadOnly75");
                }

            }
        }

        public string sFactorReadOnly56
        {
            get
            {
                return this._sFactorReadOnly56;
            }
            set
            {
                if (this._sFactorReadOnly56 != value)
                {
                    this.ValidateProperty("sFactorReadOnly56", value);
                    this._sFactorReadOnly56 = value;
                    this.RaisePropertyChanged("sFactorReadOnly56");
                }

            }
        }

        public string sFactorReadOnly100
        {
            get
            {
                return this._sFactorReadOnly100;
            }
            set
            {
                if (this._sFactorReadOnly100 != value)
                {
                    this.ValidateProperty("sFactorReadOnly100", value);
                    this._sFactorReadOnly100 = value;
                    this.RaisePropertyChanged("sFactorReadOnly100");
                }

            }
        }

        public string sFactorReadOnly64
        {
            get
            {
                return this._sFactorReadOnly64;
            }
            set
            {
                if (this._sFactorReadOnly64 != value)
                {
                    this.ValidateProperty("sFactorReadOnly64", value);
                    this._sFactorReadOnly64 = value;
                    this.RaisePropertyChanged("sFactorReadOnly64");
                }

            }
        }

        public string sFactorReadOnly144
        {
            get
            {
                return this._sFactorReadOnly144;
            }
            set
            {
                if (this._sFactorReadOnly144 != value)
                {
                    this.ValidateProperty("sFactorReadOnly144", value);
                    this._sFactorReadOnly144 = value;
                    this.RaisePropertyChanged("sFactorReadOnly144");
                }

            }
        }

        public int? iValue4_1
        {
            get
            {
                return this._iValue4_1;
            }
            set
            {
                if (this._iValue4_1 != value)
                {
                    this.ValidateProperty("iValue4_1", value);
                    this._iValue4_1 = value;
                    this.RaisePropertyChanged("iValue4_1");
                }
            }
        }

        public int? iValue4_2
        {
            get
            {
                return this._iValue4_2;
            }
            set
            {
                if (this._iValue4_2 != value)
                {
                    this.ValidateProperty("iValue4_2", value);
                    this._iValue4_2 = value;
                    this.RaisePropertyChanged("iValue4_2");
                }
            }
        }

        public int? iValue4_3
        {
            get
            {
                return this._iValue4_3;
            }
            set
            {
                if (this._iValue4_3 != value)
                {
                    this.ValidateProperty("iValue4_3", value);
                    this._iValue4_3 = value;
                    this.RaisePropertyChanged("iValue4_3");
                }
            }
        }

        public int? iValue8_1
        {
            get
            {
                return this._iValue8_1;
            }
            set
            {
                if (this._iValue8_1 != value)
                {
                    this.ValidateProperty("iValue8_1", value);
                    this._iValue8_1 = value;
                    this.RaisePropertyChanged("iValue8_1");
                }
            }
        }

        public int? iValue8_2
        {
            get
            {
                return this._iValue8_2;
            }
            set
            {
                if (this._iValue8_2 != value)
                {
                    this.ValidateProperty("iValue8_2", value);
                    this._iValue8_2 = value;
                    this.RaisePropertyChanged("iValue8_2");
                }
            }
        }

        public int? iValue8_3
        {
            get
            {
                return this._iValue8_3;
            }
            set
            {
                if (this._iValue8_3 != value)
                {
                    this.ValidateProperty("iValue8_3", value);
                    this._iValue8_3 = value;
                    this.RaisePropertyChanged("iValue8_3");
                }
            }
        }

        public int? iValue8_4
        {
            get
            {
                return this._iValue8_4;
            }
            set
            {
                if (this._iValue8_4 != value)
                {
                    this.ValidateProperty("iValue8_4", value);
                    this._iValue8_4 = value;
                    this.RaisePropertyChanged("iValue8_4");
                }
            }
        }

        public int? iValue10_1
        {
            get
            {
                return this._iValue10_1;
            }
            set
            {
                if (this._iValue10_1 != value)
                {
                    this.ValidateProperty("iValue10_1", value);
                    this._iValue10_1 = value;
                    this.RaisePropertyChanged("iValue10_1");
                }
            }
        }

        public int? iValue10_2
        {
            get
            {
                return this._iValue10_2;
            }
            set
            {
                if (this._iValue10_2 != value)
                {
                    this.ValidateProperty("iValue10_2", value);
                    this._iValue10_2 = value;
                    this.RaisePropertyChanged("iValue10_2");
                }
            }
        }

        public int? iValue10_3
        {
            get
            {
                return this._iValue10_3;
            }
            set
            {
                if (this._iValue10_3 != value)
                {
                    this.ValidateProperty("iValue10_3", value);
                    this._iValue10_3 = value;
                    this.RaisePropertyChanged("iValue10_3");
                }
            }
        }

        public int? iValue10_4
        {
            get
            {
                return this._iValue10_4;
            }
            set
            {
                if (this._iValue10_4 != value)
                {
                    this.ValidateProperty("iValue10_4", value);
                    this._iValue10_4 = value;
                    this.RaisePropertyChanged("iValue10_4");
                }
            }
        }

        public int? iValue16_1
        {
            get
            {
                return this._iValue16_1;
            }
            set
            {
                if (this._iValue16_1 != value)
                {
                    this.ValidateProperty("iValue16_1", value);
                    this._iValue16_1 = value;
                    this.RaisePropertyChanged("iValue16_1");
                }
            }
        }

        public int? iValue16_2
        {
            get
            {
                return this._iValue16_2;
            }
            set
            {
                if (this._iValue16_2 != value)
                {
                    this.ValidateProperty("iValue16_2", value);
                    this._iValue16_2 = value;
                    this.RaisePropertyChanged("iValue16_2");
                }
            }
        }

        public int? iValue16_3
        {
            get
            {
                return this._iValue16_3;
            }
            set
            {
                if (this._iValue16_3 != value)
                {
                    this.ValidateProperty("iValue16_3", value);
                    this._iValue16_3 = value;
                    this.RaisePropertyChanged("iValue16_3");
                }
            }
        }

        public int? iValue16_4
        {
            get
            {
                return this._iValue16_4;
            }
            set
            {
                if (this._iValue16_4 != value)
                {
                    this.ValidateProperty("iValue16_4", value);
                    this._iValue16_4 = value;
                    this.RaisePropertyChanged("iValue16_4");
                }
            }
        }

        public int? iValue16_5
        {
            get
            {
                return this._iValue16_5;
            }
            set
            {
                if (this._iValue16_5 != value)
                {
                    this.ValidateProperty("iValue16_5", value);
                    this._iValue16_5 = value;
                    this.RaisePropertyChanged("iValue16_5");
                }
            }
        }

        public int? iValue18_1
        {
            get
            {
                return this._iValue18_1;
            }
            set
            {
                if (this._iValue18_1 != value)
                {
                    this.ValidateProperty("iValue18_1", value);
                    this._iValue18_1 = value;
                    this.RaisePropertyChanged("iValue18_1");
                }
            }
        }

        public int? iValue18_2
        {
            get
            {
                return this._iValue18_2;
            }
            set
            {
                if (this._iValue18_2 != value)
                {
                    this.ValidateProperty("iValue18_2", value);
                    this._iValue18_2 = value;
                    this.RaisePropertyChanged("iValue18_2");
                }
            }
        }

        public int? iValue18_3
        {
            get
            {
                return this._iValue18_3;
            }
            set
            {
                if (this._iValue18_3 != value)
                {
                    this.ValidateProperty("iValue18_3", value);
                    this._iValue18_3 = value;
                    this.RaisePropertyChanged("iValue18_3");
                }
            }
        }

        public int? iValue18_4
        {
            get
            {
                return this._iValue18_4;
            }
            set
            {
                if (this._iValue18_4 != value)
                {
                    this.ValidateProperty("iValue18_4", value);
                    this._iValue18_4 = value;
                    this.RaisePropertyChanged("iValue18_4");
                }
            }
        }

        public int? iValue18_5
        {
            get
            {
                return this._iValue18_5;
            }
            set
            {
                if (this._iValue18_5 != value)
                {
                    this.ValidateProperty("iValue18_5", value);
                    this._iValue18_5 = value;
                    this.RaisePropertyChanged("iValue18_5");
                }
            }
        }

        public int? iValue18_6
        {
            get
            {
                return this._iValue18_6;
            }
            set
            {
                if (this._iValue18_6 != value)
                {
                    this.ValidateProperty("iValue18_6", value);
                    this._iValue18_6 = value;
                    this.RaisePropertyChanged("iValue18_6");
                }
            }
        }

        public int? iValue20_1
        {
            get
            {
                return this._iValue20_1;
            }
            set
            {
                if (this._iValue20_1 != value)
                {
                    this.ValidateProperty("iValue20_1", value);
                    this._iValue20_1 = value;
                    this.RaisePropertyChanged("iValue20_1");
                }
            }
        }

        public int? iValue20_2
        {
            get
            {
                return this._iValue20_2;
            }
            set
            {
                if (this._iValue20_2 != value)
                {
                    this.ValidateProperty("iValue20_2", value);
                    this._iValue20_2 = value;
                    this.RaisePropertyChanged("iValue20_2");
                }
            }
        }

        public int? iValue20_3
        {
            get
            {
                return this._iValue20_3;
            }
            set
            {
                if (this._iValue20_3 != value)
                {
                    this.ValidateProperty("iValue20_3", value);
                    this._iValue20_3 = value;
                    this.RaisePropertyChanged("iValue20_3");
                }
            }
        }

        public int? iValue20_4
        {
            get
            {
                return this._iValue20_4;
            }
            set
            {
                if (this._iValue20_4 != value)
                {
                    this.ValidateProperty("iValue20_4", value);
                    this._iValue20_4 = value;
                    this.RaisePropertyChanged("iValue20_4");
                }
            }
        }

        public int? iValue20_5
        {
            get
            {
                return this._iValue20_5;
            }
            set
            {
                if (this._iValue20_5 != value)
                {
                    this.ValidateProperty("iValue20_5", value);
                    this._iValue20_5 = value;
                    this.RaisePropertyChanged("iValue20_5");
                }
            }
        }

        public int? iValue20_6
        {
            get
            {
                return this._iValue20_6;
            }
            set
            {
                if (this._iValue20_6 != value)
                {
                    this.ValidateProperty("iValue20_6", value);
                    this._iValue20_6 = value;
                    this.RaisePropertyChanged("iValue20_6");
                }
            }
        }

        public int? iValue24_1
        {
            get
            {
                return this._iValue24_1;
            }
            set
            {
                if (this._iValue24_1 != value)
                {
                    this.ValidateProperty("iValue24_1", value);
                    this._iValue24_1 = value;
                    this.RaisePropertyChanged("iValue24_1");
                }
            }
        }

        public int? iValue24_2
        {
            get
            {
                return this._iValue24_2;
            }
            set
            {
                if (this._iValue24_2 != value)
                {
                    this.ValidateProperty("iValue24_2", value);
                    this._iValue24_2 = value;
                    this.RaisePropertyChanged("iValue24_2");
                }
            }
        }

        public int? iValue24_3
        {
            get
            {
                return this._iValue24_3;
            }
            set
            {
                if (this._iValue24_3 != value)
                {
                    this.ValidateProperty("iValue24_3", value);
                    this._iValue24_3 = value;
                    this.RaisePropertyChanged("iValue24_3");
                }
            }
        }

        public int? iValue24_4
        {
            get
            {
                return this._iValue24_4;
            }
            set
            {
                if (this._iValue24_4 != value)
                {
                    this.ValidateProperty("iValue24_4", value);
                    this._iValue24_4 = value;
                    this.RaisePropertyChanged("iValue24_4");
                }
            }
        }

        public int? iValue24_5
        {
            get
            {
                return this._iValue24_5;
            }
            set
            {
                if (this._iValue24_5 != value)
                {
                    this.ValidateProperty("iValue24_5", value);
                    this._iValue24_5 = value;
                    this.RaisePropertyChanged("iValue24_5");
                }
            }
        }

        public int? iValue24_6
        {
            get
            {
                return this._iValue24_6;
            }
            set
            {
                if (this._iValue24_6 != value)
                {
                    this.ValidateProperty("iValue24_6", value);
                    this._iValue24_6 = value;
                    this.RaisePropertyChanged("iValue24_6");
                }
            }
        }

        public int? iValue24_7
        {
            get
            {
                return this._iValue24_7;
            }
            set
            {
                if (this._iValue24_7 != value)
                {
                    this.ValidateProperty("iValue24_7", value);
                    this._iValue24_7 = value;
                    this.RaisePropertyChanged("iValue24_7");
                }
            }
        }

        public int? iValue24_8
        {
            get
            {
                return this._iValue24_8;
            }
            set
            {
                if (this._iValue24_8 != value)
                {
                    this.ValidateProperty("iValue24_8", value);
                    this._iValue24_8 = value;
                    this.RaisePropertyChanged("iValue24_8");
                }
            }
        }

        public int? iValue30_1
        {
            get
            {
                return this._iValue30_1;
            }
            set
            {
                if (this._iValue30_1 != value)
                {
                    this.ValidateProperty("iValue30_1", value);
                    this._iValue30_1 = value;
                    this.RaisePropertyChanged("iValue30_1");
                }
            }
        }

        public int? iValue30_2
        {
            get
            {
                return this._iValue30_2;
            }
            set
            {
                if (this._iValue30_2 != value)
                {
                    this.ValidateProperty("iValue30_2", value);
                    this._iValue30_2 = value;
                    this.RaisePropertyChanged("iValue30_2");
                }
            }
        }

        public int? iValue30_3
        {
            get
            {
                return this._iValue30_3;
            }
            set
            {
                if (this._iValue30_3 != value)
                {
                    this.ValidateProperty("iValue30_3", value);
                    this._iValue30_3 = value;
                    this.RaisePropertyChanged("iValue30_3");
                }
            }
        }

        public int? iValue30_4
        {
            get
            {
                return this._iValue30_4;
            }
            set
            {
                if (this._iValue30_4 != value)
                {
                    this.ValidateProperty("iValue30_4", value);
                    this._iValue30_4 = value;
                    this.RaisePropertyChanged("iValue30_4");
                }
            }
        }

        public int? iValue30_5
        {
            get
            {
                return this._iValue30_5;
            }
            set
            {
                if (this._iValue30_5 != value)
                {
                    this.ValidateProperty("iValue30_5", value);
                    this._iValue30_5 = value;
                    this.RaisePropertyChanged("iValue30_5");
                }
            }
        }

        public int? iValue30_6
        {
            get
            {
                return this._iValue30_6;
            }
            set
            {
                if (this._iValue30_6 != value)
                {
                    this.ValidateProperty("iValue30_6", value);
                    this._iValue30_6 = value;
                    this.RaisePropertyChanged("iValue30_6");
                }
            }
        }

        public int? iValue30_7
        {
            get
            {
                return this._iValue30_7;
            }
            set
            {
                if (this._iValue30_7 != value)
                {
                    this.ValidateProperty("iValue30_7", value);
                    this._iValue30_7 = value;
                    this.RaisePropertyChanged("iValue30_7");
                }
            }
        }

        public int? iValue30_8
        {
            get
            {
                return this._iValue30_8;
            }
            set
            {
                if (this._iValue30_8 != value)
                {
                    this.ValidateProperty("iValue30_8", value);
                    this._iValue30_8 = value;
                    this.RaisePropertyChanged("iValue30_8");
                }
            }
        }

        public int? iValue40_1
        {
            get
            {
                return this._iValue40_1;
            }
            set
            {
                if (this._iValue40_1 != value)
                {
                    this.ValidateProperty("iValue40_1", value);
                    this._iValue40_1 = value;
                    this.RaisePropertyChanged("iValue40_1");
                }
            }
        }

        public int? iValue40_2
        {
            get
            {
                return this._iValue40_2;
            }
            set
            {
                if (this._iValue40_2 != value)
                {
                    this.ValidateProperty("iValue40_2", value);
                    this._iValue40_2 = value;
                    this.RaisePropertyChanged("iValue40_2");
                }
            }
        }

        public int? iValue40_3
        {
            get
            {
                return this._iValue40_3;
            }
            set
            {
                if (this._iValue40_3 != value)
                {
                    this.ValidateProperty("iValue40_3", value);
                    this._iValue40_3 = value;
                    this.RaisePropertyChanged("iValue40_3");
                }
            }
        }

        public int? iValue40_4
        {
            get
            {
                return this._iValue40_4;
            }
            set
            {
                if (this._iValue40_4 != value)
                {
                    this.ValidateProperty("iValue40_4", value);
                    this._iValue40_4 = value;
                    this.RaisePropertyChanged("iValue40_4");
                }
            }
        }

        public int? iValue40_5
        {
            get
            {
                return this._iValue40_5;
            }
            set
            {
                if (this._iValue40_5 != value)
                {
                    this.ValidateProperty("iValue40_5", value);
                    this._iValue40_5 = value;
                    this.RaisePropertyChanged("iValue40_5");
                }
            }
        }

        public int? iValue40_6
        {
            get
            {
                return this._iValue40_6;
            }
            set
            {
                if (this._iValue40_6 != value)
                {
                    this.ValidateProperty("iValue40_6", value);
                    this._iValue40_6 = value;
                    this.RaisePropertyChanged("iValue40_6");
                }
            }
        }

        public int? iValue40_7
        {
            get
            {
                return this._iValue40_7;
            }
            set
            {
                if (this._iValue40_7 != value)
                {
                    this.ValidateProperty("iValue40_7", value);
                    this._iValue40_7 = value;
                    this.RaisePropertyChanged("iValue40_7");
                }
            }
        }

        public int? iValue40_8
        {
            get
            {
                return this._iValue40_8;
            }
            set
            {
                if (this._iValue40_8 != value)
                {
                    this.ValidateProperty("iValue40_8", value);
                    this._iValue40_8 = value;
                    this.RaisePropertyChanged("iValue40_8");
                }
            }
        }

        public int? iValue81_1
        {
            get
            {
                return this._iValue81_1;
            }
            set
            {
                if (this._iValue81_1 != value)
                {
                    this.ValidateProperty("iValue81_1", value);
                    this._iValue81_1 = value;
                    this.RaisePropertyChanged("iValue81_1");
                }
            }
        }

        public int? iValue81_2
        {
            get
            {
                return this._iValue81_2;
            }
            set
            {
                if (this._iValue81_2 != value)
                {
                    this.ValidateProperty("iValue81_2", value);
                    this._iValue81_2 = value;
                    this.RaisePropertyChanged("iValue81_2");
                }
            }
        }

        public int? iValue81_3
        {
            get
            {
                return this._iValue81_3;
            }
            set
            {
                if (this._iValue81_3 != value)
                {
                    this.ValidateProperty("iValue81_3", value);
                    this._iValue81_3 = value;
                    this.RaisePropertyChanged("iValue81_3");
                }
            }
        }

        public int? iValue81_4
        {
            get
            {
                return this._iValue81_4;
            }
            set
            {
                if (this._iValue81_4 != value)
                {
                    this.ValidateProperty("iValue81_4", value);
                    this._iValue81_4 = value;
                    this.RaisePropertyChanged("iValue81_4");
                }
            }
        }

        public int? iValue81_5
        {
            get
            {
                return this._iValue81_5;
            }
            set
            {
                if (this._iValue81_5 != value)
                {
                    this.ValidateProperty("iValue81_5", value);
                    this._iValue81_5 = value;
                    this.RaisePropertyChanged("iValue81_5");
                }
            }
        }
        
        public int? iValue75_1
        {
            get
            {
                return this._iValue75_1;
            }
            set
            {
                if (this._iValue75_1 != value)
                {
                    this.ValidateProperty("iValue75_1", value);
                    this._iValue75_1 = value;
                    this.RaisePropertyChanged("iValue75_1");
                }
            }
        }

        public int? iValue75_2
        {
            get
            {
                return this._iValue75_2;
            }
            set
            {
                if (this._iValue75_2 != value)
                {
                    this.ValidateProperty("iValue75_2", value);
                    this._iValue75_2 = value;
                    this.RaisePropertyChanged("iValue75_2");
                }
            }
        }

        public int? iValue75_3
        {
            get
            {
                return this._iValue75_3;
            }
            set
            {
                if (this._iValue75_3 != value)
                {
                    this.ValidateProperty("iValue75_3", value);
                    this._iValue75_3 = value;
                    this.RaisePropertyChanged("iValue75_3");
                }
            }
        }

        public int? iValue75_4
        {
            get
            {
                return this._iValue75_4;
            }
            set
            {
                if (this._iValue75_4 != value)
                {
                    this.ValidateProperty("iValue75_4", value);
                    this._iValue75_4 = value;
                    this.RaisePropertyChanged("iValue75_4");
                }
            }
        }

        public int? iValue75_5
        {
            get
            {
                return this._iValue75_5;
            }
            set
            {
                if (this._iValue75_5 != value)
                {
                    this.ValidateProperty("iValue75_5", value);
                    this._iValue75_5 = value;
                    this.RaisePropertyChanged("iValue75_5");
                }
            }
        }

        public int? iValue75_6
        {
            get
            {
                return this._iValue75_6;
            }
            set
            {
                if (this._iValue75_6 != value)
                {
                    this.ValidateProperty("iValue75_6", value);
                    this._iValue75_6 = value;
                    this.RaisePropertyChanged("iValue75_6");
                }
            }
        }

        public int? iValue56_1
        {
            get
            {
                return this._iValue56_1;
            }
            set
            {
                if (this._iValue56_1 != value)
                {
                    this.ValidateProperty("iValue56_1", value);
                    this._iValue56_1 = value;
                    this.RaisePropertyChanged("iValue56_1");
                }
            }
        }

        public int? iValue56_2
        {
            get
            {
                return this._iValue56_2;
            }
            set
            {
                if (this._iValue56_2 != value)
                {
                    this.ValidateProperty("iValue56_2", value);
                    this._iValue56_2 = value;
                    this.RaisePropertyChanged("iValue56_2");
                }
            }
        }

        public int? iValue56_3
        {
            get
            {
                return this._iValue56_3;
            }
            set
            {
                if (this._iValue56_3 != value)
                {
                    this.ValidateProperty("iValue56_3", value);
                    this._iValue56_3 = value;
                    this.RaisePropertyChanged("iValue56_3");
                }
            }
        }

        public int? iValue56_4
        {
            get
            {
                return this._iValue56_4;
            }
            set
            {
                if (this._iValue56_4 != value)
                {
                    this.ValidateProperty("iValue56_4", value);
                    this._iValue56_4 = value;
                    this.RaisePropertyChanged("iValue56_4");
                }
            }
        }

        public int? iValue56_5
        {
            get
            {
                return this._iValue56_5;
            }
            set
            {
                if (this._iValue56_5 != value)
                {
                    this.ValidateProperty("iValue56_5", value);
                    this._iValue56_5 = value;
                    this.RaisePropertyChanged("iValue56_5");
                }
            }
        }

        public int? iValue56_6
        {
            get
            {
                return this._iValue56_6;
            }
            set
            {
                if (this._iValue56_6 != value)
                {
                    this.ValidateProperty("iValue56_6", value);
                    this._iValue56_6 = value;
                    this.RaisePropertyChanged("iValue56_6");
                }
            }
        }

        public int? iValue56_7
        {
            get
            {
                return this._iValue56_7;
            }
            set
            {
                if (this._iValue56_7 != value)
                {
                    this.ValidateProperty("iValue56_7", value);
                    this._iValue56_7 = value;
                    this.RaisePropertyChanged("iValue56_7");
                }
            }
        }

        public int? iValue56_8
        {
            get
            {
                return this._iValue56_8;
            }
            set
            {
                if (this._iValue56_8 != value)
                {
                    this.ValidateProperty("iValue56_8", value);
                    this._iValue56_8 = value;
                    this.RaisePropertyChanged("iValue56_8");
                }
            }
        }

        public int? iValue100_1
        {
            get
            {
                return this._iValue100_1;
            }
            set
            {
                if (this._iValue100_1 != value)
                {
                    this.ValidateProperty("iValue100_1", value);
                    this._iValue100_1 = value;
                    this.RaisePropertyChanged("iValue100_1");
                }
            }
        }

        public int? iValue100_2
        {
            get
            {
                return this._iValue100_2;
            }
            set
            {
                if (this._iValue100_2 != value)
                {
                    this.ValidateProperty("iValue100_2", value);
                    this._iValue100_2 = value;
                    this.RaisePropertyChanged("iValue100_2");
                }
            }
        }

        public int? iValue100_3
        {
            get
            {
                return this._iValue100_3;
            }
            set
            {
                if (this._iValue100_3 != value)
                {
                    this.ValidateProperty("iValue100_3", value);
                    this._iValue100_3 = value;
                    this.RaisePropertyChanged("iValue100_3");
                }
            }
        }

        public int? iValue100_4
        {
            get
            {
                return this._iValue100_4;
            }
            set
            {
                if (this._iValue100_4 != value)
                {
                    this.ValidateProperty("iValue100_4", value);
                    this._iValue100_4 = value;
                    this.RaisePropertyChanged("iValue100_4");
                }
            }
        }

        public int? iValue100_5
        {
            get
            {
                return this._iValue100_5;
            }
            set
            {
                if (this._iValue100_5 != value)
                {
                    this.ValidateProperty("iValue100_5", value);
                    this._iValue100_5 = value;
                    this.RaisePropertyChanged("iValue100_5");
                }
            }
        }

        public int? iValue100_6
        {
            get
            {
                return this._iValue100_6;
            }
            set
            {
                if (this._iValue100_6 != value)
                {
                    this.ValidateProperty("iValue100_6", value);
                    this._iValue100_6 = value;
                    this.RaisePropertyChanged("iValue100_6");
                }
            }
        }

        public int? iValue100_7
        {
            get
            {
                return this._iValue100_7;
            }
            set
            {
                if (this._iValue100_7 != value)
                {
                    this.ValidateProperty("iValue100_7", value);
                    this._iValue100_7 = value;
                    this.RaisePropertyChanged("iValue100_7");
                }
            }
        }

        public int? iValue100_8
        {
            get
            {
                return this._iValue100_8;
            }
            set
            {
                if (this._iValue100_8 != value)
                {
                    this.ValidateProperty("iValue100_8", value);
                    this._iValue100_8 = value;
                    this.RaisePropertyChanged("iValue100_8");
                }
            }
        }

        public int? iValue100_9
        {
            get
            {
                return this._iValue100_9;
            }
            set
            {
                if (this._iValue100_9 != value)
                {
                    this.ValidateProperty("iValue100_9", value);
                    this._iValue100_9 = value;
                    this.RaisePropertyChanged("iValue100_9");
                }
            }
        }

        public int? iValue64_1
        {
            get
            {
                return this._iValue64_1;
            }
            set
            {
                if (this._iValue64_1 != value)
                {
                    this.ValidateProperty("iValue64_1", value);
                    this._iValue64_1 = value;
                    this.RaisePropertyChanged("iValue64_1");
                }
            }
        }

        public int? iValue64_2
        {
            get
            {
                return this._iValue64_2;
            }
            set
            {
                if (this._iValue64_2 != value)
                {
                    this.ValidateProperty("iValue64_2", value);
                    this._iValue64_2 = value;
                    this.RaisePropertyChanged("iValue64_2");
                }
            }
        }

        public int? iValue64_3
        {
            get
            {
                return this._iValue64_3;
            }
            set
            {
                if (this._iValue64_3 != value)
                {
                    this.ValidateProperty("iValue64_3", value);
                    this._iValue64_3 = value;
                    this.RaisePropertyChanged("iValue64_3");
                }
            }
        }

        public int? iValue64_4
        {
            get
            {
                return this._iValue64_4;
            }
            set
            {
                if (this._iValue64_4 != value)
                {
                    this.ValidateProperty("iValue64_4", value);
                    this._iValue64_4 = value;
                    this.RaisePropertyChanged("iValue64_4");
                }
            }
        }

        public int? iValue64_5
        {
            get
            {
                return this._iValue64_5;
            }
            set
            {
                if (this._iValue64_5 != value)
                {
                    this.ValidateProperty("iValue64_5", value);
                    this._iValue64_5 = value;
                    this.RaisePropertyChanged("iValue64_5");
                }
            }
        }

        public int? iValue64_6
        {
            get
            {
                return this._iValue64_6;
            }
            set
            {
                if (this._iValue64_6 != value)
                {
                    this.ValidateProperty("iValue64_6", value);
                    this._iValue64_6 = value;
                    this.RaisePropertyChanged("iValue64_6");
                }
            }
        }

        public int? iValue64_7
        {
            get
            {
                return this._iValue64_7;
            }
            set
            {
                if (this._iValue64_7 != value)
                {
                    this.ValidateProperty("iValue64_7", value);
                    this._iValue64_7 = value;
                    this.RaisePropertyChanged("iValue64_7");
                }
            }
        }

        public int? iValue144_1
        {
            get
            {
                return this._iValue144_1;
            }
            set
            {
                if (this._iValue144_1 != value)
                {
                    this.ValidateProperty("iValue144_1", value);
                    this._iValue144_1 = value;
                    this.RaisePropertyChanged("iValue144_1");
                }
            }
        }

        public int? iValue144_2
        {
            get
            {
                return this._iValue144_2;
            }
            set
            {
                if (this._iValue144_2 != value)
                {
                    this.ValidateProperty("iValue144_2", value);
                    this._iValue144_2 = value;
                    this.RaisePropertyChanged("iValue144_2");
                }
            }
        }

        public int? iValue144_3
        {
            get
            {
                return this._iValue144_3;
            }
            set
            {
                if (this._iValue144_3 != value)
                {
                    this.ValidateProperty("iValue144_3", value);
                    this._iValue144_3 = value;
                    this.RaisePropertyChanged("iValue144_3");
                }
            }
        }

        public int? iValue144_4
        {
            get
            {
                return this._iValue144_4;
            }
            set
            {
                if (this._iValue144_4 != value)
                {
                    this.ValidateProperty("iValue144_4", value);
                    this._iValue144_4 = value;
                    this.RaisePropertyChanged("iValue144_4");
                }
            }
        }

        public int? iValue144_5
        {
            get
            {
                return this._iValue144_5;
            }
            set
            {
                if (this._iValue144_5 != value)
                {
                    this.ValidateProperty("iValue144_5", value);
                    this._iValue144_5 = value;
                    this.RaisePropertyChanged("iValue144_5");
                }
            }
        }

        public int? iValue144_6
        {
            get
            {
                return this._iValue144_6;
            }
            set
            {
                if (this._iValue144_6 != value)
                {
                    this.ValidateProperty("iValue144_6", value);
                    this._iValue144_6 = value;
                    this.RaisePropertyChanged("iValue144_6");
                }
            }
        }

        public int? iValue144_7
        {
            get
            {
                return this._iValue144_7;
            }
            set
            {
                if (this._iValue144_7 != value)
                {
                    this.ValidateProperty("iValue144_7", value);
                    this._iValue144_7 = value;
                    this.RaisePropertyChanged("iValue144_7");
                }
            }
        }

        public int? iValue144_8
        {
            get
            {
                return this._iValue144_8;
            }
            set
            {
                if (this._iValue144_8 != value)
                {
                    this.ValidateProperty("iValue144_8", value);
                    this._iValue144_8 = value;
                    this.RaisePropertyChanged("iValue144_8");
                }
            }
        }

        public int? iValue144_9
        {
            get
            {
                return this._iValue144_9;
            }
            set
            {
                if (this._iValue144_9 != value)
                {
                    this.ValidateProperty("iValue144_9", value);
                    this._iValue144_9 = value;
                    this.RaisePropertyChanged("iValue144_9");
                }
            }
        }

        public int? iValue144_10
        {
            get
            {
                return this._iValue144_10;
            }
            set
            {
                if (this._iValue144_10 != value)
                {
                    this.ValidateProperty("iValue144_10", value);
                    this._iValue144_10 = value;
                    this.RaisePropertyChanged("iValue144_10");
                }
            }
        }

        public int? iValue144_11
        {
            get
            {
                return this._iValue144_11;
            }
            set
            {
                if (this._iValue144_11 != value)
                {
                    this.ValidateProperty("iValue144_11", value);
                    this._iValue144_11 = value;
                    this.RaisePropertyChanged("iValue144_11");
                }
            }
        }

        public int? iValue144_12
        {
            get
            {
                return this._iValue144_12;
            }
            set
            {
                if (this._iValue144_12 != value)
                {
                    this.ValidateProperty("iValue144_12", value);
                    this._iValue144_12 = value;
                    this.RaisePropertyChanged("iValue144_12");
                }
            }
        }

        public int? iValue144_13
        {
            get
            {
                return this._iValue144_13;
            }
            set
            {
                if (this._iValue144_13 != value)
                {
                    this.ValidateProperty("iValue144_13", value);
                    this._iValue144_13 = value;
                    this.RaisePropertyChanged("iValue144_13");
                }
            }
        }

        public int? iValue144_14
        {
            get
            {
                return this._iValue144_14;
            }
            set
            {
                if (this._iValue144_14 != value)
                {
                    this.ValidateProperty("iValue144_14", value);
                    this._iValue144_14 = value;
                    this.RaisePropertyChanged("iValue144_14");
                }
            }
        }

        public int? iValue144_15
        {
            get
            {
                return this._iValue144_15;
            }
            set
            {
                if (this._iValue144_15 != value)
                {
                    this.ValidateProperty("iValue144_15", value);
                    this._iValue144_15 = value;
                    this.RaisePropertyChanged("iValue144_15");
                }
            }
        }

        public string sValueBG4_1
        {
            get
            {
                return this._sValueBG4_1;
            }
            set
            {
                if (this._sValueBG4_1 != value)
                {
                    this.ValidateProperty("sValueBG4_1", value);
                    this._sValueBG4_1 = value;
                    this.RaisePropertyChanged("sValueBG4_1");
                }
            }
        }

        public string sValueBG4_2
        {
            get
            {
                return this._sValueBG4_2;
            }
            set
            {
                if (this._sValueBG4_2 != value)
                {
                    this.ValidateProperty("sValueBG4_2", value);
                    this._sValueBG4_2 = value;
                    this.RaisePropertyChanged("sValueBG4_2");
                }
            }
        }

        public string sValueBG4_3
        {
            get
            {
                return this._sValueBG4_3;
            }
            set
            {
                if (this._sValueBG4_3 != value)
                {
                    this.ValidateProperty("sValueBG4_3", value);
                    this._sValueBG4_3 = value;
                    this.RaisePropertyChanged("sValueBG4_3");
                }
            }
        }

        public string sValueBG8_1
        {
            get
            {
                return this._sValueBG8_1;
            }
            set
            {
                if (this._sValueBG8_1 != value)
                {
                    this.ValidateProperty("sValueBG8_1", value);
                    this._sValueBG8_1 = value;
                    this.RaisePropertyChanged("sValueBG8_1");
                }
            }
        }

        public string sValueBG8_2
        {
            get
            {
                return this._sValueBG8_2;
            }
            set
            {
                if (this._sValueBG8_2 != value)
                {
                    this.ValidateProperty("sValueBG8_2", value);
                    this._sValueBG8_2 = value;
                    this.RaisePropertyChanged("sValueBG8_2");
                }
            }
        }

        public string sValueBG8_3
        {
            get
            {
                return this._sValueBG8_3;
            }
            set
            {
                if (this._sValueBG8_3 != value)
                {
                    this.ValidateProperty("sValueBG8_3", value);
                    this._sValueBG8_3 = value;
                    this.RaisePropertyChanged("sValueBG8_3");
                }
            }
        }

        public string sValueBG8_4
        {
            get
            {
                return this._sValueBG8_4;
            }
            set
            {
                if (this._sValueBG8_4 != value)
                {
                    this.ValidateProperty("sValueBG8_4", value);
                    this._sValueBG8_4 = value;
                    this.RaisePropertyChanged("sValueBG8_4");
                }
            }
        }

        public string sValueBG10_1
        {
            get
            {
                return this._sValueBG10_1;
            }
            set
            {
                if (this._sValueBG10_1 != value)
                {
                    this.ValidateProperty("sValueBG10_1", value);
                    this._sValueBG10_1 = value;
                    this.RaisePropertyChanged("sValueBG10_1");
                }
            }
        }

        public string sValueBG10_2
        {
            get
            {
                return this._sValueBG10_2;
            }
            set
            {
                if (this._sValueBG10_2 != value)
                {
                    this.ValidateProperty("sValueBG10_2", value);
                    this._sValueBG10_2 = value;
                    this.RaisePropertyChanged("sValueBG10_2");
                }
            }
        }

        public string sValueBG10_3
        {
            get
            {
                return this._sValueBG10_3;
            }
            set
            {
                if (this._sValueBG10_3 != value)
                {
                    this.ValidateProperty("sValueBG10_3", value);
                    this._sValueBG10_3 = value;
                    this.RaisePropertyChanged("sValueBG10_3");
                }
            }
        }

        public string sValueBG10_4
        {
            get
            {
                return this._sValueBG10_4;
            }
            set
            {
                if (this._sValueBG10_4 != value)
                {
                    this.ValidateProperty("sValueBG10_4", value);
                    this._sValueBG10_4 = value;
                    this.RaisePropertyChanged("sValueBG10_4");
                }
            }
        }

        public string sValueBG16_1
        {
            get
            {
                return this._sValueBG16_1;
            }
            set
            {
                if (this._sValueBG16_1 != value)
                {
                    this.ValidateProperty("sValueBG16_1", value);
                    this._sValueBG16_1 = value;
                    this.RaisePropertyChanged("sValueBG16_1");
                }
            }
        }

        public string sValueBG16_2
        {
            get
            {
                return this._sValueBG16_2;
            }
            set
            {
                if (this._sValueBG16_2 != value)
                {
                    this.ValidateProperty("sValueBG16_2", value);
                    this._sValueBG16_2 = value;
                    this.RaisePropertyChanged("sValueBG16_2");
                }
            }
        }

        public string sValueBG16_3
        {
            get
            {
                return this._sValueBG16_3;
            }
            set
            {
                if (this._sValueBG16_3 != value)
                {
                    this.ValidateProperty("sValueBG16_3", value);
                    this._sValueBG16_3 = value;
                    this.RaisePropertyChanged("sValueBG16_3");
                }
            }
        }

        public string sValueBG16_4
        {
            get
            {
                return this._sValueBG16_4;
            }
            set
            {
                if (this._sValueBG16_4 != value)
                {
                    this.ValidateProperty("sValueBG16_4", value);
                    this._sValueBG16_4 = value;
                    this.RaisePropertyChanged("sValueBG16_4");
                }
            }
        }

        public string sValueBG16_5
        {
            get
            {
                return this._sValueBG16_5;
            }
            set
            {
                if (this._sValueBG16_5 != value)
                {
                    this.ValidateProperty("sValueBG16_5", value);
                    this._sValueBG16_5 = value;
                    this.RaisePropertyChanged("sValueBG16_5");
                }
            }
        }

        public string sValueBG18_1
        {
            get
            {
                return this._sValueBG18_1;
            }
            set
            {
                if (this._sValueBG18_1 != value)
                {
                    this.ValidateProperty("sValueBG18_1", value);
                    this._sValueBG18_1 = value;
                    this.RaisePropertyChanged("sValueBG18_1");
                }
            }
        }

        public string sValueBG18_2
        {
            get
            {
                return this._sValueBG18_2;
            }
            set
            {
                if (this._sValueBG18_2 != value)
                {
                    this.ValidateProperty("sValueBG18_2", value);
                    this._sValueBG18_2 = value;
                    this.RaisePropertyChanged("sValueBG18_2");
                }
            }
        }

        public string sValueBG18_3
        {
            get
            {
                return this._sValueBG18_3;
            }
            set
            {
                if (this._sValueBG18_3 != value)
                {
                    this.ValidateProperty("sValueBG18_3", value);
                    this._sValueBG18_3 = value;
                    this.RaisePropertyChanged("sValueBG18_3");
                }
            }
        }

        public string sValueBG18_4
        {
            get
            {
                return this._sValueBG18_4;
            }
            set
            {
                if (this._sValueBG18_4 != value)
                {
                    this.ValidateProperty("sValueBG18_4", value);
                    this._sValueBG18_4 = value;
                    this.RaisePropertyChanged("sValueBG18_4");
                }
            }
        }

        public string sValueBG18_5
        {
            get
            {
                return this._sValueBG18_5;
            }
            set
            {
                if (this._sValueBG18_5 != value)
                {
                    this.ValidateProperty("sValueBG18_5", value);
                    this._sValueBG18_5 = value;
                    this.RaisePropertyChanged("sValueBG18_5");
                }
            }
        }

        public string sValueBG18_6
        {
            get
            {
                return this._sValueBG18_6;
            }
            set
            {
                if (this._sValueBG18_6 != value)
                {
                    this.ValidateProperty("sValueBG18_6", value);
                    this._sValueBG18_6 = value;
                    this.RaisePropertyChanged("sValueBG18_6");
                }
            }
        }

        public string sValueBG20_1
        {
            get
            {
                return this._sValueBG20_1;
            }
            set
            {
                if (this._sValueBG20_1 != value)
                {
                    this.ValidateProperty("sValueBG20_1", value);
                    this._sValueBG20_1 = value;
                    this.RaisePropertyChanged("sValueBG20_1");
                }
            }
        }

        public string sValueBG20_2
        {
            get
            {
                return this._sValueBG20_2;
            }
            set
            {
                if (this._sValueBG20_2 != value)
                {
                    this.ValidateProperty("sValueBG20_2", value);
                    this._sValueBG20_2 = value;
                    this.RaisePropertyChanged("sValueBG20_2");
                }
            }
        }

        public string sValueBG20_3
        {
            get
            {
                return this._sValueBG20_3;
            }
            set
            {
                if (this._sValueBG20_3 != value)
                {
                    this.ValidateProperty("sValueBG20_3", value);
                    this._sValueBG20_3 = value;
                    this.RaisePropertyChanged("sValueBG20_3");
                }
            }
        }

        public string sValueBG20_4
        {
            get
            {
                return this._sValueBG20_4;
            }
            set
            {
                if (this._sValueBG20_4 != value)
                {
                    this.ValidateProperty("sValueBG20_4", value);
                    this._sValueBG20_4 = value;
                    this.RaisePropertyChanged("sValueBG20_4");
                }
            }
        }

        public string sValueBG20_5
        {
            get
            {
                return this._sValueBG20_5;
            }
            set
            {
                if (this._sValueBG20_5 != value)
                {
                    this.ValidateProperty("sValueBG20_5", value);
                    this._sValueBG20_5 = value;
                    this.RaisePropertyChanged("sValueBG20_5");
                }
            }
        }

        public string sValueBG20_6
        {
            get
            {
                return this._sValueBG20_6;
            }
            set
            {
                if (this._sValueBG20_6 != value)
                {
                    this.ValidateProperty("sValueBG20_6", value);
                    this._sValueBG20_6 = value;
                    this.RaisePropertyChanged("sValueBG20_6");
                }
            }
        }

        public string sValueBG24_1
        {
            get
            {
                return this._sValueBG24_1;
            }
            set
            {
                if (this._sValueBG24_1 != value)
                {
                    this.ValidateProperty("sValueBG24_1", value);
                    this._sValueBG24_1 = value;
                    this.RaisePropertyChanged("sValueBG24_1");
                }
            }
        }

        public string sValueBG24_2
        {
            get
            {
                return this._sValueBG24_2;
            }
            set
            {
                if (this._sValueBG24_2 != value)
                {
                    this.ValidateProperty("sValueBG24_2", value);
                    this._sValueBG24_2 = value;
                    this.RaisePropertyChanged("sValueBG24_2");
                }
            }
        }

        public string sValueBG24_3
        {
            get
            {
                return this._sValueBG24_3;
            }
            set
            {
                if (this._sValueBG24_3 != value)
                {
                    this.ValidateProperty("sValueBG24_3", value);
                    this._sValueBG24_3 = value;
                    this.RaisePropertyChanged("sValueBG24_3");
                }
            }
        }

        public string sValueBG24_4
        {
            get
            {
                return this._sValueBG24_4;
            }
            set
            {
                if (this._sValueBG24_4 != value)
                {
                    this.ValidateProperty("sValueBG24_4", value);
                    this._sValueBG24_4 = value;
                    this.RaisePropertyChanged("sValueBG24_4");
                }
            }
        }

        public string sValueBG24_5
        {
            get
            {
                return this._sValueBG24_5;
            }
            set
            {
                if (this._sValueBG24_5 != value)
                {
                    this.ValidateProperty("sValueBG24_5", value);
                    this._sValueBG24_5 = value;
                    this.RaisePropertyChanged("sValueBG24_5");
                }
            }
        }

        public string sValueBG24_6
        {
            get
            {
                return this._sValueBG24_6;
            }
            set
            {
                if (this._sValueBG24_6 != value)
                {
                    this.ValidateProperty("sValueBG24_6", value);
                    this._sValueBG24_6 = value;
                    this.RaisePropertyChanged("sValueBG24_6");
                }
            }
        }

        public string sValueBG24_7
        {
            get
            {
                return this._sValueBG24_7;
            }
            set
            {
                if (this._sValueBG24_7 != value)
                {
                    this.ValidateProperty("sValueBG24_7", value);
                    this._sValueBG24_7 = value;
                    this.RaisePropertyChanged("sValueBG24_7");
                }
            }
        }

        public string sValueBG24_8
        {
            get
            {
                return this._sValueBG24_8;
            }
            set
            {
                if (this._sValueBG24_8 != value)
                {
                    this.ValidateProperty("sValueBG24_8", value);
                    this._sValueBG24_8 = value;
                    this.RaisePropertyChanged("sValueBG24_8");
                }
            }
        }

        public string sValueBG30_1
        {
            get
            {
                return this._sValueBG30_1;
            }
            set
            {
                if (this._sValueBG30_1 != value)
                {
                    this.ValidateProperty("sValueBG30_1", value);
                    this._sValueBG30_1 = value;
                    this.RaisePropertyChanged("sValueBG30_1");
                }
            }
        }

        public string sValueBG30_2
        {
            get
            {
                return this._sValueBG30_2;
            }
            set
            {
                if (this._sValueBG30_2 != value)
                {
                    this.ValidateProperty("sValueBG30_2", value);
                    this._sValueBG30_2 = value;
                    this.RaisePropertyChanged("sValueBG30_2");
                }
            }
        }

        public string sValueBG30_3
        {
            get
            {
                return this._sValueBG30_3;
            }
            set
            {
                if (this._sValueBG30_3 != value)
                {
                    this.ValidateProperty("sValueBG30_3", value);
                    this._sValueBG30_3 = value;
                    this.RaisePropertyChanged("sValueBG30_3");
                }
            }
        }

        public string sValueBG30_4
        {
            get
            {
                return this._sValueBG30_4;
            }
            set
            {
                if (this._sValueBG30_4 != value)
                {
                    this.ValidateProperty("sValueBG30_4", value);
                    this._sValueBG30_4 = value;
                    this.RaisePropertyChanged("sValueBG30_4");
                }
            }
        }

        public string sValueBG30_5
        {
            get
            {
                return this._sValueBG30_5;
            }
            set
            {
                if (this._sValueBG30_5 != value)
                {
                    this.ValidateProperty("sValueBG30_5", value);
                    this._sValueBG30_5 = value;
                    this.RaisePropertyChanged("sValueBG30_5");
                }
            }
        }

        public string sValueBG30_6
        {
            get
            {
                return this._sValueBG30_6;
            }
            set
            {
                if (this._sValueBG30_6 != value)
                {
                    this.ValidateProperty("sValueBG30_6", value);
                    this._sValueBG30_6 = value;
                    this.RaisePropertyChanged("sValueBG30_6");
                }
            }
        }

        public string sValueBG30_7
        {
            get
            {
                return this._sValueBG30_7;
            }
            set
            {
                if (this._sValueBG30_7 != value)
                {
                    this.ValidateProperty("sValueBG30_7", value);
                    this._sValueBG30_7 = value;
                    this.RaisePropertyChanged("sValueBG30_7");
                }
            }
        }

        public string sValueBG30_8
        {
            get
            {
                return this._sValueBG30_8;
            }
            set
            {
                if (this._sValueBG30_8 != value)
                {
                    this.ValidateProperty("sValueBG30_8", value);
                    this._sValueBG30_8 = value;
                    this.RaisePropertyChanged("sValueBG30_8");
                }
            }
        }

        public string sValueBG40_1
        {
            get
            {
                return this._sValueBG40_1;
            }
            set
            {
                if (this._sValueBG40_1 != value)
                {
                    this.ValidateProperty("sValueBG40_1", value);
                    this._sValueBG40_1 = value;
                    this.RaisePropertyChanged("sValueBG40_1");
                }
            }
        }

        public string sValueBG40_2
        {
            get
            {
                return this._sValueBG40_2;
            }
            set
            {
                if (this._sValueBG40_2 != value)
                {
                    this.ValidateProperty("sValueBG40_2", value);
                    this._sValueBG40_2 = value;
                    this.RaisePropertyChanged("sValueBG40_2");
                }
            }
        }

        public string sValueBG40_3
        {
            get
            {
                return this._sValueBG40_3;
            }
            set
            {
                if (this._sValueBG40_3 != value)
                {
                    this.ValidateProperty("sValueBG40_3", value);
                    this._sValueBG40_3 = value;
                    this.RaisePropertyChanged("sValueBG40_3");
                }
            }
        }

        public string sValueBG40_4
        {
            get
            {
                return this._sValueBG40_4;
            }
            set
            {
                if (this._sValueBG40_4 != value)
                {
                    this.ValidateProperty("sValueBG40_4", value);
                    this._sValueBG40_4 = value;
                    this.RaisePropertyChanged("sValueBG40_4");
                }
            }
        }

        public string sValueBG40_5
        {
            get
            {
                return this._sValueBG40_5;
            }
            set
            {
                if (this._sValueBG40_5 != value)
                {
                    this.ValidateProperty("sValueBG40_5", value);
                    this._sValueBG40_5 = value;
                    this.RaisePropertyChanged("sValueBG40_5");
                }
            }
        }

        public string sValueBG40_6
        {
            get
            {
                return this._sValueBG40_6;
            }
            set
            {
                if (this._sValueBG40_6 != value)
                {
                    this.ValidateProperty("sValueBG40_6", value);
                    this._sValueBG40_6 = value;
                    this.RaisePropertyChanged("sValueBG40_6");
                }
            }
        }

        public string sValueBG40_7
        {
            get
            {
                return this._sValueBG40_7;
            }
            set
            {
                if (this._sValueBG40_7 != value)
                {
                    this.ValidateProperty("sValueBG40_7", value);
                    this._sValueBG40_7 = value;
                    this.RaisePropertyChanged("sValueBG40_7");
                }
            }
        }

        public string sValueBG40_8
        {
            get
            {
                return this._sValueBG40_8;
            }
            set
            {
                if (this._sValueBG40_8 != value)
                {
                    this.ValidateProperty("sValueBG40_8", value);
                    this._sValueBG40_8 = value;
                    this.RaisePropertyChanged("sValueBG40_8");
                }
            }
        }

        public string sValueBG81_1
        {
            get
            {
                return this._sValueBG81_1;
            }
            set
            {
                if (this._sValueBG81_1 != value)
                {
                    this.ValidateProperty("sValueBG81_1", value);
                    this._sValueBG81_1 = value;
                    this.RaisePropertyChanged("sValueBG81_1");
                }
            }
        }

        public string sValueBG81_2
        {
            get
            {
                return this._sValueBG81_2;
            }
            set
            {
                if (this._sValueBG81_2 != value)
                {
                    this.ValidateProperty("sValueBG81_2", value);
                    this._sValueBG81_2 = value;
                    this.RaisePropertyChanged("sValueBG81_2");
                }
            }
        }

        public string sValueBG81_3
        {
            get
            {
                return this._sValueBG81_3;
            }
            set
            {
                if (this._sValueBG81_3 != value)
                {
                    this.ValidateProperty("sValueBG81_3", value);
                    this._sValueBG81_3 = value;
                    this.RaisePropertyChanged("sValueBG81_3");
                }
            }
        }

        public string sValueBG81_4
        {
            get
            {
                return this._sValueBG81_4;
            }
            set
            {
                if (this._sValueBG81_4 != value)
                {
                    this.ValidateProperty("sValueBG81_4", value);
                    this._sValueBG81_4 = value;
                    this.RaisePropertyChanged("sValueBG81_4");
                }
            }
        }

        public string sValueBG81_5
        {
            get
            {
                return this._sValueBG81_5;
            }
            set
            {
                if (this._sValueBG81_5 != value)
                {
                    this.ValidateProperty("sValueBG81_5", value);
                    this._sValueBG81_5 = value;
                    this.RaisePropertyChanged("sValueBG81_5");
                }
            }
        }

        public string sValueBG75_1
        {
            get
            {
                return this._sValueBG75_1;
            }
            set
            {
                if (this._sValueBG75_1 != value)
                {
                    this.ValidateProperty("sValueBG75_1", value);
                    this._sValueBG75_1 = value;
                    this.RaisePropertyChanged("sValueBG75_1");
                }
            }
        }

        public string sValueBG75_2
        {
            get
            {
                return this._sValueBG75_2;
            }
            set
            {
                if (this._sValueBG75_2 != value)
                {
                    this.ValidateProperty("sValueBG75_2", value);
                    this._sValueBG75_2 = value;
                    this.RaisePropertyChanged("sValueBG75_2");
                }
            }
        }

        public string sValueBG75_3
        {
            get
            {
                return this._sValueBG75_3;
            }
            set
            {
                if (this._sValueBG75_3 != value)
                {
                    this.ValidateProperty("sValueBG75_3", value);
                    this._sValueBG75_3 = value;
                    this.RaisePropertyChanged("sValueBG75_3");
                }
            }
        }

        public string sValueBG75_4
        {
            get
            {
                return this._sValueBG75_4;
            }
            set
            {
                if (this._sValueBG75_4 != value)
                {
                    this.ValidateProperty("sValueBG75_4", value);
                    this._sValueBG75_4 = value;
                    this.RaisePropertyChanged("sValueBG75_4");
                }
            }
        }

        public string sValueBG56_1
        {
            get
            {
                return this._sValueBG56_1;
            }
            set
            {
                if (this._sValueBG56_1 != value)
                {
                    this.ValidateProperty("sValueBG56_1", value);
                    this._sValueBG56_1 = value;
                    this.RaisePropertyChanged("sValueBG56_1");
                }
            }
        }

        public string sValueBG56_2
        {
            get
            {
                return this._sValueBG56_2;
            }
            set
            {
                if (this._sValueBG56_2 != value)
                {
                    this.ValidateProperty("sValueBG56_2", value);
                    this._sValueBG56_2 = value;
                    this.RaisePropertyChanged("sValueBG56_2");
                }
            }
        }

        public string sValueBG56_3
        {
            get
            {
                return this._sValueBG56_3;
            }
            set
            {
                if (this._sValueBG56_3 != value)
                {
                    this.ValidateProperty("sValueBG56_3", value);
                    this._sValueBG56_3 = value;
                    this.RaisePropertyChanged("sValueBG56_3");
                }
            }
        }

        public string sValueBG56_4
        {
            get
            {
                return this._sValueBG56_4;
            }
            set
            {
                if (this._sValueBG56_4 != value)
                {
                    this.ValidateProperty("sValueBG56_4", value);
                    this._sValueBG56_4 = value;
                    this.RaisePropertyChanged("sValueBG56_4");
                }
            }
        }

        public string sValueBG56_5
        {
            get
            {
                return this._sValueBG56_5;
            }
            set
            {
                if (this._sValueBG56_5 != value)
                {
                    this.ValidateProperty("sValueBG56_5", value);
                    this._sValueBG56_5 = value;
                    this.RaisePropertyChanged("sValueBG56_5");
                }
            }
        }

        public string sValueBG56_6
        {
            get
            {
                return this._sValueBG56_6;
            }
            set
            {
                if (this._sValueBG56_6 != value)
                {
                    this.ValidateProperty("sValueBG56_6", value);
                    this._sValueBG56_6 = value;
                    this.RaisePropertyChanged("sValueBG56_6");
                }
            }
        }

        public string sValueBG56_7
        {
            get
            {
                return this._sValueBG56_7;
            }
            set
            {
                if (this._sValueBG56_7 != value)
                {
                    this.ValidateProperty("sValueBG56_7", value);
                    this._sValueBG56_7 = value;
                    this.RaisePropertyChanged("sValueBG56_7");
                }
            }
        }

        public string sValueBG56_8
        {
            get
            {
                return this._sValueBG56_8;
            }
            set
            {
                if (this._sValueBG56_8 != value)
                {
                    this.ValidateProperty("sValueBG56_8", value);
                    this._sValueBG56_8 = value;
                    this.RaisePropertyChanged("sValueBG56_8");
                }
            }
        }

        public string sValueBG100_1
        {
            get
            {
                return this._sValueBG100_1;
            }
            set
            {
                if (this._sValueBG100_1 != value)
                {
                    this.ValidateProperty("sValueBG100_1", value);
                    this._sValueBG100_1 = value;
                    this.RaisePropertyChanged("sValueBG100_1");
                }
            }
        }

        public string sValueBG100_2
        {
            get
            {
                return this._sValueBG100_2;
            }
            set
            {
                if (this._sValueBG100_2 != value)
                {
                    this.ValidateProperty("sValueBG100_2", value);
                    this._sValueBG100_2 = value;
                    this.RaisePropertyChanged("sValueBG100_2");
                }
            }
        }

        public string sValueBG100_3
        {
            get
            {
                return this._sValueBG100_3;
            }
            set
            {
                if (this._sValueBG100_3 != value)
                {
                    this.ValidateProperty("sValueBG100_3", value);
                    this._sValueBG100_3 = value;
                    this.RaisePropertyChanged("sValueBG100_3");
                }
            }
        }

        public string sValueBG100_4
        {
            get
            {
                return this._sValueBG100_4;
            }
            set
            {
                if (this._sValueBG100_4 != value)
                {
                    this.ValidateProperty("sValueBG100_4", value);
                    this._sValueBG100_4 = value;
                    this.RaisePropertyChanged("sValueBG100_4");
                }
            }
        }

        public string sValueBG100_5
        {
            get
            {
                return this._sValueBG100_5;
            }
            set
            {
                if (this._sValueBG100_5 != value)
                {
                    this.ValidateProperty("sValueBG100_5", value);
                    this._sValueBG100_5 = value;
                    this.RaisePropertyChanged("sValueBG100_5");
                }
            }
        }

        public string sValueBG100_6
        {
            get
            {
                return this._sValueBG100_6;
            }
            set
            {
                if (this._sValueBG100_6 != value)
                {
                    this.ValidateProperty("sValueBG100_6", value);
                    this._sValueBG100_6 = value;
                    this.RaisePropertyChanged("sValueBG100_6");
                }
            }
        }

        public string sValueBG100_7
        {
            get
            {
                return this._sValueBG100_7;
            }
            set
            {
                if (this._sValueBG100_7 != value)
                {
                    this.ValidateProperty("sValueBG100_7", value);
                    this._sValueBG100_7 = value;
                    this.RaisePropertyChanged("sValueBG100_7");
                }
            }
        }

        public string sValueBG100_8
        {
            get
            {
                return this._sValueBG100_8;
            }
            set
            {
                if (this._sValueBG100_8 != value)
                {
                    this.ValidateProperty("sValueBG100_8", value);
                    this._sValueBG100_8 = value;
                    this.RaisePropertyChanged("sValueBG100_8");
                }
            }
        }

        public string sValueBG100_9
        {
            get
            {
                return this._sValueBG100_9;
            }
            set
            {
                if (this._sValueBG100_9 != value)
                {
                    this.ValidateProperty("sValueBG100_9", value);
                    this._sValueBG100_9 = value;
                    this.RaisePropertyChanged("sValueBG100_9");
                }
            }
        }

        public string sValueBG64_1
        {
            get
            {
                return this._sValueBG64_1;
            }
            set
            {
                if (this._sValueBG64_1 != value)
                {
                    this.ValidateProperty("sValueBG64_1", value);
                    this._sValueBG64_1 = value;
                    this.RaisePropertyChanged("sValueBG64_1");
                }
            }
        }

        public string sValueBG64_2
        {
            get
            {
                return this._sValueBG64_2;
            }
            set
            {
                if (this._sValueBG64_2 != value)
                {
                    this.ValidateProperty("sValueBG64_2", value);
                    this._sValueBG64_2 = value;
                    this.RaisePropertyChanged("sValueBG64_2");
                }
            }
        }

        public string sValueBG64_3
        {
            get
            {
                return this._sValueBG64_3;
            }
            set
            {
                if (this._sValueBG64_3 != value)
                {
                    this.ValidateProperty("sValueBG64_3", value);
                    this._sValueBG64_3 = value;
                    this.RaisePropertyChanged("sValueBG64_3");
                }
            }
        }

        public string sValueBG64_4
        {
            get
            {
                return this._sValueBG64_4;
            }
            set
            {
                if (this._sValueBG64_4 != value)
                {
                    this.ValidateProperty("sValueBG64_4", value);
                    this._sValueBG64_4 = value;
                    this.RaisePropertyChanged("sValueBG64_4");
                }
            }
        }

        public string sValueBG64_5
        {
            get
            {
                return this._sValueBG64_5;
            }
            set
            {
                if (this._sValueBG64_5 != value)
                {
                    this.ValidateProperty("sValueBG64_5", value);
                    this._sValueBG64_5 = value;
                    this.RaisePropertyChanged("sValueBG64_5");
                }
            }
        }

        public string sValueBG64_6
        {
            get
            {
                return this._sValueBG64_6;
            }
            set
            {
                if (this._sValueBG64_6 != value)
                {
                    this.ValidateProperty("sValueBG64_6", value);
                    this._sValueBG64_6 = value;
                    this.RaisePropertyChanged("sValueBG64_6");
                }
            }
        }

        public string sValueBG64_7
        {
            get
            {
                return this._sValueBG64_7;
            }
            set
            {
                if (this._sValueBG64_7 != value)
                {
                    this.ValidateProperty("sValueBG64_7", value);
                    this._sValueBG64_7 = value;
                    this.RaisePropertyChanged("sValueBG64_7");
                }
            }
        }

        public string sValueBG144_1
        {
            get
            {
                return this._sValueBG144_1;
            }
            set
            {
                if (this._sValueBG144_1 != value)
                {
                    this.ValidateProperty("sValueBG144_1", value);
                    this._sValueBG144_1 = value;
                    this.RaisePropertyChanged("sValueBG144_1");
                }
            }
        }

        public string sValueBG144_2
        {
            get
            {
                return this._sValueBG144_2;
            }
            set
            {
                if (this._sValueBG144_2 != value)
                {
                    this.ValidateProperty("sValueBG144_2", value);
                    this._sValueBG144_2 = value;
                    this.RaisePropertyChanged("sValueBG144_2");
                }
            }
        }

        public string sValueBG144_3
        {
            get
            {
                return this._sValueBG144_3;
            }
            set
            {
                if (this._sValueBG144_3 != value)
                {
                    this.ValidateProperty("sValueBG144_3", value);
                    this._sValueBG144_3 = value;
                    this.RaisePropertyChanged("sValueBG144_3");
                }
            }
        }

        public string sValueBG144_4
        {
            get
            {
                return this._sValueBG144_4;
            }
            set
            {
                if (this._sValueBG144_4 != value)
                {
                    this.ValidateProperty("sValueBG144_4", value);
                    this._sValueBG144_4 = value;
                    this.RaisePropertyChanged("sValueBG144_4");
                }
            }
        }

        public string sValueBG144_5
        {
            get
            {
                return this._sValueBG144_5;
            }
            set
            {
                if (this._sValueBG144_5 != value)
                {
                    this.ValidateProperty("sValueBG144_5", value);
                    this._sValueBG144_5 = value;
                    this.RaisePropertyChanged("sValueBG144_5");
                }
            }
        }

        public string sValueBG144_6
        {
            get
            {
                return this._sValueBG144_6;
            }
            set
            {
                if (this._sValueBG144_6 != value)
                {
                    this.ValidateProperty("sValueBG144_6", value);
                    this._sValueBG144_6 = value;
                    this.RaisePropertyChanged("sValueBG144_6");
                }
            }
        }

        public string sValueBG144_7
        {
            get
            {
                return this._sValueBG144_7;
            }
            set
            {
                if (this._sValueBG144_7 != value)
                {
                    this.ValidateProperty("sValueBG144_7", value);
                    this._sValueBG144_7 = value;
                    this.RaisePropertyChanged("sValueBG144_7");
                }
            }
        }

        public string sValueBG144_8
        {
            get
            {
                return this._sValueBG144_8;
            }
            set
            {
                if (this._sValueBG144_8 != value)
                {
                    this.ValidateProperty("sValueBG144_8", value);
                    this._sValueBG144_8 = value;
                    this.RaisePropertyChanged("sValueBG144_8");
                }
            }
        }

        public string sValueBG144_9
        {
            get
            {
                return this._sValueBG144_9;
            }
            set
            {
                if (this._sValueBG144_9 != value)
                {
                    this.ValidateProperty("sValueBG144_9", value);
                    this._sValueBG144_9 = value;
                    this.RaisePropertyChanged("sValueBG144_9");
                }
            }
        }

        public string sValueBG144_10
        {
            get
            {
                return this._sValueBG144_10;
            }
            set
            {
                if (this._sValueBG144_10 != value)
                {
                    this.ValidateProperty("sValueBG144_10", value);
                    this._sValueBG144_10 = value;
                    this.RaisePropertyChanged("sValueBG144_10");
                }
            }
        }

        public string sValueBG144_11
        {
            get
            {
                return this._sValueBG144_11;
            }
            set
            {
                if (this._sValueBG144_11 != value)
                {
                    this.ValidateProperty("sValueBG144_11", value);
                    this._sValueBG144_11 = value;
                    this.RaisePropertyChanged("sValueBG144_11");
                }
            }
        }

        public string sValueBG144_12
        {
            get
            {
                return this._sValueBG144_12;
            }
            set
            {
                if (this._sValueBG144_12 != value)
                {
                    this.ValidateProperty("sValueBG144_12", value);
                    this._sValueBG144_12 = value;
                    this.RaisePropertyChanged("sValueBG144_12");
                }
            }
        }

        public string sValueBG144_13
        {
            get
            {
                return this._sValueBG144_13;
            }
            set
            {
                if (this._sValueBG144_13 != value)
                {
                    this.ValidateProperty("sValueBG144_13", value);
                    this._sValueBG144_13 = value;
                    this.RaisePropertyChanged("sValueBG144_13");
                }
            }
        }

        public string sValueBG144_14
        {
            get
            {
                return this._sValueBG144_14;
            }
            set
            {
                if (this._sValueBG144_14 != value)
                {
                    this.ValidateProperty("sValueBG144_14", value);
                    this._sValueBG144_14 = value;
                    this.RaisePropertyChanged("sValueBG144_14");
                }
            }
        }

        public string sValueBG144_15
        {
            get
            {
                return this._sValueBG144_15;
            }
            set
            {
                if (this._sValueBG144_15 != value)
                {
                    this.ValidateProperty("sValueBG144_15", value);
                    this._sValueBG144_15 = value;
                    this.RaisePropertyChanged("sValueBG144_15");
                }
            }
        }
        
        public string sExerciseHeading1
        {
            get
            {
                return this._sExerciseHeading1;
            }
            set
            {
                if (this._sExerciseHeading1 != value)
                {
                    this.ValidateProperty("sExerciseHeading1", value);
                    this._sExerciseHeading1 = value;
                    this.RaisePropertyChanged("sExerciseHeading1");
                }
            }
        }

        public string sExerciseHeading2
        {
            get
            {
                return this._sExerciseHeading2;
            }
            set
            {
                if (this._sExerciseHeading2 != value)
                {
                    this.ValidateProperty("sExerciseHeading2", value);
                    this._sExerciseHeading2 = value;
                    this.RaisePropertyChanged("sExerciseHeading2");
                }
            }
        }

        public string sExerciseHeading3
        {
            get
            {
                return this._sExerciseHeading3;
            }
            set
            {
                if (this._sExerciseHeading3 != value)
                {
                    this.ValidateProperty("sExerciseHeading3", value);
                    this._sExerciseHeading3 = value;
                    this.RaisePropertyChanged("sExerciseHeading3");
                }
            }
        }

        public string sExerciseHeading4
        {
            get
            {
                return this._sExerciseHeading4;
            }
            set
            {
                if (this._sExerciseHeading4 != value)
                {
                    this.ValidateProperty("sExerciseHeading4", value);
                    this._sExerciseHeading4 = value;
                    this.RaisePropertyChanged("sExerciseHeading4");
                }
            }
        }

        public string sExerciseHeading5
        {
            get
            {
                return this._sExerciseHeading5;
            }
            set
            {
                if (this._sExerciseHeading5 != value)
                {
                    this.ValidateProperty("sExerciseHeading5", value);
                    this._sExerciseHeading5 = value;
                    this.RaisePropertyChanged("sExerciseHeading5");
                }
            }
        }

        public string sExerciseHeading6
        {
            get
            {
                return this._sExerciseHeading6;
            }
            set
            {
                if (this._sExerciseHeading6 != value)
                {
                    this.ValidateProperty("sExerciseHeading6", value);
                    this._sExerciseHeading6 = value;
                    this.RaisePropertyChanged("sExerciseHeading6");
                }
            }
        }

        public string sExerciseHeading7
        {
            get
            {
                return this._sExerciseHeading7;
            }
            set
            {
                if (this._sExerciseHeading7 != value)
                {
                    this.ValidateProperty("sExerciseHeading7", value);
                    this._sExerciseHeading7 = value;
                    this.RaisePropertyChanged("sExerciseHeading7");
                }
            }
        }

        public string sExerciseHeading8
        {
            get
            {
                return this._sExerciseHeading8;
            }
            set
            {
                if (this._sExerciseHeading8 != value)
                {
                    this.ValidateProperty("sExerciseHeading8", value);
                    this._sExerciseHeading8 = value;
                    this.RaisePropertyChanged("sExerciseHeading8");
                }
            }
        }

        public string sExerciseHeading9
        {
            get
            {
                return this._sExerciseHeading9;
            }
            set
            {
                if (this._sExerciseHeading9 != value)
                {
                    this.ValidateProperty("sExerciseHeading9", value);
                    this._sExerciseHeading9 = value;
                    this.RaisePropertyChanged("sExerciseHeading9");
                }
            }
        }

        public string sExerciseHeading10
        {
            get
            {
                return this._sExerciseHeading10;
            }
            set
            {
                if (this._sExerciseHeading10 != value)
                {
                    this.ValidateProperty("sExerciseHeading10", value);
                    this._sExerciseHeading10 = value;
                    this.RaisePropertyChanged("sExerciseHeading10");
                }
            }
        }

        public string sExerciseVisibility1
        {
            get
            {
                return this._sExerciseVisibility1;
            }
            set
            {
                if (this._sExerciseVisibility1 != value)
                {
                    this.ValidateProperty("sExerciseVisibility1", value);
                    this._sExerciseVisibility1 = value;
                    this.RaisePropertyChanged("sExerciseVisibility1");
                }
            }
        }

        public string sExerciseVisibility2
        {
            get
            {
                return this._sExerciseVisibility2;
            }
            set
            {
                if (this._sExerciseVisibility2 != value)
                {
                    this.ValidateProperty("sExerciseVisibility2", value);
                    this._sExerciseVisibility2 = value;
                    this.RaisePropertyChanged("sExerciseVisibility2");
                }
            }
        }

        public string sExerciseVisibility3
        {
            get
            {
                return this._sExerciseVisibility3;
            }
            set
            {
                if (this._sExerciseVisibility3 != value)
                {
                    this.ValidateProperty("sExerciseVisibility3", value);
                    this._sExerciseVisibility3 = value;
                    this.RaisePropertyChanged("sExerciseVisibility3");
                }
            }
        }

        public string sExerciseVisibility4
        {
            get
            {
                return this._sExerciseVisibility4;
            }
            set
            {
                if (this._sExerciseVisibility4 != value)
                {
                    this.ValidateProperty("sExerciseVisibility4", value);
                    this._sExerciseVisibility4 = value;
                    this.RaisePropertyChanged("sExerciseVisibility4");
                }
            }
        }

        public string sExerciseVisibility5
        {
            get
            {
                return this._sExerciseVisibility5;
            }
            set
            {
                if (this._sExerciseVisibility5 != value)
                {
                    this.ValidateProperty("sExerciseVisibility5", value);
                    this._sExerciseVisibility5 = value;
                    this.RaisePropertyChanged("sExerciseVisibility5");
                }
            }
        }

        public string sExerciseVisibility6
        {
            get
            {
                return this._sExerciseVisibility6;
            }
            set
            {
                if (this._sExerciseVisibility6 != value)
                {
                    this.ValidateProperty("sExerciseVisibility6", value);
                    this._sExerciseVisibility6 = value;
                    this.RaisePropertyChanged("sExerciseVisibility6");
                }
            }
        }

        public string sExerciseVisibility7
        {
            get
            {
                return this._sExerciseVisibility7;
            }
            set
            {
                if (this._sExerciseVisibility7 != value)
                {
                    this.ValidateProperty("sExerciseVisibility7", value);
                    this._sExerciseVisibility7 = value;
                    this.RaisePropertyChanged("sExerciseVisibility7");
                }
            }
        }

        public string sExerciseVisibility8
        {
            get
            {
                return this._sExerciseVisibility8;
            }
            set
            {
                if (this._sExerciseVisibility8 != value)
                {
                    this.ValidateProperty("sExerciseVisibility8", value);
                    this._sExerciseVisibility8 = value;
                    this.RaisePropertyChanged("sExerciseVisibility8");
                }
            }
        }

        public string sExerciseVisibility9
        {
            get
            {
                return this._sExerciseVisibility9;
            }
            set
            {
                if (this._sExerciseVisibility9 != value)
                {
                    this.ValidateProperty("sExerciseVisibility9", value);
                    this._sExerciseVisibility9 = value;
                    this.RaisePropertyChanged("sExerciseVisibility9");
                }
            }
        }

        public string sExerciseVisibility10
        {
            get
            {
                return this._sExerciseVisibility10;
            }
            set
            {
                if (this._sExerciseVisibility10 != value)
                {
                    this.ValidateProperty("sExerciseVisibility10", value);
                    this._sExerciseVisibility10 = value;
                    this.RaisePropertyChanged("sExerciseVisibility10");
                }
            }
        }

        public string sExerciseOpacity1
        {
            get
            {
                return this._sExerciseOpacity1;
            }
            set
            {
                if (this._sExerciseOpacity1 != value)
                {
                    this.ValidateProperty("sExerciseOpacity1", value);
                    this._sExerciseOpacity1 = value;
                    this.RaisePropertyChanged("sExerciseOpacity1");
                }
            }
        }

        public string sExerciseOpacity2
        {
            get
            {
                return this._sExerciseOpacity2;
            }
            set
            {
                if (this._sExerciseOpacity2 != value)
                {
                    this.ValidateProperty("sExerciseOpacity2", value);
                    this._sExerciseOpacity2 = value;
                    this.RaisePropertyChanged("sExerciseOpacity2");
                }
            }
        }

        public string sExerciseOpacity3
        {
            get
            {
                return this._sExerciseOpacity3;
            }
            set
            {
                if (this._sExerciseOpacity3 != value)
                {
                    this.ValidateProperty("sExerciseOpacity3", value);
                    this._sExerciseOpacity3 = value;
                    this.RaisePropertyChanged("sExerciseOpacity3");
                }
            }
        }

        public string sExerciseOpacity4
        {
            get
            {
                return this._sExerciseOpacity4;
            }
            set
            {
                if (this._sExerciseOpacity4 != value)
                {
                    this.ValidateProperty("sExerciseOpacity4", value);
                    this._sExerciseOpacity4 = value;
                    this.RaisePropertyChanged("sExerciseOpacity4");
                }
            }
        }

        public string sExerciseOpacity5
        {
            get
            {
                return this._sExerciseOpacity5;
            }
            set
            {
                if (this._sExerciseOpacity5 != value)
                {
                    this.ValidateProperty("sExerciseOpacity5", value);
                    this._sExerciseOpacity5 = value;
                    this.RaisePropertyChanged("sExerciseOpacity5");
                }
            }
        }

        public string sExerciseOpacity6
        {
            get
            {
                return this._sExerciseOpacity6;
            }
            set
            {
                if (this._sExerciseOpacity6 != value)
                {
                    this.ValidateProperty("sExerciseOpacity6", value);
                    this._sExerciseOpacity6 = value;
                    this.RaisePropertyChanged("sExerciseOpacity6");
                }
            }
        }

        public string sExerciseOpacity7
        {
            get
            {
                return this._sExerciseOpacity7;
            }
            set
            {
                if (this._sExerciseOpacity7 != value)
                {
                    this.ValidateProperty("sExerciseOpacity7", value);
                    this._sExerciseOpacity7 = value;
                    this.RaisePropertyChanged("sExerciseOpacity7");
                }
            }
        }

        public string sExerciseOpacity8
        {
            get
            {
                return this._sExerciseOpacity8;
            }
            set
            {
                if (this._sExerciseOpacity8 != value)
                {
                    this.ValidateProperty("sExerciseOpacity8", value);
                    this._sExerciseOpacity8 = value;
                    this.RaisePropertyChanged("sExerciseOpacity8");
                }
            }
        }

        public string sExerciseOpacity9
        {
            get
            {
                return this._sExerciseOpacity9;
            }
            set
            {
                if (this._sExerciseOpacity9 != value)
                {
                    this.ValidateProperty("sExerciseOpacity9", value);
                    this._sExerciseOpacity9 = value;
                    this.RaisePropertyChanged("sExerciseOpacity9");
                }
            }
        }

        public string sExerciseOpacity10
        {
            get
            {
                return this._sExerciseOpacity10;
            }
            set
            {
                if (this._sExerciseOpacity10 != value)
                {
                    this.ValidateProperty("sExerciseOpacity10", value);
                    this._sExerciseOpacity10 = value;
                    this.RaisePropertyChanged("sExerciseOpacity10");
                }
            }
        }

        public int? iExerciseValue1
        {
            get
            {
                return this._iExerciseValue1;
            }
            set
            {
                if (this._iExerciseValue1 != value)
                {
                    this.ValidateProperty("iExerciseValue1", value);
                    this._iExerciseValue1 = value;
                    this.RaisePropertyChanged("iExerciseValue1");
                }
            }
        }

        public int? iExerciseValue2
        {
            get
            {
                return this._iExerciseValue2;
            }
            set
            {
                if (this._iExerciseValue2 != value)
                {
                    this.ValidateProperty("iExerciseValue2", value);
                    this._iExerciseValue2 = value;
                    this.RaisePropertyChanged("iExerciseValue2");
                }
            }
        }

        public int? iExerciseValue3
        {
            get
            {
                return this._iExerciseValue3;
            }
            set
            {
                if (this._iExerciseValue3 != value)
                {
                    this.ValidateProperty("iExerciseValue3", value);
                    this._iExerciseValue3 = value;
                    this.RaisePropertyChanged("iExerciseValue3");
                }
            }
        }

        public int? iExerciseValue4
        {
            get
            {
                return this._iExerciseValue4;
            }
            set
            {
                if (this._iExerciseValue4 != value)
                {
                    this.ValidateProperty("iExerciseValue4", value);
                    this._iExerciseValue4 = value;
                    this.RaisePropertyChanged("iExerciseValue4");
                }
            }
        }

        public int? iExerciseValue5
        {
            get
            {
                return this._iExerciseValue5;
            }
            set
            {
                if (this._iExerciseValue5 != value)
                {
                    this.ValidateProperty("iExerciseValue5", value);
                    this._iExerciseValue5 = value;
                    this.RaisePropertyChanged("iExerciseValue5");
                }
            }
        }

        public int? iExerciseValue6
        {
            get
            {
                return this._iExerciseValue6;
            }
            set
            {
                if (this._iExerciseValue6 != value)
                {
                    this.ValidateProperty("iExerciseValue6", value);
                    this._iExerciseValue6 = value;
                    this.RaisePropertyChanged("iExerciseValue6");
                }
            }
        }

        public int? iExerciseValue7
        {
            get
            {
                return this._iExerciseValue7;
            }
            set
            {
                if (this._iExerciseValue7 != value)
                {
                    this.ValidateProperty("iExerciseValue7", value);
                    this._iExerciseValue7 = value;
                    this.RaisePropertyChanged("iExerciseValue7");
                }
            }
        }

        public int? iExerciseValue8
        {
            get
            {
                return this._iExerciseValue8;
            }
            set
            {
                if (this._iExerciseValue8 != value)
                {
                    this.ValidateProperty("iExerciseValue8", value);
                    this._iExerciseValue8 = value;
                    this.RaisePropertyChanged("iExerciseValue8");
                }
            }
        }

        public int? iExerciseValue9
        {
            get
            {
                return this._iExerciseValue9;
            }
            set
            {
                if (this._iExerciseValue9 != value)
                {
                    this.ValidateProperty("iExerciseValue9", value);
                    this._iExerciseValue9 = value;
                    this.RaisePropertyChanged("iExerciseValue9");
                }
            }
        }

        public int? iExerciseValue10
        {
            get
            {
                return this._iExerciseValue10;
            }
            set
            {
                if (this._iExerciseValue10 != value)
                {
                    this.ValidateProperty("iExerciseValue10", value);
                    this._iExerciseValue10 = value;
                    this.RaisePropertyChanged("iExerciseValue10");
                }
            }
        }

        public string sExerciseBG1
        {
            get
            {
                return this._sExerciseBG1;
            }
            set
            {
                if (this._sExerciseBG1 != value)
                {
                    this.ValidateProperty("sExerciseBG1", value);
                    this._sExerciseBG1 = value;
                    this.RaisePropertyChanged("sExerciseBG1");
                }
            }
        }

        public string sExerciseBG2
        {
            get
            {
                return this._sExerciseBG2;
            }
            set
            {
                if (this._sExerciseBG2 != value)
                {
                    this.ValidateProperty("sExerciseBG2", value);
                    this._sExerciseBG2 = value;
                    this.RaisePropertyChanged("sExerciseBG2");
                }
            }
        }

        public string sExerciseBG3
        {
            get
            {
                return this._sExerciseBG3;
            }
            set
            {
                if (this._sExerciseBG3 != value)
                {
                    this.ValidateProperty("sExerciseBG3", value);
                    this._sExerciseBG3 = value;
                    this.RaisePropertyChanged("sExerciseBG3");
                }
            }
        }

        public string sExerciseBG4
        {
            get
            {
                return this._sExerciseBG4;
            }
            set
            {
                if (this._sExerciseBG4 != value)
                {
                    this.ValidateProperty("sExerciseBG4", value);
                    this._sExerciseBG4 = value;
                    this.RaisePropertyChanged("sExerciseBG4");
                }
            }
        }

        public string sExerciseBG5
        {
            get
            {
                return this._sExerciseBG5;
            }
            set
            {
                if (this._sExerciseBG5 != value)
                {
                    this.ValidateProperty("sExerciseBG5", value);
                    this._sExerciseBG5 = value;
                    this.RaisePropertyChanged("sExerciseBG5");
                }
            }
        }

        public string sExerciseBG6
        {
            get
            {
                return this._sExerciseBG6;
            }
            set
            {
                if (this._sExerciseBG6 != value)
                {
                    this.ValidateProperty("sExerciseBG6", value);
                    this._sExerciseBG6 = value;
                    this.RaisePropertyChanged("sExerciseBG6");
                }
            }
        }

        public string sExerciseBG7
        {
            get
            {
                return this._sExerciseBG7;
            }
            set
            {
                if (this._sExerciseBG7 != value)
                {
                    this.ValidateProperty("sExerciseBG7", value);
                    this._sExerciseBG7 = value;
                    this.RaisePropertyChanged("sExerciseBG7");
                }
            }
        }

        public string sExerciseBG8
        {
            get
            {
                return this._sExerciseBG8;
            }
            set
            {
                if (this._sExerciseBG8 != value)
                {
                    this.ValidateProperty("sExerciseBG8", value);
                    this._sExerciseBG8 = value;
                    this.RaisePropertyChanged("sExerciseBG8");
                }
            }
        }

        public string sExerciseBG9
        {
            get
            {
                return this._sExerciseBG9;
            }
            set
            {
                if (this._sExerciseBG9 != value)
                {
                    this.ValidateProperty("sExerciseBG9", value);
                    this._sExerciseBG9 = value;
                    this.RaisePropertyChanged("sExerciseBG9");
                }
            }
        }

        public string sExerciseBG10
        {
            get
            {
                return this._sExerciseBG10;
            }
            set
            {
                if (this._sExerciseBG10 != value)
                {
                    this.ValidateProperty("sExerciseBG10", value);
                    this._sExerciseBG10 = value;
                    this.RaisePropertyChanged("sExerciseBG10");
                }
            }
        }
    }
}
