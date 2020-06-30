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
        private SQLConn SQLConn = new SQLConn();
        public Quiz_time()
        {
            InitializeComponent();
            reload_lsb_quizlist();
            cb_am_nakijken.SelectedIndex = 0;
            cb_am_tijd.SelectedIndex = 0;
            lsb_quizlist.SelectedIndex = 0;
        }
        private void reload_lsb_quizlist() {
            foreach (DataRow dataRow in SQLConn.selectQuery("SELECT `list_id`,`list_name` FROM `list` ORDER BY `list_name` ").Rows)
            {
                lsb_quizlist.Items.Insert(0, new { Name = dataRow.ItemArray[1], Value = dataRow.ItemArray[0] });
            }
        }
        
        private void btn_selectQuiz_Click(object sender, EventArgs e)
        {
            tab_controll.SelectedTab = tab_select;
        }

        private void btn_editQuiz_Click(object sender, EventArgs e)
        {
            tab_controll.SelectedTab = tab_edit;
        }

        private void lsb_quizlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item =  lsb_quizlist.SelectedItem;
            lb_selec_quizNaam_0.Text = item.Name;
            lb_selec_quizNaam_1.Text = item.Name;
            lb_selec_quizNaam_2.Text = item.Name;
        }
    }
}
