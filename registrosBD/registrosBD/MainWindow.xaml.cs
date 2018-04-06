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

namespace registrosBD
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


        private void ingRut_MouseLeave(object sender, MouseEventArgs e)
        {
            String[] nombreStr = { "julian", "osmery", "octavio", "ximena", "pedro" };
            String[] rutStr = { "240891425", "252502505", "16462210k", "128629963", "173082525" };
            String[] emailStr = { "a@g.com", "b@g.com", "c@g.com", "d@g.com", "e@g.com" };
            int[] edadInt = { 30, 24, 36, 56, 28 };
            String[] domicilioStr = { "asd", "fgh", "jkl", "qwe", "rty" };
            Boolean rutMalo = false;

            for (int i = 0; i < rutStr.Length; i++)
            {
                if (ingRut.Text != " " && ingRut.Text.Equals(rutStr[i]))
                {
                    result.Text = "";
                    result.AppendText(nombreStr[i] + "\n" + rutStr[i] + "\n" + emailStr[i] + "\n" + edadInt[i] + "\n" + domicilioStr[i]);
                    rutMalo = true;
                    
                }
            }
            if (rutMalo == false)
                result.Text = "Ingrese un rut valido";

        }

    }
}
