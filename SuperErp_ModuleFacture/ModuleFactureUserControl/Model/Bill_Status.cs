using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class BILL_Status
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
            set { _Libel = value; }
        }
        
        

        private ObservableCollection<BILL_BillQuotationStatus> _BILL_BillQuotationStatus;
        public ObservableCollection<BILL_BillQuotationStatus> BILL_BillQuotationStatus
        {
            get
            {
                if (_BILL_BillQuotationStatus == null)
                    _BILL_BillQuotationStatus = new ObservableCollection<BILL_BillQuotationStatus>();
                return _BILL_BillQuotationStatus;
            }
            set { _BILL_BillQuotationStatus = value; }
        }
    }
}
