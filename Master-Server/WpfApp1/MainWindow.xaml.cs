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

namespace MasterServer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variablen

        //Bildschirmgröße
        private double Bildschirm_Breite = 800;
        private double Bildschirm_Hohe = 600;

        //Variablen ENDE


        public MainWindow()
        {
            InitializeComponent();

            //Bildschirmgröße ermitteln:
            Bildschirm_Breite = System.Windows.SystemParameters.PrimaryScreenWidth;
            Bildschirm_Hohe = System.Windows.SystemParameters.PrimaryScreenHeight;

            //Fenstergröße auf 75% setzen:
            this.Width = Bildschirm_Breite / 100 * 75;
            this.Height = Bildschirm_Hohe / 100 * 75;
        }
    }
}
