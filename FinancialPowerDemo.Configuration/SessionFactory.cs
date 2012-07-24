using System;
using System.Web.Mvc;
using NHibernate;
using NHibernate.Context;

namespace FinancialPowerDemo.Configuration
{
    public static class SessionFactory
    {
        public static void BeginRequest()
        {
            var sessionFactory = DependencyResolver.Current.GetService<ISessionFactory>();
            var session = sessionFactory.OpenSession();

            session.BeginTransaction();

            CurrentSessionContext.Bind(session);
        }

        public static void EndRequest()
        {
            var sessionFactory = DependencyResolver.Current.GetService<ISessionFactory>();
            var session = CurrentSessionContext.Unbind(sessionFactory);

            FinalizeSession(session);
        }

        private static void FinalizeSession(ISession session)
        {
            if (session == null || !session.IsOpen)
                return;

            try
            {
                if (session.Transaction != null && session.Transaction.IsActive)
                {
                    session.Flush();
                    session.Transaction.Commit();
                }
            }
            catch (Exception)
            {
                if (session.Transaction != null)
                    session.Transaction.Rollback();

                throw;
            }
            finally
            {
                session.Close();
                session.Dispose();
            }
        }
    }
}
