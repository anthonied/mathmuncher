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
using MathMuncherMain;

namespace Math_Muncher
{
    
    public partial class ExerciseStart : UserControl
    {
        public ExerciseStart()
        {
            InitializeComponent();            
            this.DataContext = new ExerciseStartViewModel();  
        }
                        
        /// <summary>
        /// Gets the viewmodel
        /// </summary>
        public ExerciseStartViewModel ViewModel
        {
            get
            {
                return (ExerciseStartViewModel)this.DataContext;
            }
        }
          
        
        private void Canvas_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            tbHeading1.Visibility = System.Windows.Visibility.Collapsed;
            tbHeading2.Visibility = System.Windows.Visibility.Collapsed;
            tbMessage.Visibility = System.Windows.Visibility.Collapsed;
            VisualStateManager.GoToState(this, "VisualState", true);            
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            ((Frame)this.Parent).Navigate(new Uri(ViewModel.LoadExercise(), UriKind.Relative));
        }       

    }
}
