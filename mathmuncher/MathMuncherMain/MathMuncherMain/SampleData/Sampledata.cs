using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace MathMuncherMain.SampleData
{
    public class anthropodExerciseData
    {
        public List<int> lMultipliers = new List<int>();
        public int iModifier { get; set; } 
    }
    
    public class Sampledata
    {
        private Random _r = new Random();

        /// <summary>
        /// This function create random source data for the anthropod mulitplier exercise. 
        /// </summary>
        /// <returns>List of mulipliers and a modifier</returns>
        /// <author>AJ De Klerk</author>
        /// <date>28 July 2011</date>
        public anthropodExerciseData populateAnthropodExerciseData()
        { 

            anthropodExerciseData aedSample = new anthropodExerciseData();
            aedSample.lMultipliers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                aedSample.lMultipliers.Add(_r.Next(2,12));
            }

            aedSample.iModifier = _r.Next(4,12);
            return (aedSample);
        }
    }

    
}
