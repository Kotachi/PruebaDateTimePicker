using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG1EVA1Julian_Palacios
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, RoutedEventArgs e)
        {
            String nombre=ingresoNom.Text, rut=ingresoRUT.Text, domicilio=ingresoDomi.Text;
            String[] rutProv = new String [rut.Length];
            int edad=Convert.ToInt32(ingresoEdad.Text), resultMulRut=0,suma=0;
            
            for (int i = 0; i < rut.Length; i++) {
                if (rut.ElementAt(i) != '-' && rut.ElementAt(i)!='-')
                {
                    rutProv [i] = Convert.ToString (rut.ElementAt(i));
                }
                
            }
           int [] multRutprov =  new int [rutProv.Length - 1];
            int m = 2,y=0;
            for (int i=7; i>=0;i--)
            {
               
                if (m < 8)
                {
                    multRutprov[y] = Convert.ToInt32(rutProv[i]) * m;
                   }
                else {
                    m = 2;
                        multRutprov[y] = Convert.ToInt32(rutProv[i]) * m;
                    }
                m++;

                resultMulRut = resultMulRut+multRutprov[y];

                y++;
            }
            suma = resultMulRut % 11;
            salidaDatos.Text = Convert.ToString(resultMulRut) +"   "+ Convert.ToString(suma)+"/n";
            suma = 11 - suma;

            salidaDatos.Text = Convert.ToString(resultMulRut)+ "  "+Convert.ToString(suma);

           

        }
    }
}
