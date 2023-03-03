using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1Tarea1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnenviar_Clicked(object sender, EventArgs e)
        {
            var datos = new Class1 
            {
                Nombre = txtn1.Text,
                Apellido = txtn2.Text,
                Edad = int.Parse (txtn3.Text),
                Correo= txtn4.Text,
            };
           var secondpage = new PageMostrar ();
            secondpage.BindingContext = datos ;
            Navigation.PushAsync(secondpage);

           
        }
    }
}
