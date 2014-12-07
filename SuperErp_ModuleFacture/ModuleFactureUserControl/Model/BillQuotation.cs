using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleFactureUserControl.Model;
using System.Collections.ObjectModel;
using ModuleFactureUserControl.Helpers;


namespace ModuleFactureUserControl.Model
{
    public class BillQuotation : NotificationObject
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
            set 
            { 
                _NBill = value;
                RaisePropertyChanged("NBill");
            }
        }
        private BillQuotationType _Type;

        public BillQuotationType Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                RaisePropertyChanged("Type");
            }
        }
        private bool _Vat;

        public bool Vat
        {
            get { return _Vat; }
            set 
            { 
                _Vat = value;
                RaisePropertyChanged("Vat");
            }
        }

        private double _AmountDF;

        public double AmountDF
        {
            get { return _AmountDF; }
            set 
            { 
                _AmountDF = value;
                RaisePropertyChanged("AmountDF");
            }
        }

        private double _AmountTTC;
        public double AmountTTC 
        { 
            get
            {
                return _AmountTTC;
            }
            set
            {
                _AmountTTC = value;
                RaisePropertyChanged("AmountTTC");
            }
        }

        private System.DateTime _DateBillQuotation;

        public System.DateTime DateBillQuotation
        {
            get { return _DateBillQuotation; }
            set 
            { 
                _DateBillQuotation = value;
                RaisePropertyChanged("DateBillQuotation");
            }
        }

        private Transmitter _BILL_Transmitter;

        public Transmitter BILL_Transmitter
        {
            get { return _BILL_Transmitter; }
            set 
            { 
                _BILL_Transmitter = value;
                RaisePropertyChanged("BILL_Transmitter");
            }
        }


        private Company _Company;

        public Company Company
        {
            get { return _Company; }
            set 
            { 
                _Company = value;
                RaisePropertyChanged("Company");
            }
        }
              
        
        private BillQuotationStatus _BILL_BillQuotationStatus;

        public BillQuotationStatus BILL_BillQuotationStatus
        {
            get
            {                   
                return _BILL_BillQuotationStatus; 
            }
            set 
            { 
                _BILL_BillQuotationStatus = value;
                RaisePropertyChanged("BILL_BillQuotationStatus");
            }
        }

        private ObservableCollection<LineBillQuotation> _BILL_LineBillQuotation;

        public ObservableCollection<LineBillQuotation> BILL_LineBillQuotation
        {
            get
            {
                if (_BILL_LineBillQuotation == null)
                    _BILL_LineBillQuotation = new ObservableCollection<LineBillQuotation>();
                return _BILL_LineBillQuotation; }
            set 
            { 
                _BILL_LineBillQuotation = value;
                RaisePropertyChanged("BILL_LineBillQuotation");
            }
        }
        

   }

    public enum BillQuotationType
    {
        Facture,
        Devis
    }

    public enum BillQuotationStatutEnum
    {
        EnCoursDeRedaction,
        Annule, 
        Emis,
        Accepte,
        Refuse,
        EnCoursDePaiement,
        Payee
    }
}


        

