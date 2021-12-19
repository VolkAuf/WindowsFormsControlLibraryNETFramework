using BookStorageBusinessLogic.BusinessLogics;
using BookStorageBusinessLogic.Interfaces;
using BookStorageDatabaseImplement.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace BookStorageView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IBookStorage, BookStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IReaderStorage, ReaderStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IBookFormStorage, BookFormStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<BookBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReaderBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<BookFormBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
