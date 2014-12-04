using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
   public class Company : NotificationObject
    {

        private long _Id;

        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
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

        private string _Siret;

        public string Siret
        {
            get { return _Siret; }
            set 
            { 
                _Siret = value;
                RaisePropertyChanged("Siret");
            }
        }

        private string _Adress;

        public string Adress
        {
            get { return _Adress; }
            set 
            { 
                _Adress = value;
                RaisePropertyChanged("Adress");
            }
        }



        private int _Postalcode;

        public int Postalcode
        {
            get { return _Postalcode; }
            set 
            { 
                _Postalcode = value;
                RaisePropertyChanged("Postalcode");
            }
        }

        private string _City;

        public string City
        {
            get { return _City; }
            set 
            { 
                _City = value;
                RaisePropertyChanged("City");
            }
        }
        
        
        //private ObservableCollection<BillQuotation> _BILL_BillQuotation;
      

        //private ObservableCollection<BillQuotation> BILL_BillQuotation
        //{
        //    get
        //    {
        //        if (_BILL_BillQuotation == null)
        //            _BILL_BillQuotation = new ObservableCollection<BillQuotation>();
        //        return _BILL_BillQuotation;
        //    }

        //    set 
        //    { 
        //        _BILL_BillQuotation = value;
        //        RaisePropertyChanged("BILL_BillQuotation");
        //    }
        }
    }

}
