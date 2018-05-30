using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FitnessCalculator.Classes
{
    /// <summary>
    /// Model of the person object.
    /// </summary>

    #region Person Class
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
            
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int time;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        private int heartRate;

        public int HeartRate
        {
            get { return heartRate; }
            set { heartRate = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

    }
    #endregion
}
