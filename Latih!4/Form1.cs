using Microsoft.Extensions.Configuration;

namespace Latih_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadConfiguration();
        }
        private void LoadConfiguration()
        {
            var appsetting = Program.Configuration.GetSection("AppSettings");
            var connectionString = Program.Configuration.GetConnectionString("DefaultConnection");

            string appName = appsetting["ApplicationName"];
            string version = appsetting["Version"];
            string theme = appsetting.GetSection("Settings")["theme"];
            string language = appsetting.GetSection("Settings")["Language"];

            MessageBox.Show($"App Name: {appName}\nVersion: {version}\nTheme: {theme}\nLanguage: {language}\nConnection String: {connectionString}");
        }
    }
}
