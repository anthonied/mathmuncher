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
using System.ServiceModel.DomainServices.Client;
using System.Collections.Generic;

namespace MathMuncherMain.Exercises.Multiplication.Caterpillar.ViewModels
{

    public class CaterpillarData
    {
        public int iStartingValue { get; set; }
        public int iModifier1 { get; set; }
        public int iModifier2 { get; set; }
        public int iModifier3 { get; set; }
        public int iModifier4 { get; set; }
        public int iModifier5 { get; set; }
    }
    public class ServerData : ComplexObject
    {
        public List<CaterpillarData> lCaterpillerData = new List<CaterpillarData>();
        public List<string> lCaterpillarPrefix = new List<string>(new string[] { "a","a","a"});

        public void GetServerData()
        {
            for (int iCaterpillar = 0; iCaterpillar < lCaterpillarPrefix.Count; iCaterpillar++)
            {                
                Random r = new Random();
                CaterpillarData cpData = new CaterpillarData();
                cpData.iStartingValue = r.Next(2, 4);
                cpData.iModifier1 = r.Next(1, 5);
                cpData.iModifier2 = r.Next(1, 5);
                cpData.iModifier3 = r.Next(1, 5);
                cpData.iModifier4 = r.Next(0, 3);
                cpData.iModifier5 = r.Next(0, 2);
                lCaterpillerData.Add(cpData);
            }
           // this.DataCollected(null, null);
        }

        public event EventHandler DataCollected;
    }
}
