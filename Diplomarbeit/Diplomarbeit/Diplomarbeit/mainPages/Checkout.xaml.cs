using Diplomarbeit.login;
using Diplomarbeit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diplomarbeit.mainPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Checkout : ContentPage
    {
        public Checkout()
        {
            InitializeComponent();
            getAPIStatus();
            if (api_status)
            {
                status.Text = "Die Daten konnten erfolgreich abgesendet werden!";
            }
            else
            {
                status.Text = "Es gab ein Proplem beim Übertragen der Daten, probieren Sie es bitte erneut!";
            }
        }
        private bool api_status = false;

        private async void getAPIStatus()
        {
            
            if(await DBManager.sendFilledValuation(convertData()))
            {
                api_status = true;
            }
            api_status = false;
            
        }

        private API_Template convertData()
        {
            API_Template temp = new API_Template();
            temp.teacherId = Valuation.Key;
            temp.a1 = Valuation.getAnswers()[0];
            temp.a2 = Valuation.getAnswers()[1];
            temp.a3 = Valuation.getAnswers()[2];
            temp.a4 = Valuation.getAnswers()[3];
            temp.a5 = Valuation.getAnswers()[4];
            temp.a6 = Valuation.getAnswers()[5];
            temp.a7 = Valuation.getAnswers()[6];
            temp.a8 = Valuation.getAnswers()[7];
            temp.anmerkungAnswer = Valuation.Annotation;
            temp.teacherKey = Valuation.TeacherKey;
            return temp;
        }

        private static bool AllowTap = true;
        private static async void ResumeTap()
        {
            await Task.Delay(200);
            AllowTap = true;
        }
        private void backToStart_Clicked(object sender, EventArgs e)
        {
            if (!AllowTap) return; AllowTap = false;
            backToStart.IsEnabled = true;
            ResumeTap();
            Application.Current.MainPage = new Login();
        }
    }
}