using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace for_driving
{
    public partial class Test : MaterialForm
    {
        testEntities13 conn = new testEntities13();//Строка подключения к БД
        Authorization authorization = (Authorization)Application.OpenForms["Authorization"];
        public static string fio;
        public static string @true;
        public static string @false;
        T_Regulations t = new T_Regulations(fio, @true, @false);
        public int currentQuestionId;
        public int id;
        private int currentFirstAnswerId;
        public int trueCount = 0;
        public int falseCount = 0;
        public int num_question;
        public int num_ticket;
        private int buttonClick=0;
        private int remainingTime = 1200;
        public Test(string fio)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.BlueGrey700, Primary.BlueGrey700,
            Primary.Amber50, Accent.Red700,
            TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void LoadQuestion(int questionId) // Загрузка вопроса по ID вопроса
        {
            questionId = currentQuestionId; // Устанавливаем ID текущего вопроса
            // Устанавливаем ID первого ответа для данного вопроса
            currentFirstAnswerId = conn.answers.Where(c => c.question_id == questionId).Select(c => c.id_answer).FirstOrDefault();
            // Получаем количество ответов для данного вопроса
            int numAnswers = conn.answers.Where(c => c.question_id == questionId).Select(c => c.id_answer).Distinct().Count();
            // Устанавливаем текст вопроса
            question_lb.Text = conn.questions.Where(c => (c.id_question == questionId)).SingleOrDefault()?.question_text;
            // Устанавливаем видимость RadioButton в зависимости от количества ответов для данного вопроса
            if (numAnswers == 2)
            {
                rb_1.Visible = true;
                rb_2.Visible = true;
                rb_3.Visible = false;
                rb_4.Visible = false;
            }
            if (numAnswers == 3)
            {
                rb_1.Visible = true;
                rb_2.Visible = true;
                rb_3.Visible = true;
                rb_4.Visible = false;
            }
            if (numAnswers == 4)
            {
                rb_1.Visible = true;
                rb_2.Visible = true;
                rb_3.Visible = true;
                rb_4.Visible = true;
            }
            if (currentFirstAnswerId != 0)
            {
                rb_1.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId).SingleOrDefault()?.answer_text;
                rb_2.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 1).SingleOrDefault()?.answer_text;
                rb_3.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 2).SingleOrDefault()?.answer_text;
                rb_4.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 3).SingleOrDefault()?.answer_text;
            }
           
            // Определение наличия изображения для вопроса
            bool hasPicture = conn.questions.Any(c => c.id_question == questionId && c.is_picture == 1);
            if (hasPicture)
            {
                // Определение имени файла изображения и проверка его наличия в ресурсах
                string imageName = $"_{questionId}";
                if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
                {
                    picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                }
            }
            else
            {
                string imageName = $"_{0}";
                if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
                {
                    picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                }
            }
        }
        private void LoadComment(int questionId, int answerId) // Загрузить комментарий для вопроса и ответа
        {
            // Найти id комментария в таблице вопросов
            int commentId = conn.questions.Where(c => c.id_question == questionId).Select(c => c.id_question).FirstOrDefault();
            // Загрузить текст комментария для найденного id
            comment_tb.Text = conn.questions.Where(c => c.id_question == commentId).Select(c => c.comment).FirstOrDefault();
        }
        private void Test_Load(object sender, EventArgs e) // Загрузить тест и настроить его интерфейс
        {
            if (secret_lb.Text == "333" || secret_lb_2.Text == "333" || secret_lb.Text == "222" || secret_lb_2.Text == "222")
            {
                    forward_b.Location = new Point(400,687);
                    comment_panel.Visible = false;
                    answers_panel.Location = new Point(12, 543);
                    answers_panel.Size = new Size(1103, 125);
                    picture_panel.Location = new Point(12, 150);
                    picture_panel.Size = new Size(1103, 387);       
            }
            remainingTime = 1200; // Установить время для таймера и запустить его
            time_l.Text = TimeSpan.FromSeconds(remainingTime).ToString(@"mm\:ss");
            timer1.Enabled = true;
            LoadQuestion(currentQuestionId); // Загрузить первый вопрос
            // Скрыть все элементы для данных режимов
            rb_1.Visible = false;
            rb_2.Visible = false;
            rb_3.Visible = false;
            rb_4.Visible = false;
            secret_lb.Visible = false;
            secret_lb_2.Visible = false;

            if (secret_lb_2.Text == "222") 
            {
                // Создаем объект Random для генерации случайного числа в диапазоне от 1 до 334
                Random random = new Random();
                num_question = random.Next(1, 334);
                currentFirstAnswerId = conn.answers.Where(c => c.question_id == num_question).Select(c => c.id_answer).FirstOrDefault();
                int numAnswers = conn.answers.Where(c => c.question_id == num_question).Select(c => c.id_answer).Distinct().Count();
                question_lb.Text = (conn.questions.Where(c => c.id_question == num_question).SingleOrDefault()?.question_text).ToString();
                if (numAnswers == 2)
                {
                    rb_1.Visible = true;
                    rb_2.Visible = true;
                    rb_3.Visible = false;
                    rb_4.Visible = false;
                }
                if (numAnswers == 3)
                {
                    rb_1.Visible = true;
                    rb_2.Visible = true;
                    rb_3.Visible = true;
                    rb_4.Visible = false;
                }
                if (numAnswers == 4)
                {
                    rb_1.Visible = true;
                    rb_2.Visible = true;
                    rb_3.Visible = true;
                    rb_4.Visible = true;
                }
                if (currentFirstAnswerId != 0)
                {
                    rb_1.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId).SingleOrDefault()?.answer_text;
                    rb_2.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 1).SingleOrDefault()?.answer_text;
                    rb_3.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 2).SingleOrDefault()?.answer_text;
                    rb_4.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 3).SingleOrDefault()?.answer_text;
                }
                bool hasPicture = conn.questions.Any(c => c.id_question == num_question && c.is_picture == 1);
                if (hasPicture)
                {
                    string imageName = $"_{num_question}";
                    if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
                    {
                        picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                    }
                }
                else
                {
                    string imageName = $"_{0}";
                    if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
                    {
                        picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                    }
                }
            }
        }
        private void Return_b_Click_1(object sender, EventArgs e)
        {
           this.Hide();
           t.Show();
           t.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Forward_b_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked == false && rb_2.Checked == false && rb_3.Checked == false && rb_4.Checked == false)
            {
                MessageBox.Show("Выберите ответ!");
            }
            else
            {
                return_question_b.Enabled = true;
              if (rb_1.Checked) { 
                // Получить правильный ответ для данного вопроса
                int answer1 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId).Select(c => c.is_correct).FirstOrDefault());
                
                if (answer1 == 1)  // Если выбранный ответ является правильным
                {
                    trueCount++; // Увеличить количество правильных ответов на 1
                }
                else
                {
                    falseCount++;
                }
              }
                if (rb_2.Checked)
                {
                    int answer2 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 1).Select(c => c.is_correct).FirstOrDefault());
                    if (answer2 == 1)
                    {
                        trueCount++;
                    }
                    else
                    {
                        falseCount++;
                    }
                }
                if (rb_3.Checked)
                {
                    int answer3 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 2).Select(c => c.is_correct).FirstOrDefault());
                    
                    if (answer3 == 1)
                    {
                        trueCount++;
                    }
                    else
                    {
                        falseCount++;
                    }
                }
                if (rb_4.Checked)
                {
                    int answer4 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 3).Select(c => c.is_correct).FirstOrDefault());
                    
                    if (answer4 == 1)
                    {
                        trueCount++;
                    }
                    else
                    {
                        falseCount++;
                    }
                }
                if (secret_lb_2.Text == "222")
                {
                    buttonClick++;
                    if (buttonClick <= 40) // Если кнопка нажата не более 40 раз (для данного режима)
                    {
                        Random random = new Random();
                        num_question = random.Next(1, 334);
                        currentFirstAnswerId = conn.answers.Where(c => c.question_id == num_question).Select(c => c.id_answer).FirstOrDefault();
                        int numAnswers = conn.answers.Where(c => c.question_id == num_question).Select(c => c.id_answer).Distinct().Count();
                        question_lb.Text = (conn.questions.Where(c => c.id_question == num_question).SingleOrDefault()?.question_text).ToString();
                        if (numAnswers == 2)
                        {
                            rb_1.Visible = true;
                            rb_2.Visible = true;
                            rb_3.Visible = false;
                            rb_4.Visible = false;
                        }
                        if (numAnswers == 3)
                        {
                            rb_1.Visible = true;
                            rb_2.Visible = true;
                            rb_3.Visible = true;
                            rb_4.Visible = false;
                        }
                        if (numAnswers == 4)
                        {
                            rb_1.Visible = true;
                            rb_2.Visible = true;
                            rb_3.Visible = true;
                            rb_4.Visible = true;
                        }
                        if (currentFirstAnswerId != 0)
                        {
                            rb_1.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId).SingleOrDefault()?.answer_text;
                            rb_2.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 1).SingleOrDefault()?.answer_text;
                            rb_3.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 2).SingleOrDefault()?.answer_text;
                            rb_4.Text = conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 3).SingleOrDefault()?.answer_text;
                        }
                        bool hasPicture = conn.questions.Any(c => c.id_question == num_question && c.is_picture == 1);
                        if (hasPicture)
                        {
                            string imageName = $"_{num_question}";
                            if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
                            {
                                picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                            }
                        }
                        else
                        {
                            string imageName = $"_{0}";
                            if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
                            {
                                picture_panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                            }
                        }
                    }
                    if (buttonClick == 40)
                    {
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                       
                        if (falseCount > 2)
                        {
                            MessageBox.Show("Экзамен провален, кол-во ошибок больше 2-х!");
                        }
                        var user = conn.users.FirstOrDefault(u => u.id == userId);
                        user.@true = trueCount;
                        user.@false = falseCount;
                        conn.users.Add(user);
                        users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                        conn.users.Remove(select);
                        conn.SaveChanges();
                        DialogResult result = MessageBox.Show(
                        $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.ServiceNotification);
                        if (result == DialogResult.OK)
                        {
                            this.Hide();
                            t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                        }
                    }
                }

                if (secret_lb.Text == "1")  // Если в поле secret_lb записано число 1, что означает номер темы
                {
                    if (currentQuestionId < 25) // Если номер текущего вопроса меньше 25
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)  // Если id пользователя найден в базе данных
                        {
                            // Получаем пользователя из базы данных по его идентификатору
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            // Устанавливаем количество верных ответов у пользователя
                            user.@true = trueCount;
                            // Устанавливаем количество неверных ответов у пользователя
                            user.@false = falseCount;
                            // Добавляем пользователя в таблицу "users" в базе данных
                            conn.users.Add(user);
                            // Находим пользователя с таким же именем, как у пользователя входа в систему (Authorization.fio)
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            // Удаляем пользователя с таким же именем из базы данных
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location=new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text= "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show();
                                t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "2")
                {
                    if (currentQuestionId >= 26 && currentQuestionId < 40)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            T_Regulations t = new T_Regulations(fio, @true, @false);

                            t.true_lb.Text = "Количество правильных ответов: " + Authorization.@true;
                            t.false_lb.Text = "Количество неправильных ответов: " + Authorization.@false;
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show();
                                t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "3")
                {
                    if (currentQuestionId >= 41 && currentQuestionId < 60)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            T_Regulations t = new T_Regulations(fio, @true, @false);
                           
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "4")
                {
                    if (currentQuestionId >= 61 && currentQuestionId < 80)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                          //  falseCount = 20 - trueCount;
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "5")
                {
                    if (currentQuestionId >= 81 && currentQuestionId < 88)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "6")
                {
                    if (currentQuestionId >= 89 && currentQuestionId < 108)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "7")
                {
                    if (currentQuestionId >= 109 && currentQuestionId < 119)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "8")
                {
                    if (currentQuestionId >= 120 && currentQuestionId < 137)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "9")
                {
                    if (currentQuestionId >= 138 && currentQuestionId < 157)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "10")
                {
                    if (currentQuestionId >= 158 && currentQuestionId < 167)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "11")
                {
                    if (currentQuestionId >= 168 && currentQuestionId < 176)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "12")
                {
                    if (currentQuestionId >= 177 && currentQuestionId < 186)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "13")
                {
                    if (currentQuestionId >= 187 && currentQuestionId < 196)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "14")
                {
                    if (currentQuestionId >= 197 && currentQuestionId < 200)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "15")
                {
                    if (currentQuestionId >= 201 && currentQuestionId < 210)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "16")
                {
                    if (currentQuestionId >= 211 && currentQuestionId < 219)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "17")
                {
                    if (currentQuestionId >= 220 && currentQuestionId < 226)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "18")
                {
                    if (currentQuestionId >= 227 && currentQuestionId < 234)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                          //  falseCount = 8 - trueCount;
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "19")
                {
                    if (currentQuestionId >= 235 && currentQuestionId < 245)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                          //  falseCount = 11 - trueCount;
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "20")
                {
                    if (currentQuestionId >= 246 && currentQuestionId < 255)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                          //  falseCount = 10 - trueCount;
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "21")
                {
                    if (currentQuestionId >= 256 && currentQuestionId < 259)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "22")
                {
                    if (currentQuestionId >= 260 && currentQuestionId < 262)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "23")
                {
                    if (currentQuestionId >= 263 && currentQuestionId < 265)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "24")
                {
                    if (currentQuestionId >= 266 && currentQuestionId < 274)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "25")
                {
                    if (currentQuestionId >= 275 && currentQuestionId < 285)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "26")
                {
                    if (currentQuestionId >= 286 && currentQuestionId < 294)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "27")
                {
                    if (currentQuestionId >= 295 && currentQuestionId < 305)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "28")
                {
                    if (currentQuestionId >= 306 && currentQuestionId < 315)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                if (secret_lb.Text == "29")
                {
                    if (currentQuestionId >= 316 && currentQuestionId < 334)
                    {
                        currentQuestionId++;
                        LoadQuestion(currentQuestionId);
                        conn.SaveChanges();
                    }
                    else
                    {
                        LoadQuestion(currentQuestionId);
                        int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                        if (userId > 0)
                        {
                            var user = conn.users.FirstOrDefault(u => u.id == userId);
                            user.@true = trueCount;
                            user.@false = falseCount;
                            conn.users.Add(user);
                            users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                            conn.users.Remove(select);
                            conn.SaveChanges();
                            DialogResult result = MessageBox.Show(
                            $"Количество правильных ответов: {trueCount}\nКоличество неправильных ответов: {falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                            if (result == DialogResult.OK)
                            {
                                t.true_lb.Visible = false;
                                t.false_lb.Visible = false;
                                t.true_lb2.Visible = true;
                                t.false_lb2.Visible = true;
                                t.true_lb2.Location = new Point(16, 158);
                                t.false_lb2.Location = new Point(16, 187);
                                t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                                t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                                this.Hide();
                                t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                            }
                        }
                    }
                }
                comment_tb.Clear();
                rb_1.Checked = false;
                rb_2.Checked = false;
                rb_3.Checked = false;
                rb_4.Checked = false;

                comment_panel.Visible = false;// Комментарии скрыты
                answers_panel.Location = new Point(12, 543);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 387);
            }
        }
        private void Rb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (secret_lb_2.Text == "222" || secret_lb_2.Text == "333")
            {
                comment_panel.Visible = false;// Комментарии скрыты
                answers_panel.Location = new Point(12, 543);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 387);
            }
            else
            {
                comment_panel.Visible = true;
                comment_panel.Location = new Point(9, 554);
                comment_panel.Size = new Size(1103, 127);
                answers_panel.Location = new Point(9, 409);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 242);
            }
            LoadComment(currentQuestionId, currentFirstAnswerId); // Загрузить комментарий для данного вопроса и ответа
        }
        private void Rb_2_CheckedChanged(object sender, EventArgs e)
        {
            if (secret_lb_2.Text == "222" || secret_lb_2.Text == "333")
            {
                comment_panel.Visible = false;// Комментарии скрыты
                answers_panel.Location = new Point(12, 543);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 387);
            }
            else
            {
                comment_panel.Visible = true;
                comment_panel.Location = new Point(9, 554);
                comment_panel.Size = new Size(1103, 127);
                answers_panel.Location = new Point(9, 409);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 242);
            }
            LoadComment(currentQuestionId, currentFirstAnswerId + 1);
        }
        private void Rb_3_CheckedChanged(object sender, EventArgs e)
        {
            if (secret_lb_2.Text == "222" || secret_lb_2.Text == "333")
            {
                comment_panel.Visible = false;// Комментарии скрыты
                answers_panel.Location = new Point(12, 543);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 387);
            }
            else
            {
                comment_panel.Visible = true;
                comment_panel.Location = new Point(9, 554);
                comment_panel.Size = new Size(1103, 127);
                answers_panel.Location = new Point(9, 409);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 242);
            }
            LoadComment(currentQuestionId, currentFirstAnswerId + 2);
        }
        private void Rb_4_CheckedChanged(object sender, EventArgs e)
        {
            if (secret_lb_2.Text == "222" || secret_lb_2.Text == "333")
            {
                comment_panel.Visible = false;// Комментарии скрыты
                answers_panel.Location = new Point(12, 543);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 387);
            }
            else
            {
                comment_panel.Visible = true;
                comment_panel.Location = new Point(9, 554);
                comment_panel.Size = new Size(1103, 127);
                answers_panel.Location = new Point(9, 409);
                answers_panel.Size = new Size(1103, 125);
                picture_panel.Location = new Point(12, 150);
                picture_panel.Size = new Size(1103, 242);
            }
            LoadComment(currentQuestionId, currentFirstAnswerId + 3);         
        }
        private void Return_question_b_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked)
            {
                // Получить правильный ответ для данного вопроса
                int answer1 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId).Select(c => c.is_correct).FirstOrDefault());
                
                if (answer1 == 1)  // Если выбранный ответ является правильным
                {
                    trueCount--; // Уменьшить количество правильных ответов на 1
                }
                else
                {
                    falseCount--;
                }
            }
            if (rb_2.Checked)
            {
                int answer2 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 1).Select(c => c.is_correct).FirstOrDefault());
                
                if (answer2 == 1)
                {
                    trueCount--;
                }
                else
                {
                    falseCount--;
                }
            }
            if (rb_3.Checked)
            {
                int answer3 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 2).Select(c => c.is_correct).FirstOrDefault());
                
                if (answer3 == 1)
                {
                    trueCount--;
                }
                else
                {
                    falseCount--;
                }
            }
            if (rb_4.Checked)
            {
                int answer4 = Convert.ToInt32(conn.answers.Where(c => c.id_answer == currentFirstAnswerId + 3).Select(c => c.is_correct).FirstOrDefault());
                
                if (answer4 == 1)
                {
                    trueCount--;
                }
                else
                {
                    falseCount--;
                }
            }
            currentQuestionId--;
            LoadQuestion(currentQuestionId);
            conn.SaveChanges();
            comment_tb.Clear();
            rb_1.Checked = false;
            rb_2.Checked = false;
            rb_3.Checked = false;
            rb_4.Checked = false;
            comment_panel.Visible = false;// Комментарии скрыты
            answers_panel.Location = new Point(12, 543);
            answers_panel.Size = new Size(1103, 125);
            picture_panel.Location = new Point(12, 150);
            picture_panel.Size = new Size(1103, 387);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--; // Уменьшаем время на одну секунду
            time_l.Text = TimeSpan.FromSeconds(remainingTime).ToString(@"mm\:ss"); // Отображаем оставшееся время в формате "мм:сс"
            if (remainingTime == 0) // Если время истекло
            {
                timer1.Enabled = false;// Останавливаем таймер

                // Получаем идентификатор пользователя по его имени
                int userId = conn.users.FirstOrDefault(u => u.fio == Authorization.fio)?.id ?? 0;
                if (userId > 0) // Если пользователь найден
                {
                    DialogResult result = MessageBox.Show(
                            $"Время истекло! \n$Количество правильных ответов: { trueCount}\nКоличество неправильных ответов: { falseCount}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification);
                    if (result == DialogResult.OK)
                    {
                        t.true_lb.Visible = false;
                        t.false_lb.Visible = false;
                        t.true_lb2.Visible = true;
                        t.false_lb2.Visible = true;
                        t.true_lb2.Location = new Point(16, 158);
                        t.false_lb2.Location = new Point(16, 187);
                        t.true_lb2.Text = "Количество правильных ответов: " + trueCount;
                        t.false_lb2.Text = "Количество неправильных ответов: " + falseCount;
                        this.Hide();
                        t.Show(); t.StartPosition = FormStartPosition.CenterScreen;
                    }  // Отображаем сообщение о количестве правильных ответов
                    // Обновляем данные о пользователе в БД
                    var user = conn.users.FirstOrDefault(u => u.id == userId);
                    user.@true = trueCount;
                    user.@false = falseCount;
                    conn.users.Add(user);
                    users select = conn.users.Where(c => c.fio == Authorization.fio).First();
                    conn.users.Remove(select);
                    conn.SaveChanges();
                    this.Hide(); // Скрываем текущую форму
                   t.Show(); t.StartPosition = FormStartPosition.CenterScreen; // Отображаем форму с результатами тестирования.
                }
            }
        }
    }
}
