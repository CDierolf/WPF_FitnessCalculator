using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FitnessCalculator.Classes
{
    /// <summary>
    /// Model to handle the calculations for calories burned.
    /// </summary>
    public class CaloriesBurnedEquations : BaseEquations
    {
        #region Calculation Constants
        const float MALE_CALORIES_EQUATION_MODIFIER = 55.0969F;
        const float FEMALE_CALORIES_EQUATION_MODIFIER = 20.4022F;
        #endregion

        public double MaleCaloriesBurned()
        {
            return Math.Round((MaleAgeModified() - MaleWeightModified() + MaleHeartRateModified() - MALE_CALORIES_EQUATION_MODIFIER) * TimeModified(), 3);
        }

        public double FemaleCaloriesBurned()
        {
            return Math.Round((FemaleAgeModified() - FemaleWeightModified() + FemaleHeartRateModified() - FEMALE_CALORIES_EQUATION_MODIFIER) * TimeModified(), 3);
        }

    }
}
