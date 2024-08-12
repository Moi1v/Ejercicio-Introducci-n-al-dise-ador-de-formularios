namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {

            string TextoObtenido = this.TextBoxName.Text;
            string Email = this.TextBoxEmail.Text;
            string Message = this.TextBoxMessage.Text;

            string Affirmative = "Asset";
            string Negative = "writing error";

            if (!string.IsNullOrWhiteSpace(TextoObtenido) &&
                !string.IsNullOrWhiteSpace(Email) &&
                !string.IsNullOrWhiteSpace(Message) &&
                TextoObtenido.All(char.IsLetter) &&
                Message.All(char.IsLetter))
            {
                this.Estado.Text = Affirmative.ToString();
            }

            else
            {
                this.Estado.Text = Negative.ToString();
            }


        }

        private void Clean_Click(object sender, EventArgs e)
        {
            this.TextBoxName.Clear();
            this.TextBoxEmail.Clear();
            this.TextBoxMessage.Clear();
        }
    }
}
