using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCep.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaLogradouroPorBairrosAndCidade : ContentPage
    {
        public BuscaLogradouroPorBairrosAndCidade()
        {
            InitializeComponent();
        }

        private void pck_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}