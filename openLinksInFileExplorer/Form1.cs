using openLinksInFileExplorerCore;

namespace openLinksInFileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            //load settings
            //create config file
            ConfigLoader configLoader = new ConfigLoader();
            
            //set textbox
            textBox_allowedExtensions.Text = string.Join(", ", configLoader.get().allowedExtensions);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration conf = new Configuration();
            conf.allowedExtensions = textBox_allowedExtensions.Text.Split(", ");
            new ConfigLoader().set(conf);
            this.Close();
        }

        private void textBox_allowedExtensions_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
