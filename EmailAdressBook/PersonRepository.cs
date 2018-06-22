using EmailAdressBook.address_bookDataSetTableAdapters;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmailAdressBook
{
  public class PersonRepository : IPerson<Person>,IDisposable
    {

        private address_bookDataSetTableAdapters.email_addressTableAdapter _emailAddressBookAdapter;
        private address_bookDataSet _bookDataSet;
        private bool _disposed;
        // Instantiate a SafeHandle instance.
        SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
        public PersonRepository()
        {
            _emailAddressBookAdapter = new email_addressTableAdapter();
            _bookDataSet = new address_bookDataSet();
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _handle.Dispose();
                _emailAddressBookAdapter.Dispose();
                _bookDataSet.Dispose();
            }

            _disposed = true;
        }

        //Add new record to the database
        public void Add(Person model)
        {
            address_bookDataSet.email_addressRow email_AddressRow = _bookDataSet.email_address.Newemail_addressRow();
            email_AddressRow.email = model.Email;
            email_AddressRow.phone_number = model.Number;
            email_AddressRow.name = model.Name;
            _bookDataSet.email_address.Rows.Add(email_AddressRow);
            _emailAddressBookAdapter.Update(_bookDataSet.email_address);
        }

        //delete record from the database
        //the id of the data to be deleted must be pass to the method as argument
        public void Delete(int id)
        {
            _emailAddressBookAdapter.DeleteQuery(id);
        }

        //edit existing record
        public void Edit(Person model)
        {
            var person = this.FindById(model.Id);
        
            if (person==null)
            {
             
                throw new Exception("Validation failed");
            }
            else
            {
                try
                {
                    person.Email = model.Email;
                    person.Number = model.Number;
                    person.Name = model.Name;
                    _emailAddressBookAdapter.Update1(person.Name, person.Email, person.Number, person.Id);
                }
                catch (Exception)
                {
                    throw;
                }
              
            }
        }

        //query by email
        public Person FindByEmail(string email)
        {
            //query for the person by phoneNumber
            var data = _emailAddressBookAdapter.FindByEmail(email).FirstOrDefault();
            return new Person(data.name, data.email, data.phone_number, data.ID);
        }

        public Person FindById(int Id)
        {
            var person = _emailAddressBookAdapter.GetDataById(Id).SingleOrDefault();
           return new Person(person.name, person.email, person.phone_number, person.ID);
        }

        //query by name
        public Person FindByName(string name)
        {
            //query for the person by phoneNumber
            var data = _emailAddressBookAdapter.FindByName(name).FirstOrDefault();
            return new Person(data.name, data.email, data.phone_number, data.ID);
        }

        //find persaon data by phone number
        public Person FindByNumber(string number)
        {
            //query for the person by phoneNumber
            var data = _emailAddressBookAdapter.FindByPhoneNumber(number).FirstOrDefault();
            return new Person(data.name, data.email, data.phone_number, data.ID);
        }

        //get all records from the database
        public List<Person> GetList()
        {
           var data= _emailAddressBookAdapter.GetData();
            List<Person> persons = new List<Person>();
            foreach (var item in data)
            {
                persons.Add(new Person(item.name, item.email, item.phone_number,item.ID));
            }
            persons.Sort((x, y) => x.Name.CompareTo(y.Name));
            return persons;
        }

      
    }
}
