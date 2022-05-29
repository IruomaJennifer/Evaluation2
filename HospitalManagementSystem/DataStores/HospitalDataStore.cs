using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataStores
{
    public class HospitalDataStore : IDataStore<Hospital>
    {
        public void Create(Hospital item)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    using var tx = session.BeginTransaction();
                    session.Save(item);
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

        public void Delete(Hospital item)
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

        public Hospital Read(int id)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    var item = session.Get<Drug>(id);
                    return item;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public void Update(Hospital item)
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
