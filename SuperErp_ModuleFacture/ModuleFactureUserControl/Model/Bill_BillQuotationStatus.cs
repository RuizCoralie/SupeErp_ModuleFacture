using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
   public class BILL_BillQuotationStatus
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
            set { _DateAdvancement = value; }
        }

        private long _Status_Id;

        public long Status_Id
        {
            get { return _Status_Id; }
            set { _Status_Id = value; }
        }

        private long _BillQuotation_Id;

        public long BillQuotation_Id
        {
            get { return _BillQuotation_Id; }
            set { _BillQuotation_Id = value; }
        }

        private BILL_BillQuotation _BILL_BillQuotation;

        private  BILL_BillQuotation BILL_BillQuotation
        {
            get { return _BILL_BillQuotation; }
            set { _BILL_BillQuotation = value; }
        }

        private  BILL_Status _BILL_Status;

        public  BILL_Status BILL_Status
        {
            get { return _BILL_Status; }
            set { _BILL_Status = value; }
        }
        
        

    }
}
