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
            this.lb_selec_quizNaam = new System.Windows.Forms.Label();
            this.lb_sel_label = new System.Windows.Forms.Label();
            this.lb_am_afspeelmodus = new System.Windows.Forms.Label();
            this.lb_am_tijd = new System.Windows.Forms.Label();
            this.lb_am_nakijken = new System.Windows.Forms.Label();
            this.cb_am_tijd = new System.Windows.Forms.ComboBox();
            this.cb_am_nakijken = new System.Windows.Forms.ComboBox();
            this.btn_start_quiz = new System.Windows.Forms.Button();
            this.tab_select = new System.Windows.Forms.TabPage();
            this.tab_edit = new System.Windows.Forms.TabPage();
            this.tab_controll.SuspendLayout();
            this.tab_operator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_controll
            // 
            this.tab_controll.Controls.Add(this.tab_operator);
            this.tab_controll.Controls.Add(this.tab_select);
            this.tab_controll.Controls.Add(this.tab_edit);
            this.tab_controll.Location = new System.Drawing.Point(0, 0);
            this.tab_controll.Name = "tab_controll";
            this.tab_controll.SelectedIndex = 0;
            this.tab_controll.Size = new System.Drawing.Size(798, 450);
            this.tab_controll.TabIndex = 0;
            // 
            // tab_operator
            // 
            this.tab_operator.Controls.Add(this.btn_selectQuiz);
            this.tab_operator.Controls.Add(this.btn_editQuiz);
            this.tab_operator.Controls.Add(this.lb_selec_quizNaam);
            this.tab_operator.Controls.Add(this.lb_sel_label);
            this.tab_operator.Controls.Add(this.lb_am_afspeelmodus);
            this.tab_operator.Controls.Add(this.lb_am_tijd);
            this.tab_operator.Controls.Add(this.lb_am_nakijken);
            this.tab_operator.Controls.Add(this.cb_am_tijd);
            this.tab_operator.Controls.Add(this.cb_am_nakijken);
            this.tab_operator.Controls.Add(this.btn_start_quiz);
            this.tab_operator.Location = new System.Drawing.Point(4, 25);
            this.tab_operator.Name = "tab_operator";
            this.tab_operator.Padding = new System.Windows.Forms.Padding(3);
            this.tab_operator.Size = new System.Drawing.Size(790, 421);
            this.tab_operator.TabIndex = 0;
            this.tab_operator.Text = "operator";
            this.tab_operator.UseVisualStyleBackColor = true;
            // 
            // btn_selectQuiz
            // 
            this.btn_selectQuiz.Location = new System.Drawing.Point(19, 72);
            this.btn_selectQuiz.Name = "btn_selectQuiz";
            this.btn_selectQuiz.Size = new System.Drawing.Size(182, 71);
            this.btn_selectQuiz.TabIndex = 19;
            this.btn_selectQuiz.Text = "selecteer andere quiz";
            this.btn_selectQuiz.UseVisualStyleBackColor = true;
            this.btn_selectQuiz.Click += new System.EventHandler(this.btn_selectQuiz_Click);
            // 
            // btn_editQuiz
            // 
            this.btn_editQuiz.Location = new System.Drawing.Point(19, 167);
            this.btn_editQuiz.Name = "btn_editQuiz";
            this.btn_editQuiz.Size = new System.Drawing.Size(182, 71);
            this.btn_editQuiz.TabIndex = 18;
            this.btn_editQuiz.Text = "verander quiz";
            this.btn_editQuiz.UseVisualStyleBackColor = true;
            this.btn_editQuiz.Click += new System.EventHandler(this.btn_editQuiz_Click);
            // 
            // lb_selec_quizNaam
            // 
            this.lb_selec_quizNaam.AutoSize = true;
            this.lb_selec_quizNaam.Location = new System.Drawing.Point(16, 39);
            this.lb_selec_quizNaam.Name = "lb_selec_quizNaam";
            this.lb_selec_quizNaam.Size = new System.Drawing.Size(89, 17);
            this.lb_selec_quizNaam.TabIndex = 17;
            this.lb_selec_quizNaam.Text = "[ quiz naam ]";
            // 
            // lb_sel_label
            // 
            this.lb_sel_label.AutoSize = true;
            this.lb_sel_label.Location = new System.Drawing.Point(16, 7);
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
            this.lb_am_tijd.Location = new System.Drawing.Point(530, 119);
            this.lb_am_tijd.Name = "lb_am_tijd";
            this.lb_am_tijd.Size = new System.Drawing.Size(75, 17);
            this.lb_am_tijd.TabIndex = 14;
            this.lb_am_tijd.Text = "progressie";
            // 
            // lb_am_nakijken
            // 
            this.lb_am_nakijken.AutoSize = true;
            this.lb_am_nakijken.Location = new System.Drawing.Point(530, 49);
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
            this.cb_am_nakijken.Name = "cb_am_nakijken";
            this.cb_am_nakijken.Size = new System.Drawing.Size(139, 24);
            this.cb_am_nakijken.TabIndex = 11;
            // 
            // btn_start_quiz
            // 
            this.btn_start_quiz.Location = new System.Drawing.Point(592, 342);
            this.btn_start_quiz.Name = "btn_start_quiz";
            this.btn_start_quiz.Size = new System.Drawing.Size(182, 71);
            this.btn_start_quiz.TabIndex = 10;
            this.btn_start_quiz.Text = "start quiz";
            this.btn_start_quiz.UseVisualStyleBackColor = true;
            // 
            // tab_select
            // 
            this.tab_select.Location = new System.Drawing.Point(4, 25);
            this.tab_select.Name = "tab_select";
            this.tab_select.Padding = new System.Windows.Forms.Padding(3);
            this.tab_select.Size = new System.Drawing.Size(790, 421);
            this.tab_select.TabIndex = 1;
            this.tab_select.Text = "select quiz";
            this.tab_select.UseVisualStyleBackColor = true;
            // 
            // tab_edit
            // 
            this.tab_edit.Location = new System.Drawing.Point(4, 25);
            this.tab_edit.Name = "tab_edit";
            this.tab_edit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_edit.Size = new System.Drawing.Size(790, 421);
            this.tab_edit.TabIndex = 2;
            this.tab_edit.Text = "edit quiz";
            this.tab_edit.UseVisualStyleBackColor = true;
            // 
            // Quiz_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_controll);
            this.Name = "Quiz_time";
            this.Text = "Quiz time";
            this.tab_controll.ResumeLayout(false);
            this.tab_operator.ResumeLayout(false);
            this.tab_operator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_controll;
        private System.Windows.Forms.TabPage tab_operator;
        private System.Windows.Forms.Button btn_selectQuiz;
        private System.Windows.Forms.Button btn_editQuiz;
        private System.Windows.Forms.Label lb_selec_quizNaam;
        private System.Windows.Forms.Label lb_sel_label;
        private System.Windows.Forms.Label lb_am_afspeelmodus;
        private System.Windows.Forms.Label lb_am_tijd;
        private System.Windows.Forms.Label lb_am_nakijken;
        private System.Windows.Forms.ComboBox cb_am_tijd;
        private System.Windows.Forms.ComboBox cb_am_nakijken;
        private System.Windows.Forms.Button btn_start_quiz;
        private System.Windows.Forms.TabPage tab_select;
        private System.Windows.Forms.TabPage tab_edit;
    }
}

