using System.Windows;
using System.Windows.Controls;

namespace ModuleFactureUserControl.Windows
{
    /// <summary>
    /// Interaction logic for WindowsSimple.xaml
    /// </summary>
    public partial class WindowsSimple : Window
    {
        public WindowsSimple()
        {
            InitializeComponent();
        }

        public WindowsSimple(UIElement Uc)
        {
            InitializeComponent();
            InitGrid();
            grid_UC.Children.Add(Uc);
        }

        private void InitGrid()
        {
            if (grid_UC == null)
                grid_UC = new Grid();

            if (grid_UC.Children != null)
                grid_UC.Children.Clear();
        }

        internal void CloseWindowEvent()
        {
            this.Close();
        }
    }
}