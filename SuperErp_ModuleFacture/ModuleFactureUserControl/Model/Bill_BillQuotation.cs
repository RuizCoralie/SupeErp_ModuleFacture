using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleFactureUserControl.Model;
using System.Collections.ObjectModel;


namespace ModuleFactureUserControl.Model
{
    class BILL_BillQuotation
    {
        private long _BillQuotation_Id;

        public long BillQuotation_Id
        {
            get { return _BillQuotation_Id; }
            set { _BillQuotation_Id = value; }
        }

        private string _NBill;

        public string NBill
        {
            get { return _NBill; }
            set { _NBill = value; }
        }

        private bool _Vat;

        public bool Vat
        {
            get { return _Vat; }
            set { _Vat = value; }
        }

        private int _AmountDF;

        public int AmountDF
        {
            get { return _AmountDF; }
            set { _AmountDF = value; }
        }

        private System.DateTime _DateBillQuotation;

        public System.DateTime DateBillQuotation
        {
            get { return _DateBillQuotation; }
            set { _DateBillQuotation = value; }
        }

        private long _Transmitter_Id;

        public long Transmitter_Id
        {
            get { return _Transmitter_Id; }
            set { _Transmitter_Id = value; }
        }
        private long _Company_Id;

        public long Company_Id
        {
            get { return _Company_Id; }
            set { _Company_Id = value; }
        }

        private BILL_Transmitter _Bill_Transmitter;

        public BILL_Transmitter Bill_Transmitter
        {
            get { return _Bill_Transmitter; }
            set { _Bill_Transmitter = value; }
        }


        private Company _Company;

        public Company Company
        {
            get { return _Company; }
            set { _Company = value; }
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

        private ObservableCollection<BILL_LineBillQuotation> _BILL_LineBillQuotation;

        public ObservableCollection<BILL_LineBillQuotation> BILL_LineBillQuotation
        {
            get
            {
                if (_BILL_LineBillQuotation == null)
                    _BILL_LineBillQuotation = new ObservableCollection<BILL_LineBillQuotation>();
                return _BILL_LineBillQuotation; }
            set { _BILL_LineBillQuotation = value; }
        }
        

   }
}

        

