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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace UsersApp
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
	

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Vix_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
		private void Vxod_Click(object sender, RoutedEventArgs e)
		{
			SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\Dementev\UsersApp\bd.mdf;Integrated Security=True");
			string qwery = "Select * from [dbo].[Table] where [login] = '" + login.Text.Trim() + "' and [password] = '" + password.Password + "'";
			SqlDataAdapter sda = new SqlDataAdapter(qwery, sqlcon);
			DataTable dtbl = new DataTable();
			sda.Fill(dtbl);
			if (dtbl.Rows.Count == 1)
			{
				WindowAdmin windowAdmin = new WindowAdmin();
				windowAdmin.Show();
				Hide();
			}
			else
			{
				MessageBox.Show("Неверный логин или пароль");
			}
		}
	}
}
