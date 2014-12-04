using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
   public class BillQuotationStatus : NotificationObject
    {
        private long _BillQuotationStatus_Id;

        public long BillQuotationStatus_Id
        {
            get { return _BillQuotationStatus_Id; }
            set { _BillQuotationStatus_Id = value; }
        }

        private System.DateTime _DateAdvancement;

        public System.DateTime DateAdvancement
        {
            get { return _DateAdvancement; }
            set 
            { 
                _DateAdvancement = value;
                RaisePropertyChanged("DateAdvancement");
            }
        }


        private BillQuotation _BILL_BillQuotation;

        private  BillQuotation BILL_BillQuotation
        {
            get { return _BILL_BillQuotation; }
            set 
            { 
                _BILL_BillQuotation = value;
                RaisePropertyChanged("BILL_BillQuotation");
            }
        }

        private  Status _BILL_Status;

        public  Status BILL_Status
        {
            get { return _BILL_Status; }
            set 
            { 
                _BILL_Status = value;
                RaisePropertyChanged("BILL_Status");
            }
        }
        
        

    }
}
