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

/*
El control Slider (scroll) al desplazarse varia sus valores
de forma muy sensible, con una gran cantidad de decimales ...
PERO ...
los valores RGB son 3 enteros de 0 --> 255
si capturas el valor del Slider hay que truncarlo ...
PERO ...
El Slider de WPF viene preparado para configurar los saltos de sus valores.
TickPlacement="BottomRight"   --> lugar de la regla
TickFrequency="5" --> el tamaño del salto, aquí de 5 en 5
             ="1" --> en el código de 1 en 1
IsSnapToTickEnabled="True"    --> los valores se pegan a la regla, en nuestro
código forzará que sean enteros.
*/

namespace Sergioteacher.Csharp07.ScrollColorDinamico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Se inicializa los componentes y se da unos valores por defecto
        /// para que no sea brusco el cambio al mover el scroll
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            SR.Value = 37;
            SG.Value = 200;
            SB.Value = 120;
        }

        /// <summary>
        /// Como el nombre indica explícitamente
        /// el tipo de evento "ValueChanged" como lo soportan todos los scroll
        /// se puede usar un nombre genérico para todos
        /// sin que haya que repetir código
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MismoMetodoParaTodosSroll_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color miColor = Color.FromRgb((byte)SR.Value, (byte)SG.Value, (byte)SB.Value);
            this.Background = new SolidColorBrush(miColor);
        }
    }
}
