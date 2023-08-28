using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace for_driving
{
    public partial class T_Regulations : MaterialForm
    {
        testEntities13 conn = new testEntities13();//Строка подключения к БД
        //Передача данных с формы авторизации
        Authorization authorization = (Authorization)Application.OpenForms["Authorization"]; 
        public int check;
        public T_Regulations(string fio, string @true, string @false)
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
        private void T_Regulations_Load(object sender, EventArgs e)
        {
            fio_lb.Text = Authorization.fio;
            true_lb.Text = "Количество правильных ответов: " + Authorization.@true;
            false_lb.Text = "Количество неправильных ответов: " + Authorization.@false;
            if (fio_lb.Text == "admin")
            {
                edit_link.Visible = true;
            }
            for (int i = 1; i <= 29; i++)
            {
                //Вывод названия тем
                var topic = conn.topics.Where(c => c.id_topic == i).SingleOrDefault()?.name_topic; switch (i)
                {
                    case 1:                        rb_top1.Text = topic; break;
                    case 2:                        rb_top2.Text = topic; break;
                    case 3:                        rb_top3.Text = topic; break;
                    case 4:                        rb_top4.Text = topic; break;
                    case 5:                        rb_top5.Text = topic; break;
                    case 6:                        rb_top6.Text = topic; break;
                    case 7:                        rb_top7.Text = topic; break;
                    case 8:                        rb_top8.Text = topic; break;
                    case 9:                        rb_top9.Text = topic; break;
                    case 10:                       rb_top10.Text = topic; break;
                    case 11:                       rb_top11.Text = topic; break;
                    case 12:                       rb_top12.Text = topic; break;
                    case 13:                       rb_top13.Text = topic; break;
                    case 14:                       rb_top14.Text = topic; break;
                    case 15:                       rb_top15.Text = topic; break;
                    case 16:                       rb_top16.Text = topic; break;
                    case 17:                       rb_top17.Text = topic; break;
                    case 18:                       rb_top18.Text = topic; break;
                    case 19:                       rb_top19.Text = topic; break;
                    case 20:                       rb_top20.Text = topic; break;
                    case 21:                       rb_top21.Text = topic; break;
                    case 22:                       rb_top22.Text = topic; break;
                    case 23:                       rb_top23.Text = topic; break;
                    case 24:                       rb_top24.Text = topic; break;
                    case 25:                       rb_top25.Text = topic; break;
                    case 26:                       rb_top26.Text = topic; break;
                    case 27:                       rb_top27.Text = topic; break;
                    case 28:                       rb_top28.Text = topic; break;
                    case 29:                       rb_top29.Text = topic; break;
                }
            }
        }
        private void T_Regulations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Link_topics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }
        private void Link_tickets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // Скрыть панель с выбором тем
            panel1.Visible = false;
        }
        // Обработчик события выбора первой темы и т.д.
        private void Rb_top1_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
        }
        private void Rb_top2_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }
        private void Rb_top3_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }
        private void Rb_top4_CheckedChanged(object sender, EventArgs e)
        {
            check = 4;
        }
        private void Rb_top5_CheckedChanged(object sender, EventArgs e)
        {
            check = 5;
        }
        private void Rb_top6_CheckedChanged(object sender, EventArgs e)
        {
            check = 6;
        }
        private void Rb_top7_CheckedChanged(object sender, EventArgs e)
        {
            check = 7;
        }
        private void Rb_top8_CheckedChanged(object sender, EventArgs e)
        {
            check = 8;
        }
        private void Rb_top9_CheckedChanged(object sender, EventArgs e)
        {
            check = 9;
        }
        private void Rb_top10_CheckedChanged(object sender, EventArgs e)
        {
            check = 10;
        }
        private void Rb_top11_CheckedChanged(object sender, EventArgs e)
        {
            check = 11;
        }
        private void Rb_top12_CheckedChanged(object sender, EventArgs e)
        {
            check = 12;
        }
        private void Rb_top13_CheckedChanged(object sender, EventArgs e)
        {
            check = 13;
        }
        private void Rb_top14_CheckedChanged(object sender, EventArgs e)
        {
            check = 14;
        }
        private void Rb_top15_CheckedChanged(object sender, EventArgs e)
        {
            check = 15;
        }
        private void Rb_top16_CheckedChanged(object sender, EventArgs e)
        {
            check = 16;
        }
        private void Rb_top17_CheckedChanged(object sender, EventArgs e)
        { 
            check = 17;
        }
        private void Rb_top18_CheckedChanged(object sender, EventArgs e)
        {
            check = 18;
        }
        private void Rb_top19_CheckedChanged(object sender, EventArgs e)
        {
            check = 19;
        }
        private void Rb_top20_CheckedChanged(object sender, EventArgs e)
        {
            check = 20;
        }
        private void Rb_top21_CheckedChanged(object sender, EventArgs e)
        {
            check = 21;
        }
        private void Rb_top22_CheckedChanged(object sender, EventArgs e)
        {
            check = 22;
        }
        private void Rb_top23_CheckedChanged(object sender, EventArgs e)
        {
            check = 23;
        }
        private void Rb_top24_CheckedChanged(object sender, EventArgs e)
        {
            check = 24;
        }
        private void Rb_top25_CheckedChanged(object sender, EventArgs e)
        {
            check = 25;
        }
        private void Rb_top26_CheckedChanged(object sender, EventArgs e)
        {
            check = 26;
        }
        private void Rb_top27_CheckedChanged(object sender, EventArgs e)
        {
            check = 27;
        }
        private void Rb_top28_CheckedChanged(object sender, EventArgs e)
        {
            check = 28;
        }
        private void Rb_top29_CheckedChanged(object sender, EventArgs e)
        {
            check = 29;
        }
        private void Student_b_Click(object sender, EventArgs e)
        {
            Test test = new Test(Authorization.fio); // Создание нового экземпляра формы "Тест"
            test.secret_lb.Text = check.ToString(); // Установка значения "check" в свойство "Text" для "secret_lb"
            //secret_lb для передачи и вывода значения id вопроса
            if (check != 0) // Если выбрана тема 
            {
                test.return_question_b.Enabled = false;
                this.Hide();
                test.Show();
            }
            else MessageBox.Show("Выберите тему!");
            
            if (check == 1)// Если выбрана тема №1 и т.д.
            {
                test.currentQuestionId = 1; // Установка номера текущего вопроса
                // Установка текста вопроса
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 1 && c.id_question == 1).SingleOrDefault()?.question_text;
                // Отображение вариантов ответа
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                // Установка текста для вариантов ответа
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 1) && (c.id_answer == 1)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 1) && (c.id_answer == 2)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 1) && (c.id_answer == 3)).SingleOrDefault()?.answer_text;
                if (test.rb_1.Checked)
                {
                    test.trueCount++;
                    test.falseCount = 0;
                }
                this.Hide();
                test.Show();
            }
            if (check == 2)
            {
                test.currentQuestionId = 26;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 2 && c.id_question == 26).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 77)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 78)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 79)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 80)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 3)
            {
                test.currentQuestionId = 41;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 3 && c.id_question == 41).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 127)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 128)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 129)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 130)).SingleOrDefault()?.answer_text;
                string imageName = $"_{41}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true; 
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 4)
            {
                test.currentQuestionId = 61;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 4 && c.id_question == 61).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 61) && (c.id_answer == 189)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 61) && (c.id_answer == 190)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 61) && (c.id_answer == 191)).SingleOrDefault()?.answer_text;
                string imageName = $"_{61}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 5)
            {
                test.currentQuestionId = 81;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 5 && c.id_question == 81).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 248)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 249)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 250)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 251)).SingleOrDefault()?.answer_text;
                string imageName = $"_{81}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 6)
            {
                test.currentQuestionId = 89;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 6 && c.id_question == 89).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 89) && (c.id_answer == 274)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 89) && (c.id_answer == 275)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 89) && (c.id_answer == 276)).SingleOrDefault()?.answer_text;
                string imageName = $"_{89}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 7)
            {
                test.currentQuestionId = 109;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 7 && c.id_question == 109).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 109) && (c.id_answer == 337)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 109) && (c.id_answer == 338)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 109) && (c.id_answer == 339)).SingleOrDefault()?.answer_text;
                string imageName = $"_{109}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 8)
            {
                test.currentQuestionId = 120;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 8 && c.id_question == 120).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 371)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 372)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 373)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 374)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 9)
            {
                test.currentQuestionId = 138;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 9 && c.id_question == 138).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 425)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 426)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 427)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 428)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 10)
            {
                test.currentQuestionId = 158;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 10 && c.id_question == 158).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 158) && (c.id_answer == 489)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 158) && (c.id_answer == 490)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 158) && (c.id_answer == 491)).SingleOrDefault()?.answer_text;
                string imageName = $"_{158}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 11)
            {
                test.currentQuestionId = 168;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 11 && c.id_question == 168).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 168) && (c.id_answer == 519)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 168) && (c.id_answer == 520)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 168) && (c.id_answer == 521)).SingleOrDefault()?.answer_text;
                string imageName = $"_{168}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 12)
            {
                test.currentQuestionId = 177;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 12 && c.id_question == 177).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 177) && (c.id_answer == 546)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 177) && (c.id_answer == 547)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 177) && (c.id_answer == 548)).SingleOrDefault()?.answer_text;
                string imageName = $"_{177}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 13)
            {
                test.currentQuestionId = 187;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 13 && c.id_question == 187).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 187) && (c.id_answer == 576)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 187) && (c.id_answer == 577)).SingleOrDefault()?.answer_text;
                string imageName = $"_{187}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.comment_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 14)
            {
                test.currentQuestionId = 197;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 14 && c.id_question == 197).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 197) && (c.id_answer == 605)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 197) && (c.id_answer == 606)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 197) && (c.id_answer == 607)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 15)
            {
                test.currentQuestionId = 201;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 15 && c.id_question == 201).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 617)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 618)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 619)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 620)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 16)
            {
                test.currentQuestionId = 211;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 16 && c.id_question == 211).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 211) && (c.id_answer == 648)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 211) && (c.id_answer == 649)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 211) && (c.id_answer == 650)).SingleOrDefault()?.answer_text;
                string imageName = $"_{211}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 17)
            {
                test.currentQuestionId = 220;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 17 && c.id_question == 220).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 220) && (c.id_answer == 675)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 220) && (c.id_answer == 676)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 220) && (c.id_answer == 677)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 18)
            {
                test.currentQuestionId = 227;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 18 && c.id_question == 227).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 227) && (c.id_answer == 699)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 227) && (c.id_answer == 700)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 227) && (c.id_answer == 701)).SingleOrDefault()?.answer_text;
                string imageName = $"_{227}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 19)
            {
                test.currentQuestionId = 235;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 19 && c.id_question == 235).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 235) && (c.id_answer == 726)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 235) && (c.id_answer == 727)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 235) && (c.id_answer == 728)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 20)
            {
                test.currentQuestionId = 246;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 20 && c.id_question == 246).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 246) && (c.id_answer == 762)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 246) && (c.id_answer == 763)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 246) && (c.id_answer == 764)).SingleOrDefault()?.answer_text;
                string imageName = $"_{246}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 21)
            {
                test.currentQuestionId = 256;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 21 && c.id_question == 256).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 793)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 794)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 795)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 796)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 22)
            {
                test.currentQuestionId = 260;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 22 && c.id_question == 260).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 260) && (c.id_answer == 807)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 260) && (c.id_answer == 808)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 260) && (c.id_answer == 809)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 23)
            {
                test.currentQuestionId = 263;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 23 && c.id_question == 263).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 263) && (c.id_answer == 816)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 263) && (c.id_answer == 817)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 263) && (c.id_answer == 818)).SingleOrDefault()?.answer_text;
                string imageName = $"_{263}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 24)
            {
                test.currentQuestionId = 266;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 24 && c.id_question == 266).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 266) && (c.id_answer == 825)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 266) && (c.id_answer == 826)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 266) && (c.id_answer == 827)).SingleOrDefault()?.answer_text;
                string imageName = $"_{266}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 25)
            {
                test.currentQuestionId = 275;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 25 && c.id_question == 275).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 275) && (c.id_answer == 854)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 275) && (c.id_answer == 855)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 275) && (c.id_answer == 856)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 275) && (c.id_answer == 857)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 26)
            {
                test.currentQuestionId = 286;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 26 && c.id_question == 286).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 286) && (c.id_answer == 889)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 286) && (c.id_answer == 890)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 286) && (c.id_answer == 891)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 27)
            {
                test.currentQuestionId = 295;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 27 && c.id_question == 295).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 295) && (c.id_answer == 917)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 295) && (c.id_answer == 918)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 295) && (c.id_answer == 919)).SingleOrDefault()?.answer_text;
                string imageName = $"_{295}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (check == 28)
            {
                test.currentQuestionId = 306;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 28 && c.id_question == 306).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 306) && (c.id_answer == 951)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 306) && (c.id_answer == 952)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 306) && (c.id_answer == 953)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (check == 29)
            {
                test.currentQuestionId = 316;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 29 && c.id_question == 316).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 316) && (c.id_answer == 981)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 316) && (c.id_answer == 982)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 316) && (c.id_answer == 983)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            test.comment_panel.Visible = false;// Комментарии скрыты
            test.answers_panel.Location = new Point(12, 543);
            test.answers_panel.Size = new Size(1103, 125);
            test.picture_panel.Location = new Point(12, 150);
            test.picture_panel.Size = new Size(1103, 387);
        }
      
        private void Preparetion_b_Click(object sender, EventArgs e)
        {
            check = 333; // Устанавливаем значение переменной check в 333
            Test test = new Test(Authorization.fio); // Создаем экземпляр класса Test и передаем ему имя пользователя
            test.secret_lb_2.Text = check.ToString(); // Устанавливаем значение свойства secret_lb экземпляра класса Test
            test.return_question_b.Visible = false; // Скрываем кнопку "Вернуться к вопросу" в экземпляре класса Test (для данного режима)
            this.Hide();
            test.Show();
            Random random = new Random();
            int num_ticket = random.Next(1, 24);
            test.secret_lb.Text = Convert.ToString(num_ticket);

            if (num_ticket == 1)// Если выбрана тема №1 и т.д.
            {
                test.currentQuestionId = 1; // Установка номера текущего вопроса
                // Установка текста вопроса
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 1 && c.id_question == 1).SingleOrDefault()?.question_text;
                // Отображение вариантов ответа
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                // Установка текста для вариантов ответа
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 1) && (c.id_answer == 1)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 1) && (c.id_answer == 2)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 1) && (c.id_answer == 3)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 2)
            {
                test.currentQuestionId = 26;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 2 && c.id_question == 26).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 77)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 78)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 79)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 26) && (c.id_answer == 80)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 3)
            {
                test.currentQuestionId = 41;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 3 && c.id_question == 41).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 127)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 128)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 129)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 41) && (c.id_answer == 130)).SingleOrDefault()?.answer_text;
                string imageName = $"_{41}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.answers_panel.Location = new Point(12, 414);
                test.picture_panel.Location = new Point(12, 150);
                test.Size = new System.Drawing.Size(912, 735);
                test.return_question_b.Location = new Point(175, 661);
                test.forward_b.Location = new Point(485, 661);
                test.return_b.Location = new Point(12, 661);
                test.picture_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 4)
            {
                test.currentQuestionId = 61;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 4 && c.id_question == 61).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 61) && (c.id_answer == 189)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 61) && (c.id_answer == 190)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 61) && (c.id_answer == 191)).SingleOrDefault()?.answer_text;
                string imageName = $"_{61}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 5)
            {
                test.currentQuestionId = 81;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 5 && c.id_question == 81).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 248)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 249)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 250)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 81) && (c.id_answer == 251)).SingleOrDefault()?.answer_text;
                string imageName = $"_{81}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 6)
            {
                test.currentQuestionId = 89;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 6 && c.id_question == 89).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 89) && (c.id_answer == 274)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 89) && (c.id_answer == 275)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 89) && (c.id_answer == 276)).SingleOrDefault()?.answer_text;
                string imageName = $"_{89}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 7)
            {
                test.currentQuestionId = 109;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 7 && c.id_question == 109).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 109) && (c.id_answer == 337)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 109) && (c.id_answer == 338)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 109) && (c.id_answer == 339)).SingleOrDefault()?.answer_text;
                string imageName = $"_{109}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 8)
            {
                test.currentQuestionId = 120;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 8 && c.id_question == 120).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 371)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 372)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 373)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 120) && (c.id_answer == 374)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 9)
            {
                test.currentQuestionId = 138;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 9 && c.id_question == 138).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 425)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 426)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 427)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 138) && (c.id_answer == 428)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 10)
            {
                test.currentQuestionId = 158;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 10 && c.id_question == 158).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 158) && (c.id_answer == 489)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 158) && (c.id_answer == 490)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 158) && (c.id_answer == 491)).SingleOrDefault()?.answer_text;
                string imageName = $"_{158}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 11)
            {
                test.currentQuestionId = 168;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 11 && c.id_question == 168).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 168) && (c.id_answer == 519)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 168) && (c.id_answer == 520)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 168) && (c.id_answer == 521)).SingleOrDefault()?.answer_text;
                string imageName = $"_{168}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 12)
            {
                test.currentQuestionId = 177;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 12 && c.id_question == 177).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 177) && (c.id_answer == 546)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 177) && (c.id_answer == 547)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 177) && (c.id_answer == 548)).SingleOrDefault()?.answer_text;
                string imageName = $"_{177}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.picture_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 13)
            {
                test.currentQuestionId = 187;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 13 && c.id_question == 187).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 187) && (c.id_answer == 576)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 187) && (c.id_answer == 577)).SingleOrDefault()?.answer_text;
                string imageName = $"_{187}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.picture_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 14)
            {
                test.currentQuestionId = 197;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 14 && c.id_question == 197).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 197) && (c.id_answer == 605)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 197) && (c.id_answer == 606)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 197) && (c.id_answer == 607)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 15)
            {
                test.currentQuestionId = 201;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 15 && c.id_question == 201).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 617)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 618)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 619)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 201) && (c.id_answer == 620)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 16)
            {
                test.currentQuestionId = 211;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 16 && c.id_question == 211).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 211) && (c.id_answer == 648)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 211) && (c.id_answer == 649)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 211) && (c.id_answer == 650)).SingleOrDefault()?.answer_text;
                string imageName = $"_{211}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.picture_panel.Visible = true;
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 17)
            {
                test.currentQuestionId = 220;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 17 && c.id_question == 220).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 220) && (c.id_answer == 675)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 220) && (c.id_answer == 676)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 220) && (c.id_answer == 677)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 18)
            {
                test.currentQuestionId = 227;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 18 && c.id_question == 227).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 227) && (c.id_answer == 699)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 227) && (c.id_answer == 700)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 227) && (c.id_answer == 701)).SingleOrDefault()?.answer_text;
                string imageName = $"_{227}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 19)
            {
                test.currentQuestionId = 235;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 19 && c.id_question == 235).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 235) && (c.id_answer == 726)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 235) && (c.id_answer == 727)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 235) && (c.id_answer == 728)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 20)
            {
                test.currentQuestionId = 246;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 20 && c.id_question == 246).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 246) && (c.id_answer == 762)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 246) && (c.id_answer == 763)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 246) && (c.id_answer == 764)).SingleOrDefault()?.answer_text;
                string imageName = $"_{246}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 21)
            {
                test.currentQuestionId = 256;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 21 && c.id_question == 256).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_4.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 793)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 794)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 795)).SingleOrDefault()?.answer_text;
                test.rb_4.Text = conn.answers.Where(c => (c.question_id == 256) && (c.id_answer == 796)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 22)
            {
                test.currentQuestionId = 260;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 22 && c.id_question == 260).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 260) && (c.id_answer == 807)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 260) && (c.id_answer == 808)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 260) && (c.id_answer == 809)).SingleOrDefault()?.answer_text;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 23)
            {
                test.currentQuestionId = 263;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 23 && c.id_question == 263).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 263) && (c.id_answer == 816)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 263) && (c.id_answer == 817)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 263) && (c.id_answer == 818)).SingleOrDefault()?.answer_text;
                string imageName = $"_{263}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            if (num_ticket == 24)
            {
                test.currentQuestionId = 266;
                test.question_lb.Text = conn.questions.Where(c => c.topic_id == 24 && c.id_question == 266).SingleOrDefault()?.question_text;
                test.rb_1.Visible = true;
                test.rb_2.Visible = true;
                test.rb_3.Visible = true;
                test.rb_1.Text = conn.answers.Where(c => (c.question_id == 266) && (c.id_answer == 825)).SingleOrDefault()?.answer_text;
                test.rb_2.Text = conn.answers.Where(c => (c.question_id == 266) && (c.id_answer == 826)).SingleOrDefault()?.answer_text;
                test.rb_3.Text = conn.answers.Where(c => (c.question_id == 266) && (c.id_answer == 827)).SingleOrDefault()?.answer_text;
                string imageName = $"_{266}";
                test.picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                test.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                test.Show();
            }
            test.comment_panel.Visible = false;// Комментарии скрыты
            test.answers_panel.Location = new Point(12, 543);
            test.answers_panel.Size = new Size(1103, 125);
            test.picture_panel.Location = new Point(12, 150);
            test.picture_panel.Size = new Size(1103, 387);
        }
        private void Exam_b_Click(object sender, EventArgs e)
        {
            check = 222; // Устанавливаем значение переменной check в 222
            Test test = new Test(Authorization.fio);
            test.secret_lb_2.Text = check.ToString(); 
            test.return_question_b.Visible = false;
            this.Hide();
            test.Show();
            test.comment_panel.Visible = false;// Комментарии скрыты
            test.answers_panel.Location = new Point(12, 543);
            test.answers_panel.Size = new Size(1103, 125);
            test.picture_panel.Location = new Point(12, 150);
            test.picture_panel.Size = new Size(1103, 387);
        }

        private void Return_b_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.ShowDialog();
        }

        private void Link_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            this.Hide();
            help.ShowDialog();
        }

        private void Link_theory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Theory theory = new Theory();
            this.Hide();
            theory.ShowDialog();
        }

        private void Edit_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit edit = new Edit();
            this.Hide();
            edit.ShowDialog();
        }

        private void App_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Дипломный проект по теме 'Разработка программы для изучения правил дорожного движения'\n" +
                "Автор: Якунина А.В.\n" +
                "Руководитель: Смотрикин В.А.\n" +
                "По вопросам обращаться: yakunina490@gmail.com\n" +
                "Год разработки: 2023");
        }
    }
}
