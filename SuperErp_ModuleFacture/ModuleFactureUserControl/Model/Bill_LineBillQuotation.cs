using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class BILL_LineBillQuotation
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
            set { _DateLine = value; }
        }

        private double _Quantite;

        public double Quantite
        {
            get { return _Quantite; }
            set { _Quantite = value; }
        }

        private long _BillQuotation_Id;

        public long BillQuotation_Id
        {
            get { return _BillQuotation_Id; }
            set { _BillQuotation_Id = value; }
        }


        private long _Product_Id;

        public long Product_Id
        {
            get { return _Product_Id; }
            set { _Product_Id = value; }
        }

        private BILL_BillQuotation _BILL_BillQuotation;

        private BILL_BillQuotation BILL_BillQuotation
        {
            get { return _BILL_BillQuotation; }
            set { _BILL_BillQuotation = value; }
        }

        private BILL_Product _BILL_Product;

        public BILL_Product BILL_Product
        {
            get { return _BILL_Product; }
            set { _BILL_Product = value; }
        }
        
        
        
    }
}
