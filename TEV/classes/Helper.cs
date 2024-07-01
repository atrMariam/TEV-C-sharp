using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEV.classes
{
    public class Helper
    {
        Event evnt = new Event();
        public List<ControlMetadata> GetControlMetadata(string category)
        {
            // Fetch the field visibility settings from the database based on the category
            var settings = evnt.getEventCategoryAndVisibility(category);
            return new List<ControlMetadata>
            {
                new ControlMetadata { LabelText = "Code", ControlName = "txtCode", DatabaseField = "code", IsVisible = settings.show_code, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Reference", ControlName = "txtReference", DatabaseField = "reference", IsVisible = settings.show_reference, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Source", ControlName = "txtSource", DatabaseField = "source", IsVisible = settings.show_source, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Date de l'occurance", ControlName = "txtOccurrenceDate", DatabaseField = "occurrence_date", IsVisible = settings.show_occurrence_date, ControlType="DateTimePicker", Validation="required" },
                new ControlMetadata { LabelText = "Date de la notification", ControlName = "txtNotificationDate", DatabaseField = "notification_date", IsVisible = settings.show_notification_date, ControlType="DateTimePicker", Validation="required" },
                new ControlMetadata { LabelText = "Type", ControlName = "comboBoxEventType", DatabaseField = "event_type", IsVisible = settings.show_eventType, ControlType="ComboBox", Validation="required" },
                new ControlMetadata { LabelText = "Location", ControlName = "txtShowLocation", DatabaseField = "location", IsVisible = settings.show_location, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Traffic impliqué", ControlName = "txtShowInvolvedTraffic", DatabaseField = "involved_traffic", IsVisible = settings.show_involved_traffic, Validation="required" },
                new ControlMetadata { LabelText = "Description", ControlName = "txtDescription", DatabaseField = "description", IsVisible = settings.show_description, ControlType="MultiLineTextBox", Validation="required" },
                new ControlMetadata { LabelText = "Cause", ControlName = "comboBoxCause", DatabaseField = "event_cause", IsVisible = settings.show_event_cause, ControlType="ComboBox", Validation="required" },
                new ControlMetadata { LabelText = "Fréquence", ControlName = "comboBoxShowFrequency", DatabaseField = "frequency", IsVisible = settings.show_frequency, ControlType="ComboBox", Validation="required" },
                new ControlMetadata { LabelText = "Gravité", ControlName = "comboBoxSeverity", DatabaseField = "severity", IsVisible = settings.show_severity, ControlType="ComboBox", Validation="required" },
                new ControlMetadata { LabelText = "Classe", ControlName = "txtClasse", DatabaseField = "classe", IsVisible = settings.show_classe, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Recommandation de sécurité", ControlName = "textBoxSecurityRecommandation", DatabaseField = "security_recommendation", IsVisible = settings.show_security_recommendation, ControlType="MultiLineTextBox", Validation="required" },
                new ControlMetadata { LabelText = "Etat", ControlName = "comboBoxEventStatus", DatabaseField = "event_status", IsVisible = settings.show_event_status, ControlType="ComboBox", Validation="required" },
                new ControlMetadata { LabelText = "Coleur", ControlName = "txtColor", DatabaseField = "color", IsVisible = settings.show_color, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Phase de vol", ControlName = "txtFlightPhase", DatabaseField = "flight_phase", IsVisible = settings.show_flight_phase, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Altitude", ControlName = "txtAltitude", DatabaseField = "altitude", IsVisible = settings.show_altitude, ControlType="TextBox", Validation="required" },
                new ControlMetadata { LabelText = "Date d'élaboration de rapport", ControlName = "txtReportElaborationDate", DatabaseField = "report_elaboration_date", IsVisible = settings.show_report_elaboration_date, ControlType="DateTimePicker", Validation="required" },
                new ControlMetadata { LabelText = "Date de récption du rapport", ControlName = "txtReportReceptionDate", DatabaseField = "report_reception_date", IsVisible = settings.show_report_reception_date, ControlType="DateTimePicker", Validation="required" },
                new ControlMetadata { LabelText = "Date de récption du dernier élément d'analyse", ControlName = "txtlast_elm_reception_date", DatabaseField = "last_elm_reception_date", IsVisible = settings.show_last_elm_reception_date, ControlType="DateTimePicker", Validation="required" },
                new ControlMetadata { LabelText = "Date de diffusion des recommandations", ControlName = "txtRecommendations_release_date", DatabaseField = "recommendations_release_date", IsVisible = settings.show_recommendations_release_date, ControlType="DateTimePicker", Validation="required" },
                new ControlMetadata { LabelText = "Date reception evidence", ControlName = "txtEvidence_reception_date", DatabaseField = "evidence_reception_date", IsVisible = settings.show_evidence_reception_date, ControlType="DateTimePicker", Validation="required" },
            };
        }

        public void GenerateControls(List<ControlMetadata> controlMetadataList, Control rootControl)
        {
            int yPosition = 20; // Starting position for controls
            int xPosition = 400; // Starting position for controls
            int labelWidth = 300; // Width for the labels
            int controlWidth = 200; // Width for the controls
            int spacing = 10; // Spacing between controls

            foreach (var metadata in controlMetadataList)
            {
                if (metadata.IsVisible)
                {
                    Label lbl = new Label
                    {
                        Text = metadata.LabelText,
                        Location = new Point(20, yPosition),
                        Width = labelWidth
                    };

                    Control ctrl = null;

                    switch (metadata.ControlType)
                    {
                        case "TextBox":
                            ctrl = new TextBox
                            {
                                Name = metadata.ControlName,
                                Location = new Point(xPosition, yPosition),
                                Width = controlWidth
                            };
                            break;
                        case "ComboBox":
                            ctrl = new ComboBox
                            {
                                Name = metadata.ControlName,
                                Location = new Point(xPosition, yPosition),
                                Width = controlWidth
                            };
                            break;
                        case "DateTimePicker":
                            ctrl = new DateTimePicker
                            {
                                Name = metadata.ControlName,
                                Location = new Point(xPosition, yPosition),
                                Width = controlWidth
                            };
                            break;
                        case "MultiLineTextBox":
                            ctrl = new TextBox
                            {
                                Name = metadata.ControlName,
                                Location = new Point(xPosition, yPosition),
                                Width = controlWidth,
                                Multiline = true,
                                Height = 60 // Adjust height as needed
                            };
                            break;
                    }

                    if (ctrl != null)
                    {
                        rootControl.Controls.Add(lbl);
                        rootControl.Controls.Add(ctrl);
                        yPosition += ctrl.Height + spacing;
                    }
                }
            }
        }


        public void PopulateComboBoxs(string category, Control control)
        {
            Control control1 = control.Controls.Find("comboBoxEventStatus", true).FirstOrDefault();
            if (control1 != null && control1 is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control1;
                List<string> eventStatus = evnt.selectEventStatus();
                foreach (string item in eventStatus)
                {
                    comboBox.Items.Add(item);
                }
            }

            Control control2 = control.Controls.Find("comboBoxEventType", true).FirstOrDefault();
            if (control2 != null && control2 is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control2;
                List<string> eventTypes = evnt.selectEventTypes(category);
                foreach (string item in eventTypes)
                {
                    comboBox.Items.Add(item);
                }
            }

            Control control3 = control.Controls.Find("comboBoxCause", true).FirstOrDefault();
            if (control3 != null && control3 is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control3;
                List<string> eventCauses = evnt.selectEventCauses();
                foreach (string item in eventCauses)
                {
                    comboBox.Items.Add(item);
                }
            }

            Control control4 = control.Controls.Find("comboBoxSeverity", true).FirstOrDefault();
            if (control4 != null && control4 is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control4;
                comboBox.Items.AddRange(new object[] { "A : Accident", "B : Incident grave", "C : Incident majeur", "D : Incident significatif", "E : Aucune incidence immédiate sur la sécurité" });
            }

            Control control5 = control.Controls.Find("comboBoxShowFrequency", true).FirstOrDefault();
            if (control5 != null && control5 is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control5;
                comboBox.Items.AddRange(new object[] { "1 : Extrêmement rare", "2 : Rare", "3 : Occasionnel", "4 : Fréquent", "5 : Très fréquent" });
            }
        }



        public Event RetrieveFormData(Control parentControl, List<ControlMetadata> controlMetadataList)
        {
            // Get the values from the input fields, checking if they are visible
            Event eventData = new Event();
            foreach (var metadata in controlMetadataList)
            {
                Control control = FindControlByName(parentControl, metadata.ControlName);
                if (control != null && metadata.IsVisible)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        typeof(Event).GetProperty(metadata.DatabaseField)?.SetValue(eventData, textBox.Text);
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        typeof(Event).GetProperty(metadata.DatabaseField)?.SetValue(eventData, comboBox.SelectedItem?.ToString());
                    }
                    else if (control is DateTimePicker)
                    {
                        DateTimePicker dateTimePicker = (DateTimePicker)control;
                        typeof(Event).GetProperty(metadata.DatabaseField)?.SetValue(eventData, dateTimePicker.Value);
                    }
                }
            }
            return eventData;
        }

        private Control FindControlByName(Control parent, string name)
        {
            return parent.Controls.Find(name, true).FirstOrDefault();
        }

        public bool ValidateInputs(Control parentControl, List<ControlMetadata> controlMetadataList)
        {
            // Define a lighter red color
            Color lighterRed = Color.FromArgb(255, 204, 204);

            bool isValid = true;

            foreach (var metadata in controlMetadataList)
            {
                Control control = FindControlByName(parentControl, metadata.ControlName);
                if (control != null && metadata.IsVisible && metadata.Validation=="required")
                {
            
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        if (string.IsNullOrEmpty(textBox.Text) && textBox.Visible)
                        {
                            textBox.BackColor = lighterRed;
                            isValid = false;
                        }
                        else
                        {
                            textBox.BackColor = Color.White;
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (string.IsNullOrEmpty(comboBox.SelectedItem?.ToString()))
                        {
                            comboBox.BackColor = lighterRed;
                            isValid = false;
                        }
                        else
                        {
                            comboBox.BackColor = Color.White;
                        }
                    }
                    else if (control is DateTimePicker)
                    {
                        DateTimePicker dateTimePicker = (DateTimePicker)control;
                        if (dateTimePicker.Value == dateTimePicker.MinDate && dateTimePicker.Visible)
                        {
                            dateTimePicker.CalendarTitleBackColor = lighterRed;
                            isValid = false;
                        }
                        else
                        {
                            dateTimePicker.CalendarTitleBackColor = Color.White;
                        }
                    }
                    // Add more checks for other types of controls as necessary (CheckBox, RadioButton, etc.)
                }
            }
            return isValid;
        }

        public void Clear(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    Clear(control); // Recursive call for container controls like Panels, GroupBoxes, etc.
                }
            }
        }
    }
}
