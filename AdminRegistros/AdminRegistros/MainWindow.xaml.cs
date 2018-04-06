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



namespace AdminRegistros
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

        Persona persona1 = new Persona();

        private void guardar_Click(object sender, RoutedEventArgs e)
        {
           
            persona1.setNombre(ingNombre.Text);
            persona1.setRut(ingRut.Text);
            persona1.setEdad(ingEdad.Text);
            persona1.setDomicilio(ingDomicilio.Text);
            persona1.setApellido(ingApellido.Text);

        }

        private void mostrar_Click(object sender, RoutedEventArgs e)
        {
            result.Text = persona1.getNombre() + "\n"+persona1.getRut();
        }
    }

}
