using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UsersApp
{
	/// <summary>
	/// Логика взаимодействия для WindowBux.xaml
	/// </summary>
	public partial class WindowBux : Window
	{
		public WindowBux()
		{
			InitializeComponent();
		}

		private void Button_Vix_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
