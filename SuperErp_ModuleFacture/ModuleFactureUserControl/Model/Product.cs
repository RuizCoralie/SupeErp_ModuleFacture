using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class Product : NotificationObject
    {
        private long _Product_Id;

        public long Product_Id
        {
            get { return _Product_Id; }
            set { _Product_Id = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set 
            { 
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string _DescriptionPro;

        public string DescriptionPro
        {
            get { return _DescriptionPro; }
            set 
            { 
                _DescriptionPro = value;
                RaisePropertyChanged("DescriptionPro");
            }
        }

        private double _Price;

        public double Price
        {
            get { return _Price; }
            set 
            { 
                _Price = value;
                RaisePropertyChanged("Price");
            }
        }

        private Category _BILL_Category;

        public Category BILL_Category
        {
            get { return _BILL_Category; }
            set 
            { 
                _BILL_Category = value;
                RaisePropertyChanged("BILL_Category");
            }
        }


        private Vat _BILL_Vat;

        public Vat BILL_Vat
        {
            get { return _BILL_Vat; }
            set 
            { 
                _BILL_Vat = value;
                RaisePropertyChanged("BILL_Vat");
            }
        }
        

        private ObservableCollection<LineBillQuotation> _BILL_LineBillQuotation;
        public ObservableCollection<LineBillQuotation> BILL_LineBillQuotation
        {
            get
            {
                if (_BILL_LineBillQuotation==null)
                    _BILL_LineBillQuotation= new ObservableCollection<LineBillQuotation>();
                return _BILL_LineBillQuotation;
            }
            set 
            { 
                _BILL_LineBillQuotation = value;
                RaisePropertyChanged("BILL_LineBillQuotation");
            }
        }



        
    }
}
