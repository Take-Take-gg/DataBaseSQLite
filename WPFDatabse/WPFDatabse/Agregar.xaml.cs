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
using WPFDatabse.Clases;
using SQLite;

namespace WPFDatabse
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Agregar : Window
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Contactos contacto = new Contactos()
            {
               
                Nombre = txtNombre.Text,
                Skool = txtEscuela.Text,
                Grupo = txtGrupo.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Regalo = txtRegalo.Text
            };
            using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
            {
                conexion.CreateTable<Contactos>();
                conexion.Insert(contacto);
            }
            Close();
        }
    }
}
