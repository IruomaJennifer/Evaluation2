using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataStores
{
    public class ReceptionistDataStore : IDataStore<Receptionist>
    {
        public void Create(Receptionist item)
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

        public void Delete(Receptionist item)
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

        public Receptionist Read(int id)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    var item = session.Get<Receptionist>(id);
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

        public void Update(Receptionist item)
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
