using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggersMVVM_LDVP.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_LDVP.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vcategoria : ContentPage
    {
        public Vcategoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}