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
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();
        }

        public registro(string usuario)
        {
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {

        }
    }
}