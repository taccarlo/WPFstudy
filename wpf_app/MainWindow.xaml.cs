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

namespace wpf_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.PeopleService personService = null;

        public MainWindow()
        {
            InitializeComponent();
            personService = new Models.PeopleService();
            cmbPeople.ItemsSource = personService.People;
            cmbPeople.DisplayMemberPath = "Surname";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonOutputFun();
        }
        private void ButtonOutputFun()
        {
            if (cmbPeople.SelectedItem != null)
            {
                Models.Person person = (Models.Person)cmbPeople.SelectedItem;

                txtOutput.Text = $"Hello {person.Name} {person.Surname}!";
            }
        }
    }
}
