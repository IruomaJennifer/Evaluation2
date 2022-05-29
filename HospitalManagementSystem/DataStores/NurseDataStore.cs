using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataStores
{
    public class NurseDataStore : IDataStore<Nurse>
    {
        public void Create(Nurse item)
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

        public void Delete(Nurse item)
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

        public Nurse Read(int id)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    var item = session.Get<Nurse>(id);
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

        public void Update(Nurse item)
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
