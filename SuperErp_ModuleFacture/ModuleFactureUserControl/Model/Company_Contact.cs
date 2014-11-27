using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFactureUserControl.Model
{
    public class Company_Contact
    {

        private long _id;

        public long id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstname;

        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }


        private string _lastname;

        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        private int _gender;

        public int gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phone;

        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private long _company_id;

        public long compani_id
        {
            get { return _company_id; }
            set { _company_id = value; }
        }

        private Company _Company;

        public Company Company
        {
            get { return _Company; }
            set { _Company = value; }
        }
        
        
    }
}
