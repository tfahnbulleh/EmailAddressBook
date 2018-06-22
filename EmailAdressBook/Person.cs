using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailAdressBook
{
  public  class Person
    {
        //instance variable
        private string _name;
        private string _email;
        private string _number;
        private int _id;

        //constructor
        public Person( string name, string email, string number,int id=0)
        {
            this._name = name;
            this._number = number;
            this._email =email;
            this._id = id;
        }

        //properties to get or set instance variable
        public string Name
        {
            get { return this._name; } set { this._name = value; }
        }

        public int Id
        {
            get { return this._id; }
        }

        public string Number
        {
            get { return this._number; }
            set { this._number = value; }
        }

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public override string ToString()
        {
            return this._name + "\n" + this._email + "\n" + this._number;
        }
    }
}
