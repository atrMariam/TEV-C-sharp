using System.Data;
using TEV.classes;

namespace TEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Event evnt = new Event();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = evnt.select();
            dataGridView1.DataSource = dt;
        }

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            // open form to add a new recod
            CreateEvent createEvent = new CreateEvent();
            createEvent.DataUpdated += new EventHandler(Form1_Load);
            createEvent.ShowDialog();
        }
    }
}
