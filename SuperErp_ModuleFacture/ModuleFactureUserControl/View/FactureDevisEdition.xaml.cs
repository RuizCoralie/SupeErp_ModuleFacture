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
    /// Logique d'interaction pour FactureDevisEdition.xaml
    /// </summary>
    public partial class FactureDevisEdition : UserControl, ISubMenu
    {
        public FactureDevisEdition()
        {
            InitializeComponent();
        }

        public bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }

        public string SubMenuName
        {
            get { return "Ajout Facture / Devis"; }
        }

        public List<ISubMenu> SubMenus
        {
            get { return null; }
        }
    }
}
