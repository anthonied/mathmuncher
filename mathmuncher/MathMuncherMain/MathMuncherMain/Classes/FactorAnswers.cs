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
    public class FactorAnswers
    {
        public List<int> lFactorAnswer4
        {
            get;
            set;
        }
        public List<int> lFactorAnswer8
        {
            get;
            set;
        }
        public List<int> lFactorAnswer10
        {
            get;
            set;
        }
        public List<int> lFactorAnswer16
        {
            get;
            set;
        }
        public List<int> lFactorAnswer18
        {
            get;
            set;
        }
        public List<int> lFactorAnswer24
        {
            get;
            set;
        }
        public List<int> lFactorAnswer30
        {
            get;
            set;
        }
        public List<int> lFactorAnswer40
        {
            get;
            set;
        }
        public List<int> lFactorAnswer56
        {
            get;
            set;
        }
        public List<int> lFactorAnswer64
        {
            get;
            set;
        }
        public List<int> lFactorAnswer75
        {
            get;
            set;
        }
        public List<int> lFactorAnswer81
        {
            get;
            set;
        }
        public List<int> lFactorAnswer100
        {
            get;
            set;
        }
        public List<int> lFactorAnswer144
        {
            get;
            set;
        }



        public FactorAnswers()
        {
            lFactorAnswer4 = new List<int>(new int[] { 1, 2, 4 }); //Factors of  4
            lFactorAnswer8 = new List<int>(new int[] { 1, 2, 4, 8 });//Factors of  8
            lFactorAnswer10 = new List<int>(new int[] { 1, 2, 5, 10 });  //Factors of 10
            lFactorAnswer16 = new List<int>(new int[] { 1, 2, 4, 8, 16 });  //Factors of 16
            lFactorAnswer18 = new List<int>(new int[] { 1, 2, 3, 6, 9, 18 });  //Factors of 18
            lFactorAnswer24 = new List<int>(new int[] { 1, 2, 3, 4, 6, 8, 12, 24 });  //Factors of 24
            lFactorAnswer30 = new List<int>(new int[] { 1, 2, 3, 5, 6, 10, 15, 30 });  //Factors of 30
            lFactorAnswer40 = new List<int>(new int[] { 1, 2, 4, 5, 8, 10, 20, 40 });  //Factors of 40
            lFactorAnswer56 = new List<int>(new int[] { 1, 2, 4, 7, 8, 14, 28, 56 });  //Factors of 56
            lFactorAnswer64 = new List<int>(new int[] { 1, 2, 4, 8, 16, 32, 64 });  //Factors of 64
            lFactorAnswer75 = new List<int>(new int[] { 1, 3, 5, 15, 25, 75 });  //Factors of 75     
            lFactorAnswer81 = new List<int>(new int[] { 1, 3, 9, 27, 81 });  //Factors of 81
            lFactorAnswer100 = new List<int>(new int[] { 1, 2, 4, 5, 10, 20, 25, 50, 100 });  //Factors of  100
            lFactorAnswer144 = new List<int>(new int[] { 1, 2, 4, 6, 8, 9, 12, 16, 18, 24, 36, 72, 144 }); //Factors of  144
        }
  }
}
