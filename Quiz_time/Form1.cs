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
    public partial class Quiz_time : Form
    {
        public Quiz_time()
        {
            InitializeComponent();
            cb_am_nakijken.SelectedIndex = 0;
            cb_am_tijd.SelectedIndex = 0;
        }

        private void btn_selectQuiz_Click(object sender, EventArgs e)
        {
            tab_controll.SelectedTab = tab_select;
        }

        private void btn_editQuiz_Click(object sender, EventArgs e)
        {
            tab_controll.SelectedTab = tab_edit;
        }
    }
}
