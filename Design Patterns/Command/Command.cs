using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        void Execute();
    }

    public class PrintCommand: ICommand
    {
        private string _str = string.Empty;

        public PrintCommand(string str) 
        {
            this._str = str;
        }

        public void Execute() 
        {
            Console.WriteLine(_str);
        }
    }

    public class AddCommand : ICommand
    {
        private Reciever _reciever;
        private int _num1;
        private int _num2;

        public AddCommand(Reciever reciever, int num1, int num2)
        {
            _reciever = reciever;
            _num1 = num1;
            _num2 = num2;
        }

        public void Execute() 
        {
            Console.WriteLine(_reciever.AddNumbers(_num1, _num2));
        }


    }

    public class Reciever
    {
        public int AddNumbers(int num1, int num2) 
        {
            return num1 + num2;
        }
    }

    public class Invoker
    {
        private ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand() 
        {
            _command.Execute();
        }
    }
}
