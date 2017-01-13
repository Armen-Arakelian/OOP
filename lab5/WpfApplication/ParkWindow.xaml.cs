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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfApplication
{
    public partial class ParkWindow : Window
    {
        public List<God> data = new List<God>();
        public God tempGod = new God();
        public ParkWindow()
        {
            God g1 = new God("Zevs", 342343467);
            God g2 = new God("Venera", 53453453);
            God g3 = new God("Upiter", 879798798);
            God g4 = new God("Aid", 353453);
            God g5 = new God("Appolon", 2342342);

            Olymp olymp = new Olymp(5);

            MyXmlSerializer XMLSer = new MyXmlSerializer();
            olymp = XMLSer.xmlDeserialize();
            data = olymp.gods;

            InitializeComponent();

             dgGods.IsReadOnly = true;

            labelH.Visibility = Visibility.Hidden;
            labelK.Visibility = Visibility.Hidden;
            textH.Visibility = Visibility.Hidden;
            textK.Visibility = Visibility.Hidden;
            button_save.Visibility = Visibility.Hidden;
            button_save_edit.Visibility = Visibility.Hidden;

            dgGods.ItemsSource = data;
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            labelH.Visibility = Visibility.Visible;
            labelK.Visibility = Visibility.Visible;
            textH.Visibility = Visibility.Visible;
            textK.Visibility = Visibility.Visible;
            button_save.Visibility = Visibility.Visible;
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            int ancientAge;
            if (!Int32.TryParse(textH.Text, out ancientAge))
            {
                MessageBox.Show("Ancient age cannot be not a number");
                return;
            }
            if (textK.Text.Where(x => Char.IsDigit(x)).Any())
            {
                MessageBox.Show("Name can`t contain any numbers");
                return;
            }
            data.Add(new God() { ancientAge = Convert.ToInt32(textH.Text), name = textK.Text });
            labelH.Visibility = Visibility.Hidden;
            labelK.Visibility = Visibility.Hidden;
            textH.Visibility = Visibility.Hidden;
            textK.Visibility = Visibility.Hidden;
            button_save.Visibility = Visibility.Hidden;
            dgGods.ItemsSource = null;
            dgGods.ItemsSource = data;
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            var selectedIndex = dgGods.SelectedIndex;
            if (selectedIndex >= 0)
            {
                God god = dgGods.SelectedItem as God;
                data.Remove(god);
            }
            dgGods.ItemsSource = null;
            dgGods.ItemsSource = data;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            labelH.Visibility = Visibility.Visible;
            labelK.Visibility = Visibility.Visible;
            textH.Visibility = Visibility.Visible;
            textK.Visibility = Visibility.Visible;
            button_save_edit.Visibility = Visibility.Visible;

            var selectedIndex = dgGods.SelectedIndex;
            if (selectedIndex >= 0)
            {
                God god = dgGods.SelectedItem as God;
                textH.Text = god.ancientAge.ToString();
                textK.Text = god.name;
                tempGod = god;
            }
        }

        private void button_save_edit_Click(object sender, EventArgs e)
        {
            int ancientAge;
            if (!Int32.TryParse(textH.Text, out ancientAge))
            {
                MessageBox.Show("Ancient age cannot be not a number");
                return;
            }
            if (textK.Text.Where(x => Char.IsDigit(x)).Any())
            {
                MessageBox.Show("Name can`t contain any numbers");
                return;
            }
            data.Find(x => x.ancientAge == tempGod.ancientAge).ancientAge = Convert.ToInt32(textH.Text);
            data.Find(x => x.name == tempGod.name).name = textK.Text;
            labelH.Visibility = Visibility.Hidden;
            labelK.Visibility = Visibility.Hidden;
            textH.Visibility = Visibility.Hidden;
            textK.Visibility = Visibility.Hidden;
            button_save_edit.Visibility = Visibility.Hidden;

            dgGods.ItemsSource = null;
            dgGods.ItemsSource = data;
        }

        void Window_Closing(object sender, CancelEventArgs e)
        {
            Olymp olymp = new Olymp();
            foreach (var item in data)
                olymp.addGod(new God());

            MyXmlSerializer serialisator = new MyXmlSerializer();
            serialisator.xmlSerialize(olymp);
        }
    }
}
