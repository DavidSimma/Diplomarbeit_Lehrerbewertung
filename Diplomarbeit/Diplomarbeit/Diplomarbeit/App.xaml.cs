using Diplomarbeit.login;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Diplomarbeit.models;
using System.Collections.Generic;
using System.Collections;

namespace Diplomarbeit
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
