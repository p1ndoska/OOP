using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    public class NullObject : Exception
    {
        private string message;
        public NullObject()
        {
            message = "Null-объект";
        }
        public void PrintInfo()
        {
            Console.WriteLine("Сообщение: " + message + ", метод, где возникло исключение: " + TargetSite + "\n");
        }
    }

    public class WrongDate : Exception
    {
        private string message;
        public WrongDate(string message)
        {
            this.message = message;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Сообщение: " + message + ", метод, где возникло исключение: " + TargetSite + "\n");
        }
    }

    public class EmptyStruct : Exception
    {
        public void PrintInfo()
        {
            Console.WriteLine("Сообщение: член класса не инициализирован" + "\n");
        }
    }
}
