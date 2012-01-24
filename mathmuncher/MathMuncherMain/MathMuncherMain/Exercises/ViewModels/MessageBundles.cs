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
using System.ComponentModel;
using System.ServiceModel;
using MathMuncherMain.Exercise;
using System.ServiceModel.DomainServices.Client;
using System.Collections.Generic;
using MathMuncherMain;

namespace Math_Muncher
{    
    public class ExerciseMessage
    {
        public string sWelcome {get;set;}
        public string sLesson {get;set;}

        public string sActionMessage {get;set;}
        public string sExerciseURI;
    }

    public class MessageBundles
    {
        public ExerciseMessage setAnthropodMessageBunle()
        {
            ExerciseMessage emAnthropod = new ExerciseMessage();
            emAnthropod.sWelcome = @"Hallo " + Session.sUser + @".   Dit is baie nodig dat jy jou tafels BAIE goed moet ken voor jy verder met veelvoude kan werk.";
            emAnthropod.sLesson = @"Veelvoude - Les 1";
            emAnthropod.sActionMessage = "Wanneer  jy gereed is, druk op die \"begin\" knoppie hieronder.";
            emAnthropod.sExerciseURI =  "/Exercises/Multiplication/Anthropods/Views/Anthropod1";
            return emAnthropod;
        }

        public ExerciseMessage setCaterpillarMessageBunle()
        {
            ExerciseMessage emAnthropod = new ExerciseMessage();
            emAnthropod.sWelcome = Session.sUser + @", jou tafels is nou klaar.  Nou moet jy na hierdie wurm kyk";
            emAnthropod.sLesson = @"Veelvoude - Les 2";
            emAnthropod.sActionMessage = "Wanneer  jy gereed is, druk op die \"begin\" knoppie hieronder.";
            emAnthropod.sExerciseURI = "/Exercises/Multiplication/Caterpillar/Views/CaterpillarView";
            return emAnthropod;
        }     
        public ExerciseMessage setFactorsG7_1MessageBundle()
        {
            ExerciseMessage emAnthropod = new ExerciseMessage();
            emAnthropod.sWelcome = Session.sUser + @", nou is jy gereed vir 'n Wikkel en Werk.";
            emAnthropod.sLesson = @"Faktore - Les 1";
            emAnthropod.sActionMessage = "Onthou die Faktore van 'n getal is 'n Eindige versameling - Jy kan dus die versameling sluit met { } hakkies.";
            emAnthropod.sExerciseURI = "/Exercises/Factors/Views/FactorsG7_1";
            return emAnthropod;
        }

        public ExerciseMessage setFactorsG7_GGFMessageBundle()
        {
            ExerciseMessage emAnthropod = new ExerciseMessage();
            emAnthropod.sWelcome = Session.sUser + @", kom ons kyk of jy nou 'n paar GGF somme kan regkry?";
            emAnthropod.sLesson = @"Faktore - Les 2";
            emAnthropod.sActionMessage = "Die GGF is die grootste getal wat in die getalle kan indeel.";
            emAnthropod.sExerciseURI = "/Exercises/Factors/Views/FactorsG7_GGF";
            return emAnthropod;
        }
    }
}
