using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class BILL_Product
    {
        private long _Product_Id;

        public long Product_Id
        {
            get { return _Product_Id; }
            set { _Product_Id = value; }
        }


        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }




        private string _DescriptionPro;

        public string DescriptionPro
        {
            get { return _DescriptionPro; }
            set { _DescriptionPro = value; }
        }

        private double _Price;

        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private long _Category_Id;

        public long Category_Id
        {
            get { return _Category_Id; }
            set { _Category_Id = value; }
        }

        private long _Vat_Id;

        public long Vat_Id
        {
            get { return _Vat_Id; }
            set { _Vat_Id = value; }
        }

        private BILL_Category _BILL_Category;

        public BILL_Category BILL_Category
        {
            get { return _BILL_Category; }
            set { _BILL_Category = value; }
        }


        private BILL_Vat _BILL_Vat;

        public BILL_Vat BILL_Vat
        {
            get { return _BILL_Vat; }
            set { _BILL_Vat = value; }
        }
        

        private ObservableCollection<BILL_LineBillQuotation> _BILL_LineBillQuotation;
        public ObservableCollection<BILL_LineBillQuotation> BILL_LineBillQuotation
        {
            get
            {
                if (_BILL_LineBillQuotation==null)
                    _BILL_LineBillQuotation= new ObservableCollection<BILL_LineBillQuotation>();
                return _BILL_LineBillQuotation;
            }
            set { _BILL_LineBillQuotation = value; }
        }



        
    }
}
