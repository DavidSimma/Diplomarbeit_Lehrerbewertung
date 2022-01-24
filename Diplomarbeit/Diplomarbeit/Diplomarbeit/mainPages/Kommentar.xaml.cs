using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Diplomarbeit.models;

namespace Diplomarbeit.mainPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kommentar : ContentPage
    {
        public Kommentar()
        {
            InitializeComponent();
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
        private void weiter_Clicked(object sender, EventArgs e)
        {
            if (!AllowTap) return; AllowTap = false;
            weiter.IsEnabled = true;
            ResumeTap();


            safeAnnotationInRAM();
            Application.Current.MainPage.Navigation.PushAsync(new TeacherKey());

        }
        
        private void safeAnnotationInRAM()
        {
            Valuation.Annotation = anmerkung.Text;
        }

        private void anmerkung_TextChanged(object sender, TextChangedEventArgs e)
        {
            string temp = anmerkung.Text;
            int maxCharacters = 256;
            if(anmerkung.Text.Length > maxCharacters)
            {
                temp = temp.Remove(temp.Length - 1);
                anmerkung.Text = temp;
            }
        }
    }
}