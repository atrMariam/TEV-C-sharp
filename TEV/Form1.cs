using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using TEV.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Event evnt = new Event();

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string databasePath = Path.Combine(desktopPath, "TEV/database.db");
        static string connectionString = $"Data Source=\"{databasePath}\";Version=3;";

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

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["Id"].Value.ToString();

                // Show a confirmation dialog with Yes and No buttons
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Check the result of the confirmation dialog
                if (result == DialogResult.Yes)
                {
                    // Perform the delete operation if the user clicked Yes
                    evnt.id = int.Parse(id);
                    bool success = evnt.DeleteEvent(evnt);
                    if (success == true)
                    {
                        MessageBox.Show("Event has been successfully deleted.");
                        // Load the data on the DataGridView
                        DataTable dt = evnt.select();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the event. Try again.");
                    }
                }
                else
                {
                    // The user clicked No, so cancel the delete operation
                    MessageBox.Show("Delete operation canceled.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void buttonEditerEvent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int selectedEventId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                CreateEvent createEvent = new CreateEvent(selectedEventId, true);
                createEvent.DataUpdated += new EventHandler(Form1_Load);
                createEvent.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void buttonShowEventDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedEventId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                
                string eventCategory = "";
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    string sql = "SELECT name FROM categories WHERE id = (SELECT category_id FROM events WHERE id=@eventId)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@eventId", selectedEventId);
                    con.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            eventCategory = reader["name"].ToString();
                        }
                    }
                }

                EventDetails detailsForm = new EventDetails(selectedEventId, eventCategory);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an event first.");
            }
        }
    }
}
