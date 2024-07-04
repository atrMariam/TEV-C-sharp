using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Xml.Linq;
using TEV.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEV
{
    public partial class ManageRelatedTables : Form
    {
        Category category = new();
        Helper helper = new();
        public ManageRelatedTables()
        {
            InitializeComponent();
        }

        private void ManageRelatedTables_Load(object sender, EventArgs e)
        {
            LoadDataCategories();
        }

        private void LoadDataCategories()
        {
            DataTable dt = category.Select();
            dataGridViewCategories.DataSource = dt;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            // get the values from the input fields
            category = RetrieveFormData(groupBoxCategory);

            bool success = category.Insert(category);
            if (success == true)
            {
                MessageBox.Show("New Category Successfully Inserted");
                helper.Clear(groupBoxCategory);
            }
            else
            {
                MessageBox.Show("Failed to Add New Category. Try Again");
            }
            //load the data on data gridview
            LoadDataCategories();
        }

        public Category RetrieveFormData(Control parentControl)
        {
            category.id = int.Parse(textBoxCategoryId.Text);
            category.name = textBoxCategoryName.Text;
            category.show_code = checkBoxshow_code.Checked;
            category.show_reference = checkBoxshow_reference.Checked;
            category.show_source = checkBoxshow_source.Checked;
            category.show_occurrence_date = checkBoxshow_occurrence_date.Checked;
            category.show_notification_date = checkBoxshow_notification_date.Checked;
            category.show_eventType = checkBoxshow_eventType.Checked;
            category.show_location = checkBoxshow_location.Checked;
            category.show_involved_traffic = checkBoxshow_involved_traffic.Checked;
            category.show_description = checkBoxshow_description.Checked;
            category.show_event_cause = checkBoxshow_event_cause.Checked;
            category.show_frequency = checkBoxshow_frequency.Checked;
            category.show_severity = checkBoxshow_severity.Checked;
            category.show_classe = checkBoxshow_classe.Checked;
            category.show_security_recommendation = checkBoxshow_security_recommendation.Checked;
            category.show_event_status = checkBoxshow_event_status.Checked;
            category.show_color = checkBoxshow_color.Checked;
            category.show_flight_phase = checkBoxshow_flight_phase.Checked;
            category.show_altitude = checkBoxshow_altitude.Checked;
            category.show_report_elaboration_date = checkBoxshow_report_elaboration_date.Checked;
            category.show_report_reception_date = checkBoxshow_report_reception_date.Checked;
            category.show_last_elm_reception_date = checkBoxshow_last_elm_reception_date.Checked;
            category.show_recommendations_release_date = checkBoxshow_recommendations_release_date.Checked;
            category.show_evidence_reception_date = checkBoxshow_evidence_reception_date.Checked;

            return category;
        }

        private void dataGridViewCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            // Ensure the row is not the "new row" (the blank row at the end)
            if (!dataGridViewCategories.Rows[rowIndex].IsNewRow)
            {
                textBoxCategoryId.Text = dataGridViewCategories.Rows[rowIndex].Cells["id"].Value.ToString();
                textBoxCategoryName.Text = dataGridViewCategories.Rows[rowIndex].Cells["name"].Value.ToString();
                checkBoxshow_code.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_code"].Value) == 1);
                checkBoxshow_reference.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_reference"].Value) == 1);
                checkBoxshow_source.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_source"].Value) == 1);
                checkBoxshow_occurrence_date.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_occurrence_date"].Value) == 1);
                checkBoxshow_notification_date.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_notification_date"].Value) == 1);
                checkBoxshow_eventType.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_eventType"].Value) == 1);
                checkBoxshow_location.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_location"].Value) == 1);
                checkBoxshow_involved_traffic.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_involved_traffic"].Value) == 1);
                checkBoxshow_description.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_description"].Value) == 1);
                checkBoxshow_event_cause.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_event_cause"].Value) == 1);
                checkBoxshow_frequency.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_frequency"].Value) == 1);
                checkBoxshow_severity.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_severity"].Value) == 1);
                checkBoxshow_classe.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_classe"].Value) == 1);
                checkBoxshow_security_recommendation.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_security_recommendation"].Value) == 1);
                checkBoxshow_event_status.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_event_status"].Value) == 1);
                checkBoxshow_color.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_color"].Value) == 1);
                checkBoxshow_flight_phase.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_flight_phase"].Value) == 1);
                checkBoxshow_altitude.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_altitude"].Value) == 1);
                checkBoxshow_report_elaboration_date.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_report_elaboration_date"].Value) == 1);
                checkBoxshow_report_reception_date.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_report_reception_date"].Value) == 1);
                checkBoxshow_last_elm_reception_date.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_last_elm_reception_date"].Value) == 1);
                checkBoxshow_recommendations_release_date.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_recommendations_release_date"].Value) == 1);
                checkBoxshow_evidence_reception_date.Checked = (Convert.ToInt32(dataGridViewCategories.Rows[rowIndex].Cells["show_evidence_reception_date"].Value) == 1);
            }
        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                category = RetrieveFormData(groupBoxCategory);
                // update data in database
                bool success = category.Update(category);
                if (success == true)
                {
                    MessageBox.Show("Category has been Successfully Updated");
                    //load the data on data gridview
                    LoadDataCategories();
                    helper.Clear(groupBoxCategory);
                }
                else
                {
                    MessageBox.Show("Failed to Update the Category. Try Again");
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                category.id = int.Parse(textBoxCategoryId.Text);
                bool success = category.Delete(category);
                if (success == true)
                {
                    MessageBox.Show("Category has been Successfully Deleted");
                    //load the data on data gridview
                    LoadDataCategories();
                    helper.Clear(groupBoxCategory);
                }
                else
                {
                    MessageBox.Show("Failed to Delete the Category. Try Again");
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }
    }
}
