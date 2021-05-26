using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameQuest.Classes;

namespace GameQuest.Classes
{
    class Node
    {
        public string name { get; }

        public List<linesStruct> lines = new List<linesStruct>();
        public List<gatesStruct> gates = new List<gatesStruct>();

        public Node(string nodeName)
        {
            name = nodeName;
            NodeController.nodeList.Add(this);
        }

        /// <summary>
        /// Структура строки текста
        /// </summary>
        public struct linesStruct
        {
            public linesStruct(string txt, Image img)
            {
                text = txt;
                if (img != null)
                    image = img;
                else image = null;
            }

            public string text { get; }
            public Image image { get; }
        }

        /// <summary>
        /// Структура связи нода
        /// </summary>
        public struct gatesStruct
        {
            public gatesStruct(Node node, string act, string condition = null, string reward = null)
            {
                LinkedNode = node;
                action = act;
                this.condition = condition;
                InventoryController.PlayerInventory.Add(InventoryController.ItemsList.Find(x => x.itmName == reward));
            }

            public Node LinkedNode { get; }
            public string action { get; }
            public string condition { get; }
            
        }

        /// <summary>
        /// Добавить новую строку текста и рисунок, если нужно.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="img"></param>
        public void addLine(string text, Image img = null)
        {
            lines.Add(new linesStruct(text, img));
        }

        /// <summary>
        /// Добавить связь с нодами по окончанию текущего
        /// Указывается название действия (текст на кнопке)
        /// Условие, если требуется
        /// Награда, если требуется
        /// </summary>
        /// <param name="node"></param>
        /// <param name="action"></param>
        /// <param name="conditionItem"></param>
        /// <param name="rewardItem"></param>
        public void addLink(Node node, string action, string conditionItem = null, string rewardItem = null)
        {
            gates.Add(new gatesStruct(node, action, conditionItem, rewardItem));
        }
    }
}
