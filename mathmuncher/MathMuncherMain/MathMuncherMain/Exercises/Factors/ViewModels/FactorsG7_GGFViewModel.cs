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
using System.Text;
using MathMuncherMain.Classes;
using System.Collections.Generic;

namespace MathMuncherMain.Exercises.Factors.ViewModels
{
    public class FactorsG7_GGFViewModel : INotifyPropertyChanged
    {
        private int _iTop = 190;
        private string _sGGFHeading = "";
        private int _iActiveInput = 1;
        private int _iActiveExercise = 0;
        private int _iActiveSubFactorIndex = 0;
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

        public ServerData_G7_GGF ServerData { get; set; }
        public FormData FormData { get; set; }
        //end properties

        public FactorsG7_GGFViewModel()
        {
            this.ServerData = new ServerData_G7_GGF();
            this.FormData = new FormData();
        }

        public void StartExercise()
        {
            ServerData.GetServerData_GFF();
            SetExerciseLabels();
        }


        private void SetExerciseLabels()
        {
            for (int iExercise = 0; iExercise < ServerData.lFactorsGGF.Count; iExercise++)
            {
                
                _sGGFHeading = Convert.ToChar(97 + iExercise).ToString() + ") " + ServerData.lFactorsGGF[iExercise][0].ToString() + " en " + ServerData.lFactorsGGF[iExercise][1].ToString();
                FormData.GetType().GetProperty("sExerciseHeading" + (iExercise+1).ToString()).SetValue(FormData, _sGGFHeading, null);
                FormData.GetType().GetProperty("sExerciseVisibility" + (iExercise+1).ToString()).SetValue(FormData, "Visible", null);

                if (iExercise != 0)
                {
                    FormData.GetType().GetProperty("sExerciseOpacity" + (iExercise + 1).ToString()).SetValue(FormData, "0.2", null);
                    FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[iExercise][0].ToString()).SetValue(FormData, "0.2", null);
                    FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[iExercise][1].ToString()).SetValue(FormData, "0.2", null);
                }
                else
                {
                    FormData.GetType().GetProperty("sFactorInputVisibility" + ServerData.lFactorsGGF[iExercise][0].ToString()).SetValue(FormData, "Visible", null);
                    SetInputFocus = "txtFactor" + ServerData.lFactorsGGF[iExercise][0].ToString() + "_1";
                }

                FormData.GetType().GetProperty("sFactorVisibility" + ServerData.lFactorsGGF[iExercise][0].ToString()).SetValue(FormData, "Visible", null);
                FormData.GetType().GetProperty("sFactorTop" + ServerData.lFactorsGGF[iExercise][0].ToString()).SetValue(FormData, _iTop.ToString(), null);
                _iTop += 50;
                FormData.GetType().GetProperty("sFactorVisibility" + ServerData.lFactorsGGF[iExercise][1].ToString()).SetValue(FormData, "Visible", null);
                FormData.GetType().GetProperty("sFactorTop" + ServerData.lFactorsGGF[iExercise][1].ToString()).SetValue(FormData, _iTop.ToString(), null);
                _iTop += 160;
            }
        }

        public void NextAnswer(int iActiveInput)
        {
            iActiveInput++;
            _iActiveInput = iActiveInput;
            SetInputFocus = "txtFactor" + ServerData.lFactorsGGF[_iActiveExercise][_iActiveSubFactorIndex].ToString() + "_" + iActiveInput.ToString();
        }

        public void NextFactor(int iFinalValue)
        {
            FormData.GetType().GetProperty("iValue" + ServerData.lFactorsGGF[_iActiveExercise][_iActiveSubFactorIndex].ToString() + "_" + _iActiveInput.ToString()).SetValue(FormData, iFinalValue, null);


            _iActiveInput = 1;
            if (_iActiveSubFactorIndex == 0)
            {
                _iActiveSubFactorIndex = 1;
                FormData.GetType().GetProperty("sFactorInputVisibility" + ServerData.lFactorsGGF[_iActiveExercise][_iActiveSubFactorIndex].ToString()).SetValue(FormData, "Visible", null);
                SetInputFocus = "txtFactor" + ServerData.lFactorsGGF[_iActiveExercise][_iActiveSubFactorIndex].ToString() + "_1";
            }
            else
            {
                SetInputFocus = "txtAnswer" + (_iActiveExercise + 1).ToString();
            }

        }
        public void NextExercise()
        {
            FormData.GetType().GetProperty("sFactorReadOnly" + ServerData.lFactorsGGF[_iActiveExercise][0].ToString()).SetValue(FormData, "True", null);
            FormData.GetType().GetProperty("sFactorReadOnly" + ServerData.lFactorsGGF[_iActiveExercise][1].ToString()).SetValue(FormData, "True", null);
            if (_iActiveExercise + 1 < ServerData.lFactorsGGF.Count) //Not the last exercise
            {                
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[_iActiveExercise][0].ToString()).SetValue(FormData, "0.2", null);
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[_iActiveExercise][1].ToString()).SetValue(FormData, "0.2", null);
                FormData.GetType().GetProperty("sExerciseOpacity" + (_iActiveExercise + 1).ToString()).SetValue(FormData, "0.2", null);
                _iActiveSubFactorIndex = 0;
                _iActiveExercise++;
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[_iActiveExercise][0].ToString()).SetValue(FormData, "1", null);
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[_iActiveExercise][1].ToString()).SetValue(FormData, "1", null);
                FormData.GetType().GetProperty("sExerciseOpacity" + (_iActiveExercise + 1).ToString()).SetValue(FormData, "1", null);
                FormData.GetType().GetProperty("sFactorInputVisibility" + ServerData.lFactorsGGF[_iActiveExercise][_iActiveSubFactorIndex].ToString()).SetValue(FormData, "Visible", null);
                FormData.GetType().GetProperty("sExerciseVisibility" + (_iActiveExercise + 1).ToString()).SetValue(FormData, "Visible", null);
                SetInputFocus = "txtFactor" + ServerData.lFactorsGGF[_iActiveExercise][_iActiveSubFactorIndex].ToString() + "_1";
            }
            else
            {                
                MarkExercise();
            }
        }

        public void MarkExercise()
        {
            FactorAnswers faFactorAnswers = new FactorAnswers();
            List<int> lAnswerSet;
            int iGGFAnswer;
            //Set state
            
            for (int iExercise = 0; iExercise < ServerData.lFactorsGGF.Count; iExercise++)
            {
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[iExercise][0].ToString()).SetValue(FormData, "1", null);
                FormData.GetType().GetProperty("sFactorOpacity" + ServerData.lFactorsGGF[iExercise][1].ToString()).SetValue(FormData, "1", null);
                FormData.GetType().GetProperty("sExerciseOpacity" + (iExercise+1).ToString()).SetValue(FormData, "1", null);
                
                //Mark spesific top and bottom factor's answers
                for (int iFactorSet = 0; iFactorSet < 2; iFactorSet++)
                {
                    lAnswerSet = (List<int>)faFactorAnswers.GetType().GetProperty("lFactorAnswer" + ServerData.lFactorsGGF[iExercise][iFactorSet].ToString()).GetValue(faFactorAnswers, null);
                    for (int iAnswer = 0; iAnswer < lAnswerSet.Count; iAnswer++)
                    {
                        if (lAnswerSet[iAnswer] == (int)FormData.GetType().GetProperty("iValue" + ServerData.lFactorsGGF[iExercise][iFactorSet].ToString() + "_" + (iAnswer + 1).ToString()).GetValue(FormData, null))
                        {
                            FormData.GetType().GetProperty("sValueBG" + ServerData.lFactorsGGF[iExercise][iFactorSet].ToString() + "_" + (iAnswer + 1).ToString()).SetValue(FormData, Session.sCorrectBackGroundColor, null);
                        }
                        else
                        {
                            FormData.GetType().GetProperty("sValueBG" + ServerData.lFactorsGGF[iExercise][iFactorSet].ToString() + "_" + (iAnswer + 1).ToString()).SetValue(FormData, Session.sWrongBackGroundColor, null);
                        }
                    }
                }         
                //Get GGF answer

                iGGFAnswer = Calculations.GetBigestSharedFactor((List<int>)faFactorAnswers.GetType().GetProperty("lFactorAnswer" + ServerData.lFactorsGGF[iExercise][0].ToString()).GetValue(faFactorAnswers, null), (List<int>)faFactorAnswers.GetType().GetProperty("lFactorAnswer" + ServerData.lFactorsGGF[iExercise][1].ToString()).GetValue(faFactorAnswers, null));
                if (iGGFAnswer == (int)FormData.GetType().GetProperty("iExerciseValue" + (iExercise + 1).ToString()).GetValue(FormData, null))
                {
                    FormData.GetType().GetProperty("sExerciseBG" + (iExercise +1).ToString()).SetValue(FormData, Session.sCorrectBackGroundColor, null);
                }
                else
                {
                    FormData.GetType().GetProperty("sExerciseBG" + (iExercise + 1).ToString()).SetValue(FormData, Session.sWrongBackGroundColor, null);
                }
            }    
        }
       
        public void ResetInputFocus()
        {
            SetInputFocus = "txtFactor" + ServerData.lFactorsGGF[_iActiveExercise][_iActiveSubFactorIndex].ToString() + "_" + _iActiveInput.ToString();
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
