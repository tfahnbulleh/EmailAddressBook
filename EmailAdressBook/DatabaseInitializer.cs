using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmailAdressBook
{
  public  class DatabaseInitializer:IDisposable
    {
        private PersonRepository _personRepository;
        private bool _disposed;
        // Instantiate a SafeHandle instance.
        SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
        //constructor
        public DatabaseInitializer()
        {
            _personRepository = new PersonRepository();
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
                _personRepository.Dispose();
            }

            _disposed = true;
        }

        //seed database with default data
        //method create four new Person
        //add the four persons to the database
        public void Seed()
        {
            try
            {
                Person person1 = new Person("James Jones", "jjones@gmail.com", "2816187777");
                Person person2 = new Person("Bill Smith", "bsmith@gmail.com", "2814566555");
                Person person3 = new Person("Wendy Berger", "wberger@gmail.com", "2818978888");
                Person person4 = new Person("Sally Rider", "srider@hotmail.com", " 2814556654");
                _personRepository.Add(person1);
                _personRepository.Add(person2);
                _personRepository.Add(person3);
                _personRepository.Add(person4);
            }
            catch (ArgumentNullException ex)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (System.Data.ConstraintException ex)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw;
            }
           
           
        }
    }
}
