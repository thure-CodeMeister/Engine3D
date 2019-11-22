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

namespace Engine3D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Face f = new Face(new Point3D(150, 150, 0), new Point3D(150, 50, 0), new Point3D(50, 50, 0), new Point3D(50, 150, 0));
            canvas.Children.Add(f.Polygon);
            canvas.UpdateLayout();
        }
    }
}
