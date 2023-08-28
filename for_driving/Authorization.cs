using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace for_driving
{
    public partial class Authorization : MaterialForm
    {
        testEntities13 conn = new testEntities13(); //Строка подключения к БД
        // Объявляем статические строки для передачи в другие формы
        public static string fio;
        public static string @true;
        public static string @false;
        public Authorization()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.BlueGrey700, Primary.BlueGrey700,
            Primary.Amber50, Accent.Red700,
            TextShade.WHITE);
            pass_tb.UseSystemPasswordChar = true;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Login_b_Click(object sender, EventArgs e)
        {   
            // Проверяем наличие пользователя с указанными логином и паролем в базе данных
            int count = conn.users.Where(c => (c.login == log_tb.Text) && (c.password == pass_tb.Text)).Count();
            if (count == 1)
            {
                // Если пользователь найден, получаем его данные
                users listGroup = conn.users.Where(c => (c.login == log_tb.Text) && (c.password == pass_tb.Text)).First();
                fio = Convert.ToString(listGroup.fio);
                @true = Convert.ToString(listGroup.@true);
                @false = Convert.ToString(listGroup.@false);
                T_Regulations t = new T_Regulations(fio, @true, @false);
                this.Hide();
                t.ShowDialog();
            }
            else MessageBox.Show("Неправильно указан логин и/или пароль.");
        }
        private void Reg_b_Click_1(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
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
