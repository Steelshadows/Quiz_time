namespace Quiz_time
{
    partial class Quiz_time
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_controll = new System.Windows.Forms.TabControl();
            this.tab_operator = new System.Windows.Forms.TabPage();
            this.btn_selectQuiz = new System.Windows.Forms.Button();
            this.btn_editQuiz = new System.Windows.Forms.Button();
            this.lb_selec_quizNaam_0 = new System.Windows.Forms.Label();
            this.lb_sel_label = new System.Windows.Forms.Label();
            this.lb_am_afspeelmodus = new System.Windows.Forms.Label();
            this.lb_am_tijd = new System.Windows.Forms.Label();
            this.lb_am_nakijken = new System.Windows.Forms.Label();
            this.cb_am_tijd = new System.Windows.Forms.ComboBox();
            this.cb_am_nakijken = new System.Windows.Forms.ComboBox();
            this.btn_start_quiz = new System.Windows.Forms.Button();
            this.tab_select = new System.Windows.Forms.TabPage();
            this.btn_delete_selected_list = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_new_list = new System.Windows.Forms.Button();
            this.txb_new_list = new System.Windows.Forms.TextBox();
            this.lb_selec_quizNaam_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsb_quizlist = new System.Windows.Forms.ListBox();
            this.tab_edit = new System.Windows.Forms.TabPage();
            this.btn_update_question = new System.Windows.Forms.Button();
            this.txb_ans_d = new System.Windows.Forms.TextBox();
            this.txb_ans_c = new System.Windows.Forms.TextBox();
            this.txb_ans_b = new System.Windows.Forms.TextBox();
            this.txb_ans_a = new System.Windows.Forms.TextBox();
            this.txb_update_question = new System.Windows.Forms.TextBox();
            this.rb_ans_d = new System.Windows.Forms.RadioButton();
            this.rb_ans_c = new System.Windows.Forms.RadioButton();
            this.rb_ans_b = new System.Windows.Forms.RadioButton();
            this.rb_ans_a = new System.Windows.Forms.RadioButton();
            this.btn_new_question = new System.Windows.Forms.Button();
            this.lsb_question_select = new System.Windows.Forms.ListBox();
            this.lb_selec_quizNaam_2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_controll.SuspendLayout();
            this.tab_operator.SuspendLayout();
            this.tab_select.SuspendLayout();
            this.tab_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_controll
            // 
            this.tab_controll.Controls.Add(this.tab_operator);
            this.tab_controll.Controls.Add(this.tab_select);
            this.tab_controll.Controls.Add(this.tab_edit);
            this.tab_controll.Location = new System.Drawing.Point(0, 0);
            this.tab_controll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_controll.Name = "tab_controll";
            this.tab_controll.SelectedIndex = 0;
            this.tab_controll.Size = new System.Drawing.Size(797, 450);
            this.tab_controll.TabIndex = 0;
            // 
            // tab_operator
            // 
            this.tab_operator.Controls.Add(this.btn_selectQuiz);
            this.tab_operator.Controls.Add(this.btn_editQuiz);
            this.tab_operator.Controls.Add(this.lb_selec_quizNaam_0);
            this.tab_operator.Controls.Add(this.lb_sel_label);
            this.tab_operator.Controls.Add(this.lb_am_afspeelmodus);
            this.tab_operator.Controls.Add(this.lb_am_tijd);
            this.tab_operator.Controls.Add(this.lb_am_nakijken);
            this.tab_operator.Controls.Add(this.cb_am_tijd);
            this.tab_operator.Controls.Add(this.cb_am_nakijken);
            this.tab_operator.Controls.Add(this.btn_start_quiz);
            this.tab_operator.Location = new System.Drawing.Point(4, 25);
            this.tab_operator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_operator.Name = "tab_operator";
            this.tab_operator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_operator.Size = new System.Drawing.Size(789, 421);
            this.tab_operator.TabIndex = 0;
            this.tab_operator.Text = "operator";
            this.tab_operator.UseVisualStyleBackColor = true;
            // 
            // btn_selectQuiz
            // 
            this.btn_selectQuiz.Location = new System.Drawing.Point(19, 71);
            this.btn_selectQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_selectQuiz.Name = "btn_selectQuiz";
            this.btn_selectQuiz.Size = new System.Drawing.Size(181, 71);
            this.btn_selectQuiz.TabIndex = 19;
            this.btn_selectQuiz.Text = "selecteer andere quiz";
            this.btn_selectQuiz.UseVisualStyleBackColor = true;
            this.btn_selectQuiz.Click += new System.EventHandler(this.btn_selectQuiz_Click);
            // 
            // btn_editQuiz
            // 
            this.btn_editQuiz.Location = new System.Drawing.Point(19, 167);
            this.btn_editQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editQuiz.Name = "btn_editQuiz";
            this.btn_editQuiz.Size = new System.Drawing.Size(181, 71);
            this.btn_editQuiz.TabIndex = 18;
            this.btn_editQuiz.Text = "verander quiz";
            this.btn_editQuiz.UseVisualStyleBackColor = true;
            this.btn_editQuiz.Click += new System.EventHandler(this.btn_editQuiz_Click);
            // 
            // lb_selec_quizNaam_0
            // 
            this.lb_selec_quizNaam_0.AutoSize = true;
            this.lb_selec_quizNaam_0.Location = new System.Drawing.Point(3, 34);
            this.lb_selec_quizNaam_0.Name = "lb_selec_quizNaam_0";
            this.lb_selec_quizNaam_0.Size = new System.Drawing.Size(89, 17);
            this.lb_selec_quizNaam_0.TabIndex = 17;
            this.lb_selec_quizNaam_0.Text = "[ quiz naam ]";
            // 
            // lb_sel_label
            // 
            this.lb_sel_label.AutoSize = true;
            this.lb_sel_label.Location = new System.Drawing.Point(3, 2);
            this.lb_sel_label.Name = "lb_sel_label";
            this.lb_sel_label.Size = new System.Drawing.Size(135, 17);
            this.lb_sel_label.TabIndex = 16;
            this.lb_sel_label.Text = "geselecteerde Quiz:";
            // 
            // lb_am_afspeelmodus
            // 
            this.lb_am_afspeelmodus.AutoSize = true;
            this.lb_am_afspeelmodus.Location = new System.Drawing.Point(632, 7);
            this.lb_am_afspeelmodus.Name = "lb_am_afspeelmodus";
            this.lb_am_afspeelmodus.Size = new System.Drawing.Size(104, 17);
            this.lb_am_afspeelmodus.TabIndex = 15;
            this.lb_am_afspeelmodus.Text = "afspeel modus:";
            // 
            // lb_am_tijd
            // 
            this.lb_am_tijd.AutoSize = true;
            this.lb_am_tijd.Location = new System.Drawing.Point(531, 119);
            this.lb_am_tijd.Name = "lb_am_tijd";
            this.lb_am_tijd.Size = new System.Drawing.Size(75, 17);
            this.lb_am_tijd.TabIndex = 14;
            this.lb_am_tijd.Text = "progressie";
            // 
            // lb_am_nakijken
            // 
            this.lb_am_nakijken.AutoSize = true;
            this.lb_am_nakijken.Location = new System.Drawing.Point(531, 49);
            this.lb_am_nakijken.Name = "lb_am_nakijken";
            this.lb_am_nakijken.Size = new System.Drawing.Size(60, 17);
            this.lb_am_nakijken.TabIndex = 13;
            this.lb_am_nakijken.Text = "nakijken";
            // 
            // cb_am_tijd
            // 
            this.cb_am_tijd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_am_tijd.FormattingEnabled = true;
            this.cb_am_tijd.Items.AddRange(new object[] {
            "10 seconden",
            "click"});
            this.cb_am_tijd.Location = new System.Drawing.Point(635, 119);
            this.cb_am_tijd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_am_tijd.Name = "cb_am_tijd";
            this.cb_am_tijd.Size = new System.Drawing.Size(139, 24);
            this.cb_am_tijd.TabIndex = 12;
            // 
            // cb_am_nakijken
            // 
            this.cb_am_nakijken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_am_nakijken.Items.AddRange(new object[] {
            "check vraag",
            "check lijst",
            "no check"});
            this.cb_am_nakijken.Location = new System.Drawing.Point(635, 49);
            this.cb_am_nakijken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_am_nakijken.Name = "cb_am_nakijken";
            this.cb_am_nakijken.Size = new System.Drawing.Size(139, 24);
            this.cb_am_nakijken.TabIndex = 11;
            // 
            // btn_start_quiz
            // 
            this.btn_start_quiz.Location = new System.Drawing.Point(592, 342);
            this.btn_start_quiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start_quiz.Name = "btn_start_quiz";
            this.btn_start_quiz.Size = new System.Drawing.Size(181, 71);
            this.btn_start_quiz.TabIndex = 10;
            this.btn_start_quiz.Text = "start quiz";
            this.btn_start_quiz.UseVisualStyleBackColor = true;
            this.btn_start_quiz.Click += new System.EventHandler(this.btn_start_quiz_Click);
            // 
            // tab_select
            // 
            this.tab_select.Controls.Add(this.btn_delete_selected_list);
            this.tab_select.Controls.Add(this.label1);
            this.tab_select.Controls.Add(this.btn_new_list);
            this.tab_select.Controls.Add(this.txb_new_list);
            this.tab_select.Controls.Add(this.lb_selec_quizNaam_1);
            this.tab_select.Controls.Add(this.label2);
            this.tab_select.Controls.Add(this.lsb_quizlist);
            this.tab_select.Location = new System.Drawing.Point(4, 25);
            this.tab_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_select.Name = "tab_select";
            this.tab_select.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_select.Size = new System.Drawing.Size(789, 421);
            this.tab_select.TabIndex = 1;
            this.tab_select.Text = "select quiz";
            this.tab_select.UseVisualStyleBackColor = true;
            // 
            // btn_delete_selected_list
            // 
            this.btn_delete_selected_list.Location = new System.Drawing.Point(596, 363);
            this.btn_delete_selected_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete_selected_list.Name = "btn_delete_selected_list";
            this.btn_delete_selected_list.Size = new System.Drawing.Size(151, 47);
            this.btn_delete_selected_list.TabIndex = 23;
            this.btn_delete_selected_list.Text = "verweider geselecteerde lijst";
            this.btn_delete_selected_list.UseVisualStyleBackColor = true;
            this.btn_delete_selected_list.Click += new System.EventHandler(this.btn_delete_selected_list_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "nieuwe lijst naam:";
            // 
            // btn_new_list
            // 
            this.btn_new_list.Location = new System.Drawing.Point(615, 70);
            this.btn_new_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_new_list.Name = "btn_new_list";
            this.btn_new_list.Size = new System.Drawing.Size(132, 30);
            this.btn_new_list.TabIndex = 21;
            this.btn_new_list.Text = "maak nieuwe lijst";
            this.btn_new_list.UseVisualStyleBackColor = true;
            this.btn_new_list.Click += new System.EventHandler(this.btn_new_list_Click);
            // 
            // txb_new_list
            // 
            this.txb_new_list.Location = new System.Drawing.Point(247, 34);
            this.txb_new_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_new_list.Name = "txb_new_list";
            this.txb_new_list.Size = new System.Drawing.Size(500, 22);
            this.txb_new_list.TabIndex = 20;
            // 
            // lb_selec_quizNaam_1
            // 
            this.lb_selec_quizNaam_1.AutoSize = true;
            this.lb_selec_quizNaam_1.Location = new System.Drawing.Point(3, 34);
            this.lb_selec_quizNaam_1.Name = "lb_selec_quizNaam_1";
            this.lb_selec_quizNaam_1.Size = new System.Drawing.Size(89, 17);
            this.lb_selec_quizNaam_1.TabIndex = 19;
            this.lb_selec_quizNaam_1.Text = "[ quiz naam ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "geselecteerde Quiz:";
            // 
            // lsb_quizlist
            // 
            this.lsb_quizlist.DisplayMember = "Name";
            this.lsb_quizlist.FormattingEnabled = true;
            this.lsb_quizlist.ItemHeight = 16;
            this.lsb_quizlist.Items.AddRange(new object[] {
            ""});
            this.lsb_quizlist.Location = new System.Drawing.Point(8, 70);
            this.lsb_quizlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsb_quizlist.Name = "lsb_quizlist";
            this.lsb_quizlist.Size = new System.Drawing.Size(153, 340);
            this.lsb_quizlist.TabIndex = 0;
            this.lsb_quizlist.ValueMember = "Value";
            this.lsb_quizlist.SelectedIndexChanged += new System.EventHandler(this.lsb_quizlist_SelectedIndexChanged);
            // 
            // tab_edit
            // 
            this.tab_edit.Controls.Add(this.btn_update_question);
            this.tab_edit.Controls.Add(this.txb_ans_d);
            this.tab_edit.Controls.Add(this.txb_ans_c);
            this.tab_edit.Controls.Add(this.txb_ans_b);
            this.tab_edit.Controls.Add(this.txb_ans_a);
            this.tab_edit.Controls.Add(this.txb_update_question);
            this.tab_edit.Controls.Add(this.rb_ans_d);
            this.tab_edit.Controls.Add(this.rb_ans_c);
            this.tab_edit.Controls.Add(this.rb_ans_b);
            this.tab_edit.Controls.Add(this.rb_ans_a);
            this.tab_edit.Controls.Add(this.btn_new_question);
            this.tab_edit.Controls.Add(this.lsb_question_select);
            this.tab_edit.Controls.Add(this.lb_selec_quizNaam_2);
            this.tab_edit.Controls.Add(this.label4);
            this.tab_edit.Location = new System.Drawing.Point(4, 25);
            this.tab_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_edit.Name = "tab_edit";
            this.tab_edit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_edit.Size = new System.Drawing.Size(789, 421);
            this.tab_edit.TabIndex = 2;
            this.tab_edit.Text = "edit quiz";
            this.tab_edit.UseVisualStyleBackColor = true;
            // 
            // btn_update_question
            // 
            this.btn_update_question.Location = new System.Drawing.Point(600, 350);
            this.btn_update_question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update_question.Name = "btn_update_question";
            this.btn_update_question.Size = new System.Drawing.Size(171, 62);
            this.btn_update_question.TabIndex = 33;
            this.btn_update_question.Text = "opslaan";
            this.btn_update_question.UseVisualStyleBackColor = true;
            this.btn_update_question.Click += new System.EventHandler(this.btn_update_question_Click);
            // 
            // txb_ans_d
            // 
            this.txb_ans_d.Location = new System.Drawing.Point(513, 247);
            this.txb_ans_d.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ans_d.Multiline = true;
            this.txb_ans_d.Name = "txb_ans_d";
            this.txb_ans_d.Size = new System.Drawing.Size(205, 91);
            this.txb_ans_d.TabIndex = 32;
            // 
            // txb_ans_c
            // 
            this.txb_ans_c.Location = new System.Drawing.Point(209, 247);
            this.txb_ans_c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ans_c.Multiline = true;
            this.txb_ans_c.Name = "txb_ans_c";
            this.txb_ans_c.Size = new System.Drawing.Size(205, 91);
            this.txb_ans_c.TabIndex = 31;
            // 
            // txb_ans_b
            // 
            this.txb_ans_b.Location = new System.Drawing.Point(513, 119);
            this.txb_ans_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ans_b.Multiline = true;
            this.txb_ans_b.Name = "txb_ans_b";
            this.txb_ans_b.Size = new System.Drawing.Size(205, 91);
            this.txb_ans_b.TabIndex = 30;
            // 
            // txb_ans_a
            // 
            this.txb_ans_a.Location = new System.Drawing.Point(209, 119);
            this.txb_ans_a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ans_a.Multiline = true;
            this.txb_ans_a.Name = "txb_ans_a";
            this.txb_ans_a.Size = new System.Drawing.Size(205, 91);
            this.txb_ans_a.TabIndex = 29;
            // 
            // txb_update_question
            // 
            this.txb_update_question.Location = new System.Drawing.Point(209, 34);
            this.txb_update_question.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_update_question.Name = "txb_update_question";
            this.txb_update_question.Size = new System.Drawing.Size(561, 22);
            this.txb_update_question.TabIndex = 28;
            // 
            // rb_ans_d
            // 
            this.rb_ans_d.AutoSize = true;
            this.rb_ans_d.Location = new System.Drawing.Point(563, 220);
            this.rb_ans_d.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ans_d.Name = "rb_ans_d";
            this.rb_ans_d.Size = new System.Drawing.Size(101, 21);
            this.rb_ans_d.TabIndex = 27;
            this.rb_ans_d.TabStop = true;
            this.rb_ans_d.Text = "antwoord D";
            this.rb_ans_d.UseVisualStyleBackColor = true;
            // 
            // rb_ans_c
            // 
            this.rb_ans_c.AutoSize = true;
            this.rb_ans_c.Location = new System.Drawing.Point(251, 220);
            this.rb_ans_c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ans_c.Name = "rb_ans_c";
            this.rb_ans_c.Size = new System.Drawing.Size(100, 21);
            this.rb_ans_c.TabIndex = 26;
            this.rb_ans_c.TabStop = true;
            this.rb_ans_c.Text = "antwoord C";
            this.rb_ans_c.UseVisualStyleBackColor = true;
            // 
            // rb_ans_b
            // 
            this.rb_ans_b.AutoSize = true;
            this.rb_ans_b.Location = new System.Drawing.Point(563, 92);
            this.rb_ans_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ans_b.Name = "rb_ans_b";
            this.rb_ans_b.Size = new System.Drawing.Size(100, 21);
            this.rb_ans_b.TabIndex = 25;
            this.rb_ans_b.Text = "antwoord B";
            this.rb_ans_b.UseVisualStyleBackColor = true;
            // 
            // rb_ans_a
            // 
            this.rb_ans_a.AutoSize = true;
            this.rb_ans_a.Location = new System.Drawing.Point(251, 92);
            this.rb_ans_a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ans_a.Name = "rb_ans_a";
            this.rb_ans_a.Size = new System.Drawing.Size(100, 21);
            this.rb_ans_a.TabIndex = 24;
            this.rb_ans_a.TabStop = true;
            this.rb_ans_a.Text = "antwoord A";
            this.rb_ans_a.UseVisualStyleBackColor = true;
            // 
            // btn_new_question
            // 
            this.btn_new_question.Location = new System.Drawing.Point(7, 384);
            this.btn_new_question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_new_question.Name = "btn_new_question";
            this.btn_new_question.Size = new System.Drawing.Size(156, 28);
            this.btn_new_question.TabIndex = 23;
            this.btn_new_question.Text = "nieuwe vraag";
            this.btn_new_question.UseVisualStyleBackColor = true;
            this.btn_new_question.Click += new System.EventHandler(this.btn_new_question_Click);
            // 
            // lsb_question_select
            // 
            this.lsb_question_select.DisplayMember = "Name";
            this.lsb_question_select.FormattingEnabled = true;
            this.lsb_question_select.ItemHeight = 16;
            this.lsb_question_select.Items.AddRange(new object[] {
            ""});
            this.lsb_question_select.Location = new System.Drawing.Point(8, 70);
            this.lsb_question_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsb_question_select.Name = "lsb_question_select";
            this.lsb_question_select.Size = new System.Drawing.Size(153, 308);
            this.lsb_question_select.TabIndex = 22;
            this.lsb_question_select.ValueMember = "Value";
            this.lsb_question_select.SelectedIndexChanged += new System.EventHandler(this.lsb_question_select_SelectedIndexChanged);
            // 
            // lb_selec_quizNaam_2
            // 
            this.lb_selec_quizNaam_2.AutoSize = true;
            this.lb_selec_quizNaam_2.Location = new System.Drawing.Point(3, 34);
            this.lb_selec_quizNaam_2.Name = "lb_selec_quizNaam_2";
            this.lb_selec_quizNaam_2.Size = new System.Drawing.Size(89, 17);
            this.lb_selec_quizNaam_2.TabIndex = 21;
            this.lb_selec_quizNaam_2.Text = "[ quiz naam ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "geselecteerde Quiz:";
            // 
            // Quiz_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_controll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Quiz_time";
            this.Text = "Quiz time";
            this.tab_controll.ResumeLayout(false);
            this.tab_operator.ResumeLayout(false);
            this.tab_operator.PerformLayout();
            this.tab_select.ResumeLayout(false);
            this.tab_select.PerformLayout();
            this.tab_edit.ResumeLayout(false);
            this.tab_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tab_controll;
        public System.Windows.Forms.TabPage tab_operator;
        public System.Windows.Forms.Button btn_selectQuiz;
        public System.Windows.Forms.Button btn_editQuiz;
        public System.Windows.Forms.Label lb_selec_quizNaam_0;
        public System.Windows.Forms.Label lb_sel_label;
        public System.Windows.Forms.Label lb_am_afspeelmodus;
        public System.Windows.Forms.Label lb_am_tijd;
        public System.Windows.Forms.Label lb_am_nakijken;
        public System.Windows.Forms.ComboBox cb_am_tijd;
        public System.Windows.Forms.ComboBox cb_am_nakijken;
        public System.Windows.Forms.Button btn_start_quiz;
        public System.Windows.Forms.TabPage tab_select;
        public System.Windows.Forms.TabPage tab_edit;
        public System.Windows.Forms.ListBox lsb_quizlist;
        public System.Windows.Forms.Label lb_selec_quizNaam_1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_selec_quizNaam_2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox lsb_question_select;
        private System.Windows.Forms.Button btn_new_question;
        private System.Windows.Forms.Button btn_new_list;
        private System.Windows.Forms.TextBox txb_new_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete_selected_list;
        private System.Windows.Forms.TextBox txb_ans_d;
        private System.Windows.Forms.TextBox txb_ans_c;
        private System.Windows.Forms.TextBox txb_ans_b;
        private System.Windows.Forms.TextBox txb_ans_a;
        private System.Windows.Forms.TextBox txb_update_question;
        private System.Windows.Forms.RadioButton rb_ans_d;
        private System.Windows.Forms.RadioButton rb_ans_c;
        private System.Windows.Forms.RadioButton rb_ans_b;
        private System.Windows.Forms.RadioButton rb_ans_a;
        private System.Windows.Forms.Button btn_update_question;
    }
}

