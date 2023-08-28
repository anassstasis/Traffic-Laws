namespace for_driving
{
    partial class Edit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.questions_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.answers_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.questions_panel = new System.Windows.Forms.Panel();
            this.number_topic = new System.Windows.Forms.NumericUpDown();
            this.comment_txt_lb = new MaterialSkin.Controls.MaterialLabel();
            this.question_txt_lb = new MaterialSkin.Controls.MaterialLabel();
            this.picture_flag_lb = new MaterialSkin.Controls.MaterialLabel();
            this.number_topic_lb = new MaterialSkin.Controls.MaterialLabel();
            this.number_answer_lb = new MaterialSkin.Controls.MaterialLabel();
            this.picture_flag = new System.Windows.Forms.ComboBox();
            this.comment_txt = new System.Windows.Forms.RichTextBox();
            this.number_answer = new System.Windows.Forms.ComboBox();
            this.question_txt = new System.Windows.Forms.RichTextBox();
            this.add_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.table = new System.Windows.Forms.DataGridView();
            this.search_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.search_tb = new System.Windows.Forms.RichTextBox();
            this.delete_b = new MaterialSkin.Controls.MaterialRaisedButton();
            this.answers_panel = new System.Windows.Forms.Panel();
            this.question_id_tb = new System.Windows.Forms.TextBox();
            this.answer_txt_lb = new MaterialSkin.Controls.MaterialLabel();
            this.answer_flag_lb = new MaterialSkin.Controls.MaterialLabel();
            this.question_id_lb = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.answers_flag = new System.Windows.Forms.ComboBox();
            this.answers_txt = new System.Windows.Forms.RichTextBox();
            this.delete_tb = new System.Windows.Forms.NumericUpDown();
            this.topics_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.topics_panel = new System.Windows.Forms.Panel();
            this.id_topic_tb = new System.Windows.Forms.NumericUpDown();
            this.topic_txt_lb = new MaterialSkin.Controls.MaterialLabel();
            this.id_topic_lb = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.topic_txt = new System.Windows.Forms.RichTextBox();
            this.return_b = new MaterialSkin.Controls.MaterialFlatButton();
            this.questions_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_topic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.answers_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete_tb)).BeginInit();
            this.topics_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_topic_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // questions_rb
            // 
            this.questions_rb.AutoSize = true;
            this.questions_rb.Depth = 0;
            this.questions_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.questions_rb.Location = new System.Drawing.Point(209, 71);
            this.questions_rb.Margin = new System.Windows.Forms.Padding(0);
            this.questions_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.questions_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.questions_rb.Name = "questions_rb";
            this.questions_rb.Ripple = true;
            this.questions_rb.Size = new System.Drawing.Size(87, 30);
            this.questions_rb.TabIndex = 0;
            this.questions_rb.TabStop = true;
            this.questions_rb.Text = "Вопросы";
            this.questions_rb.UseVisualStyleBackColor = true;
            this.questions_rb.CheckedChanged += new System.EventHandler(this.Questions_rb_CheckedChanged);
            // 
            // answers_rb
            // 
            this.answers_rb.AutoSize = true;
            this.answers_rb.Depth = 0;
            this.answers_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.answers_rb.Location = new System.Drawing.Point(306, 71);
            this.answers_rb.Margin = new System.Windows.Forms.Padding(0);
            this.answers_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answers_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.answers_rb.Name = "answers_rb";
            this.answers_rb.Ripple = true;
            this.answers_rb.Size = new System.Drawing.Size(78, 30);
            this.answers_rb.TabIndex = 1;
            this.answers_rb.TabStop = true;
            this.answers_rb.Text = "Ответы";
            this.answers_rb.UseVisualStyleBackColor = true;
            this.answers_rb.CheckedChanged += new System.EventHandler(this.Answers_rb_CheckedChanged);
            // 
            // questions_panel
            // 
            this.questions_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questions_panel.Controls.Add(this.number_topic);
            this.questions_panel.Controls.Add(this.comment_txt_lb);
            this.questions_panel.Controls.Add(this.question_txt_lb);
            this.questions_panel.Controls.Add(this.picture_flag_lb);
            this.questions_panel.Controls.Add(this.number_topic_lb);
            this.questions_panel.Controls.Add(this.number_answer_lb);
            this.questions_panel.Controls.Add(this.picture_flag);
            this.questions_panel.Controls.Add(this.comment_txt);
            this.questions_panel.Controls.Add(this.number_answer);
            this.questions_panel.Controls.Add(this.question_txt);
            this.questions_panel.Location = new System.Drawing.Point(3, 386);
            this.questions_panel.Name = "questions_panel";
            this.questions_panel.Size = new System.Drawing.Size(861, 225);
            this.questions_panel.TabIndex = 2;
            // 
            // number_topic
            // 
            this.number_topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.number_topic.Location = new System.Drawing.Point(384, 37);
            this.number_topic.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.number_topic.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.number_topic.Name = "number_topic";
            this.number_topic.Size = new System.Drawing.Size(94, 20);
            this.number_topic.TabIndex = 23;
            this.number_topic.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // comment_txt_lb
            // 
            this.comment_txt_lb.AutoSize = true;
            this.comment_txt_lb.Depth = 0;
            this.comment_txt_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.comment_txt_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comment_txt_lb.Location = new System.Drawing.Point(17, 149);
            this.comment_txt_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.comment_txt_lb.Name = "comment_txt_lb";
            this.comment_txt_lb.Size = new System.Drawing.Size(108, 19);
            this.comment_txt_lb.TabIndex = 18;
            this.comment_txt_lb.Text = "Комментарий";
            // 
            // question_txt_lb
            // 
            this.question_txt_lb.AutoSize = true;
            this.question_txt_lb.Depth = 0;
            this.question_txt_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.question_txt_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.question_txt_lb.Location = new System.Drawing.Point(17, 68);
            this.question_txt_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.question_txt_lb.Name = "question_txt_lb";
            this.question_txt_lb.Size = new System.Drawing.Size(113, 19);
            this.question_txt_lb.TabIndex = 18;
            this.question_txt_lb.Text = "Текст вопроса";
            // 
            // picture_flag_lb
            // 
            this.picture_flag_lb.AutoSize = true;
            this.picture_flag_lb.Depth = 0;
            this.picture_flag_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.picture_flag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picture_flag_lb.Location = new System.Drawing.Point(691, 14);
            this.picture_flag_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.picture_flag_lb.Name = "picture_flag_lb";
            this.picture_flag_lb.Size = new System.Drawing.Size(143, 19);
            this.picture_flag_lb.TabIndex = 18;
            this.picture_flag_lb.Text = "Флаг изображения";
            // 
            // number_topic_lb
            // 
            this.number_topic_lb.AutoSize = true;
            this.number_topic_lb.Depth = 0;
            this.number_topic_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.number_topic_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.number_topic_lb.Location = new System.Drawing.Point(380, 14);
            this.number_topic_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.number_topic_lb.Name = "number_topic_lb";
            this.number_topic_lb.Size = new System.Drawing.Size(98, 19);
            this.number_topic_lb.TabIndex = 17;
            this.number_topic_lb.Text = "Номер темы";
            // 
            // number_answer_lb
            // 
            this.number_answer_lb.AutoSize = true;
            this.number_answer_lb.Depth = 0;
            this.number_answer_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.number_answer_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.number_answer_lb.Location = new System.Drawing.Point(17, 14);
            this.number_answer_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.number_answer_lb.Name = "number_answer_lb";
            this.number_answer_lb.Size = new System.Drawing.Size(145, 19);
            this.number_answer_lb.TabIndex = 16;
            this.number_answer_lb.Text = "Правильный ответ";
            // 
            // picture_flag
            // 
            this.picture_flag.FormattingEnabled = true;
            this.picture_flag.Items.AddRange(new object[] {
            "0",
            "1"});
            this.picture_flag.Location = new System.Drawing.Point(694, 36);
            this.picture_flag.Name = "picture_flag";
            this.picture_flag.Size = new System.Drawing.Size(140, 21);
            this.picture_flag.TabIndex = 4;
            // 
            // comment_txt
            // 
            this.comment_txt.Location = new System.Drawing.Point(21, 171);
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(813, 50);
            this.comment_txt.TabIndex = 3;
            this.comment_txt.Text = "";
            // 
            // number_answer
            // 
            this.number_answer.FormattingEnabled = true;
            this.number_answer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.number_answer.Location = new System.Drawing.Point(21, 36);
            this.number_answer.Name = "number_answer";
            this.number_answer.Size = new System.Drawing.Size(140, 21);
            this.number_answer.TabIndex = 1;
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(21, 90);
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(813, 50);
            this.question_txt.TabIndex = 0;
            this.question_txt.Text = "";
            // 
            // add_b
            // 
            this.add_b.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_b.Depth = 0;
            this.add_b.Location = new System.Drawing.Point(352, 622);
            this.add_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_b.Name = "add_b";
            this.add_b.Primary = true;
            this.add_b.Size = new System.Drawing.Size(165, 39);
            this.add_b.TabIndex = 15;
            this.add_b.Text = "Добавить запись";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.Add_b_Click);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(30, 116);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(813, 188);
            this.table.TabIndex = 5;
            // 
            // search_b
            // 
            this.search_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_b.Depth = 0;
            this.search_b.Location = new System.Drawing.Point(30, 344);
            this.search_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_b.Name = "search_b";
            this.search_b.Primary = true;
            this.search_b.Size = new System.Drawing.Size(111, 39);
            this.search_b.TabIndex = 13;
            this.search_b.Text = "Поиск";
            this.search_b.UseVisualStyleBackColor = true;
            this.search_b.Click += new System.EventHandler(this.Search_b_Click);
            // 
            // search_tb
            // 
            this.search_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_tb.Location = new System.Drawing.Point(30, 310);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(387, 28);
            this.search_tb.TabIndex = 0;
            this.search_tb.Text = "";
            // 
            // delete_b
            // 
            this.delete_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_b.Depth = 0;
            this.delete_b.Location = new System.Drawing.Point(732, 344);
            this.delete_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_b.Name = "delete_b";
            this.delete_b.Primary = true;
            this.delete_b.Size = new System.Drawing.Size(111, 39);
            this.delete_b.TabIndex = 14;
            this.delete_b.Text = "Удалить";
            this.delete_b.UseVisualStyleBackColor = true;
            this.delete_b.Click += new System.EventHandler(this.Delete_b_Click);
            // 
            // answers_panel
            // 
            this.answers_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answers_panel.Controls.Add(this.question_id_tb);
            this.answers_panel.Controls.Add(this.answer_txt_lb);
            this.answers_panel.Controls.Add(this.answer_flag_lb);
            this.answers_panel.Controls.Add(this.question_id_lb);
            this.answers_panel.Controls.Add(this.materialRaisedButton3);
            this.answers_panel.Controls.Add(this.answers_flag);
            this.answers_panel.Controls.Add(this.answers_txt);
            this.answers_panel.Location = new System.Drawing.Point(9, 389);
            this.answers_panel.Name = "answers_panel";
            this.answers_panel.Size = new System.Drawing.Size(861, 157);
            this.answers_panel.TabIndex = 19;
            // 
            // question_id_tb
            // 
            this.question_id_tb.Location = new System.Drawing.Point(21, 36);
            this.question_id_tb.Name = "question_id_tb";
            this.question_id_tb.Size = new System.Drawing.Size(111, 20);
            this.question_id_tb.TabIndex = 19;
            // 
            // answer_txt_lb
            // 
            this.answer_txt_lb.AutoSize = true;
            this.answer_txt_lb.Depth = 0;
            this.answer_txt_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer_txt_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer_txt_lb.Location = new System.Drawing.Point(17, 68);
            this.answer_txt_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer_txt_lb.Name = "answer_txt_lb";
            this.answer_txt_lb.Size = new System.Drawing.Size(101, 19);
            this.answer_txt_lb.TabIndex = 18;
            this.answer_txt_lb.Text = "Текст ответа";
            // 
            // answer_flag_lb
            // 
            this.answer_flag_lb.AutoSize = true;
            this.answer_flag_lb.Depth = 0;
            this.answer_flag_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer_flag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer_flag_lb.Location = new System.Drawing.Point(139, 14);
            this.answer_flag_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer_flag_lb.Name = "answer_flag_lb";
            this.answer_flag_lb.Size = new System.Drawing.Size(96, 19);
            this.answer_flag_lb.TabIndex = 18;
            this.answer_flag_lb.Text = "Флаг ответа";
            // 
            // question_id_lb
            // 
            this.question_id_lb.AutoSize = true;
            this.question_id_lb.Depth = 0;
            this.question_id_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.question_id_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.question_id_lb.Location = new System.Drawing.Point(17, 14);
            this.question_id_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.question_id_lb.Name = "question_id_lb";
            this.question_id_lb.Size = new System.Drawing.Size(120, 19);
            this.question_id_lb.TabIndex = 16;
            this.question_id_lb.Text = "Номер вопроса";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(346, 169);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(165, 39);
            this.materialRaisedButton3.TabIndex = 15;
            this.materialRaisedButton3.Text = "Добавить запись";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // answers_flag
            // 
            this.answers_flag.FormattingEnabled = true;
            this.answers_flag.Items.AddRange(new object[] {
            "0",
            "1"});
            this.answers_flag.Location = new System.Drawing.Point(143, 36);
            this.answers_flag.Name = "answers_flag";
            this.answers_flag.Size = new System.Drawing.Size(92, 21);
            this.answers_flag.TabIndex = 4;
            // 
            // answers_txt
            // 
            this.answers_txt.Location = new System.Drawing.Point(21, 90);
            this.answers_txt.Name = "answers_txt";
            this.answers_txt.Size = new System.Drawing.Size(813, 50);
            this.answers_txt.TabIndex = 0;
            this.answers_txt.Text = "";
            // 
            // delete_tb
            // 
            this.delete_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_tb.Location = new System.Drawing.Point(732, 311);
            this.delete_tb.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.delete_tb.Name = "delete_tb";
            this.delete_tb.Size = new System.Drawing.Size(111, 20);
            this.delete_tb.TabIndex = 21;
            // 
            // topics_rb
            // 
            this.topics_rb.AutoSize = true;
            this.topics_rb.Depth = 0;
            this.topics_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.topics_rb.Location = new System.Drawing.Point(125, 71);
            this.topics_rb.Margin = new System.Windows.Forms.Padding(0);
            this.topics_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.topics_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.topics_rb.Name = "topics_rb";
            this.topics_rb.Ripple = true;
            this.topics_rb.Size = new System.Drawing.Size(66, 30);
            this.topics_rb.TabIndex = 22;
            this.topics_rb.TabStop = true;
            this.topics_rb.Text = "Темы";
            this.topics_rb.UseVisualStyleBackColor = true;
            this.topics_rb.CheckedChanged += new System.EventHandler(this.Topics_rb_CheckedChanged);
            // 
            // topics_panel
            // 
            this.topics_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topics_panel.Controls.Add(this.id_topic_tb);
            this.topics_panel.Controls.Add(this.topic_txt_lb);
            this.topics_panel.Controls.Add(this.id_topic_lb);
            this.topics_panel.Controls.Add(this.materialRaisedButton1);
            this.topics_panel.Controls.Add(this.topic_txt);
            this.topics_panel.Location = new System.Drawing.Point(6, 386);
            this.topics_panel.Name = "topics_panel";
            this.topics_panel.Size = new System.Drawing.Size(861, 157);
            this.topics_panel.TabIndex = 20;
            // 
            // id_topic_tb
            // 
            this.id_topic_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_topic_tb.Location = new System.Drawing.Point(24, 40);
            this.id_topic_tb.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.id_topic_tb.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.id_topic_tb.Name = "id_topic_tb";
            this.id_topic_tb.Size = new System.Drawing.Size(94, 20);
            this.id_topic_tb.TabIndex = 24;
            this.id_topic_tb.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // topic_txt_lb
            // 
            this.topic_txt_lb.AutoSize = true;
            this.topic_txt_lb.Depth = 0;
            this.topic_txt_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.topic_txt_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topic_txt_lb.Location = new System.Drawing.Point(17, 68);
            this.topic_txt_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.topic_txt_lb.Name = "topic_txt_lb";
            this.topic_txt_lb.Size = new System.Drawing.Size(121, 19);
            this.topic_txt_lb.TabIndex = 18;
            this.topic_txt_lb.Text = "Название темы";
            // 
            // id_topic_lb
            // 
            this.id_topic_lb.AutoSize = true;
            this.id_topic_lb.Depth = 0;
            this.id_topic_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.id_topic_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.id_topic_lb.Location = new System.Drawing.Point(17, 14);
            this.id_topic_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.id_topic_lb.Name = "id_topic_lb";
            this.id_topic_lb.Size = new System.Drawing.Size(98, 19);
            this.id_topic_lb.TabIndex = 16;
            this.id_topic_lb.Text = "Номер темы";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(346, 169);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(165, 39);
            this.materialRaisedButton1.TabIndex = 15;
            this.materialRaisedButton1.Text = "Добавить запись";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // topic_txt
            // 
            this.topic_txt.Location = new System.Drawing.Point(21, 90);
            this.topic_txt.Name = "topic_txt";
            this.topic_txt.Size = new System.Drawing.Size(813, 50);
            this.topic_txt.TabIndex = 0;
            this.topic_txt.Text = "";
            // 
            // return_b
            // 
            this.return_b.AutoSize = true;
            this.return_b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.return_b.Depth = 0;
            this.return_b.Location = new System.Drawing.Point(30, 71);
            this.return_b.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.return_b.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_b.Name = "return_b";
            this.return_b.Primary = false;
            this.return_b.Size = new System.Drawing.Size(59, 36);
            this.return_b.TabIndex = 38;
            this.return_b.Text = "Назад";
            this.return_b.UseVisualStyleBackColor = true;
            this.return_b.Click += new System.EventHandler(this.Return_b_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 673);
            this.Controls.Add(this.return_b);
            this.Controls.Add(this.topics_rb);
            this.Controls.Add(this.delete_tb);
            this.Controls.Add(this.delete_b);
            this.Controls.Add(this.search_b);
            this.Controls.Add(this.table);
            this.Controls.Add(this.add_b);
            this.Controls.Add(this.questions_panel);
            this.Controls.Add(this.answers_rb);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.topics_panel);
            this.Controls.Add(this.questions_rb);
            this.Controls.Add(this.answers_panel);
            this.MinimumSize = new System.Drawing.Size(885, 673);
            this.Name = "Edit";
            this.Text = "Редактирование тестов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.questions_panel.ResumeLayout(false);
            this.questions_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_topic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.answers_panel.ResumeLayout(false);
            this.answers_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete_tb)).EndInit();
            this.topics_panel.ResumeLayout(false);
            this.topics_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_topic_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton questions_rb;
        private MaterialSkin.Controls.MaterialRadioButton answers_rb;
        private System.Windows.Forms.Panel questions_panel;
        private System.Windows.Forms.ComboBox picture_flag;
        private System.Windows.Forms.RichTextBox comment_txt;
        private System.Windows.Forms.ComboBox number_answer;
        private System.Windows.Forms.RichTextBox question_txt;
        private System.Windows.Forms.DataGridView table;
        private MaterialSkin.Controls.MaterialLabel comment_txt_lb;
        private MaterialSkin.Controls.MaterialLabel question_txt_lb;
        private MaterialSkin.Controls.MaterialLabel picture_flag_lb;
        private MaterialSkin.Controls.MaterialLabel number_topic_lb;
        private MaterialSkin.Controls.MaterialLabel number_answer_lb;
        private MaterialSkin.Controls.MaterialRaisedButton add_b;
        private MaterialSkin.Controls.MaterialRaisedButton search_b;
        private System.Windows.Forms.RichTextBox search_tb;
        private MaterialSkin.Controls.MaterialRaisedButton delete_b;
        private System.Windows.Forms.Panel answers_panel;
        private System.Windows.Forms.TextBox question_id_tb;
        private MaterialSkin.Controls.MaterialLabel answer_txt_lb;
        private MaterialSkin.Controls.MaterialLabel answer_flag_lb;
        private MaterialSkin.Controls.MaterialLabel question_id_lb;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.ComboBox answers_flag;
        private System.Windows.Forms.RichTextBox answers_txt;
        private System.Windows.Forms.NumericUpDown delete_tb;
        private MaterialSkin.Controls.MaterialRadioButton topics_rb;
        private System.Windows.Forms.NumericUpDown number_topic;
        private System.Windows.Forms.Panel topics_panel;
        private MaterialSkin.Controls.MaterialLabel topic_txt_lb;
        private MaterialSkin.Controls.MaterialLabel id_topic_lb;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.RichTextBox topic_txt;
        private System.Windows.Forms.NumericUpDown id_topic_tb;
        public MaterialSkin.Controls.MaterialFlatButton return_b;
    }
}