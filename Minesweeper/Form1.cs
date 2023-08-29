namespace Minesweeper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            time timer = new time(this, timeView);
            functions function = new functions(this, "Form1");
            function.FillGroupGame(groupGameForm1, 10, 10);
            timer.startTimer();
            home.Click += new EventHandler(BackHome);
            settings.Click += new EventHandler(settings_Click);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void BackHome(object sender, EventArgs e)
        {
            functions function = new functions(this, "Form1");
            function.buttonsClear();
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}