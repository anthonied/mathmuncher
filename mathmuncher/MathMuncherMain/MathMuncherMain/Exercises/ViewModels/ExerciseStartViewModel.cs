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
using Microsoft.Expression.Interactivity.Core;
using Math_Muncher;
using System.ComponentModel;
using MathMuncherMain.Exercises.Multiplication.Tafels.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Collections.Generic;
using MathMuncherMain;

namespace Math_Muncher
{

    public class ExerciseStartViewModel: INotifyPropertyChanged
    {
        private ExerciseMessage ExerciseMessage { get; set; }
        private MessageBundles MessageBundles { get; set; }

        public ExerciseStartViewModel()
        {
            this.ExerciseMessage = new ExerciseMessage();
            this.MessageBundles = new MessageBundles();
            switch (Session.sActiveExercise)
            {
                case "Anthropod":
                    ExerciseMessage = MessageBundles.setAnthropodMessageBunle();
                    break;
                case "Caterpillar":
                    ExerciseMessage = MessageBundles.setCaterpillarMessageBunle();
                    break;
                case "FactorsG7_1":
                    ExerciseMessage = MessageBundles.setFactorsG7_1MessageBundle();
                    break;
                case "FactorsG7_GGF":
                    ExerciseMessage = MessageBundles.setFactorsG7_GGFMessageBundle();
                    break;
            }

            sExerciseMessage = ExerciseMessage.sWelcome;
            sLesson = ExerciseMessage.sLesson;
            sLessonMessage = ExerciseMessage.sActionMessage;
        }


        private string _sExerciseMessage;
        public string sExerciseMessage
        {
            get
            {
                return this._sExerciseMessage;
            }

            set
            {
                if (this._sExerciseMessage != value)
                {
                    this._sExerciseMessage = value;
                    this.RaisePropertyChanged("sExerciseMessage");
                }
            }
        }

        private string _sLesson;
        public string sLesson
        {
            get
            {
                return this._sLesson;
            }

            set
            {
                if (this._sLesson != value)
                {
                    this._sLesson = value;
                    this.RaisePropertyChanged("sLesson");
                }
            }
        }

        private string _sLessonMessage;
        public string sLessonMessage
        {
            get
            {
                return this._sLessonMessage;
            }

            set
            {
                if (this._sLessonMessage != value)
                {
                    this._sLessonMessage = value;
                    this.RaisePropertyChanged("sLessonMessage");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public string LoadExercise()
        {
            return ExerciseMessage.sExerciseURI;
        }
    }
}
