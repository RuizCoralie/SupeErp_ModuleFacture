using SupErp.Shared;
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

namespace ModuleFactureUserControl.View
{
    /// <summary>
    /// Logique d'interaction pour ListeFactureDevis.xaml
    /// </summary>
    public partial class ListeFactureDevis : UserControl, ISubMenu
    {
        public ListeFactureDevis()
        {
            InitializeComponent();
        }

        public bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }

        public string SubMenuName
        {
            get { return "Listes Factures / Devis"; }
        }

        public List<ISubMenu> SubMenus
        {
            get { return null; }
        }

        private void Print(object sender, RoutedEventArgs e)
        {
              System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();
            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
       
            {
                Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);

                dataListFD.Measure(pageSize);
                dataListFD.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                Printdlg.PrintVisual(dataListFD, SubMenuName );
            }
        }
    }
}
