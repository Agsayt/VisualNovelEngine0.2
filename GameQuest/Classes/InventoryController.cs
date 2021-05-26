using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuest.Classes
{
    class InventoryController
    {
        public static List<Item> PlayerInventory = new List<Item>();
        public static List<Item> ItemsList = new List<Item>();

        public struct Item
        {
            public Item(string itemName, Image itemImage = null)
            {
                itmName = itemName;
                itmImage = itemImage;
            }

            public string itmName { get; }
            public Image itmImage { get; }
        }

        public void addNewItem(string itemName, Image itemImage = null)
        {
            ItemsList.Add(new Item(itemName, itemImage));
        }

        public void addToInventory(Item item)
        {
            PlayerInventory.Add(item);

        }

        public void removeFromInventory(Item item)
        {
            PlayerInventory.Remove(item);
        }
    }
}
