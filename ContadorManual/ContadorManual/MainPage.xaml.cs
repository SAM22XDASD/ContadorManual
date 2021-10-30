using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ContadorManual.Model;

namespace ContadorManual
{
    public partial class MainPage : ContentPage
    {
        private int _Conteo;
        private Contador _Contador;
        public MainPage()
        {
            InitializeComponent();
            //_Conteo = 0;
            _Contador = new Contador();
            //ConteoLabel.Text = _Contador.Conteo.ToString();
            ConteoLabel.BindingContext = _Contador;

        }

        private void ReiniciarButton_Clicked(object sender, EventArgs e)
        {
            //_Conteo++;
            //ConteoLabel.Text = _Conteo.ToString();

            _Contador.ReiniciarConteo();
            //ConteoLabel.Text = _Contador.Conteo.ToString();

        }

        private void ContarButton_Clicked(object sender, EventArgs e)
        {
            //_Conteo = 0;
            //ConteoLabel.Text = _Conteo.ToString();

            _Contador = new Contador();
            //ConteoLabel.Text = _Contador.Conteo.ToString();

        }
    }


   
}
