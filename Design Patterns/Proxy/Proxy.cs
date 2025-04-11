using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Service: IService
    {
        public void Operation()
        {
            Console.WriteLine("Service operating...");
        }
    }

    public interface IService
    {
        public void Operation();
    }

    public class Proxy
    {
        private IService service;

        public Proxy(IService service)
        {
            this.service = service;
        }

        public void CheckAccess()
        {
            Console.WriteLine("Checking Access....");
        }

        public void Operation() 
        {
            CheckAccess();
            Log();
            service.Operation();
        }

        public void Log()
        {
            Console.WriteLine("Logging....");
        }
    }

    public class Client
    {
        public void Operate()
        {
            var proxy = new Proxy(new Service());
            proxy.Operation();
        }
    }
}
