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
using MathMuncherMain.Classes;
using System.Collections.Generic;

namespace MathMuncherMain.Exercises.Factors.ViewModels
{
    public class FactorsG7_1ViewModel : INotifyPropertyChanged
    {
        private int _iTop = 210;
        private int _iActiveExercise = 0;
        private int _iActiveInput = 1;
       
        //properties

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

        public ServerData_G7_1 ServerData { get; set; }
        public FormData FormData { get; set; }
        //end properties

        public FactorsG7_1ViewModel()
        {
            this.ServerData = new ServerData_G7_1();
            this.FormData = new FormData();
        }

        public void StartExercise()
        {
          //  ServerData.GetServerData_G7_1();
            BuildFrontEnd();

        }

        public void BuildFrontEnd()
        {
            
            for (int iExercise = 0; iExercise < ServerData.lFactorsNumbers_G7_1.Count; iExercise++)
            {
                FormData.GetType().GetProperty("sFactorVisibility" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString()).SetValue(FormData, "Visible", null);
                FormData.GetType().GetProperty("sFactorTop" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString()).SetValue(FormData, _iTop.ToString(), null);
                if (iExercise == 0)
                {
                    FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString()).SetValue(FormData, "1", null);
                    FormData.GetType().GetProperty("sFactorInputVisibility" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString()).SetValue(FormData, "Visible", null);
                    SetInputFocus = "txtFactor" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString() + "_1";
                }
                else
                {
                    FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString()).SetValue(FormData, "0.2", null);
                }
                
                _iTop += 45;
            }
        }

        public void NextAnswer(int iActiveInput)
        {
            iActiveInput++;
            _iActiveInput = iActiveInput;
            SetInputFocus = "txtFactor" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString() + "_" + iActiveInput.ToString();
        }

        public void NextExercise(int iFinalValue)
        {
            FormData.GetType().GetProperty("iValue" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString() + "_" + _iActiveInput.ToString()).SetValue(FormData, iFinalValue, null);
            FormData.GetType().GetProperty("sFactorReadOnly" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString()).SetValue(FormData, "True", null);
            if (_iActiveExercise + 1 < ServerData.lFactorsNumbers_G7_1.Count)
            {
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString()).SetValue(FormData, "0.2", null);              
                //    FormData.GetType().GetProperty("sFactorInputVisibility" + ServerData.lFactorsNumbers[_iActiveExercise].ToString()).SetValue(FormData, "Collapsed", null);
                _iActiveExercise++;
                _iActiveInput = 1;
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString()).SetValue(FormData, "1", null);
                FormData.GetType().GetProperty("sFactorInputVisibility" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString()).SetValue(FormData, "Visible", null);
                SetInputFocus = "txtFactor" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString() + "_1";
            }
            else
            {
                MarkExercise();

            }
        }

        public void ResetInputFocus()
        {
            SetInputFocus = "txtFactor" + ServerData.lFactorsNumbers_G7_1[_iActiveExercise].ToString() + "_" + _iActiveInput.ToString();
        }

        private void MarkExercise()
        {
            FactorAnswers faFactorAnswers = new FactorAnswers();
            List<int> lAnswerSet; 
            
            //Set state
            for (int iExercise = 0; iExercise < ServerData.lFactorsNumbers_G7_1.Count; iExercise++)
            {
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString()).SetValue(FormData, "1", null);
                lAnswerSet = (List<int>)faFactorAnswers.GetType().GetProperty("lFactorAnswer" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString()).GetValue(faFactorAnswers, null);
                //Mark spesific factor's answers
                for (int iAnswer = 0; iAnswer < lAnswerSet.Count; iAnswer++)
                {
                    if (lAnswerSet[iAnswer] == (int)FormData.GetType().GetProperty("iValue" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString() + "_" + (iAnswer + 1).ToString()).GetValue(FormData, null))
                    {
                        FormData.GetType().GetProperty("sValueBG" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString() + "_" + (iAnswer + 1).ToString()).SetValue(FormData, Session.sCorrectBackGroundColor, null);
                    }
                    else
                    {
                        FormData.GetType().GetProperty("sValueBG" + ServerData.lFactorsNumbers_G7_1[iExercise].ToString() + "_" + (iAnswer + 1).ToString()).SetValue(FormData, Session.sWrongBackGroundColor, null);
                    }
                }                
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

