using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenDiseñoApps_AMGD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Suma_Clicked(object sender, EventArgs e)
        {
            double primerNum = Convert.ToDouble(PrimNum.Text);
            double segundoNum = Convert.ToDouble(SecNum.Text);
            double resultado = primerNum + segundoNum;

            DisplayAlert("Resultado", $"El resultado es: {resultado}", "Ok");
        }

        private void Resta_Clicked(object sender, EventArgs e)
        {
            double primerNum = Convert.ToDouble(PrimNum.Text);
            double segundoNum = Convert.ToDouble(SecNum.Text);
            double resultado = primerNum - segundoNum;

            DisplayAlert("Resultado", $"El resultado es: {resultado}", "Ok");
        }

        private void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            double primerNum = Convert.ToDouble(PrimNum.Text);
            double segundoNum = Convert.ToDouble(SecNum.Text);
            double resultado = primerNum * segundoNum;

            DisplayAlert("Resultado", $"El resultado es: {resultado}", "Ok");
        }

        private void Division_Clicked(object sender, EventArgs e)
        {
            double primerNum = Convert.ToDouble(PrimNum.Text);
            double segundoNum = Convert.ToDouble(SecNum.Text);
            double resultado = primerNum / segundoNum;

            DisplayAlert("Resultado", $"El resultado es: {resultado}", "Ok");
        }
    }
}

