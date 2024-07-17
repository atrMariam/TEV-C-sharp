namespace TEV
{
    partial class ManageRelatedTables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageCategories = new TabPage();
            groupBoxCategory = new GroupBox();
            buttonDeleteCategory = new Button();
            buttonEditCategory = new Button();
            buttonAddCategory = new Button();
            textBoxCategoryId = new TextBox();
            label2 = new Label();
            checkBoxshow_evidence_reception_date = new CheckBox();
            checkBoxshow_recommendations_release_date = new CheckBox();
            checkBoxshow_event_status = new CheckBox();
            checkBoxshow_altitude = new CheckBox();
            checkBoxshow_report_reception_date = new CheckBox();
            checkBoxshow_last_elm_reception_date = new CheckBox();
            checkBoxshow_report_elaboration_date = new CheckBox();
            checkBoxshow_color = new CheckBox();
            checkBoxshow_security_recommendation = new CheckBox();
            checkBoxshow_flight_phase = new CheckBox();
            checkBoxshow_classe = new CheckBox();
            checkBoxshow_occurrence_date = new CheckBox();
            checkBoxshow_notification_date = new CheckBox();
            checkBoxshow_eventType = new CheckBox();
            checkBoxshow_location = new CheckBox();
            checkBoxshow_involved_traffic = new CheckBox();
            checkBoxshow_description = new CheckBox();
            checkBoxshow_severity = new CheckBox();
            checkBoxshow_frequency = new CheckBox();
            checkBoxshow_event_cause = new CheckBox();
            checkBoxshow_source = new CheckBox();
            checkBoxshow_reference = new CheckBox();
            checkBoxshow_code = new CheckBox();
            textBoxCategoryName = new TextBox();
            label1 = new Label();
            dataGridViewCategories = new DataGridView();
            tabPageType = new TabPage();
            groupBoxType = new GroupBox();
            textBoxTypeName = new TextBox();
            comboBoxTypeCategory = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            textBoxTypeId = new TextBox();
            buttonDeleteType = new Button();
            buttonEditType = new Button();
            buttonAddType = new Button();
            dataGridViewTypes = new DataGridView();
            tabPageCause = new TabPage();
            tabControl1.SuspendLayout();
            tabPageCategories.SuspendLayout();
            groupBoxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            tabPageType.SuspendLayout();
            groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCategories);
            tabControl1.Controls.Add(tabPageType);
            tabControl1.Controls.Add(tabPageCause);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(groupBoxCategory);
            tabPageCategories.Controls.Add(dataGridViewCategories);
            tabPageCategories.Location = new Point(4, 24);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(922, 542);
            tabPageCategories.TabIndex = 0;
            tabPageCategories.Text = "Categories";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategory
            // 
            groupBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxCategory.Controls.Add(buttonDeleteCategory);
            groupBoxCategory.Controls.Add(buttonEditCategory);
            groupBoxCategory.Controls.Add(buttonAddCategory);
            groupBoxCategory.Controls.Add(textBoxCategoryId);
            groupBoxCategory.Controls.Add(label2);
            groupBoxCategory.Controls.Add(checkBoxshow_evidence_reception_date);
            groupBoxCategory.Controls.Add(checkBoxshow_recommendations_release_date);
            groupBoxCategory.Controls.Add(checkBoxshow_event_status);
            groupBoxCategory.Controls.Add(checkBoxshow_altitude);
            groupBoxCategory.Controls.Add(checkBoxshow_report_reception_date);
            groupBoxCategory.Controls.Add(checkBoxshow_last_elm_reception_date);
            groupBoxCategory.Controls.Add(checkBoxshow_report_elaboration_date);
            groupBoxCategory.Controls.Add(checkBoxshow_color);
            groupBoxCategory.Controls.Add(checkBoxshow_security_recommendation);
            groupBoxCategory.Controls.Add(checkBoxshow_flight_phase);
            groupBoxCategory.Controls.Add(checkBoxshow_classe);
            groupBoxCategory.Controls.Add(checkBoxshow_occurrence_date);
            groupBoxCategory.Controls.Add(checkBoxshow_notification_date);
            groupBoxCategory.Controls.Add(checkBoxshow_eventType);
            groupBoxCategory.Controls.Add(checkBoxshow_location);
            groupBoxCategory.Controls.Add(checkBoxshow_involved_traffic);
            groupBoxCategory.Controls.Add(checkBoxshow_description);
            groupBoxCategory.Controls.Add(checkBoxshow_severity);
            groupBoxCategory.Controls.Add(checkBoxshow_frequency);
            groupBoxCategory.Controls.Add(checkBoxshow_event_cause);
            groupBoxCategory.Controls.Add(checkBoxshow_source);
            groupBoxCategory.Controls.Add(checkBoxshow_reference);
            groupBoxCategory.Controls.Add(checkBoxshow_code);
            groupBoxCategory.Controls.Add(textBoxCategoryName);
            groupBoxCategory.Controls.Add(label1);
            groupBoxCategory.Location = new Point(6, 20);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Size = new Size(465, 498);
            groupBoxCategory.TabIndex = 1;
            groupBoxCategory.TabStop = false;
            groupBoxCategory.Text = "Categorie";
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.Anchor = AnchorStyles.Bottom;
            buttonDeleteCategory.BackColor = Color.FromArgb(255, 128, 128);
            buttonDeleteCategory.ForeColor = Color.Black;
            buttonDeleteCategory.Location = new Point(313, 454);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(78, 38);
            buttonDeleteCategory.TabIndex = 30;
            buttonDeleteCategory.Text = "Delete";
            buttonDeleteCategory.UseVisualStyleBackColor = false;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
            // 
            // buttonEditCategory
            // 
            buttonEditCategory.Anchor = AnchorStyles.Bottom;
            buttonEditCategory.BackColor = Color.FromArgb(255, 192, 128);
            buttonEditCategory.Location = new Point(199, 454);
            buttonEditCategory.Name = "buttonEditCategory";
            buttonEditCategory.Size = new Size(72, 38);
            buttonEditCategory.TabIndex = 29;
            buttonEditCategory.Text = "Editer";
            buttonEditCategory.UseVisualStyleBackColor = false;
            buttonEditCategory.Click += buttonEditCategory_Click;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Anchor = AnchorStyles.Bottom;
            buttonAddCategory.BackColor = Color.FromArgb(128, 128, 255);
            buttonAddCategory.ForeColor = Color.Black;
            buttonAddCategory.Location = new Point(75, 454);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(86, 38);
            buttonAddCategory.TabIndex = 28;
            buttonAddCategory.Text = "Ajouter";
            buttonAddCategory.UseVisualStyleBackColor = false;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // textBoxCategoryId
            // 
            textBoxCategoryId.Location = new Point(123, 31);
            textBoxCategoryId.Name = "textBoxCategoryId";
            textBoxCategoryId.ReadOnly = true;
            textBoxCategoryId.Size = new Size(227, 23);
            textBoxCategoryId.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 26;
            label2.Text = "ID";
            // 
            // checkBoxshow_evidence_reception_date
            // 
            checkBoxshow_evidence_reception_date.AutoSize = true;
            checkBoxshow_evidence_reception_date.Location = new Point(229, 413);
            checkBoxshow_evidence_reception_date.Name = "checkBoxshow_evidence_reception_date";
            checkBoxshow_evidence_reception_date.Size = new Size(189, 19);
            checkBoxshow_evidence_reception_date.TabIndex = 25;
            checkBoxshow_evidence_reception_date.Text = "show_evidence_reception_date";
            checkBoxshow_evidence_reception_date.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_recommendations_release_date
            // 
            checkBoxshow_recommendations_release_date.AutoSize = true;
            checkBoxshow_recommendations_release_date.Location = new Point(229, 384);
            checkBoxshow_recommendations_release_date.Name = "checkBoxshow_recommendations_release_date";
            checkBoxshow_recommendations_release_date.Size = new Size(225, 19);
            checkBoxshow_recommendations_release_date.TabIndex = 24;
            checkBoxshow_recommendations_release_date.Text = "show_recommendations_release_date";
            checkBoxshow_recommendations_release_date.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_event_status
            // 
            checkBoxshow_event_status.AutoSize = true;
            checkBoxshow_event_status.Location = new Point(163, 271);
            checkBoxshow_event_status.Name = "checkBoxshow_event_status";
            checkBoxshow_event_status.Size = new Size(124, 19);
            checkBoxshow_event_status.TabIndex = 23;
            checkBoxshow_event_status.Text = "show_event_status";
            checkBoxshow_event_status.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_altitude
            // 
            checkBoxshow_altitude.AutoSize = true;
            checkBoxshow_altitude.Location = new Point(336, 271);
            checkBoxshow_altitude.Name = "checkBoxshow_altitude";
            checkBoxshow_altitude.Size = new Size(99, 19);
            checkBoxshow_altitude.TabIndex = 22;
            checkBoxshow_altitude.Text = "show_altitude";
            checkBoxshow_altitude.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_report_reception_date
            // 
            checkBoxshow_report_reception_date.AutoSize = true;
            checkBoxshow_report_reception_date.Location = new Point(6, 384);
            checkBoxshow_report_reception_date.Name = "checkBoxshow_report_reception_date";
            checkBoxshow_report_reception_date.Size = new Size(174, 19);
            checkBoxshow_report_reception_date.TabIndex = 21;
            checkBoxshow_report_reception_date.Text = "show_report_reception_date";
            checkBoxshow_report_reception_date.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_last_elm_reception_date
            // 
            checkBoxshow_last_elm_reception_date.AutoSize = true;
            checkBoxshow_last_elm_reception_date.Location = new Point(6, 413);
            checkBoxshow_last_elm_reception_date.Name = "checkBoxshow_last_elm_reception_date";
            checkBoxshow_last_elm_reception_date.Size = new Size(185, 19);
            checkBoxshow_last_elm_reception_date.TabIndex = 20;
            checkBoxshow_last_elm_reception_date.Text = "show_last_elm_reception_date";
            checkBoxshow_last_elm_reception_date.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_report_elaboration_date
            // 
            checkBoxshow_report_elaboration_date.AutoSize = true;
            checkBoxshow_report_elaboration_date.Location = new Point(229, 350);
            checkBoxshow_report_elaboration_date.Name = "checkBoxshow_report_elaboration_date";
            checkBoxshow_report_elaboration_date.Size = new Size(184, 19);
            checkBoxshow_report_elaboration_date.TabIndex = 19;
            checkBoxshow_report_elaboration_date.Text = "show_report_elaboration_date";
            checkBoxshow_report_elaboration_date.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_color
            // 
            checkBoxshow_color.AutoSize = true;
            checkBoxshow_color.Location = new Point(6, 312);
            checkBoxshow_color.Name = "checkBoxshow_color";
            checkBoxshow_color.Size = new Size(86, 19);
            checkBoxshow_color.TabIndex = 18;
            checkBoxshow_color.Text = "show_color";
            checkBoxshow_color.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_security_recommendation
            // 
            checkBoxshow_security_recommendation.AutoSize = true;
            checkBoxshow_security_recommendation.Location = new Point(6, 350);
            checkBoxshow_security_recommendation.Name = "checkBoxshow_security_recommendation";
            checkBoxshow_security_recommendation.Size = new Size(197, 19);
            checkBoxshow_security_recommendation.TabIndex = 17;
            checkBoxshow_security_recommendation.Text = "show_security_recommendation";
            checkBoxshow_security_recommendation.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_flight_phase
            // 
            checkBoxshow_flight_phase.AutoSize = true;
            checkBoxshow_flight_phase.Location = new Point(163, 312);
            checkBoxshow_flight_phase.Name = "checkBoxshow_flight_phase";
            checkBoxshow_flight_phase.Size = new Size(123, 19);
            checkBoxshow_flight_phase.TabIndex = 16;
            checkBoxshow_flight_phase.Text = "show_flight_phase";
            checkBoxshow_flight_phase.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_classe
            // 
            checkBoxshow_classe.AutoSize = true;
            checkBoxshow_classe.Location = new Point(6, 271);
            checkBoxshow_classe.Name = "checkBoxshow_classe";
            checkBoxshow_classe.Size = new Size(90, 19);
            checkBoxshow_classe.TabIndex = 15;
            checkBoxshow_classe.Text = "show_classe";
            checkBoxshow_classe.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_occurrence_date
            // 
            checkBoxshow_occurrence_date.AutoSize = true;
            checkBoxshow_occurrence_date.Location = new Point(6, 157);
            checkBoxshow_occurrence_date.Name = "checkBoxshow_occurrence_date";
            checkBoxshow_occurrence_date.Size = new Size(146, 19);
            checkBoxshow_occurrence_date.TabIndex = 14;
            checkBoxshow_occurrence_date.Text = "show_occurrence_date";
            checkBoxshow_occurrence_date.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_notification_date
            // 
            checkBoxshow_notification_date.AutoSize = true;
            checkBoxshow_notification_date.Location = new Point(163, 157);
            checkBoxshow_notification_date.Name = "checkBoxshow_notification_date";
            checkBoxshow_notification_date.Size = new Size(148, 19);
            checkBoxshow_notification_date.TabIndex = 13;
            checkBoxshow_notification_date.Text = "show_notification_date";
            checkBoxshow_notification_date.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_eventType
            // 
            checkBoxshow_eventType.AutoSize = true;
            checkBoxshow_eventType.Location = new Point(336, 157);
            checkBoxshow_eventType.Name = "checkBoxshow_eventType";
            checkBoxshow_eventType.Size = new Size(112, 19);
            checkBoxshow_eventType.TabIndex = 12;
            checkBoxshow_eventType.Text = "show_eventType";
            checkBoxshow_eventType.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_location
            // 
            checkBoxshow_location.AutoSize = true;
            checkBoxshow_location.Location = new Point(6, 194);
            checkBoxshow_location.Name = "checkBoxshow_location";
            checkBoxshow_location.Size = new Size(102, 19);
            checkBoxshow_location.TabIndex = 11;
            checkBoxshow_location.Text = "show_location";
            checkBoxshow_location.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_involved_traffic
            // 
            checkBoxshow_involved_traffic.AutoSize = true;
            checkBoxshow_involved_traffic.Location = new Point(163, 194);
            checkBoxshow_involved_traffic.Name = "checkBoxshow_involved_traffic";
            checkBoxshow_involved_traffic.Size = new Size(140, 19);
            checkBoxshow_involved_traffic.TabIndex = 10;
            checkBoxshow_involved_traffic.Text = "show_involved_traffic";
            checkBoxshow_involved_traffic.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_description
            // 
            checkBoxshow_description.AutoSize = true;
            checkBoxshow_description.Location = new Point(336, 194);
            checkBoxshow_description.Name = "checkBoxshow_description";
            checkBoxshow_description.Size = new Size(118, 19);
            checkBoxshow_description.TabIndex = 9;
            checkBoxshow_description.Text = "show_description";
            checkBoxshow_description.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_severity
            // 
            checkBoxshow_severity.AutoSize = true;
            checkBoxshow_severity.Location = new Point(336, 234);
            checkBoxshow_severity.Name = "checkBoxshow_severity";
            checkBoxshow_severity.Size = new Size(99, 19);
            checkBoxshow_severity.TabIndex = 8;
            checkBoxshow_severity.Text = "show_severity";
            checkBoxshow_severity.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_frequency
            // 
            checkBoxshow_frequency.AutoSize = true;
            checkBoxshow_frequency.Location = new Point(163, 234);
            checkBoxshow_frequency.Name = "checkBoxshow_frequency";
            checkBoxshow_frequency.Size = new Size(112, 19);
            checkBoxshow_frequency.TabIndex = 7;
            checkBoxshow_frequency.Text = "show_frequency";
            checkBoxshow_frequency.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_event_cause
            // 
            checkBoxshow_event_cause.AutoSize = true;
            checkBoxshow_event_cause.Location = new Point(6, 234);
            checkBoxshow_event_cause.Name = "checkBoxshow_event_cause";
            checkBoxshow_event_cause.Size = new Size(123, 19);
            checkBoxshow_event_cause.TabIndex = 6;
            checkBoxshow_event_cause.Text = "show_event_cause";
            checkBoxshow_event_cause.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_source
            // 
            checkBoxshow_source.AutoSize = true;
            checkBoxshow_source.Location = new Point(336, 118);
            checkBoxshow_source.Name = "checkBoxshow_source";
            checkBoxshow_source.Size = new Size(94, 19);
            checkBoxshow_source.TabIndex = 4;
            checkBoxshow_source.Text = "show_source";
            checkBoxshow_source.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_reference
            // 
            checkBoxshow_reference.AutoSize = true;
            checkBoxshow_reference.Location = new Point(163, 118);
            checkBoxshow_reference.Name = "checkBoxshow_reference";
            checkBoxshow_reference.Size = new Size(108, 19);
            checkBoxshow_reference.TabIndex = 3;
            checkBoxshow_reference.Text = "show_reference";
            checkBoxshow_reference.UseVisualStyleBackColor = true;
            // 
            // checkBoxshow_code
            // 
            checkBoxshow_code.AutoSize = true;
            checkBoxshow_code.Location = new Point(6, 118);
            checkBoxshow_code.Name = "checkBoxshow_code";
            checkBoxshow_code.Size = new Size(85, 19);
            checkBoxshow_code.TabIndex = 2;
            checkBoxshow_code.Text = "show_code";
            checkBoxshow_code.UseVisualStyleBackColor = true;
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Location = new Point(123, 69);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(227, 23);
            textBoxCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "nom";
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(477, 30);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.Size = new Size(427, 488);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.RowHeaderMouseClick += dataGridViewCategories_RowHeaderMouseClick;
            // 
            // tabPageType
            // 
            tabPageType.Controls.Add(groupBoxType);
            tabPageType.Controls.Add(buttonDeleteType);
            tabPageType.Controls.Add(buttonEditType);
            tabPageType.Controls.Add(buttonAddType);
            tabPageType.Controls.Add(dataGridViewTypes);
            tabPageType.Location = new Point(4, 24);
            tabPageType.Name = "tabPageType";
            tabPageType.Padding = new Padding(3);
            tabPageType.Size = new Size(922, 542);
            tabPageType.TabIndex = 1;
            tabPageType.Text = "Types";
            tabPageType.UseVisualStyleBackColor = true;
            // 
            // groupBoxType
            // 
            groupBoxType.Controls.Add(textBoxTypeName);
            groupBoxType.Controls.Add(comboBoxTypeCategory);
            groupBoxType.Controls.Add(label4);
            groupBoxType.Controls.Add(label5);
            groupBoxType.Controls.Add(label3);
            groupBoxType.Controls.Add(textBoxTypeId);
            groupBoxType.Location = new Point(22, 21);
            groupBoxType.Name = "groupBoxType";
            groupBoxType.Size = new Size(440, 217);
            groupBoxType.TabIndex = 40;
            groupBoxType.TabStop = false;
            groupBoxType.Text = "Type";
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Location = new Point(134, 72);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(208, 23);
            textBoxTypeName.TabIndex = 35;
            // 
            // comboBoxTypeCategory
            // 
            comboBoxTypeCategory.FormattingEnabled = true;
            comboBoxTypeCategory.Location = new Point(134, 115);
            comboBoxTypeCategory.Name = "comboBoxTypeCategory";
            comboBoxTypeCategory.Size = new Size(208, 23);
            comboBoxTypeCategory.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 75);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 34;
            label4.Text = "nom";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 118);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 38;
            label5.Text = "Categorie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 34);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 36;
            label3.Text = "ID";
            // 
            // textBoxTypeId
            // 
            textBoxTypeId.Location = new Point(134, 34);
            textBoxTypeId.Name = "textBoxTypeId";
            textBoxTypeId.ReadOnly = true;
            textBoxTypeId.Size = new Size(208, 23);
            textBoxTypeId.TabIndex = 37;
            // 
            // buttonDeleteType
            // 
            buttonDeleteType.Anchor = AnchorStyles.Bottom;
            buttonDeleteType.BackColor = Color.FromArgb(255, 128, 128);
            buttonDeleteType.ForeColor = Color.Black;
            buttonDeleteType.Location = new Point(326, 478);
            buttonDeleteType.Name = "buttonDeleteType";
            buttonDeleteType.Size = new Size(78, 38);
            buttonDeleteType.TabIndex = 33;
            buttonDeleteType.Text = "Delete";
            buttonDeleteType.UseVisualStyleBackColor = false;
            buttonDeleteType.Click += buttonDeleteType_Click;
            // 
            // buttonEditType
            // 
            buttonEditType.Anchor = AnchorStyles.Bottom;
            buttonEditType.BackColor = Color.FromArgb(255, 192, 128);
            buttonEditType.Location = new Point(201, 478);
            buttonEditType.Name = "buttonEditType";
            buttonEditType.Size = new Size(72, 38);
            buttonEditType.TabIndex = 32;
            buttonEditType.Text = "Editer";
            buttonEditType.UseVisualStyleBackColor = false;
            buttonEditType.Click += buttonEditType_Click;
            // 
            // buttonAddType
            // 
            buttonAddType.Anchor = AnchorStyles.Bottom;
            buttonAddType.BackColor = Color.FromArgb(128, 128, 255);
            buttonAddType.ForeColor = Color.Black;
            buttonAddType.Location = new Point(79, 478);
            buttonAddType.Name = "buttonAddType";
            buttonAddType.Size = new Size(86, 38);
            buttonAddType.TabIndex = 31;
            buttonAddType.Text = "Ajouter";
            buttonAddType.UseVisualStyleBackColor = false;
            buttonAddType.Click += buttonAddType_Click;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Location = new Point(477, 28);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.Size = new Size(427, 488);
            dataGridViewTypes.TabIndex = 1;
            dataGridViewTypes.RowHeaderMouseClick += dataGridViewTypes_RowHeaderMouseClick;
            // 
            // tabPageCause
            // 
            tabPageCause.AutoScroll = true;
            tabPageCause.Location = new Point(4, 24);
            tabPageCause.Name = "tabPageCause";
            tabPageCause.Padding = new Padding(3);
            tabPageCause.Size = new Size(922, 542);
            tabPageCause.TabIndex = 2;
            tabPageCause.Text = "Causes";
            tabPageCause.UseVisualStyleBackColor = true;
            // 
            // ManageRelatedTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 605);
            Controls.Add(tabControl1);
            Name = "ManageRelatedTables";
            Text = "ManageRelatedTables";
            Load += ManageRelatedTables_Load;
            tabControl1.ResumeLayout(false);
            tabPageCategories.ResumeLayout(false);
            groupBoxCategory.ResumeLayout(false);
            groupBoxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            tabPageType.ResumeLayout(false);
            groupBoxType.ResumeLayout(false);
            groupBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCategories;
        private TabPage tabPageType;
        private GroupBox groupBoxCategory;
        private DataGridView dataGridViewCategories;
        private TabPage tabPageCause;
        private CheckBox checkBoxshow_code;
        private TextBox textBoxCategoryName;
        private Label label1;
        private CheckBox checkBoxshow_event_status;
        private CheckBox checkBoxshow_altitude;
        private CheckBox checkBoxshow_report_reception_date;
        private CheckBox checkBoxshow_last_elm_reception_date;
        private CheckBox checkBoxshow_report_elaboration_date;
        private CheckBox checkBoxshow_color;
        private CheckBox checkBoxshow_security_recommendation;
        private CheckBox checkBoxshow_flight_phase;
        private CheckBox checkBoxshow_classe;
        private CheckBox checkBoxshow_occurrence_date;
        private CheckBox checkBoxshow_notification_date;
        private CheckBox checkBoxshow_eventType;
        private CheckBox checkBoxshow_location;
        private CheckBox checkBoxshow_involved_traffic;
        private CheckBox checkBoxshow_description;
        private CheckBox checkBoxshow_severity;
        private CheckBox checkBoxshow_frequency;
        private CheckBox checkBoxshow_event_cause;
        private CheckBox checkBoxshow_source;
        private CheckBox checkBoxshow_reference;
        private CheckBox checkBoxshow_evidence_reception_date;
        private CheckBox checkBoxshow_recommendations_release_date;
        private Button buttonDeleteCategory;
        private Button buttonEditCategory;
        private Button buttonAddCategory;
        private TextBox textBoxCategoryId;
        private Label label2;
        private DataGridView dataGridViewTypes;
        private Button buttonDeleteType;
        private Button buttonEditType;
        private Button buttonAddType;
        private ComboBox comboBoxTypeCategory;
        private Label label5;
        private TextBox textBoxTypeId;
        private Label label3;
        private TextBox textBoxTypeName;
        private Label label4;
        private GroupBox groupBoxType;
    }
}