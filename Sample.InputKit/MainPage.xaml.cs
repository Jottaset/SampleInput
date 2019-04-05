using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample.InputKit
{
    public partial class MainPage : ContentPage
    {
        async void Handle_Clicked(object sender, EventArgs e)
        {
            string opcaoSexo = string.Empty, opcaoCor = string.Empty;

;            if (Masc.IsChecked){
                opcaoSexo = "menino";
            }else if(Fem.IsChecked){
                opcaoSexo = "menina";
            }

            if (Cor1.IsChecked){
                opcaoCor = "pardo";
            }
            else if (Cor2.IsChecked){
                opcaoCor = "negro";
            }

            await DisplayAlert("App", "Sexo: " + opcaoSexo + "\nCor: " + opcaoCor, "Ok");


        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
