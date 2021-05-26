using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameQuest.Classes
{
    class NodeController
    {
        public static List<Node> nodeList = new List<Node>();
        TextBox textWindow = Application.OpenForms["MainForm"].Controls["outputTextBox"] as TextBox;
        private Boolean printNextMessage = false;

        public async void nextNode(string node)
        {
            Panel mainPanel = null;
            PictureBox mainPicture = null;
            textWindow.Click += nextMessage_Click;
            Node currentNode = nodeList.Find(x => x.name == node);
            textWindow.Text = "";

            foreach (Control control in Application.OpenForms["MainForm"].Controls)
            {
                if (control is Panel && control.Name == "mainPanel")
                    mainPanel = control as Panel;
                if (control is PictureBox && control.Name == "mainPicture")
                {
                    mainPicture = control as PictureBox;
                    mainPicture.Click += nextMessage_Click;
                }
            }
            mainPanel.Controls.Clear();


                     

            for (int i = 0; i < currentNode.lines.Count; i++)
            {
                textWindow.Text = "";
                if (currentNode.lines[i].image != null)
                    mainPicture.Image = currentNode.lines[i].image;

                await TextTyper.Typer(textWindow, currentNode.lines[i].text);

                while (!printNextMessage)
                {
                    await Task.Delay(10);                    
                }
                printNextMessage = false;
                
            }

            int step = 0;
            foreach (var gate in nodeList.Find(x => x.name == node).gates)
            {
                if (gate.condition != null && !InventoryController.PlayerInventory.Contains(InventoryController.ItemsList.Find(x => x.itmName == gate.condition)))
                {
                    continue;
                }

                Label btn1 = new Label();
                btn1.Location = new System.Drawing.Point(10, 10 + step);
                btn1.Tag = gate.LinkedNode.name;
                btn1.AutoSize = true;                
                btn1.Text = gate.action;                
                step += btn1.Height + 5;
                btn1.Click += nextNode_Click;
                Application.OpenForms["MainForm"].Controls.Add(btn1);
                btn1.Parent = mainPanel;
            }
            
        }

        private void nextMessage_Click(object sender, EventArgs e)
        {
            printNextMessage = true;
        }

        private void nextNode_Click(object sender, EventArgs e)
        {
            nextNode((sender as Label).Tag.ToString());
        }
    }
}
