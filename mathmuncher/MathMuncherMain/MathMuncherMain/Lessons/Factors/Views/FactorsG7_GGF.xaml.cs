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
using MathMuncherMain.Lessons.Factors.ViewModels;

namespace MathMuncherMain.Lessons.Factors.Views
{
    public partial class FactorsG7_GGF : Page
    {
        public FactorsG7_GGF()
        {
            InitializeComponent();
            this.DataContext = new FactorsG7_GGFViewModel();
            ViewModel.startLesson();
            ViewModel.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(ViewModel_PropertyChanged);
            this.KeyUp += new KeyEventHandler(FactorsG7_GGF_KeyUp);            
        }

        public FactorsG7_GGFViewModel ViewModel
        {
            get
            {
                return (FactorsG7_GGFViewModel)this.DataContext;
            }
        }

        void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ViewState":
                    VisualStateManager.GoToState(this, ViewModel.ViewState, true);
                    break;
                case "Navigate":
                    ((Frame)this.Parent).Navigate(new Uri(ViewModel.Navigate, UriKind.Relative));
                    break;
            }
        }

        private void cmdNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void cmdPrevious_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        void FactorsG7_GGF_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Right)
            {
                ViewModel.NextState();
            }
            else if (e.Key == Key.Left)
            {
                ViewModel.PreviousState();
            }

        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            this.Focus();
        }

        
    }
}
