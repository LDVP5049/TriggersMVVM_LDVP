using System;
using TriggersMVVM_LDVP.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_LDVP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vcategoria();
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
