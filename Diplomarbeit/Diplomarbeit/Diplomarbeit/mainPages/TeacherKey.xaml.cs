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
    public partial class TeacherKey : ContentPage
    {
        public TeacherKey()
        {
            InitializeComponent();
            displayText();
        }

        private void displayText()
        {
            ueberschrift.Text = EmptyForm.Heading;
        }

        private void teacherKey_TextChanged(object sender, TextChangedEventArgs e)
        {
            string temp = teacherKey.Text;
            int maxCharacters = 10;
            if (teacherKey.Text.Length > maxCharacters)
            {
                temp = temp.Remove(temp.Length - 1);
                teacherKey.Text = temp;
            }
        }


        private void zurueck_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        private static bool AllowTap = true;
        private static async void ResumeTap()
        {
            await Task.Delay(200);
            AllowTap = true;
        }
        private async void absenden_Clicked(object sender, EventArgs e)
        {
            if (!AllowTap) return; AllowTap = false;
            absenden.IsEnabled = true;
            ResumeTap();
            try
            {
                bool temp = await DBManager.feedbackExists(Valuation.Key, teacherKey.Text);
                if (temp)
                {
                    safeTeacherKeyInRAM();
                    Application.Current.MainPage = new Checkout();
                }
                else
                {
                    wrongKey.IsVisible = true;
                }
            }
            catch(Exception)
            {
                wrongKey.IsVisible = true;
            }
        }


        private void safeTeacherKeyInRAM()
        {
            Valuation.TeacherKey = teacherKey.Text;
        }
    }
}