using System.Windows;
using System.Windows.Controls;
using ModuleFactureUserControl.View;

namespace WpfModuleFactureTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var uc = new ListeFactureDevis();

            InitGrid();
            grid_Main.Children.Add(uc);
        }

        private void InitGrid()
        {
            if (grid_Main == null)
                grid_Main = new Grid();

            if (grid_Main.Children != null)
                grid_Main.Children.Clear();
        }
    }
}
