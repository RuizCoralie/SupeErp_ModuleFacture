using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleFactureUserControl.Model;
using ModuleFactureUserControl.Helpers;


namespace ModuleFactureUserControl.Model
{
    public class Category : NotificationObject
    {
        private long _Category_Id;

        public long Category_Id
        {
            get { return _Category_Id; }
            set { _Category_Id = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set 
            { 
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string _DescriptionCat;

        public string DescriptionCat
        {
            get { return _DescriptionCat; }
            set 
            { 
                _DescriptionCat = value;
                RaisePropertyChanged("DescriptionCat");
            }
        }
    }
    


   
}
