using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_fin
{
    public class GiftIdeas
    {
        public static List<string> GetGiftIdeas(List<Products> products, decimal budget)
        {
            List<string> giftIdeas = new List<string>();

            foreach (Products product in products)
            {
                if (product.Price <= budget)
                {
                    giftIdeas.Add(product.Name);
                }
            }

            return giftIdeas;
        }
    }
}
