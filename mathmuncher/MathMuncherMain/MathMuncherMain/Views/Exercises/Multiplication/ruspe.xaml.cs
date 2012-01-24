using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace MathMuncherMain.Views.Exercises.Multiplication
{
    public partial class ruspe : Page
    {

        private string _sCatapillarPrefix = "a";
        private TextBox _txtActiveInput;
        public ruspe()
        {

            InitializeComponent();
            aSircle3Textbox.Focus();
            _beginExercise();
        }        

        private void _beginExercise()
        {
            _txtActiveInput = (TextBox)this.FindName(_sCatapillarPrefix + "Sircle3Textbox");
            VisualStateManager.GoToState(this, _sCatapillarPrefix + "Question1", true);         
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            aSircle3Textbox.Focus();
        }

        private void aSircleTextbox_LostFocus(object sender, RoutedEventArgs e)
        {
            int iTextboxPosition = _getTextboxPosition(((TextBox)sender).Name);

            if (iTextboxPosition != 11) //Last Textbox
            {
                int iNextQuestionID = ((int)iTextboxPosition / 2) + 1;
                VisualStateManager.GoToState(this, _sCatapillarPrefix + "Question" + iNextQuestionID.ToString() , true);  
                iTextboxPosition += 2; //Next Textbox
                _txtActiveInput = (TextBox)this.FindName(_sCatapillarPrefix + "Sircle" + iTextboxPosition.ToString() + "Textbox");
                _txtActiveInput.Focus();
            }
        }

        private int _getTextboxPosition(string sTextboxName)
        {
            return Convert.ToInt32(sTextboxName.Remove(0, 7).Replace("Textbox",""));            
        }

        
    }
}
