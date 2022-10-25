using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab04_OOP
{
    class PublishingHouse:AAA, IPrintInfo
    {
        ////////////////////////////////////////////////////////////////
        public static void getInfo()
        {
            Console.WriteLine($"Всего книг: {theTotalNumberOfBooks}");
            Console.WriteLine($"Цена книг: {theTotalCost}");
        }
        ////////////////////////////////////////////////////////////////
        //private string number = "10";
        public string Number { get; set; }
        public static int theTotalCost = 0;
        public static int theTotalNumberOfBooks=0;
        public string publisherName;
        public string pubishingAdress;
        public PublishingHouse(string publisherName, string pubishingAdress)
        {
            this.publisherName = publisherName;
            this.pubishingAdress = pubishingAdress;
        }

        public override string ToString()
        {
            return  "Тип объекта: " + GetType() + "\nНазвание издательства: " + publisherName +"\nАдрес издательства: "+pubishingAdress;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            return true;
        }
        public void LeaveFeedback()
        {
            Console.WriteLine($"Оставьте отзыв о книге");
            Console.ReadLine();
            Console.WriteLine("Спасибо, ваш отзыв очень важен для нас");
        }

        public override void YaAbstraktniyClass()
        {
            Console.WriteLine("Я абстрактный класс!");
        }

        public virtual void Gotovo()
        {
            Console.WriteLine("Готово!");
        }

        public override void KtoYa()
        {
            Console.WriteLine("Возможно я человек!");      
        }

         void IPrintInfo.KtoYa()
        {
            Console.WriteLine("Возможно я кот!");
        }
    }
}
