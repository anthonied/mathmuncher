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
using System.ServiceModel.DomainServices.Client;
using System.ComponentModel.DataAnnotations;

namespace MathMuncherMain.Multiplication.Tafels.ViewModels
{
    public class FormData: ComplexObject
    {

        private int? _iLinkerPoot1;
        private int? _iLinkerPoot2;
        private int? _iLinkerPoot3;
        private int? _iLinkerPoot4;
        private int? _iLinkerPoot5;
        private int? _iRegterPoot1;
        private int? _iRegterPoot2;
        private int? _iRegterPoot3;
        private int? _iRegterPoot4;
        private int? _iRegterPoot5;
        private string _sRegterPootResult1;
        private string _sRegterPootResult2;
        private string _sRegterPootResult3;
        private string _sRegterPootResult4;
        private string _sRegterPootResult5;
        private int _iModifier;
        private int? _iRegterPootCorrection1;
        private int? _iRegterPootCorrection2;
        private int? _iRegterPootCorrection3;
        private int? _iRegterPootCorrection4;
        private int? _iRegterPootCorrection5;
        private string _sLinkerPootBG1;
        private string _sLinkerPootBG2;
        private string _sLinkerPootBG3;
        private string _sLinkerPootBG4;
        private string _sLinkerPootBG5;
        private string _sRegterPootBG1;
        private string _sRegterPootBG2;
        private string _sRegterPootBG3;
        private string _sRegterPootBG4;
        private string _sRegterPootBG5;
        private string _sLinkerPootOpacity1;
        private string _sLinkerPootOpacity2;
        private string _sLinkerPootOpacity3;
        private string _sLinkerPootOpacity4;
        private string _sLinkerPootOpacity5;
        private string _sRegterPootOpacity1;
        private string _sRegterPootOpacity2;
        private string _sRegterPootOpacity3;
        private string _sRegterPootOpacity4;
        private string _sRegterPootOpacity5;
        
        public int? iLinkerPoot1
        {
            get
            {

                return this._iLinkerPoot1;
            }
            set
            {
                if (this._iLinkerPoot1 != value)
                {
                    this.ValidateProperty("iLinkerPoot1", value);
                    this._iLinkerPoot1 = value;
                    this.RaisePropertyChanged("iLinkerPoot1");
                }
            }
        }

        public int? iLinkerPoot2
        {
            get
            {
                return this._iLinkerPoot2;
            }
            set
            {
                if (this._iLinkerPoot2 != value)
                {
                    this.ValidateProperty("iLinkerPoot2", value);
                    this._iLinkerPoot2 = value;
                    this.RaisePropertyChanged("iLinkerPoot2");
                }
            }
        }

        public int? iLinkerPoot3
        {
            get
            {
                return this._iLinkerPoot3;
            }
            set
            {
                if (this._iLinkerPoot3 != value)
                {
                    this.ValidateProperty("iLinkerPoot3", value);
                    this._iLinkerPoot3 = value;
                    this.RaisePropertyChanged("iLinkerPoot3");
                }
            }
        }

        public int? iLinkerPoot4
        {
            get
            {
                return this._iLinkerPoot4;
            }
            set
            {
                if (this._iLinkerPoot4 != value)
                {
                    this.ValidateProperty("iLinkerPoot4", value);
                    this._iLinkerPoot4 = value;
                    this.RaisePropertyChanged("iLinkerPoot4");
                }
            }
        }

        public int? iLinkerPoot5
        {
            get
            {
                return this._iLinkerPoot5;
            }
            set
            {
                if (this._iLinkerPoot5 != value)
                {
                    this.ValidateProperty("iLinkerPoot5", value);
                    this._iLinkerPoot5 = value;
                    this.RaisePropertyChanged("iLinkerPoot5");
                }
            }
        }

                
        //[DataType("int", ErrorMessage="Incorrect datatype")]
        public int? iRegterPoot1
        {
            get
            {

                return this._iRegterPoot1;
            }
            set
            {
                if (this._iRegterPoot1 != value)
                {
                    this.ValidateProperty("iRegterPoot1", value);
                    this._iRegterPoot1 = value;
                    this.RaisePropertyChanged("iRegterPoot1");
                }

            }

        }

        public int? iRegterPoot2
        {
            get
            {

                return this._iRegterPoot2;
            }
            set
            {
                if (this._iRegterPoot2 != value)
                {
                    this.ValidateProperty("iRegterPoot2", value);
                    this._iRegterPoot2 = value;
                    this.RaisePropertyChanged("iRegterPoot2");
                }

            }

        }

        public int? iRegterPoot3
        {
            get
            {

                return this._iRegterPoot3;
            }
            set
            {
                if (this._iRegterPoot3 != value)
                {
                    this.ValidateProperty("iRegterPoot3", value);
                    this._iRegterPoot3 = value;
                    this.RaisePropertyChanged("iRegterPoot3");
                }

            }

        }

        public int? iRegterPoot4
        {
            get
            {

                return this._iRegterPoot4;
            }
            set
            {
                if (this._iRegterPoot4 != value)
                {
                    this.ValidateProperty("iRegterPoot4", value);
                    this._iRegterPoot4 = value;
                    this.RaisePropertyChanged("iRegterPoot4");
                }

            }

        }

        public int? iRegterPoot5
        {
            get
            {

                return this._iRegterPoot5;
            }
            set
            {
                if (this._iRegterPoot5 != value)
                {
                    this.ValidateProperty("iRegterPoot5", value);
                    this._iRegterPoot5 = value;
                    this.RaisePropertyChanged("iRegterPoot5");
                }

            }
        }

        public string sRegterPootResult1
        {
            get
            {
                return this._sRegterPootResult1;
            }
            set
            {
                if (this._sRegterPootResult1 != value)
                {
                    this.ValidateProperty("sRegterPootResult1", value);
                    this._sRegterPootResult1 = value;
                    this.RaisePropertyChanged("sRegterPootResult1");
                }

            }
        }

        public string sRegterPootResult2
        {
            get
            {
                return this._sRegterPootResult2;
            }
            set
            {
                if (this._sRegterPootResult2 != value)
                {
                    this.ValidateProperty("sRegterPootResult2", value);
                    this._sRegterPootResult2 = value;
                    this.RaisePropertyChanged("sRegterPootResult2");
                }

            }
        }

        public string sRegterPootResult3
        {
            get
            {
                return this._sRegterPootResult3;
            }
            set
            {
                if (this._sRegterPootResult3 != value)
                {
                    this.ValidateProperty("sRegterPootResult3", value);
                    this._sRegterPootResult3 = value;
                    this.RaisePropertyChanged("sRegterPootResult3");
                }

            }
        }

        public string sRegterPootResult4
        {
            get
            {
                return this._sRegterPootResult4;
            }
            set
            {
                if (this._sRegterPootResult4 != value)
                {
                    this.ValidateProperty("sRegterPootResult4", value);
                    this._sRegterPootResult4 = value;
                    this.RaisePropertyChanged("sRegterPootResult4");
                }

            }
        }

        public string sRegterPootResult5
        {
            get
            {
                return this._sRegterPootResult5;
            }
            set
            {
                if (this._sRegterPootResult5 != value)
                {
                    this.ValidateProperty("sRegterPootResult5", value);
                    this._sRegterPootResult5 = value;
                    this.RaisePropertyChanged("sRegterPootResult5");
                }

            }
        }

        public int iModifier
        {
            get
            {

                return this._iModifier;
            }
            set
            {
                if (this._iModifier != value)
                {
                    this.ValidateProperty("iModifier", value);
                    this._iModifier = value;
                    this.RaisePropertyChanged("iModifier");
                }
            }
        }
        
        public int? iRegterPootCorrection1
        {
            get
            {
                return this._iRegterPootCorrection1;
            }
            set
            {
                if (this._iRegterPootCorrection1 != value)
                {
                    this.ValidateProperty("iRegterPootCorrection1", value);
                    this._iRegterPootCorrection1 = value;
                    this.RaisePropertyChanged("iRegterPootCorrection1");
                }
            }
        }

        public int? iRegterPootCorrection2
        {
            get
            {
                return this._iRegterPootCorrection2;
            }
            set
            {
                if (this._iRegterPootCorrection2 != value)
                {
                    this.ValidateProperty("iRegterPootCorrection2", value);
                    this._iRegterPootCorrection2 = value;
                    this.RaisePropertyChanged("iRegterPootCorrection2");
                }
            }
        }       

        public int? iRegterPootCorrection3
        {
            get
            {
                return this._iRegterPootCorrection3;
            }
            set
            {
                if (this._iRegterPootCorrection3 != value)
                {
                    this.ValidateProperty("iRegterPootCorrection3", value);
                    this._iRegterPootCorrection3 = value;
                    this.RaisePropertyChanged("iRegterPootCorrection3");
                }
            }
        }

        public int? iRegterPootCorrection4
        {
            get
            {
                return this._iRegterPootCorrection4;
            }
            set
            {
                if (this._iRegterPootCorrection4 != value)
                {
                    this.ValidateProperty("iRegterPootCorrection4", value);
                    this._iRegterPootCorrection4 = value;
                    this.RaisePropertyChanged("iRegterPootCorrection4");
                }
            }
        }

        public int? iRegterPootCorrection5
        {
            get
            {
                return this._iRegterPootCorrection5;
            }
            set
            {
                if (this._iRegterPootCorrection5 != value)
                {
                    this.ValidateProperty("iRegterPootCorrection5", value);
                    this._iRegterPootCorrection5 = value;
                    this.RaisePropertyChanged("iRegterPootCorrection5");
                }
            }
        }

        public string sLinkerPootBG1
        {
            get
            {
                return this._sLinkerPootBG1;
            }
            set
            {
                if (this._sLinkerPootBG1 != value)
                {
                    this.ValidateProperty("sLinkerPootBG1", value);
                    this._sLinkerPootBG1 = value;
                    this.RaisePropertyChanged("sLinkerPootBG1");
                }

            }
        }

        public string sLinkerPootBG2
        {
            get
            {
                return this._sLinkerPootBG2;
            }
            set
            {
                if (this._sLinkerPootBG2 != value)
                {
                    this.ValidateProperty("sLinkerPootBG2", value);
                    this._sLinkerPootBG2 = value;
                    this.RaisePropertyChanged("sLinkerPootBG2");
                }

            }
        }

        public string sLinkerPootBG3
        {
            get
            {
                return this._sLinkerPootBG3;
            }
            set
            {
                if (this._sLinkerPootBG3 != value)
                {
                    this.ValidateProperty("sLinkerPootBG3", value);
                    this._sLinkerPootBG3 = value;
                    this.RaisePropertyChanged("sLinkerPootBG3");
                }

            }
        }

        public string sLinkerPootBG4
        {
            get
            {
                return this._sLinkerPootBG4;
            }
            set
            {
                if (this._sLinkerPootBG4 != value)
                {
                    this.ValidateProperty("sLinkerPootBG4", value);
                    this._sLinkerPootBG4 = value;
                    this.RaisePropertyChanged("sLinkerPootBG4");
                }

            }
        }

        public string sLinkerPootBG5
        {
            get
            {
                return this._sLinkerPootBG5;
            }
            set
            {
                if (this._sLinkerPootBG5 != value)
                {
                    this.ValidateProperty("sLinkerPootBG5", value);
                    this._sLinkerPootBG5 = value;
                    this.RaisePropertyChanged("sLinkerPootBG5");
                }

            }
        }

        public string sRegterPootBG1
        {
            get
            {
                return this._sRegterPootBG1;
            }
            set
            {
                if (this._sRegterPootBG1 != value)
                {
                    this.ValidateProperty("sRegterPootBG1", value);
                    this._sRegterPootBG1 = value;
                    this.RaisePropertyChanged("sRegterPootBG1");
                }

            }
        }

        public string sRegterPootBG2
        {
            get
            {
                return this._sRegterPootBG2;
            }
            set
            {
                if (this._sRegterPootBG2 != value)
                {
                    this.ValidateProperty("sRegterPootBG2", value);
                    this._sRegterPootBG2 = value;
                    this.RaisePropertyChanged("sRegterPootBG2");
                }

            }
        }

        public string sRegterPootBG3
        {
            get
            {
                return this._sRegterPootBG3;
            }
            set
            {
                if (this._sRegterPootBG3 != value)
                {
                    this.ValidateProperty("sRegterPootBG3", value);
                    this._sRegterPootBG3 = value;
                    this.RaisePropertyChanged("sRegterPootBG3");
                }

            }
        }

        public string sRegterPootBG4
        {
            get
            {
                return this._sRegterPootBG4;
            }
            set
            {
                if (this._sRegterPootBG4 != value)
                {
                    this.ValidateProperty("sRegterPootBG4", value);
                    this._sRegterPootBG4 = value;
                    this.RaisePropertyChanged("sRegterPootBG4");
                }

            }
        }

        public string sRegterPootBG5
        {
            get
            {
                return this._sRegterPootBG5;
            }
            set
            {
                if (this._sRegterPootBG5 != value)
                {
                    this.ValidateProperty("sRegterPootBG5", value);
                    this._sRegterPootBG5 = value;
                    this.RaisePropertyChanged("sRegterPootBG5");
                }

            }
        }

        public string sLinkerPootOpacity1
        {
            get
            {
                return this._sLinkerPootOpacity1;
            }
            set
            {
                if (this._sLinkerPootOpacity1 != value)
                {
                    this.ValidateProperty("sLinkerPootOpacity1", value);
                    this._sLinkerPootOpacity1 = value;
                    this.RaisePropertyChanged("sLinkerPootOpacity1");
                }

            }
        }

        public string sLinkerPootOpacity2
        {
            get
            {
                return this._sLinkerPootOpacity2;
            }
            set
            {
                if (this._sLinkerPootOpacity2 != value)
                {
                    this.ValidateProperty("sLinkerPootOpacity2", value);
                    this._sLinkerPootOpacity2 = value;
                    this.RaisePropertyChanged("sLinkerPootOpacity2");
                }

            }
        }

        public string sLinkerPootOpacity3
        {
            get
            {
                return this._sLinkerPootOpacity3;
            }
            set
            {
                if (this._sLinkerPootOpacity3 != value)
                {
                    this.ValidateProperty("sLinkerPootOpacity3", value);
                    this._sLinkerPootOpacity3 = value;
                    this.RaisePropertyChanged("sLinkerPootOpacity3");
                }

            }
        }

        public string sLinkerPootOpacity4
        {
            get
            {
                return this._sLinkerPootOpacity4;
            }
            set
            {
                if (this._sLinkerPootOpacity4 != value)
                {
                    this.ValidateProperty("sLinkerPootOpacity4", value);
                    this._sLinkerPootOpacity4 = value;
                    this.RaisePropertyChanged("sLinkerPootOpacity4");
                }

            }
        }

        public string sLinkerPootOpacity5
        {
            get
            {
                return this._sLinkerPootOpacity5;
            }
            set
            {
                if (this._sLinkerPootOpacity5 != value)
                {
                    this.ValidateProperty("sLinkerPootOpacity5", value);
                    this._sLinkerPootOpacity5 = value;
                    this.RaisePropertyChanged("sLinkerPootOpacity5");
                }

            }
        }

        public string sRegterPootOpacity1
        {
            get
            {
                return this._sRegterPootOpacity1;
            }
            set
            {
                if (this._sRegterPootOpacity1 != value)
                {
                    this.ValidateProperty("sRegterPootOpacity1", value);
                    this._sRegterPootOpacity1 = value;
                    this.RaisePropertyChanged("sRegterPootOpacity1");
                }

            }
        }

        public string sRegterPootOpacity2
        {
            get
            {
                return this._sRegterPootOpacity2;
            }
            set
            {
                if (this._sRegterPootOpacity2 != value)
                {
                    this.ValidateProperty("sRegterPootOpacity2", value);
                    this._sRegterPootOpacity2 = value;
                    this.RaisePropertyChanged("sRegterPootOpacity2");
                }

            }
        }

        public string sRegterPootOpacity3
        {
            get
            {
                return this._sRegterPootOpacity3;
            }
            set
            {
                if (this._sRegterPootOpacity3 != value)
                {
                    this.ValidateProperty("sRegterPootOpacity3", value);
                    this._sRegterPootOpacity3 = value;
                    this.RaisePropertyChanged("sRegterPootOpacity3");
                }

            }
        }

        public string sRegterPootOpacity4
        {
            get
            {
                return this._sRegterPootOpacity4;
            }
            set
            {
                if (this._sRegterPootOpacity4 != value)
                {
                    this.ValidateProperty("sRegterPootOpacity4", value);
                    this._sRegterPootOpacity4 = value;
                    this.RaisePropertyChanged("sRegterPootOpacity4");
                }

            }
        }

        public string sRegterPootOpacity5
        {
            get
            {
                return this._sRegterPootOpacity5;
            }
            set
            {
                if (this._sRegterPootOpacity5 != value)
                {
                    this.ValidateProperty("sRegterPootOpacity5", value);
                    this._sRegterPootOpacity5 = value;
                    this.RaisePropertyChanged("sRegterPootOpacity5");
                }

            }
        }

    }
}
