using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_fin
{
    internal class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Ласкаво просимо до Помічника з подарунками!");
            Console.WriteLine("Введіть, будь ласка, кого ви хочете привітати (мама, батько, сестра, брат, друг):");
            string recipient = Console.ReadLine();

            Console.WriteLine("Введіть, будь ласка, свято, на яке потрібно придбати подарунок:");
            Console.WriteLine("( день народження, новий рік(вписувати як нг), день ангела, Хелловін(вписувати як х) )");
            string occasion = Console.ReadLine();

            Console.WriteLine("Введіть, будь ласка, бажану суму для подарунка (наприклад, 1):");
            decimal budget = decimal.Parse(Console.ReadLine());

            List<Products> products = GiftProducts.GetProducts(recipient, occasion);
            List<string> giftIdeas = GiftIdeas.GetGiftIdeas(products, budget);

            Console.WriteLine("Ось список ідей для подарунків:");
            foreach (string gift in giftIdeas)
            {
                Console.WriteLine("- " + gift);
            }

            Console.WriteLine("Дякую за використання Помічника з подарунками. Гарного святкування!");

            Console.ReadLine();
        }
    }
}
