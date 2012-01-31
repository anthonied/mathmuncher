using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MathMuncherMain.Lessons.Factors.ViewModels;
using MathMuncherMain.Exercises.Factors.ViewModels;
using MathMuncherMain.Classes;

namespace MathMuncherMain
{
	/// <summary>
	/// Interaction logic for PrimeFactors.xaml
	/// </summary>
	public partial class PrimeFactors : UserControl
	{
		public PrimeFactors()
		{
			this.InitializeComponent();
			this.DataContext = new PrimeFactorsModel();
			ViewModel.startLesson();
			ViewModel.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(ViewModel_PropertyChanged);
			this.KeyUp += new KeyEventHandler(PrimeFactors_KeyUp);

		}

		public PrimeFactorsModel ViewModel
		{
			get
			{
				return (PrimeFactorsModel)this.DataContext;
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

                case "SetInputFocus":
                    ((TextBox)this.FindName(ViewModel.SetInputFocus)).Focus();
                    break;
			}
		}
		
		 
		
		private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Focus();
			ViewModel.ViewState = "BaseState";
		}

		void PrimeFactors_KeyUp(object sender, KeyEventArgs e)
		{

			if ((e.Key == Key.Right) && (ViewModel.ViewState != "LessonState3"))
			{
				ViewModel.NextState();
			}
            else if ((e.Key == Key.Left) && (ViewModel.ViewState != "LessonState3"))
			{
				ViewModel.PreviousState();
			}

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
            if ((e.Key == Key.Enter) || (e.Key == Key.Tab))
            { 

                List<string> lAnswers = new List<string>();

                for (int i = 1; i<=9 ; i++)
                {
                    lAnswers.Add(((TextBox)this.FindName("txtPrimeFactor_" + i.ToString())).Text); 
                }
                
                ViewModel.MarkExercise(lAnswers);

            }
        }


		private void cmdNext_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           
                ViewModel.NextState();
		
		}

		private void cmdPrevious_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			ViewModel.PreviousState();// TODO: Add event handler implementation here.

		}

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            txtPrimeFactor_1.Focus();
        }

        private void Storyboard_Completed2(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                ((TextBox)this.FindName("txtPrimeFactor_" + i.ToString())).Text = "";
            }

            txtPrimeFactor_1.Focus();
        }
		
		
		
	}
}