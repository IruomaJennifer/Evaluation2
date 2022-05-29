using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataStores
{
    public class MyDataStore<T>
    {
        public static void Create(T item)
        {
            try
            {
                using(var session = FluentNHibernateHelper.OpenSession())
                {
                    using var tx = session.BeginTransaction();
                    session.Save(item);
                    tx.Commit();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }
       public static T ReadById(int id)
       {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                   var item = session.Get<T>(id);
                    return item;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
       }
        public static void Delete(T item)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    using var tx = session.BeginTransaction();
                    session.Delete(item);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }
        public static void Update(T item)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    using var tx = session.BeginTransaction();
                    session.Update(item);
                    tx.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

    }
}
