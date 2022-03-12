using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Diplomarbeit.mainPages;
using Diplomarbeit.models;

namespace Diplomarbeit.login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            

        }
        private async void submit_Clicked(Object sender, EventArgs e)
        {
            string input = key.Text.ToString();
            try
            {
                API_Request temp = await DBManager.getEmptyValuation(input);
                if (temp != null && temp.Heading != "")
                {
                    convertData(temp);
                    Application.Current.MainPage = new NavigationPage(new Formular());
                }
                else{ this.wrongKey.IsVisible = true; }
            }
            catch (Exception){ wrongKey.IsVisible = true; }
        }

        private void convertData(API_Request a)
        {
            EmptyForm.Questions.Clear();
            EmptyForm.Key = a.teacherId;
            EmptyForm.Heading = a.Heading;
            EmptyForm.addQuestion(a.q1);
            EmptyForm.addQuestion(a.q2);
            EmptyForm.addQuestion(a.q3);
            EmptyForm.addQuestion(a.q4);
            EmptyForm.addQuestion(a.q5);
            EmptyForm.addQuestion(a.q6);
            EmptyForm.addQuestion(a.q7);
            EmptyForm.addQuestion(a.q8);
            EmptyForm.Annotation = a.annotion;
        }


    }
}