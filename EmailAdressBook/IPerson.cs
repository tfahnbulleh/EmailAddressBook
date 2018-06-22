using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailAdressBook
{
   public interface IPerson<T> where T:class
    {
        T FindByEmail(string email);
        T FindByName(string name);
        T FindByNumber(string number);
        T FindById(int Id);
        List<T> GetList();
        void Add(T model);
        void Delete(int id);
        void Edit(T model);
      
    }
}
