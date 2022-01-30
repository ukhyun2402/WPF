﻿using System;
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

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Description is {descriptionTxtBox.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.AssemblyCheckBox.IsChecked = this.WeldCheckBox.IsChecked = this.SawCheckBox.IsChecked = this.RollCheckBox.IsChecked = this.LatheCheckBox.IsChecked = this.DrillCheckBox.IsChecked = this.FoldCheckBox.IsChecked = this.LaserCheckBox.IsChecked = this.LatheCheckBox.IsChecked = this.PlasmaCheckBox.IsChecked = this.PurchaseCheckBox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content + " ";
        }
    }
}
