

using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TEV.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEV
{
    public partial class CreateEvent : Form
    {
        public event EventHandler DataUpdated;
        Event evnt = new Event();

        public CreateEvent()
        {
            InitializeComponent();
        }

        protected virtual void OnDataUpdated(EventArgs e)
        {
            DataUpdated?.Invoke(this, e);
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;

            List<string> categories = evnt.selectCategories();
            // Populate the comboBoxUserType with categories from the database
            comboBoxCategory.Items.Clear(); // Clear existing items if any
            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }

            comboBoxStatus.Items.Clear();
            List<string> eventStatus = evnt.selectEventStatus();
            foreach (string item in eventStatus)
            {
                comboBoxStatus.Items.Add(item);
            }

            comboBoxCauses.Items.Clear();
            List<string> eventCauses = evnt.selectEventCauses();
            foreach (string item in eventCauses)
            {
                comboBoxCauses.Items.Add(item);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;

            string selectedEventCategory = comboBoxCategory.SelectedItem.ToString();

            comboBoxEventType.Items.Clear();
            List<string> eventTypes = evnt.selectEventTypes(selectedEventCategory);
            foreach (string item in eventTypes)
            {
                comboBoxEventType.Items.Add(item);
            }

            EventFormVisibility settings = evnt.getEventCategoriesAndVisibility(selectedEventCategory);
            textBoxCode.Visible = settings.show_code;
            labelCode.Visible = settings.show_code;
            textBoxReference.Visible = settings.show_reference;
            labelReference.Visible = settings.show_reference;
            textBoxSource.Visible = settings.show_source;
            labelSource.Visible = settings.show_source;
            dateTimePickerOccurrenceDate.Visible = settings.show_occurrence_date;
            labelOccurrenceDate.Visible = settings.show_occurrence_date;
            dateTimePickerNotificationDate.Visible = settings.show_notification_date;
            labelNotificationDate.Visible = settings.show_notification_date;
            comboBoxEventType.Visible = settings.show_eventType;
            labelEventType.Visible = settings.show_eventType;
            textBoxLocation.Visible = settings.show_location;
            labelLocation.Visible = settings.show_location;
            textBoxInvolvedTraffic.Visible = settings.show_involved_traffic;
            labelInvolvedTraffic.Visible = settings.show_involved_traffic;
            textBoxDescription.Visible = settings.show_description;
            labelDescription.Visible = settings.show_description;
            comboBoxCauses.Visible = settings.show_event_cause;
            labelCauses.Visible = settings.show_event_cause;
            comboBoxFrequency.Visible = settings.show_frequency;
            labelFrequency.Visible = settings.show_frequency;
            comboBoxSeverity.Visible = settings.show_severity;
            labelSeverity.Visible = settings.show_severity;
            //show_classe.Visible = settings.show_classe ;
            textBoxSecurityRecommandation.Visible = settings.show_security_recommendation;
            labelSecurityRecommandation.Visible = settings.show_security_recommendation;
            comboBoxStatus.Visible = settings.show_event_status;
            labelStatus.Visible = settings.show_event_status;
            textBoxColor.Visible = settings.show_color;
            labelColor.Visible = settings.show_color;
            textBoxFlightPhase.Visible = settings.show_flight_phase;
            labelFlightPhase.Visible = settings.show_flight_phase;
            textBoxAltitude.Visible = settings.show_altitude;
            labelAltitude.Visible = settings.show_altitude;
            dateTimePickerReportElaborationDate.Visible = settings.show_report_elaboration_date;
            labelReportElaborationDate.Visible = settings.show_report_elaboration_date;
            dateTimePickerReportReceptionDate.Visible = settings.show_report_reception_date;
            labelReportReceptionDate.Visible = settings.show_report_reception_date;
            dateTimePickerLastElmReceptionDate.Visible = settings.show_last_elm_reception_date;
            labelLastElmReceptionDate.Visible = settings.show_last_elm_reception_date;
            dateTimePickerRecommendationsReleaseDate.Visible = settings.show_recommendations_release_date;
            labelRecommendationsReleaseDate.Visible = settings.show_recommendations_release_date;
            dateTimePickerEvidenceReceptionDate.Visible = settings.show_evidence_reception_date;
            labelEvidenceReceptionDate.Visible = settings.show_evidence_reception_date;

            // Refresh the TableLayoutPanel to update the layout
            flowLayoutPanel1.PerformLayout();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs())
            {
                MessageBox.Show("Please correct the highlighted fields.");
                return;
            }
            // Get the values from the input fields, checking if they are visible
            evnt.category = comboBoxCategory.SelectedItem?.ToString();
            evnt.code = textBoxCode.Visible ? textBoxCode.Text : null;
            evnt.reference = textBoxReference.Visible ? textBoxReference.Text : null;
            evnt.source = textBoxSource.Visible ? textBoxSource.Text : null;
            evnt.occurrence_date = dateTimePickerOccurrenceDate.Value;
            evnt.notification_date = dateTimePickerNotificationDate.Value;
            evnt.eventType = comboBoxEventType.SelectedItem?.ToString();
            evnt.location = textBoxLocation.Visible ? textBoxLocation.Text : null;
            evnt.involved_traffic = textBoxInvolvedTraffic.Visible ? textBoxInvolvedTraffic.Text : null;
            evnt.description = textBoxDescription.Visible ? textBoxDescription.Text : null;
            evnt.event_cause = comboBoxCauses.SelectedItem?.ToString();
            evnt.frequency = comboBoxFrequency.SelectedItem?.ToString();
            evnt.severity = comboBoxSeverity.SelectedItem?.ToString();
            evnt.security_recommendation = textBoxSecurityRecommandation.Visible ? textBoxSecurityRecommandation.Text : null;
            evnt.event_status = comboBoxStatus.SelectedItem?.ToString();
            evnt.color = textBoxColor.Visible ? textBoxColor.Text : null;
            evnt.flight_phase = textBoxFlightPhase.Visible ? textBoxFlightPhase.Text : null;
            evnt.altitude = textBoxAltitude.Visible ? textBoxAltitude.Text : null;
            evnt.report_elaboration_date = dateTimePickerReportElaborationDate.Value;
            evnt.report_reception_date = dateTimePickerReportReceptionDate.Value;
            evnt.last_elm_reception_date = dateTimePickerLastElmReceptionDate.Value;
            evnt.recommendations_release_date = dateTimePickerRecommendationsReleaseDate.Value;
            evnt.evidence_reception_date = dateTimePickerEvidenceReceptionDate.Value;

            bool success = evnt.InsertEvent(evnt);
            if (success == true)
            {
                // Trigger the event
                OnDataUpdated(EventArgs.Empty);
                MessageBox.Show("New User Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New User. Try Again");
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textBoxCode.Text = "";
            textBoxReference.Text = "";
            textBoxSource.Text = "";
            dateTimePickerOccurrenceDate.Value = DateTime.Now;
            dateTimePickerNotificationDate.Value = DateTime.Now;
            comboBoxEventType.SelectedIndex = -1;
            textBoxLocation.Text = "";
            textBoxInvolvedTraffic.Text = "";
            textBoxDescription.Text = "";
            comboBoxCauses.SelectedIndex = -1;
            comboBoxFrequency.SelectedIndex = -1;
            comboBoxSeverity.SelectedIndex = -1;
            textBoxSecurityRecommandation.Text = "";
            comboBoxStatus.SelectedIndex = -1;
            textBoxColor.Text = "";
            textBoxFlightPhase.Text = "";
            textBoxAltitude.Text = "";
            dateTimePickerReportElaborationDate.Value = DateTime.Now;
            dateTimePickerReportReceptionDate.Value = DateTime.Now;
            dateTimePickerLastElmReceptionDate.Value = DateTime.Now;
            dateTimePickerRecommendationsReleaseDate.Value = DateTime.Now;
            dateTimePickerEvidenceReceptionDate.Value = DateTime.Now;
        }

        public bool ValidateInputs()
        {
            // Define a lighter red color
            Color lighterRed = Color.FromArgb(255, 204, 204);

            bool isValid = true;

            if (string.IsNullOrEmpty(comboBoxCategory.SelectedItem?.ToString()))
            {
                comboBoxCategory.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                comboBoxCategory.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxCode.Text) && textBoxCode.Visible)
            {
                textBoxCode.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxCode.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxReference.Text) && textBoxReference.Visible)
            {
                textBoxReference.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxCode.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxSource.Text) && textBoxSource.Visible)
            {
                textBoxSource.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxSource.BackColor = Color.White;
            }

            if (dateTimePickerOccurrenceDate.Value == dateTimePickerOccurrenceDate.MinDate && dateTimePickerOccurrenceDate.Visible)
            {
                dateTimePickerOccurrenceDate.CalendarTitleBackColor = lighterRed;
                isValid = false;
            }
            else
            {
                dateTimePickerOccurrenceDate.CalendarTitleBackColor = Color.White;
            }

            if (dateTimePickerNotificationDate.Value == dateTimePickerNotificationDate.MinDate && dateTimePickerNotificationDate.Visible)
            {
                dateTimePickerNotificationDate.CalendarTitleBackColor = lighterRed;
                isValid = false;
            }
            else
            {
                dateTimePickerNotificationDate.CalendarTitleBackColor = Color.White;
            }

            if (comboBoxEventType.SelectedItem == null)
            {
                comboBoxEventType.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                comboBoxEventType.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxLocation.Text) && textBoxLocation.Visible)
            {
                textBoxLocation.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxLocation.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxInvolvedTraffic.Text) && textBoxInvolvedTraffic.Visible)
            {
                textBoxInvolvedTraffic.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxInvolvedTraffic.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxDescription.Text) && textBoxDescription.Visible)
            {
                textBoxDescription.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxDescription.BackColor = Color.White;
            }

            if (comboBoxCauses.SelectedItem == null)
            {
                comboBoxCauses.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                comboBoxCauses.BackColor = Color.White;
            }

            if (comboBoxFrequency.SelectedItem == null)
            {
                comboBoxFrequency.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                comboBoxFrequency.BackColor = Color.White;
            }

            if (comboBoxSeverity.SelectedItem == null)
            {
                comboBoxSeverity.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                comboBoxSeverity.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxSecurityRecommandation.Text) && textBoxSecurityRecommandation.Visible)
            {
                textBoxSecurityRecommandation.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxSecurityRecommandation.BackColor = Color.White;
            }

            if (comboBoxStatus.SelectedItem == null)
            {
                comboBoxStatus.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                comboBoxStatus.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxColor.Text) && textBoxColor.Visible)
            {
                textBoxColor.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxColor.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxFlightPhase.Text) && textBoxFlightPhase.Visible)
            {
                textBoxFlightPhase.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxColor.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(textBoxAltitude.Text) && textBoxAltitude.Visible)
            {
                textBoxAltitude.BackColor = lighterRed;
                isValid = false;
            }
            else
            {
                textBoxAltitude.BackColor = Color.White;
            }

            if (dateTimePickerReportElaborationDate.Value == dateTimePickerReportElaborationDate.MinDate && dateTimePickerReportElaborationDate.Visible)
            {
                dateTimePickerReportElaborationDate.CalendarTitleBackColor = lighterRed;
                isValid = false;
            }
            else
            {
                dateTimePickerReportElaborationDate.CalendarTitleBackColor = Color.White;
            }

            if (dateTimePickerReportReceptionDate.Value == dateTimePickerReportReceptionDate.MinDate && dateTimePickerReportReceptionDate.Visible)
            {
                dateTimePickerReportReceptionDate.CalendarTitleBackColor = lighterRed;
                isValid = false;
            }
            else
            {
                dateTimePickerReportReceptionDate.CalendarTitleBackColor = Color.White;
            }

            if (dateTimePickerLastElmReceptionDate.Value == dateTimePickerLastElmReceptionDate.MinDate && dateTimePickerLastElmReceptionDate.Visible)
            {
                dateTimePickerLastElmReceptionDate.CalendarTitleBackColor = lighterRed;
                isValid = false;
            }
            else
            {
                dateTimePickerLastElmReceptionDate.CalendarTitleBackColor = Color.White;
            }

            if (dateTimePickerRecommendationsReleaseDate.Value == dateTimePickerRecommendationsReleaseDate.MinDate && dateTimePickerRecommendationsReleaseDate.Visible)
            {
                dateTimePickerRecommendationsReleaseDate.CalendarTitleBackColor = lighterRed;
                isValid = false;
            }
            else
            {
                dateTimePickerRecommendationsReleaseDate.CalendarTitleBackColor = Color.White;
            }

            if (dateTimePickerEvidenceReceptionDate.Value == dateTimePickerEvidenceReceptionDate.MinDate && dateTimePickerEvidenceReceptionDate.Visible)
            {
                dateTimePickerEvidenceReceptionDate.CalendarTitleBackColor = lighterRed;
                isValid = false;
            }
            else
            {
                dateTimePickerEvidenceReceptionDate.CalendarTitleBackColor = Color.White;
            }

            return isValid;
        }

    }
}
