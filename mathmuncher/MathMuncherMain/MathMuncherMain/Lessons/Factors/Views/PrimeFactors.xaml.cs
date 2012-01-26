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
			}
		}
		
		private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Focus();
		}

		void PrimeFactors_KeyUp(object sender, KeyEventArgs e)
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
		
		private void txtFactor_KeyUp(object sender, KeyEventArgs e)
		{
		   
		}
		
	}
}