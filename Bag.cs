using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Bag
    {
        private readonly int maxCapacity;
        private Item[] items;
        private int fillAmount;

        public Bag(int capacity)
        {
            maxCapacity = capacity;
            items = new Item[maxCapacity];
        }

        public void AddItem(Item i)
        {
            if (fillAmount < maxCapacity)
            {
                items[fillAmount] = i;
                fillAmount++;
                Console.WriteLine($"Предмет {i.Name} был успешно добавить");
            }
            else
            {
                Console.WriteLine($"Предмет {i.Name} не помещается");
            }
            Console.WriteLine();
        }

        public void GetItemNameInBag()
        {
            Console.Write("В рюкзаке находится следующие предметы - ");

            foreach (Item i in items)
            {
                if (i != null)
                {
                    Console.Write($"{i.Name}, ");
                }
            }
            Console.WriteLine();
        }
    }
}
