using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ModuleFactureUserControl.Model
{
    public class Vat : NotificationObject
    {
        
        private long _Vat_Id;

        public long Vat_Id
        {
            get { return _Vat_Id; }
            set { _Vat_Id = value; }
        }
        

        private double _Rate;

        public double Rate
        {
            get { return _Rate; }
            set 
            { 
                _Rate = value;
                RaisePropertyChanged("Rate");
            }
        }


        private System.DateTime _DateVat;

        public System.DateTime DateVat
        {
            get { return _DateVat; }
            set 
            { 
                _DateVat = value;
                RaisePropertyChanged("DateVat");
            }
        }
        
 

        private ObservableCollection<Product> _BILL_Product;
        
        public ObservableCollection<Product> BILL_Product
        {
            get
            {
                if (_BILL_Product == null)
                    _BILL_Product = new ObservableCollection<Product>();
                return _BILL_Product;

            }
            set
            {
                _BILL_Product = value;
                RaisePropertyChanged("BILL_Product");
            }
        }
    }
}
