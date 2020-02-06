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

namespace Hull_Speed__grids_only_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += Key_Pressed;
            Image_boat.MouseDown += MouseDown_Image_boat;
        }

        private void MouseDown_Image_boat(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                MessageBox.Show($"The name of the ship is {Name_textbox.Text}");

            }
        }
        private void Key_Pressed(object sender, KeyEventArgs e)
        {
            Console.WriteLine("YO");
            if (e.Key == Key.L && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                Name_label.FontSize += 2;
                Name_textbox.FontSize += 2;
                Length_label.FontSize += 2;
                Length_input.FontSize += 2;
                Calculate_button.FontSize += 2;
                Hull_speed_label.FontSize += 2;
                Speed_label.FontSize += 2;
                Knots_label.FontSize += 2;
            }
            else if (e.Key == Key.S && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                Name_label.FontSize -= 2;
                Name_textbox.FontSize -= 2;
                Length_label.FontSize -= 2;
                Length_input.FontSize -= 2;
                Calculate_button.FontSize -= 2;
                Hull_speed_label.FontSize -= 2;
                Speed_label.FontSize -= 2;
                Knots_label.FontSize -= 2;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Speed_label.Content = "Hej";
            Speed_label.Content = (1.34 * System.Math.Sqrt(Double.Parse(Length_input.Text))).ToString();
        }
    }
}
