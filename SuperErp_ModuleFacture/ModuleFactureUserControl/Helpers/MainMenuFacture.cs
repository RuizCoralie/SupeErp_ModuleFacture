using ModuleFactureUserControl.View;
using SupErp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Helpers
{
    public class MainMenuFacture : IMainMenu
    {
        public MainMenuFacture ()
	    {
            SubMenus = new List<ISubMenu>();
            SubMenus.Add(new ListeFactureDevis());
            SubMenus.Add(new FactureDevisEdition());
	    }

        public string MenuName
        {
            get { return "Facturation"; }
        }

        public List<ISubMenu> SubMenus
        {
            get;
            set;
        }
    }
}
