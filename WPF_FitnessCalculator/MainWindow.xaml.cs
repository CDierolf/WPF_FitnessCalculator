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
using WPF_FitnessCalculator.Classes;

namespace WPF_FitnessCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseEquations be = new BaseEquations();
        CaloriesBurnedEquations cbe = new CaloriesBurnedEquations();
        public MainWindow()
        {
            InitializeComponent();
            btnSubmit.Click += btnSubmit_Click;
            txtBoxAge.LostFocus += txtBoxAge_LostFocus;
        }

        private void txtBoxAge_LostFocus(object sender, RoutedEventArgs e)
        {
            int age;
            Int32.TryParse(txtBoxAge.Text, out age);
            be.Age = age;
            cbe.Age = age;
            lblMaximumHeartRate.Content = be.MaxHeartRate();
            lblTargetHeartRate.Content = String.Format("{0} - {1}", be.TargetHeartRateLower(), be.TargetHeartRateUpper());
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int weight, heartRate, time;
            Int32.TryParse(txtBoxWeight.Text, out weight);
            Int32.TryParse(txtBoxHeartRate.Text, out heartRate);
            Int32.TryParse(txtBoxTime.Text, out time);

            cbe.Weight = weight;
            cbe.Time = time;
            cbe.HeartRate = heartRate;

            if (cboGender.Text == "Male") 
            {
                lblCaloriesBurned.Content =  String.Format("{0} Calories Burned",cbe.MaleCaloriesBurned());
            }
            else if (cboGender.Text == "Female")
            {
                lblCaloriesBurned.Content =  String.Format("{0} Calories Burned", cbe.FemaleCaloriesBurned());
            }
        }
    }
}
