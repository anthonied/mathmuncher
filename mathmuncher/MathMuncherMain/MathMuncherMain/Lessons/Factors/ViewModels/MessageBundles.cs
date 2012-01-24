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
    }
}
