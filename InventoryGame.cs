using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class InventoryGame
    {
        private Item[] items;

        public InventoryGame()
        {
            RunGame();
        }

        private void RunGame()
        {
            Bag b;
            
            b = new Bag(3);
            items = new Item[5];
            items[0] = new Item("Яблоко");
            items[1] = new Item("Тетрадь");
            items[2] = new Item("Учебник");
            items[3] = new Item("Карандаш");
            items[4] = new Item("Вода");
            Console.WriteLine("Предметы:");
            foreach (Item i in items)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();

            String input = null;
            while (input != "Exit")
               {
                Console.WriteLine("Какой предмет добавить в рюкзак?");
                Console.WriteLine("Введите Предметы для получения всех предметов в инвенторе");

                input = Console.ReadLine();

                if (input == "Предметы")
                {
                    b.GetItemNameInBag();
                }
                else
                {
                    if (GetItemByName(input) != null)
                    {
                        b.AddItem(GetItemByName(input));
                    }
                }
            }
        }


        private Item GetItemByName(string name)
        {
            foreach (Item i in items)
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            Console.WriteLine("Предмета с заданным именем не существует");
            return null;
        }
    }
}
