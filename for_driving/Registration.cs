using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace for_driving
{
    public partial class Registration : MaterialForm
    {
       testEntities13 conn = new testEntities13();//Строка подключения к БД
        public Registration()
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
            pass_tb.UseSystemPasswordChar = true;
        }
        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Reg_b_Click_1(object sender, EventArgs e)
        {
            users user = new users(); // Создаем новый объект пользователя
            // Создаем новый объект пользователя
            user.fio = Convert.ToString(fio_tb.Text);
            user.login = Convert.ToString(log_tb.Text);
            user.password = Convert.ToString(pass_tb.Text);
            conn.users.Add(user);  // Добавляем объект пользователя в базу данных
            conn.SaveChanges();
            // Проверяем, что все поля формы заполнены
            if (pass_tb.Text == "" || fio_tb.Text == "" || log_tb.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                MessageBox.Show("Регистрация прошла успешно.");
                Authorization authorization = new Authorization();
                this.Hide();
                authorization.ShowDialog();
            }
        }
        private void Return_b_Click_1(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.ShowDialog();
        }

        private void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                pass_tb.UseSystemPasswordChar = false;
            }
            else
            {
                pass_tb.UseSystemPasswordChar = true;
            }
        }
    }
}
