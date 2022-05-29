using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataStores
{
    public class RegisteredPatientDataStore : IDataStore<RegisteredPatient>
    {
        public void Create(RegisteredPatient item)
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

        public void Delete(RegisteredPatient item)
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

        public RegisteredPatient Read(int id)
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    var item = session.Get<RegisteredPatient>(id);
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

        public List<RegisteredPatient> ReadAllRegisteredPatients()
        {
            try
            {
                using (var session = FluentNHibernateHelper.OpenSession())
                {
                    var items = session.Query<RegisteredPatient>();
                    return items.ToList();
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

        public void Update(RegisteredPatient item)
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
