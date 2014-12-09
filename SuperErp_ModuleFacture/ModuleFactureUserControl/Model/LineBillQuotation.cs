using ModuleFactureUserControl.Helpers;

namespace ModuleFactureUserControl.Model
{
    public class LineBillQuotation : NotificationObject
    {
        private long _LineBillQuotation_Id;

        public long LineBillQuotation_Id
        {
            get { return _LineBillQuotation_Id; }
            set { _LineBillQuotation_Id = value; }
        }

        private bool _IsInBill;

        public bool IsInBill
        {
            get { return _IsInBill; }
            set
            {
                _IsInBill = value;
                RaisePropertyChanged("IsInBill");
            }
        }

        private System.DateTime _DateLine;

        public System.DateTime DateLine
        {
            get { return _DateLine; }
            set
            {
                _DateLine = value;
                RaisePropertyChanged("DateLine");
            }
        }

        private double _Quantite;

        public double Quantite
        {
            get { return _Quantite; }
            set
            {
                _Quantite = value;
                RefreshCountLineAmount();
                RaisePropertyChanged("Quantite");
            }
        }

        private BillQuotation _BILL_BillQuotation;

        private BillQuotation BILL_BillQuotation
        {
            get { return _BILL_BillQuotation; }
            set
            {
                _BILL_BillQuotation = value;
                RaisePropertyChanged("BILL_BillQuotation");
            }
        }

        private Product _BILL_Product;

        public Product BILL_Product
        {
            get
            {
                return _BILL_Product;
            }
            set
            {
                _BILL_Product = value;
                RaisePropertyChanged("BILL_Product");
            }
        }

        private double _AmountHT;

        public double AmountHT
        {
            get { return _AmountHT; }
            set
            {
                _AmountHT = value;
                RaisePropertyChanged("AmountHT");
            }
        }

        private double _AmountTTC;

        public double AmountTTC
        {
            get { return _AmountTTC; }
            set
            {
                _AmountTTC = value;
                RaisePropertyChanged("AmountTTC");
            }
        }

        //Methods
        private void RefreshCountLineAmount()
        {
            if (BILL_Product != null)
            {
                AmountHT = Quantite * BILL_Product.Price;
                if (BILL_Product.BILL_Vat != null)
                    AmountTTC = (AmountHT * BILL_Product.BILL_Vat.Rate).Value;
                else
                    AmountTTC = AmountHT;
            }
        }
    }
}