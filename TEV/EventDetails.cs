using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEV.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TEV
{
    public partial class EventDetails : Form
    {
        private int eventId;
        private string eventCategory;
        Event evnt = new Event();
        Helper helper = new Helper();
        public EventDetails(int id, string category)
        {
            InitializeComponent();
            eventId = id;
            eventCategory = category;
        }

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string databasePath = Path.Combine(desktopPath, "TEV/database.db");
        static string connectionString = $"Data Source=\"{databasePath}\";Version=3;";

        private void EventDetails_Load(object sender, EventArgs e)
        {
            // Dynamically generate controls based on the event category
            helper.GenerateControls(helper.GetControlMetadata(eventCategory), panelControls);
            // Load the event details and populate controls
            LoadEventDetails(eventId);
        }

        public void LoadEventDetails(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                string sql = @"SELECT 
                    code,c.name AS category,reference,source,occurrence_date,notification_date,t.name as event_type,location,involved_traffic,description,ca.text AS event_cause,frequency,severity,classe,s.name AS event_status,e.color as color,flight_phase,altitude,report_elaboration_date,report_reception_date,recommendations_release_date,evidence_reception_date
                    FROM events e
                    LEFT JOIN categories c ON e.category_id = c.id
                    LEFT JOIN event_types t ON e.event_type_id = t.id
                    LEFT JOIN event_causes ca ON e.event_cause_id = ca.id
                    LEFT JOIN event_statuses s ON e.event_cause_id = s.id
                    WHERE e.id = @EventId";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@EventId", id);
                con.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var controlMetadataList = helper.GetControlMetadata(eventCategory);

                        foreach (var metadata in controlMetadataList)
                        {
                            if (metadata.IsVisible)
                            {
                                if (Controls.Find(metadata.ControlName, true).FirstOrDefault() is TextBox txt)
                                {
                                    txt.Text = reader[metadata.DatabaseField].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

    }

    public class ControlMetadata
    {
        public string LabelText { get; set; }
        public string ControlName { get; set; }
        public string DatabaseField { get; set; }
        public bool IsVisible { get; set; }
        public string ControlType { get; set; }
        public string Validation { get; set; }
    }
}

