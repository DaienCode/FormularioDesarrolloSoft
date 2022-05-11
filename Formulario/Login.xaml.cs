using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formulario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String Usuario = User.Text;
            String Contraseña = Password.Text;

            if (Usuario == "admin" && Contraseña == "admin")
            {
                Navigation.PushAsync(new Dashboard());
            }else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }
        }
    }
}