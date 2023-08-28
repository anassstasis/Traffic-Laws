using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace for_driving
{
    public partial class Edit : MaterialForm
    {
        testEntities13 conn = new testEntities13();
        bool check = false;
        public static string fio;
        public static string @true;
        public static string @false;
        T_Regulations t = new T_Regulations(fio, @true, @false);
        public Edit()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.BlueGrey700, Primary.BlueGrey700,
            Primary.Amber50, Accent.Red700,
            TextShade.WHITE);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Questions_rb_CheckedChanged(object sender, EventArgs e)
        {
            check = questions_rb.Checked;

            if (check)
            {
                questions_panel.Visible = true;
                answers_panel.Visible = false;
                topics_panel.Visible = false;
                table.DataSource = conn.questions.ToList();
                table.Columns[6].Visible = false;
                table.Columns[7].Visible = false;
                table.Columns[0].HeaderText = "Номер";
                table.Columns[1].HeaderText = "Текст вопроса";
                table.Columns[2].HeaderText = "Правильный ответ";
                table.Columns[3].HeaderText = "Комментарий";
                table.Columns[4].HeaderText = "Номер темы";
                table.Columns[5].HeaderText = "Флаг изображения";
            }
        }

        private void Answers_rb_CheckedChanged(object sender, EventArgs e)
        {
            check = answers_rb.Checked;

            if (check)
            {
                questions_panel.Visible = false;
                answers_panel.Visible = true;
                topics_panel.Visible = false;
                table.DataSource = conn.answers.ToList();
                table.Columns[4].Visible = false;
                table.Columns[1].Visible = false;
                table.Columns[0].HeaderText = "Номер вопроса";
                table.Columns[2].HeaderText = "Текст ответа";
                table.Columns[3].HeaderText = "Флаг ответа";
            }
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Search_b_Click(object sender, EventArgs e)
        {
            if (questions_rb.Checked)
            {
                table.DataSource = conn.questions.Where(c => c.question_text.Contains(search_tb.Text)).ToList();
            }
            if (answers_rb.Checked)
            {
                table.DataSource = conn.answers.Where(c => c.answer_text.Contains(search_tb.Text)).ToList();
            }
        }

        private void Delete_b_Click(object sender, EventArgs e)
        {
            if (questions_rb.Checked)
            {
                questions select = conn.questions.Where(c => c.id_question == delete_tb.Value).First();
                conn.questions.Remove(select);
                conn.SaveChanges();
                table.DataSource = conn.questions.ToList();
            }
            if (answers_rb.Checked)
            {
                answers select = conn.answers.Where(c => c.id_answer == delete_tb.Value).First();
                conn.answers.Remove(select);
                conn.SaveChanges();
                table.DataSource = conn.answers.ToList();
            }
            if (topics_rb.Checked)
            {
                topics select = conn.topics.Where(c => c.id_topic == delete_tb.Value).First();
                conn.topics.Remove(select);
                conn.SaveChanges();
                table.DataSource = conn.topics.ToList();
            }
        }

        private void Add_b_Click(object sender, EventArgs e)
        {
            if (questions_rb.Checked)
            {
                if (number_answer.Text == "" || number_topic.Text == "" || picture_flag.Text == "" || question_txt.Text == "" || comment_txt.Text == "")
                {
                    MessageBox.Show("Заполните все поля! ");
                }
                else
                {
                    string question_text = question_txt.Text;
                    string comment_text = comment_txt.Text;
                    questions questions = new questions();
                    questions.question_text = question_text;
                    questions.correct_answer = Convert.ToInt32(number_answer.Text);
                    questions.comment = comment_text;
                    questions.topic_id = Convert.ToInt32(number_topic.Value);
                    questions.is_picture = Convert.ToInt32(picture_flag.Text);
                    conn.questions.Add(questions);
                    conn.SaveChanges();
                    MessageBox.Show("Запись добавлена.");
                    table.DataSource = conn.questions.ToList();
                }
            }
            if (answers_rb.Checked)
            {
                if (question_id_tb.Text == "" || answers_flag.Text == "" || answers_txt.Text == "")
                {
                    MessageBox.Show("Заполните все поля! ");
                }
                else
                {
                    string answers_text=answers_txt.Text;
                    answers answers = new answers();
                    answers.question_id = Convert.ToInt32(question_id_tb.Text);
                    answers.answer_text = answers_text;
                    answers.is_correct = Convert.ToInt32(answers_flag.Text);
                    conn.answers.Add(answers);
                    conn.SaveChanges();
                    MessageBox.Show("Запись добавлена.");
                    table.DataSource = conn.answers.ToList();
                }
            }
            if (topics_rb.Checked)
            {
                if (id_topic_tb.Text == "" || topic_txt.Text == "")
                {
                    MessageBox.Show("Заполните все поля! ");
                }
                else
                {
                    string topic_text = topic_txt.Text;
                    topics topics = new topics();
                    topics.id_topic = Convert.ToInt32(id_topic_tb.Value);
                    topics.name_topic = topic_text;
                    conn.topics.Add(topics);
                    conn.SaveChanges();
                    MessageBox.Show("Запись добавлена.");
                    table.DataSource = conn.topics.ToList();
                }
            }
        }

        private void Topics_rb_CheckedChanged(object sender, EventArgs e)
        {
            check = topics_rb.Checked;

            if (check)
            {
                questions_panel.Visible = false;
                answers_panel.Visible = false;
                topics_panel.Visible = true;
                table.DataSource = conn.topics.ToList();
                table.Columns[2].Visible = false;
                table.Columns[0].HeaderText = "Номер темы";
                table.Columns[1].HeaderText = "Название темы";
            }
        }

        private void Return_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            t.Show();
            t.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
