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
        public dynamic selectedList;
        public dynamic selectedQuestion;
        public Quiz_time()
        {
            InitializeComponent();
            reload_Operator();
            cb_am_nakijken.SelectedIndex = 0;
            cb_am_tijd.SelectedIndex = 0;            
            lsb_quizlist.SelectedIndex = 0;
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
            selectedList = item;
            Console.WriteLine(selectedList);
            lb_selec_quizNaam_0.Text = item.Name;
            lb_selec_quizNaam_1.Text = item.Name;
            lb_selec_quizNaam_2.Text = item.Name;
            reload_lsb_question_select();

        }
        
        public void reload_Operator()
        {
            reload_lsb_quizlist();
            //reload_lsb_question_select();
        }
        public void reload_lsb_quizlist()
        {
            lsb_quizlist.Items.Clear();
            DataTable dt = SQLConn.selectQuery("SELECT `list_id`,`list_name` FROM `list` ORDER BY `list_name` ");
            foreach (DataRow dataRow in dt.Rows)
            {
                lsb_quizlist.Items.Insert(0, new { Name = dataRow.ItemArray[1], Value = dataRow.ItemArray[0] });
            }
        }
        public void reload_lsb_question_select()
        {
            
            lsb_question_select.Items.Clear();
            List<string[]> sqlParams = new List<string[]>();
            //Console.WriteLine(selectedList);
            //sqlParams.Add( new string[2] { "@list_id", "3" });
            int listId = selectedList.Value;
            sqlParams.Add(new string[2] { "@list_id", listId.ToString() }) ;
            
            DataTable dt = SQLConn.selectQuery("SELECT `question_id`,`list_id`,`question`,`correct`,`a`,`b`,`c`,`d` FROM `questions` WHERE `list_id` = @list_id", sqlParams);
            foreach (DataRow dataRow in dt.Rows)
            {
                //lsb_question_select.Items.Insert(0, new { Name = dataRow.ItemArray[2], Value = dataRow.ItemArray[0] });
                lsb_question_select.Items.Insert(0, new { Name = dataRow.ItemArray[2], Question_id = dataRow.ItemArray[0], Question = dataRow.ItemArray[2], correct = dataRow.ItemArray[3], a = dataRow.ItemArray[4], b = dataRow.ItemArray[5], c = dataRow.ItemArray[6], d = dataRow.ItemArray[7] });
            }
        }

        private void btn_new_question_Click(object sender, EventArgs e)
        {
            lsb_question_select.Items.Insert(lsb_question_select.Items.Count, new { Name = "nieuwe vraag", Question_id = "new", Question="nieuwe vraag",correct="a" ,a="" ,b="" ,c="" ,d="" });
            
        }

        private void btn_new_list_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `list`(`list_name`) VALUES(@list_name)";
            List<string[]> sqlParams = new List<string[]>();
            sqlParams.Add(new string[2] { "@list_name", txb_new_list.Text });
            SQLConn.executeQuery(insertQuery,sqlParams);
            reload_lsb_quizlist();
        }

        private void btn_delete_selected_list_Click(object sender, EventArgs e)
        {
            string deleteQuery1 = "DELETE FROM `list` WHERE `list_id` = @list_id";
            string deleteQuery2 = "DELETE FROM `questions` WHERE `list_id` = @list_id";
            List<string[]> sqlParams = new List<string[]>();
            int listId = selectedList.Value;
            sqlParams.Add(new string[2] { "@list_id", listId.ToString() });
            SQLConn.executeQuery(deleteQuery1, sqlParams);
            SQLConn.executeQuery(deleteQuery2, sqlParams);
            reload_Operator();
        }

        private void lsb_question_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = lsb_question_select.SelectedItem;
            selectedList = item;
            Console.WriteLine(item);
            selectedQuestion = item;
        }
    }
}
