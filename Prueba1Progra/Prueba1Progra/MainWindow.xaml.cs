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

namespace Prueba1Progra
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

       private void Guardar_Click_1(object sender, RoutedEventArgs e)
        {
            int edad = Convert.ToInt32(ingEdad.Text);
            String direccion = ingDomicilio.Text, rut = ingRUT.Text, nombre = ingNombre.Text, DV1 = Convert.ToString(rut[rut.Length-1]);
            String[] rutProvStr = new String[rut.Length];
            int i, x,m=2, suma=0,dV=0;
                      
            for (i = 0,x = 0; i < rut.Length; i++,x++)
            {
               
                if (rut.ElementAt(i) != '.' && rut.ElementAt(i) != '-')
                {
                    rutProvStr[x] = Convert.ToString(rut.ElementAt(i));
                }
                else { x--; }
               
            }
      
            int [] rutProvInt = new int[x];

            i = 0;
            for (int y = (x - 2); y >= 0; y--)
            {
                if (m > 7) { m = 2; }
                rutProvInt[i] = Convert.ToInt32(Convert.ToString(rutProvStr[y])) * m;
                m++;
                suma =suma + rutProvInt[i];
                i++;
            }
            dV = suma % 11;
            dV = 11 - dV;
           if (dV == 10 && DV1.Equals("K") || DV1.Equals("k"))
            {
                textBox.Text = "el Digito verificador es valido";
            }
            else
            {
                if (dV == 11 && Convert.ToInt32(DV1) == 0)
                {
                    textBox.Text = "el Digito verificador es valido";
                }
                else
                {
                    if (dV == Convert.ToInt32(DV1))
                    {
                        textBox.Text = ("el Digito verificador es valido");
                    }
                    else
                    {
                        textBox.Text = "Digito verificador invalido";
                    }
                }
            }

        
               // rutProvInt[y] = Convert.ToInt32(Convert.ToString(rutProvStr[y]));
                //textBox.AppendText(Convert.ToString(rut.Length - 1) + " " + Convert.ToString(dV)+"\n");
            
        }
    }
}
