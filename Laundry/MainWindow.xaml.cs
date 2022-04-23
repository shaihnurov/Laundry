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

namespace Laundry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator controller;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            controller = new Calculator();
        }

        /// <summary>
        /// загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Calculator controller = new Calculator();
            cb1.ItemsSource = controller.Calculations;
            cb2.ItemsSource = controller.Calculations;
            cb3.ItemsSource = controller.Calculations;
            cb4.ItemsSource = controller.Calculations;
            cb5.ItemsSource = controller.Calculations;
            cb6.ItemsSource = controller.Calculations;
            cb7.ItemsSource = controller.Calculations;
            cb8.ItemsSource = controller.Calculations;
            cb9.ItemsSource = controller.Calculations;
            cb10.ItemsSource = controller.Calculations;
            tb1.Text = "1";
            tb2.Text = "1";
            tb3.Text = "1";
            tb4.Text = "1";
            tb5.Text = "1";
            tb6.Text = "1";
            tb7.Text = "1";
            tb8.Text = "1";
            tb9.Text = "1";
            tb10.Text = "1";
        }

        private void formgo_Click(object sender, RoutedEventArgs e)
        {
            if (cb1.SelectedIndex < 0 || cb1.SelectedIndex > cb1.Items.Count)
            {
                MessageBox.Show("Неверные  параметры ");
                return;
            }

            try
            {
                var valueUnder = Convert.ToDouble(tb1.Text);
                var valueUnder2 = Convert.ToDouble(tb2.Text);
                var valueUnder3 = Convert.ToDouble(tb3.Text);
                var valueUnder4 = Convert.ToDouble(tb4.Text);
                var valueUnder5 = Convert.ToDouble(tb5.Text);
                var valueUnder6 = Convert.ToDouble(tb6.Text);
                var valueUnder7 = Convert.ToDouble(tb7.Text);
                var valueUnder8 = Convert.ToDouble(tb8.Text);
                var valueUnder9 = Convert.ToDouble(tb9.Text);
                var valueUnder10 = Convert.ToDouble(tb10.Text);

                string inUnderwear = (string)cb1.SelectedItem;
                string inUnderwear2 = (string)cb2.SelectedItem;
                string inUnderwear3 = (string)cb3.SelectedItem;
                string inUnderwear4 = (string)cb4.SelectedItem;
                string inUnderwear5 = (string)cb5.SelectedItem;
                string inUnderwear6 = (string)cb6.SelectedItem;
                string inUnderwear7 = (string)cb7.SelectedItem;
                string inUnderwear8 = (string)cb8.SelectedItem;
                string inUnderwear9 = (string)cb9.SelectedItem;
                string inUnderwear10 = (string)cb10.SelectedItem;

                double r1 = controller.Calc(valueUnder, inUnderwear);
                double r2 = controller.Calc(valueUnder2, inUnderwear2);
                double r3 = controller.Calc(valueUnder3, inUnderwear3);
                double r4 = controller.Calc(valueUnder4, inUnderwear4);
                double r5 = controller.Calc(valueUnder5, inUnderwear5);
                double r6 = controller.Calc(valueUnder6, inUnderwear6);
                double r7 = controller.Calc(valueUnder7, inUnderwear7);
                double r8 = controller.Calc(valueUnder8, inUnderwear8);
                double r9 = controller.Calc(valueUnder9, inUnderwear9);
                double r10 = controller.Calc(valueUnder10, inUnderwear10);

                double rob = r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10;
                double kg = r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10;

                otvet.Content = $"Вес стирки: {r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10} грамм " +
                    $"({kg / 1000} кг)" +
                    $"\nПорошка: {rob / 40} грамм " + $"({rob / 40 / 1000} кг)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}