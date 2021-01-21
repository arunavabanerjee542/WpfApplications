using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseINotify
{
   public  class ShowFullName : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;


        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                IfPropertyChanged("FirstName");
                IfPropertyChanged("FullName");
            }

        }



        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                IfPropertyChanged("LastName");
                IfPropertyChanged("FullName");
            }

        }


        public string FullName
        {
            get
            {
                return _firstName +  " " + _lastName;
            }
            set
            {
                _fullName = value;
                IfPropertyChanged("FullName");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void IfPropertyChanged(string property)
        {
            if(PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }

        }


    }
}
