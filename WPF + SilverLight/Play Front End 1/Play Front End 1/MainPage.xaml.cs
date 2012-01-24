using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Text;

using Microsoft.Http;

namespace Play_Front_End_1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            // Required to initialize variables
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ConnectRestServer();
        }

        private void Start_Quiz_Click(object sender, RoutedEventArgs e)
        {
           ConnectRestServer();
        }

        public void ConnectRestServer()
        {
            WebClient wc = new WebClient();

            wc.Headers["accept"] = "application/xml,application/json";
            wc.OpenReadCompleted += new OpenReadCompletedEventHandler(wc_OpenReadCompleted);
            string sServiceAddress = "http://localhost:8080/quiz/start/bob";
            wc.OpenReadAsync(new Uri(sServiceAddress));
        }

        void wc_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            try
            {
                if (e.Result != null)
                {
                    Stream x = e.Result;
                    byte[] baX;
                    byte[] buffer = new byte[16 * 1024];
                    using (MemoryStream ms = new MemoryStream())
                    {
                        int read;
                        while ((read = x.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            ms.Write(buffer, 0, read);
                        }
                        baX = ms.ToArray();
                    }
                    baX = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.UTF8, baX);
                   
                    ////////string jsonString = Encoding.UTF8.GetString(baX, 0, baX.Length);
                    ////////Newtonsoft.Json.Linq.JObject oJson = Newtonsoft.Json.Linq.JObject.Parse(jsonString);
                    ////////JsonSerializer ser = new JsonSerializer();
                    ////////Plus p = (Plus)ser.Deserialize(new Newtonsoft.Json.Linq.JTokenReader(oJson), typeof(Plus));
                    ////////lblDigit1.Content = p.value1;
                    ////////lblDigit2.Content = p.value2;
                    ////////lblOperator.Content = p.operand;
                    ////////lblAnswer.Content = p.result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}