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
    public partial class FactorsG7_1 : Page
    {
        public FactorsG7_1()
        {
            InitializeComponent();
            this.DataContext = new FactorsG7_1ViewModel();
            ViewModel.startLesson();
            ViewModel.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(ViewModel_PropertyChanged);
            this.KeyUp += new KeyEventHandler(FactorsG7_1_KeyUp);                       
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

        void FactorsG7_1_KeyUp(object sender, KeyEventArgs e)
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

        /// <summary>
        /// Gets the viewmodel
        /// </summary>
        public FactorsG7_1ViewModel ViewModel
        {
            get
            {
                return (FactorsG7_1ViewModel)this.DataContext;
            }
        }

        private void cmdNext_Copy_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ViewModel.NextState();
        }
        private void cmdPrevious_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ViewModel.PreviousState();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            this.Focus();
        }

    }
}
