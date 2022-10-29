using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    partial class PublishingHouse
    {
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

        //определение enum
        public enum ActionChoice : short
        {
            BuyNow = 1,
            AddToCart = 2,
            removeFromCart = 3
        }

    }
}
