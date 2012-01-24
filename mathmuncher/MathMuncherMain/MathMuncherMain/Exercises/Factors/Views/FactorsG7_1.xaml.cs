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
using MathMuncherMain.Exercises.Factors.ViewModels;

namespace MathMuncherMain.Exercises.Factors.Views
{


    public partial class FactorsG7_1 : Page
    {


        public FactorsG7_1()
        {
            InitializeComponent();
            this.DataContext = new FactorsG7_1ViewModel();
            ViewModel.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(ViewModel_PropertyChanged);
        }

        void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SetInputFocus":
                    ((TextBox)this.FindName(ViewModel.SetInputFocus)).Focus();
                    break;
            }
        }

        public FactorsG7_1ViewModel ViewModel
        {
            get
            {
                return (FactorsG7_1ViewModel)this.DataContext;
            }
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            ViewModel.StartExercise();
        }

        private void txtFactor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (((TextBox)sender).Text != "")
                {
                    string[] aInput = ((TextBox)sender).Name.Split("_".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (aInput.Length > 0)
                    {
                        ViewModel.NextAnswer(Convert.ToInt32(aInput[1]));
                    }
                }
            }
        }

        private void txtFactorLast_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (((TextBox)sender).Text != "")
                {                    
                    ViewModel.NextExercise(Convert.ToInt32(((TextBox)sender).Text));
                }
            }
        }

        private void txtFactor_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!((TextBox)sender).IsReadOnly)
            {
                string[] aFactor_Index = ((TextBox)sender).Name.Replace("txtFactor", "").Split("_".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                ViewModel.ResetInputFocus();
            }
        }
    }

    public class TextBox2 : TextBox
    {
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            e.Handled = false;
        }
        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
            e.Handled = false;
        }
    }
}
