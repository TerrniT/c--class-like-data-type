using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Goods
    {
        // // // fields: // // //
        // 
        // Имя товара
        // Имя поставщика
        // Стоимость закупки
        // Стоимость продажи
        // Количество купленного товара
        // Количество проданного товара
        //
        // // // Methods: // // //
        // 
        // Выручка (В) - это совокупный объем денежных средств, полученный компанией, предприятимем или подлежащий получению за определеннный период времени коммерческой деятельности
        // Прибыль (П) - разница между суммарными доходами (выручка) и затратами на производство или прибретение, хранение , транспортировку, сбыт этих товаров и услуг
        // 
        // В = Стоимость проданного товара * Количество проданного товара
        // П = В -  (Количество купленного товара * Стоимость закупки)
        //
        // // // // // // // // //
        // Fields
        public string name{ get; set; }
        public string providerName { get; set; }
        public static int purchasePrice { get; set; }
        public static int sellingPrice { get; set; }
        public static int numberOfPurchasedGoods { get; set; }
        public static int numberOfGoodsSold { get; set; } 
        public static int profit { get; set; }


        // Methods
        public void show_information()
        {
            Console.WriteLine("#############################");
            Console.WriteLine("Имя товара: " + name);
            Console.WriteLine("Название поставщика: " + providerName);
            Console.WriteLine("Стоимость закупки: " + purchasePrice);
            Console.WriteLine("Стоимость продажи: " + sellingPrice);
            Console.WriteLine("Количество купленного товара: " + numberOfPurchasedGoods);
            Console.WriteLine("Количество проданного товара: " + numberOfGoodsSold);
            Console.WriteLine("______________________________");
            Console.WriteLine("Выручка: " + numberOfGoodsSold * sellingPrice);
            Console.WriteLine("Прибыль: " + (numberOfGoodsSold * sellingPrice - numberOfPurchasedGoods * purchasePrice));
            Console.WriteLine("______________________________");
            Console.WriteLine("#############################");
        }
        // Не работате метод для получения прибыли
        //public int getProfit(int a, int b, int c, int d)
        //{
        //    Goods.numberOfGoodsSold = a;
        //    Goods.sellingPrice = b;
        //    Goods.numberOfPurchasedGoods = c;
        //    Goods.purchasePrice = d;
        //    int profit = (a * b - c * d);
        //    return profit;
        //}

        public Goods(string name_, string prov_name)
        {
            this.name = name_;
            this.providerName = prov_name;
            Goods.purchasePrice = 0;
            Goods.sellingPrice = 0;
            Goods.numberOfPurchasedGoods = 0;
            Goods.numberOfGoodsSold = 0;
        }
        public Goods(string goods_name, string prov_name, int purchase_price, int selling_price, int number_purchased, int number_sold)
        {
            this.name = goods_name;
            this.providerName = prov_name;
            Goods.purchasePrice = purchase_price;
            Goods.sellingPrice = selling_price;
            Goods.numberOfPurchasedGoods = number_purchased;
            Goods.numberOfGoodsSold = number_sold;
        }
        public Goods()
        {
            this.name = "";
            this.providerName = "";
            Goods.purchasePrice = 0;
            Goods.sellingPrice = 0;
            Goods.numberOfPurchasedGoods = 0;
            Goods.numberOfGoodsSold = 0;
        }
        public Goods(string name_)
        {
            this.name = name_;
            this.providerName = "";
            Goods.purchasePrice = 0;
            Goods.sellingPrice = 0;
            Goods.numberOfPurchasedGoods = 0;
            Goods.numberOfGoodsSold = 0;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Пожалуйста, введите параметры для товара");
                Console.WriteLine("Имя товара ? ");
                string name_ = Console.ReadLine();
                Console.WriteLine("Имя поставщика ? ");
                string prov_name = Console.ReadLine();
                Console.WriteLine("Стоимость покупки товара за одну единицу ? ");
                int purchase_price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Какое количество закупили ? ");
                int number_purchased = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Стоимость продажи товара за одну единицу ? ");
                int selling_price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Какое количество продали ? ");
                int number_sold = Convert.ToInt32(Console.ReadLine());

                Goods UserGood;
                UserGood = new Goods(name_, prov_name, purchase_price, selling_price, number_purchased, number_sold);
                UserGood.show_information();
                //UserGood.getProfit();
             


            }
        }
    }
}