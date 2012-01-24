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
using MathMuncherMain.Exercises.Multiplication.Caterpillar.ViewModels;

namespace MathMuncherMain.Exercises.Multiplication.Caterpillar.Views
{
    public partial class CaterpillarView : Page
    {
        
        public CaterpillarView()
        {
            InitializeComponent();
            this.DataContext = new CaterpillarViewModel();
            ViewModel.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(ViewModel_PropertyChanged);
            ViewModel.startExercise();
        }

        void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SetInputFocus":
                    ((TextBox)this.FindName(ViewModel.SetInputFocus)).Focus();
                    break;
                case "ViewState":
                    VisualStateManager.GoToState(this, ViewModel.ViewState, true);
                    break;
                case "SetEnterActive":
                    this.Focus();
                    this.KeyUp += new KeyEventHandler(Root_Enter);
                    break;
                case "DisableEnterActive":
                    this.KeyUp -= Root_Enter;
                    break;
            }
        }

        public CaterpillarViewModel ViewModel
        {
            get
            {
                return (CaterpillarViewModel)this.DataContext;
            }
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            ViewModel.SetActiveFocus();
        }

        private void atxtSircle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {                   
                if (((TextBox)sender).Text != "")
                {
                    try
                    {
                        int iValue = Convert.ToInt32(((TextBox)sender).Text);
                        ViewModel.NextNode(iValue);
                    }
                    catch
                    {

                    }                    
                }
            }            
        }

        private void Root_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ViewModel.NextExercise();
            }
        }
        
    }
}
