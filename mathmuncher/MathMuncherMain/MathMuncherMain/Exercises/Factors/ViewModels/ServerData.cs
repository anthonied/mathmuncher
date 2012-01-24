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

namespace MathMuncherMain.Exercises.Factors.ViewModels
{
   
    public class ServerData_G7_1
    {
        //public List<string> lFactorsNumbers_G7_1 = new List<string>(new string[] { "10", "16", "18","24","30","40","81","75","56","100","64","144"});
        public List<string> lFactorsNumbers_G7_1 = new List<string>(new string[] { "10", "16"});      
    }

    public class ServerData_G7_GGF
    {
        public List<List<string>> lFactorsGGF = new List<List<string>>();

        public void GetServerData_GFF()
        {
            lFactorsGGF.Add(new List<string>(new string [] { "4", "8" }));
            lFactorsGGF.Add(new List<string>(new string[] { "24", "30" }));
         //   lFactorsGGF.Add(new List<string>(new string[] { "20", "40" }));


        }
    }
}
