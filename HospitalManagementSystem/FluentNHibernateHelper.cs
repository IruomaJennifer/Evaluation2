using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public static class FluentNHibernateHelper
    {
        private static ISessionFactory sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if(sessionFactory is null)
                {
                    CreateSessionFactory();
                }
                return sessionFactory;
            }
        }

        private static void CreateSessionFactory()
        {
            sessionFactory = Fluently.Configure().Database(
                MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\HospitalSystem.mdf;Integrated Security=True;Connect Timeout=30"))
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public static ISession CloseSession()
        {
            return null;
        }
        
    }
}
