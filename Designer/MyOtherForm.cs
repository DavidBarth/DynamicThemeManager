using System.Windows.Forms;


namespace Designer
{
    public partial class MyOtherForm : Form
    {
        IThemeService service = new ThemeService();

        public MyOtherForm()
        {
            Init();           

        }

        private void Init()
        {
            InitializeComponent();
            MessageLabel.Text = "";
        }

        private void ShowMessageButton_MouseClick(object sender, MouseEventArgs e)
        {
            var source = service.GetThemes();
            comboBox1.DataSource = source;
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem;
           // int themeSwitch = int.Parse(selectedItem.ToString());

            switch selectedItem)
            {
                case 1:
                    MessageBox.Show("Switch to theme 2");
                    break;

                case 2:
                    MessageBox.Show("Switch to theme 2");
                    break;
            }
        }
    }
}
