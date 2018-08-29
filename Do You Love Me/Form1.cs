using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_You_Love_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button btn2 = (Button)sender;
            int[] bound = ChangeSize(btn2);
            btn2.SetBounds(bound[0], bound[1], btn2.Width, btn2.Height);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int[] ChangeSize(Button btn)
        {
            Random r = new Random();
            int x = r.Next(0, this.ClientSize.Width - btn.Size.Width);
            int y = r.Next(0, this.ClientSize.Height - btn.Size.Height);
            int[] bound = new int[2] { x, y };
            return bound;
        }
    }
}
