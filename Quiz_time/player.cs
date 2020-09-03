using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_time
{
    public partial class player : Form
    {
        public player(int ListId)
        {
            InitializeComponent();
            Console.WriteLine(ListId);
        }

        private void display_Load(object sender, EventArgs e)
        {

        }
    }
}
