using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class Status : NotificationObject
    {
        private long _Status_Id;

        public long Status_Id
        {
            get { return _Status_Id; }
            set { _Status_Id = value; }
        }

        private string _Libel;

        public string Libel
        {
            get { return _Libel; }
            set 
            { 
                _Libel = value;
                RaisePropertyChanged("Libel");
            }
        }
        
        

        private ObservableCollection<BillQuotationStatus> _BILL_BillQuotationStatus;
        public ObservableCollection<BillQuotationStatus> BILL_BillQuotationStatus
        {
            get
            {
                if (_BILL_BillQuotationStatus == null)
                    _BILL_BillQuotationStatus = new ObservableCollection<BillQuotationStatus>();
                return _BILL_BillQuotationStatus;
            }
            set 
            { 
                _BILL_BillQuotationStatus = value;
                RaisePropertyChanged("BILL_BillQuotationStatus");
            }
        }
    }
}
