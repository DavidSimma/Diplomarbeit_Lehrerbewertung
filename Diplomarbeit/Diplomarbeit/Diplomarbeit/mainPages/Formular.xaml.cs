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
    public partial class Formular : ContentPage
    {
        public Formular()
        {
            InitializeComponent();
            displayTexts();
            if(Application.Current.MainPage.Navigation.NavigationStack.Count == 0)
            {
                safeDataInRAMOnce();
                zurueck.IsVisible = false;
            }

        }

        private void displayTexts()
        {
            ueberschrift.Text = EmptyForm.Heading;
            frage.Text = EmptyForm.getQuestions()[Application.Current.MainPage.Navigation.NavigationStack.Count];
        }

        private void displaySliderValue(Slider auswahl, Label text)
        {
            int newSliderValue = (int)Math.Round(auswahl.Value);
            text.Text = newSliderValue.ToString();
        }

        private void auswahl_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            displaySliderValue(auswahl, zaehler);
        }

        private void zurueck_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();

        }

        //damit mehrere Seiten auf einmal geöffnet werden

        private static bool AllowTap = true;
        private static async void ResumeTap()
        {
            await Task.Delay(200);
            AllowTap = true;
        }
        
        private void naechsteFrage_Clicked(object sender, EventArgs e)
        {
            if (!AllowTap) return; AllowTap = false;
            weiter.IsEnabled = true;
            ResumeTap();
            safeDataInRAMDynamic();
            if (Application.Current.MainPage.Navigation.NavigationStack.Count > 7)
            {
                Application.Current.MainPage.Navigation.PushAsync(new Kommentar());
            }
            else if(Application.Current.MainPage.Navigation.NavigationStack.Count < 9)
            {
                Application.Current.MainPage.Navigation.PushAsync(new Formular());
            }
        }

        private void safeDataInRAMDynamic()
        {
            Valuation.addAnswer((int)Math.Round(auswahl.Value));
        }
        private void safeDataInRAMOnce()
        {
            Valuation.Key = EmptyForm.Key;
            Valuation.Heading = EmptyForm.Heading;
        }
    }
}