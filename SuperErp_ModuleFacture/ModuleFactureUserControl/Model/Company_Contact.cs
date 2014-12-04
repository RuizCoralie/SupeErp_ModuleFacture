using ModuleFactureUserControl.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class Company_Contact : NotificationObject
    {

        private long _Id;

        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Firstname;

        public string Firstname
        {
            get { return _Firstname; }
            set 
            { 
                _Firstname = value;
                RaisePropertyChanged("Firstname");
            }
        }


        private string _Lastname;

        public string Lastname
        {
            get { return _Lastname; }
            set 
            { 
                _Lastname = value;
                RaisePropertyChanged("Lastname");
            }
        }

        private int _Gender;

        public int Gender
        {
            get { return _Gender; }
            set 
            { 
                _Gender = value;
                RaisePropertyChanged("Gender");
            }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set 
            { 
                _Email = value;
                RaisePropertyChanged("Email");
            }
        }

        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set 
            { 
                _Phone = value;
                RaisePropertyChanged("Phone");
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
        
        
    }
}
