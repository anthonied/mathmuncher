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

namespace MathMuncherMain.Exercises.Multiplication.Tafels.ViewModels
{

    public class AnthroPodExerciseData
    {
        public List<int> lAnthropodLegs
        {
            get;
            set;
        }
        public int iModifier
        {
            get;
            set;
        }
    }

    public class AnthroPodExerciseResult
    {
        public int iModifier { get; set; }
        public int iCorrect { get; set; }
        public int iSecondsSpend { get; set; }

    }

    public class ServerData : ComplexObject
    {
        private anthropodExerciseResponse _aerData;
        private List<int> _lAnthropodLegs;
        private AnthroPodExerciseData _apedAnthropodData;

        public List<AnthroPodExerciseData> lAnthropodExercises = new List<AnthroPodExerciseData>();
        
        public void GetServerData()
        {          

            anthropodExerciseRequest wsRequest = new anthropodExerciseRequest();
            wsRequest.type = exerciseType.MULTIPLICATION;
            wsRequest.typeSpecified = true;

            BasicHttpBinding bind = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress("http://localhost:8080/mathmuncher/ws/exercise/exercise.wsdl");
            ExercisePortClient wsClient = new ExercisePortClient(bind, endpoint);
            wsClient.anthropodExerciseCompleted += (sender, e) =>
                {                    
                    _aerData = (anthropodExerciseResponse)e.Result;                   

                    for (int iAnthropodIndex = 0; iAnthropodIndex < _aerData.anthropod.Length; iAnthropodIndex++)
                    {
                        _apedAnthropodData = new AnthroPodExerciseData();
                        _lAnthropodLegs = new List<int>();
                        string[] aLegs = _aerData.anthropod[iAnthropodIndex].legs.Replace("[", "").Replace("]", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        for (int _i = 0; _i < aLegs.Length; _i++)
                        {
                            _lAnthropodLegs.Add(Convert.ToInt32(aLegs[_i]));                         
                        }
                        _apedAnthropodData.lAnthropodLegs = _lAnthropodLegs;
                        _apedAnthropodData.iModifier = Convert.ToInt32(_aerData.anthropod[iAnthropodIndex].body);
                        lAnthropodExercises.Add(_apedAnthropodData);
                    }
                    //Nie seker of ek 'n ander async event moet roep
                    this.DataCollected(sender, e);                   
                }
            ;
            wsClient.anthropodExerciseAsync(wsRequest);
        }

        public event EventHandler DataCollected;
    }
}
