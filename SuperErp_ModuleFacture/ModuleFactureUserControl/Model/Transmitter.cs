using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class Transmitter : NotificationObject
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
            set 
            { 
                _CompanyName = value;
                RaisePropertyChanged("CompanyName");
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

        private int _PostCode;

        public int PostCode
        {
            get { return _PostCode; }
            set 
            { 
                _PostCode = value;
                RaisePropertyChanged("PostCode");
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


        private long _NSiret;

        public long NSiret
        {
            get { return _NSiret; }
            set 
            { 
                _NSiret = value;
                RaisePropertyChanged("NSiret");
            }
        }


        private string _AdressMail;

        public string AdressMail
        {
            get { return _AdressMail; }
            set 
            { 
                _AdressMail = value;
                RaisePropertyChanged("AdressMail");
            }
        }


        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set 
            { 
                _Phone = value;
                RaisePropertyChanged("Phone");
            }
        }
        
        

        private ObservableCollection<BillQuotation> _BILL_BillQuotation;
        private ObservableCollection<BillQuotation> BILL_BillQuotation
        {
            get
            {
                if (_BILL_BillQuotation == null)
                    _BILL_BillQuotation = new ObservableCollection<BillQuotation>();
                return _BILL_BillQuotation;
            }

            set
            {
                _BILL_BillQuotation = value;
                RaisePropertyChanged("BILL_BillQuotation");
            }
        }

    }
}
