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
        }
    }
}