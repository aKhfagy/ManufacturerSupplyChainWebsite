[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebAppOrder.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(WebAppOrder.App_Start.NinjectWebCommon), "Stop")]

namespace WebAppOrder.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
<<<<<<< HEAD
   
=======
    using Order.BL;
    using Order.IBL;
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c
    using Manufacturer.IBL;
    using Manufacturer.BL;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
<<<<<<< HEAD
                kernel.Bind<IManufacturerRepository>().To<ManufacturerRepository>();
                kernel.Bind<IOrderRepository>().To<OrderRepository>();

=======
                kernel.Bind<IOrderRepository>().To<OrderRepository>();
                kernel.Bind<IManufacturerRepository>().To<ManufacturerRepository>();
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
<<<<<<< HEAD
           // kernel.Bind<IOrderRepository>().To<OrderRepository>().InRequestScope();
=======
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c
        }        
    }
}
