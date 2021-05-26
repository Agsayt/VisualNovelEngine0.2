using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuest.Classes
{
    /// <summary>
    /// Прототип системы инвентаря
    /// </summary>
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

        /// <summary>
        /// Добавить новую вещь в систему
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="itemImage"></param>
        public void addNewItem(string itemName, Image itemImage = null)
        {
            ItemsList.Add(new Item(itemName, itemImage));
        }

        /// <summary>
        /// Добавить новую вещь в инвентарь игрока
        /// </summary>
        /// <param name="item"></param>
        public void addToInventory(Item item)
        {
            PlayerInventory.Add(item);

        }

        /// <summary>
        /// Удалить вещь из инвентаря игрока
        /// </summary>
        /// <param name="item"></param>
        public void removeFromInventory(Item item)
        {
            PlayerInventory.Remove(item);
        }
    }
}
