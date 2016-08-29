using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Tut_Proj_1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            textBox.TextChanging += textBox_TextChanging;
            button.Click += button_Click;
        }

        public void textBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if (sender.Text.Contains("bold"))
            {
                sender.FontWeight = Windows.UI.Text.FontWeights.Bold;
            }

            if (sender.Text.Equals("softtama"))
            {
                passwordBox.IsEnabled = true;
                sender.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                passwordBox.IsEnabled = false;
            }
        }

        public void button_Click(object sender, RoutedEventArgs args)
        {
            if (!textBox.Text.Equals(""))
            {
                string username = textBox.Text,
                       rememberMe = (bool) checkBox.IsChecked ? "Yes" : "No";

                textBlock.Text = "Username: " + username + "\n\n" + "Remember me?: " + rememberMe;
            }
        }
    }
}
