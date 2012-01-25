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

namespace MathMuncherMain.Lessons.Factors.ViewModels
{
    public class FactorG7_1_Messages
    {
        public string sMainHeading { get; set; }
        public string sMessageIntroduction { get; set; }
        public string sLessonState1Heading { get; set; }
    }

    public class FactorG7_GGF_Messages
    {
        public string sMainHeading { get; set; }
        public string sMessageIntroduction { get; set; }
        public string sLessonState1Heading { get; set; }
    }

    public class PrimeFactor_Messages
    {
        public string sMainHeading { get; set; }
        public string sMessageIntroduction { get; set; }
        public string sLessonState1Heading { get; set; }
        public string sExtraInfo { get; set; }
    }

    public class MessageBundles
    {
        public FactorG7_1_Messages Set_G7_1_Afrikaans()
        {
            FactorG7_1_Messages FactorG7_1_Messages = new FactorG7_1_Messages();
            FactorG7_1_Messages.sMainHeading = "Faktore";
            FactorG7_1_Messages.sMessageIntroduction = "Dit is daardie getalle wat in 'n ander getal kan indeel sonder 'n res!";
            FactorG7_1_Messages.sLessonState1Heading = "Jy moet dus deelsomme hier doen:  bv.";
            return (FactorG7_1_Messages);
        }

        public FactorG7_GGF_Messages Set_G7_GFF_Afrikaans()
        {
            FactorG7_GGF_Messages FactorG7_GGF_Messages = new FactorG7_GGF_Messages();
            FactorG7_GGF_Messages.sMainHeading = "Faktore";
            FactorG7_GGF_Messages.sMessageIntroduction = "Dit is daardie getalle wat in 'n ander getal kan indeel sonder 'n res!";
            FactorG7_GGF_Messages.sLessonState1Heading = "Jy is nou so slim.  Jy kan nou die GGF bepaal.";
            return (FactorG7_GGF_Messages);
        }

        public PrimeFactor_Messages Set_G7_PF_Afrikaans()
        {
            PrimeFactor_Messages PrimeFactor_Messages = new PrimeFactor_Messages();
            //PrimeFactor_Messages.sMainHeading = "Priemfaktore";
            //PrimeFactor_Messages.sMessageIntroduction = "Soek die priemgetalle tussen die lys/versameling faktore";
            //PrimeFactor_Messages.sLessonState1Heading = "Kom ons voltooi eers die ry priemgetalle";
            //PrimeFactor_Messages.sExtraInfo = "- 1 is NOOIT 'n priemgetal nie/n- 2 is die enigste heelgetal wat ook 'n priemgetal is/n- 'n Priemgetal het net 2 faktore; 1, en die getal self/n- 'n Saamgestelde getal is enige getal met meer as 2 faktore";
            return (PrimeFactor_Messages);
        }

    }
}
