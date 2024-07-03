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
            Event e = evnt.GetEventById(id);
//          comboBoxCategory.SelectedItem = e.category;
            List<ControlMetadata> controlMetadataList = helper.GetControlMetadata(e.Category);
            helper.GenerateControls(controlMetadataList, panelControls);
            helper.PopulateComboBoxs(e.Category, panelControls);
            foreach (var metadata in controlMetadataList)
            {
                if (metadata.IsVisible)
                {
                    // Find the control by name
                    var control = Controls.Find(metadata.ControlName, true).FirstOrDefault();
                    // Skip if the control is not found
                    if (control == null) continue;

                    var propertyValue = typeof(Event).GetProperty(metadata.DatabaseField)?.GetValue(e);

                    if (control is TextBox txt && propertyValue != null)
                    {
                        txt.Text = propertyValue.ToString();
                    }
                    else if (control is ComboBox comboBox && propertyValue != null)
                    {
                        comboBox.SelectedItem = propertyValue.ToString();
                    }
                    else if (control is DateTimePicker date && propertyValue is DateTime dateValue)
                    {
                        date.Value = dateValue;
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

