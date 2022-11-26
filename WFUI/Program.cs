using BLL;
using Autofac;
using DAL;
using Tools;

namespace WFUI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            //Application.Run(new SignInForm());
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                ApplicationConfiguration.Initialize();
                Application.Run(container.Resolve<SignInForm>());
            }
        }
    }   
}