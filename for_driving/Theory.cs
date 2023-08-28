using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using AcroPDFLib;
namespace for_driving
{
    public partial class Theory : MaterialForm
    {
        public static string fio;
        public static string @true;
        public static string @false;
        public static AcroPDF axAcroPDF;
        public Theory()
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
        private void Return_b_Click(object sender, EventArgs e)
        {
            T_Regulations t = new T_Regulations(fio, @true, @false);
            this.Hide();
            t.Show();
        }
        private void Theory_Load(object sender, EventArgs e)
        {
          axAcroPDF1.LoadFile(@"pdd-2023.pdf"); // Загружаем PDF-файл с правилами дорожного движения
        }

        private void Theory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
