using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GameQuest.Classes
{
    class TextTyper
    {
        

        static async public         

        Task
        Typer(TextBox output, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                output.Text += text[i].ToString();                
                output.Refresh();
                await Task.Delay(10);
            }
        }


       
    }
}
