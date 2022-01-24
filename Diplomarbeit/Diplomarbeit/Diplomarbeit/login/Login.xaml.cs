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
        private void createTestingData()
        {
            EmptyForm.Key = "12345";
            EmptyForm.Heading = "Test";
            EmptyForm.addQuestion("Frage - 1");
            EmptyForm.addQuestion("Frage - 2");
            EmptyForm.addQuestion("Frage - 3");
            EmptyForm.addQuestion("Frage - 4");
            EmptyForm.addQuestion("Frage - 5");
            EmptyForm.addQuestion("Frage - 6");
            EmptyForm.addQuestion("Frage - 7");
            EmptyForm.addQuestion("Frage - 8");
            EmptyForm.Annotation = "Sonsiges";
        }
        private bool keyExists=false;
        private async void checkIfKeyExists(string key)
        {
            if(await DBManager.keyExists(key))
            {
                keyExists = true;
            }
            keyExists = false;
        }
        private void submit_Clicked(Object sender, EventArgs e)
        {
            string input = key.Text;

            //checkIfKeyExists(input);

            if(keyExists || input == "12345")
            {
                createTestingData();
                //getDataFromAPI(input);
                Application.Current.MainPage = new NavigationPage(new Formular());
            }
            else{
                wrongKey.IsVisible = true;
            }

        }
        private async void getDataFromAPI(string key)
        {
            API_Request temp = new API_Request();
            temp = await DBManager.getEmptyValuation(key);
            convertData(temp);
        }
        private void convertData(API_Request a)
        {
            EmptyForm.Key = a.ID;
            EmptyForm.Heading = a.Heading;
            EmptyForm.addQuestion(a.q1);
            EmptyForm.addQuestion(a.q2);
            EmptyForm.addQuestion(a.q3);
            EmptyForm.addQuestion(a.q4);
            EmptyForm.addQuestion(a.q5);
            EmptyForm.addQuestion(a.q6);
            EmptyForm.addQuestion(a.q7);
            EmptyForm.addQuestion(a.q8);
            EmptyForm.Annotation = a.Annotation;
        }

    }
}