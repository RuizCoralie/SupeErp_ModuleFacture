using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
   public class Company
    {

        private long _id;

        public long id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _siret;

        public string siret
        {
            get { return _siret; }
            set { _siret = value; }
        }

        private string _adress;

        public string adress
        {
            get { return _adress; }
            set { _adress = value; }
        }



        private int _postalcode;

        public int postalcode
        {
            get { return _postalcode; }
            set { _postalcode = value; }
        }

        private string _city;

        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
        
        
        private ObservableCollection<BILL_BillQuotation> _BILL_BillQuotation;
        private ObservableCollection<Company_Contact> _Company_Contact;

        private ObservableCollection<BILL_BillQuotation> BILL_BillQuotation
        {
            get
            {
                if (_BILL_BillQuotation == null)
                    _BILL_BillQuotation = new ObservableCollection<BILL_BillQuotation>();
                return _BILL_BillQuotation;
            }

            set { _BILL_BillQuotation = value; }
        }

        public ObservableCollection<Company_Contact> Company_Contact
        {
            get
            {
                if (_Company_Contact == null)
                    _Company_Contact = new ObservableCollection<Company_Contact>();
                return _Company_Contact;
            }
            set
            {
                _Company_Contact = value;
            }
        }

    }

}
