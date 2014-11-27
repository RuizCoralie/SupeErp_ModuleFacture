using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class BILL_Transmitter
    {
        private long _Transmitter_Id;

        public long Transmitter_Id
        {
            get { return _Transmitter_Id; }
            set { _Transmitter_Id = value; }
        }

        private string _CompanyName;

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }
        private string _Adress;

        public string Adress
        {
            get { return _Adress; }
            set { _Adress = value; }
        }

        private int _PostCode;

        public int PostCode
        {
            get { return _PostCode; }
            set { _PostCode = value; }
        }

        private string _City;

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }


        private long _NSiret;

        public long NSiret
        {
            get { return _NSiret; }
            set { _NSiret = value; }
        }


        private string _AdressMail;

        public string AdressMail
        {
            get { return _AdressMail; }
            set { _AdressMail = value; }
        }


        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        
        

        private ObservableCollection<BILL_BillQuotation> _BILL_BillQuotation;
        private ObservableCollection<BILL_BillQuotation> BILL_BillQuotation
        {
            get
            {
                if (_BILL_BillQuotation == null)
                    _BILL_BillQuotation = new ObservableCollection<BILL_BillQuotation>();
                return _BILL_BillQuotation;
            }

            set
            {
                _BILL_BillQuotation = value;
            }
        }

    }
}
