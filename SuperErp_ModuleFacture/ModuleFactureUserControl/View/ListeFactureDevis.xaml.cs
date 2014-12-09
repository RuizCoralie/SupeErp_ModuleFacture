using System;
using System.Collections.Generic;
using System.Windows.Controls;
using SupErp.Shared;

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
    }
}