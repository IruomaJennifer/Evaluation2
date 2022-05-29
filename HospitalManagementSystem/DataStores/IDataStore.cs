using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataStores
{
    public interface IDataStore<T>
    {
        void Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(T item);
    }
}
