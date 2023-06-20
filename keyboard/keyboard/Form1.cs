namespace keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddToTextbox(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Text == "Space")
                    this.RichTextBox.Text += " ";
                else
                    this.RichTextBox.Text += button.Text;
            }
        }
        private void DeleteToTextbox(object sender, EventArgs e)
        {
            if (this.RichTextBox.Text.Length == 0)
            {
                return;
            }
            string text = this.RichTextBox.Text;
            this.RichTextBox.Text = text.Substring(0, text.Length - 1);
        }
    }
}