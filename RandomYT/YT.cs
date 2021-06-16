using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomYT
{
    public partial class YT : Form
    {
        public YT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] base64 = new string[]{"A","B","C","D","E","F","G","H","I","J",
            "K","L","M","N","O","P","Q","R","S","T",
            "U","V","W","X","Y","Z","a","b","c","d",
            "e","f","g","h","i","j","k","l","m","n",
            "o","p","q","r","s","t","u","v","w","x",
            "y","z","1","2","3","4","5","6","7","8",
            "9","0","-","_"};

            string videoURL = "https://www.youtube.com/watch?v=";
            Random random = new Random();

            for(int i = 0;i<11;i++)
            {
                int randomPick = random.Next(0, base64.Length);
                videoURL = videoURL + base64[randomPick];
            }

            textBox1.Text = videoURL;
        }
    }
}
