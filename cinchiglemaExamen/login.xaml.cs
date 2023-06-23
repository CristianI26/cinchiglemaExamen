using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinchiglemaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";
            if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena  )
            {
                Navigation.PushAsync(new registro(usuario)); 
            }

        }
    }
}