using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleFactureUserControl.Model;


namespace ModuleFactureUserControl.Model
{
    public class BILL_Category
    {
        private long _Category_Id;

        public long Category_Id
        {
            get { return _Category_Id; }
            set { _Category_Id = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _DescriptionCat;

        public string DescriptionCat
        {
            get { return _DescriptionCat; }
            set { _DescriptionCat = value; }
        }

        
        
        private ObservableCollection<BILL_Product> _BILL_Product;
        public  ObservableCollection<BILL_Product> BILL_Product
        {
            get
            {
                if (_BILL_Product == null)
                    _BILL_Product = new ObservableCollection<BILL_Product>();
                return _BILL_Product;
            }
            set { _BILL_Product = value; }
        }
   

    }
    


   
}
