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

namespace MathMuncherMain.Classes
{
    public static class Calculations
    {
        ///Kry die Grootste Gemene Faktor
        ///
        public static int GetBigestSharedFactor(List<int> lFactorSet1, List<int> lFactorSet2)
        {
            for (int iFactor2Index = lFactorSet2.Count - 1; iFactor2Index >= 0; iFactor2Index--)
            {
                for (int iFactor1Index = lFactorSet1.Count - 1; iFactor1Index >= 0; iFactor1Index--)
                {
                    if (lFactorSet2[iFactor2Index] == lFactorSet1[iFactor1Index])
                    {
                        return lFactorSet2[iFactor2Index];
                    }
                }
            }
            return -1;
        }
    }
}
