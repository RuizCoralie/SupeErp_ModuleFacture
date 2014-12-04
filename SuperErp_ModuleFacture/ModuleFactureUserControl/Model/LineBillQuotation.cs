using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            get { return _BILL_Product; }
            set 
            { 
                _BILL_Product = value;
                RaisePropertyChanged("BILL_Product");
            }
        }
        
        
        
    }
}
