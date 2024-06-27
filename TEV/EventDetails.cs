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
        public EventDetails(int id, string category)
        {
            InitializeComponent();
            eventId = id;
            eventCategory = category;
        }

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string databasePath = Path.Combine(desktopPath, "TEV/database.db");
        static string connectionString = $"Data Source=\"{databasePath}\";Version=3;";

        public List<ControlMetadata> GetControlMetadata(string category)
        {
            // Fetch the field visibility settings from the database based on the category
            var settings = evnt.getEventCategoriesAndVisibility(category);
            return new List<ControlMetadata>
            {
                new ControlMetadata { LabelText = "Code", ControlName = "txtCode", DatabaseField = "code", IsVisible = settings.show_code },
                new ControlMetadata { LabelText = "Reference", ControlName = "txtReference", DatabaseField = "reference", IsVisible = settings.show_reference },
                new ControlMetadata { LabelText = "Source", ControlName = "txtSource", DatabaseField = "source", IsVisible = settings.show_source },
                new ControlMetadata { LabelText = "Date de l'occurance", ControlName = "txtOccurrenceDate", DatabaseField = "occurrence_date", IsVisible = settings.show_occurrence_date },
                new ControlMetadata { LabelText = "Date de la notification", ControlName = "txtNotificationDate", DatabaseField = "notification_date", IsVisible = settings.show_notification_date },
                new ControlMetadata { LabelText = "Type", ControlName = "txtShowEventType", DatabaseField = "event_type", IsVisible = settings.show_eventType },
                new ControlMetadata { LabelText = "Location", ControlName = "txtShowLocation", DatabaseField = "location", IsVisible = settings.show_location },
                new ControlMetadata { LabelText = "Traffic impliqué", ControlName = "txtShowInvolvedTraffic", DatabaseField = "involved_traffic", IsVisible = settings.show_involved_traffic },
                new ControlMetadata { LabelText = "Description", ControlName = "txtDescription", DatabaseField = "description", IsVisible = settings.show_description },
                new ControlMetadata { LabelText = "Cause", ControlName = "txtCause", DatabaseField = "event_cause", IsVisible = settings.show_event_cause },
                new ControlMetadata { LabelText = "Fréquence", ControlName = "txtShowFrequency", DatabaseField = "frequency", IsVisible = settings.show_frequency },
                new ControlMetadata { LabelText = "Gravité", ControlName = "txtSeverity", DatabaseField = "severity", IsVisible = settings.show_severity },
                new ControlMetadata { LabelText = "Classe", ControlName = "txtClasse", DatabaseField = "classe", IsVisible = settings.show_classe },
                new ControlMetadata { LabelText = "Etat", ControlName = "txtEventStatus", DatabaseField = "event_status", IsVisible = settings.show_event_status },
                new ControlMetadata { LabelText = "Coleur", ControlName = "txtColor", DatabaseField = "color", IsVisible = settings.show_color },
                new ControlMetadata { LabelText = "Phase de vol", ControlName = "txtFlightPhase", DatabaseField = "flight_phase", IsVisible = settings.show_flight_phase },
                new ControlMetadata { LabelText = "Altitude", ControlName = "txtAltitude", DatabaseField = "altitude", IsVisible = settings.show_altitude },
                new ControlMetadata { LabelText = "Date d'élaboration de rapport", ControlName = "txtReportElaborationDate", DatabaseField = "report_elaboration_date", IsVisible = settings.show_report_elaboration_date },
                new ControlMetadata { LabelText = "Date de récption du rapport", ControlName = "txtReportReceptionDate", DatabaseField = "report_reception_date", IsVisible = settings.show_report_reception_date },
                new ControlMetadata { LabelText = "Date de récption du dernier élément d'analyse", ControlName = "txtlast_elm_reception_date", DatabaseField = "last_elm_reception_date", IsVisible = settings.show_last_elm_reception_date },
                new ControlMetadata { LabelText = "Date de diffusion des recommandations", ControlName = "txtRecommendations_release_date", DatabaseField = "recommendations_release_date", IsVisible = settings.show_recommendations_release_date },
                new ControlMetadata { LabelText = "Date reception evidence", ControlName = "txtEvidence_reception_date", DatabaseField = "evidence_reception_date", IsVisible = settings.show_evidence_reception_date },
            }; 
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {
            // Dynamically generate controls based on the event category
            GenerateControls(eventCategory);
            // Load the event details and populate controls
            LoadEventDetails(eventId);
        }

        private void GenerateControls(string category)
        {
            var controlMetadataList = GetControlMetadata(category);
            int yPosition = 20; // Starting position for controls
            int labelWidth = 100; // Width for the labels
            int textboxWidth = 200; // Width for the textboxes
            int spacing = 10; // Spacing between controls

            foreach (var metadata in controlMetadataList)
            {
                if (metadata.IsVisible)
                {
                    Label lbl = new Label { Text = metadata.LabelText, Location = new Point(20, yPosition), Width = textboxWidth };
                    TextBox txt = new TextBox { Name = metadata.ControlName, Location = new Point(240, yPosition), Width = textboxWidth };
                    panelControls.Controls.Add(lbl);
                    panelControls.Controls.Add(txt);
                    yPosition += 30 + spacing;
                }
            }
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
                        var controlMetadataList = GetControlMetadata(eventCategory);

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
    }
}

