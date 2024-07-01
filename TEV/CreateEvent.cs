
using System.Windows.Forms;
using TEV.classes;

namespace TEV
{
    public partial class CreateEvent : Form
    {
        public event EventHandler DataUpdated;
        private bool isEditMode;
        Event evnt = new Event();
        Helper helper = new Helper();
        List<ControlMetadata> controlMetadataList;
        int selectedEventId;

        public CreateEvent(int selectedEventId = 0, bool editMode = false)
        {
            InitializeComponent();
            this.isEditMode = editMode;
            this.selectedEventId = selectedEventId;
        }

        protected virtual void OnDataUpdated(EventArgs e)
        {
            DataUpdated?.Invoke(this, e);
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            List<string> categories = evnt.selectCategories();
            // Populate the comboBoxUserType with categories from the database
            comboBoxCategory.Items.Clear(); // Clear existing items if any
            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }
            if (isEditMode)
            {
                buttonSubmit.Text = "Update Event";
                FillFormFromEvent(evnt);
            }
            buttonSubmit.Text = "Create Event";
        }

        public void FillFormFromEvent(Event e)
        {
            // fill inputs ??
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEventCategory = comboBoxCategory.SelectedItem.ToString();
            // Dynamically generate controls based on the event category
            panel1.Controls.Clear();  // Clear all existing controls inside the
            this.controlMetadataList = helper.GetControlMetadata(selectedEventCategory);
            helper.GenerateControls(controlMetadataList, panel1);
            helper.PopulateComboBoxs(selectedEventCategory, panel1);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string category = comboBoxCategory.SelectedItem?.ToString();
            if (category != null)
            {
                if (!helper.ValidateInputs(panel1, controlMetadataList))
                {
                    MessageBox.Show("Please correct the highlighted fields.");
                    return;
                }
                Event eventData = helper.RetrieveFormData(panel1, controlMetadataList);
                eventData.category = category;

                if (isEditMode)
                {
                    bool success = evnt.InsertEvent(eventData);
                    if (success == true)
                    {
                        OnDataUpdated(EventArgs.Empty);// Trigger the event
                        MessageBox.Show("New Event Successfully Inserted");
                        helper.Clear(panel1);
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add New Event. Try Again");
                    }
                }
                else
                {
                    bool success = evnt.UpdateEvent(evnt);
                    if (success == true)
                    {
                        OnDataUpdated(EventArgs.Empty);// Trigger the event
                        MessageBox.Show("New Event Successfully updated");
                        helper.Clear(panel1);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Event. Try Again");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            helper.Clear(panel1);
        }   

    }
}
