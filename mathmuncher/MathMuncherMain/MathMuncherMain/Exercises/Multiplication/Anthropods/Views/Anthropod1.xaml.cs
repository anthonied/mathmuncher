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

using MathMuncherMain.SampleData;
using System.Windows.Media.Imaging;
using MathMuncherMain.Exercise;
using MathMuncherMain.Multiplication.Tafels.ViewModels;

namespace Math_Muncher
{
    
    public partial class Anthropod1 : UserControl
    {
        public Anthropod1()
        {
            InitializeComponent();
            this.DataContext = new Anthropod1ViewModel();        
            ViewModel.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(ViewModel_PropertyChanged);
            ViewModel.StartExercise();                
        }

        void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ViewState")
            {
               VisualStateManager.GoToState(this, ViewModel.ViewState, true);
            }
            else if (e.PropertyName == "SetInputFocus")
            {
                txtInput.Focus();              
            }
            else if (e.PropertyName == "SetEnterActive")
            {
                this.Focus();
                this.KeyUp += new KeyEventHandler(Root_Enter);
            }
            else if (e.PropertyName == "DisableEnterActive")
            {
                this.KeyUp -= Root_Enter;
            }
        }

        private void Root_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ViewModel.NextExercise();
            }
        }
        
        /// <summary>
        /// Gets the viewmodel
        /// </summary>
        public Anthropod1ViewModel ViewModel
        {
            get
            {
                return (Anthropod1ViewModel)this.DataContext;
            }
        }          
     
        private void txtExerciseInput_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ViewModel.InputExcepted(txtInput.Text);
            }
        }
        
        private void cmdNext_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ViewModel.NextExercise();
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            txtInput.Focus();
        }
    }
}
