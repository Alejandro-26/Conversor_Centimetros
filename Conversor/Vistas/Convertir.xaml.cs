using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;
        public Convertir()
        {
            InitializeComponent();
        }
        private void calcula()
        {
            cm = Convert.ToDouble(txtCentimetros.Text);
            m = cm / 100;
            lblResultado.Text = m.ToString() + " m";
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(txtCentimetros.Text))
            {
                calcula();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad > 0", "Cancelar");
            }
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}