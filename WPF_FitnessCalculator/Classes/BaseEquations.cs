using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_FitnessCalculator.Classes
{
    /// <summary>
    /// Model for the baseline equations needed to calculate the calories burned.
    /// Inherits the Person Properties.
    /// </summary>
    public class BaseEquations : Person
    {
        #region Calculation Constants
        const int MAX_HEART_RATE_MODIFIER = 220;
        const float MALE_AGE_MODIFIER = 0.2017F;
        const float FEMALE_AGE_MODIFIER = 0.074F;
        const float MALE_WEIGHT_MODIFIER = 0.09036F;
        const float FEMALE_WEIGHT_MODIFIER = 0.05741F;
        const float MALE_HEART_RATE_MODIFIER = 0.6309F;
        const float FEMALE_HEART_RATE_MODIFIER = 0.4472F;
        const float COMMON_TIME_MODIFIER = 4.184F;
        #endregion
        
        #region Gender Common Calculations
        public int MaxHeartRate()
        {
            return MAX_HEART_RATE_MODIFIER - Age;
        }
        public int TargetHeartRateUpper()
        {
            return Convert.ToInt32(MaxHeartRate() * .85);
        }

        public int TargetHeartRateLower()
        {
            return Convert.ToInt32(MaxHeartRate() * .5);
        }

        public double TimeModified()
        {
            return Time / COMMON_TIME_MODIFIER;
        }
        #endregion


        #region Male Baseline Calculations
        protected double MaleAgeModified()
        {
            return Age * MALE_AGE_MODIFIER;
        }

        protected double MaleWeightModified()
        {
            return Weight * MALE_WEIGHT_MODIFIER;
        }

        protected double MaleHeartRateModified()
        {
            return HeartRate * MALE_HEART_RATE_MODIFIER;
        }
        #endregion

        #region Female Baseline Calculations
        protected double FemaleAgeModified()
        {
            return Age * FEMALE_AGE_MODIFIER;
        }

        protected double FemaleWeightModified()
        {
            return Weight * FEMALE_WEIGHT_MODIFIER;
        }

        protected double FemaleHeartRateModified()
        {
            return HeartRate * FEMALE_HEART_RATE_MODIFIER;
        }
        #endregion
    }
}
