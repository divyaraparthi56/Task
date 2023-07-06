using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace WinFormsApp1_sub_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "started counting please wait";
            int c = CountChar();
            label1.Text = "count" + c.ToString();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int CountChar()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\draparthi\\Desktop\\file.txt"))
            {
                count = reader.ReadToEnd().Length;
                Thread.Sleep(5000);
            }
            return count;
        }
    }
}