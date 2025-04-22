using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class BaseClass
    {
        public void Step1()
        {
            Console.WriteLine("Executing Step1");
        }
        public void Step3()
        {
            Console.WriteLine("Executing Step3");
        }
        public abstract void RequiredStep2();
        public abstract void RequiredStep4();
        public virtual void Hook1() { }
        public virtual void Hook2() { }
        public void TemplateMethod()
        {
            Hook1();
            Step1();
            RequiredStep2();
            Step3();
            RequiredStep4();
            Hook2();
        }
    }

    public class ClassA : BaseClass
    {
        public override void RequiredStep2()
        {
            Console.WriteLine("ClassA executing Step 2");
        }

        public override void RequiredStep4()
        {
            Console.WriteLine("ClassA executing Step 4");
        }
    }

    public class ClassB : BaseClass
    {
        public override void RequiredStep2()
        {
            Console.WriteLine("ClassB executing Step 2");
        }

        public override void RequiredStep4()
        {
            Console.WriteLine("ClassB executing Step 4");
        }

        public override void Hook2()
        {
            Console.WriteLine("Class B executing Hook 2");
        }
    }

    public class Client
    {
        public static void Execute(BaseClass bc)
        {
            bc.TemplateMethod();
        }
    }
}
