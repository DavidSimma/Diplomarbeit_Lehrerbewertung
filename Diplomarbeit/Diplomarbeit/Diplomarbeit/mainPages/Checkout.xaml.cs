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
            checkForAPIStatus();
        }

        private async void checkForAPIStatus()
        {
            try
            {
                bool result = await DBManager.sendFilledValuation(convertData());
                
                if (result)
                {
                    status.Text = "Die Daten konnten erfolgreich abgesendet werden!";
                }
                else
                {
                    status.Text = "Es gab ein Proplem beim Übertragen der Daten, probieren Sie es bitte erneut!";
                }
            }
            catch (Exception)
            {
                status.Text = "Es gab ein Proplem beim Übertragen der Daten, probieren Sie es bitte erneut!";
            }
            
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