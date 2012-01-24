using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace State_Transitions_2
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void onAdd(object sender, System.Windows.RoutedEventArgs e)
		{
			List.Items.Insert(0,"New Item" + List.Items.Count.ToString());
		}

		private void onRemover(object sender, System.Windows.RoutedEventArgs e)
		{
			if(List.Items.Count > 0)
			{
				List.Items.RemoveAt(0);
			}
		}

		
	}
}