using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Quiz_time
{
    public partial class playerClass
    {
        private SQLConn SQLConn = new SQLConn();
        public string tijdmodus;
        public string nakijkmodus;
        public List<question> questions = new List<question>();
        public playerClass(int listId,string tijdmodus, string nakijkmodus) {
            this.tijdmodus = tijdmodus;
            this.nakijkmodus = nakijkmodus;
            List<string[]> sqlParams = new List<string[]>();
            sqlParams.Add(new string[2] { "@list_id", listId.ToString() });

            DataTable dt = SQLConn.selectQuery("SELECT `question_id`,`list_id`,`question`,`correct`,`a`,`b`,`c`,`d`,`image_src` FROM `questions` WHERE `list_id` = @list_id", sqlParams);
            foreach (DataRow dataRow in dt.Rows)
            {
                questions.Add(new question(dataRow));
            }
        }
    }
    public partial class question {
        public string question_id;
        public string list_id;
        public string playerQuestion;
        public string questionImage;
        public string ans_a;
        public string ans_b;
        public string ans_c;
        public string ans_d;
        public string correct;
        public question(DataRow dataRow) {
            this.question_id = (dataRow.ItemArray[0]).ToString();
            this.playerQuestion = (dataRow.ItemArray[2]).ToString();
            this.correct = (dataRow.ItemArray[3]).ToString();
            this.ans_a = (dataRow.ItemArray[4]).ToString();
            this.ans_b = (dataRow.ItemArray[5]).ToString();
            this.ans_c = (dataRow.ItemArray[6]).ToString();
            this.ans_d = (dataRow.ItemArray[7]).ToString();
            if ((dataRow.ItemArray[8]).ToString() != string.Empty)
            {
                this.questionImage = (dataRow.ItemArray[8]).ToString();
            }
            else { 
                this.questionImage = "C:\\Users\\itsam\\drives\\OneDrive - ROC Midden Nederland\\prjcts\\C#\\Quiz_time\\Quiz_time\\img_default\\question-man.jpg";
            };

        }

    }
}
