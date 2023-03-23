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
    public partial class BuscaCidadesPorEstado : ContentPage
    {
        public BuscaCidadesPorEstado()
        {
            InitializeComponent();
        }

        private void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}