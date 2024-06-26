namespace TEV
{
    partial class CreateEvent
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
            comboBoxCategory = new ComboBox();
            label1 = new Label();
            textBoxCode = new TextBox();
            labelCode = new Label();
            labelReference = new Label();
            textBoxReference = new TextBox();
            labelSource = new Label();
            textBoxSource = new TextBox();
            labelOccurrenceDate = new Label();
            labelNotificationDate = new Label();
            labelEventType = new Label();
            comboBoxEventType = new ComboBox();
            labelLocation = new Label();
            textBoxLocation = new TextBox();
            labelInvolvedTraffic = new Label();
            textBoxInvolvedTraffic = new TextBox();
            dateTimePickerOccurrenceDate = new DateTimePicker();
            dateTimePickerNotificationDate = new DateTimePicker();
            dateTimePickerReportReceptionDate = new DateTimePicker();
            labelReportReceptionDate = new Label();
            dateTimePickerLastElmReceptionDate = new DateTimePicker();
            labelLastElmReceptionDate = new Label();
            dateTimePickerReportElaborationDate = new DateTimePicker();
            labelReportElaborationDate = new Label();
            dateTimePickerRecommendationsReleaseDate = new DateTimePicker();
            labelRecommendationsReleaseDate = new Label();
            dateTimePickerEvidenceReceptionDate = new DateTimePicker();
            labelEvidenceReceptionDate = new Label();
            comboBoxStatus = new ComboBox();
            labelStatus = new Label();
            labelColor = new Label();
            textBoxColor = new TextBox();
            labelFlightPhase = new Label();
            textBoxFlightPhase = new TextBox();
            labelAltitude = new Label();
            textBoxAltitude = new TextBox();
            comboBoxSeverity = new ComboBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            labelCauses = new Label();
            comboBoxCauses = new ComboBox();
            labelFrequency = new Label();
            comboBoxFrequency = new ComboBox();
            labelSeverity = new Label();
            textBoxSecurityRecommandation = new TextBox();
            labelSecurityRecommandation = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAddEvent = new Button();
            buttonDeleteEvent = new Button();
            button2 = new Button();
            buttonUpdateEvent = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(509, 23);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 31);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "Selectioner une categorie";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(25, 26);
            textBoxCode.Margin = new Padding(20, 3, 20, 3);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(200, 23);
            textBoxCode.TabIndex = 2;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(25, 8);
            labelCode.Margin = new Padding(20, 3, 20, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(33, 15);
            labelCode.TabIndex = 3;
            labelCode.Text = "code";
            // 
            // labelReference
            // 
            labelReference.AutoSize = true;
            labelReference.Location = new Point(25, 55);
            labelReference.Margin = new Padding(20, 3, 20, 0);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(59, 15);
            labelReference.TabIndex = 5;
            labelReference.Text = "Reference";
            // 
            // textBoxReference
            // 
            textBoxReference.Location = new Point(25, 73);
            textBoxReference.Margin = new Padding(20, 3, 20, 3);
            textBoxReference.Name = "textBoxReference";
            textBoxReference.Size = new Size(200, 23);
            textBoxReference.TabIndex = 4;
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Location = new Point(25, 102);
            labelSource.Margin = new Padding(20, 3, 20, 0);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(43, 15);
            labelSource.TabIndex = 7;
            labelSource.Text = "Source";
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(25, 120);
            textBoxSource.Margin = new Padding(20, 3, 20, 3);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(200, 23);
            textBoxSource.TabIndex = 6;
            // 
            // labelOccurrenceDate
            // 
            labelOccurrenceDate.AutoSize = true;
            labelOccurrenceDate.Location = new Point(25, 149);
            labelOccurrenceDate.Margin = new Padding(20, 3, 20, 0);
            labelOccurrenceDate.Name = "labelOccurrenceDate";
            labelOccurrenceDate.Size = new Size(111, 15);
            labelOccurrenceDate.TabIndex = 9;
            labelOccurrenceDate.Text = "Date de l'occurance";
            // 
            // labelNotificationDate
            // 
            labelNotificationDate.AutoSize = true;
            labelNotificationDate.Location = new Point(25, 196);
            labelNotificationDate.Margin = new Padding(20, 3, 20, 0);
            labelNotificationDate.Name = "labelNotificationDate";
            labelNotificationDate.Size = new Size(123, 15);
            labelNotificationDate.TabIndex = 11;
            labelNotificationDate.Text = "Date de la notification";
            // 
            // labelEventType
            // 
            labelEventType.AutoSize = true;
            labelEventType.Location = new Point(25, 243);
            labelEventType.Margin = new Padding(20, 3, 20, 0);
            labelEventType.Name = "labelEventType";
            labelEventType.Size = new Size(103, 15);
            labelEventType.TabIndex = 13;
            labelEventType.Text = "Type d'evenement";
            // 
            // comboBoxEventType
            // 
            comboBoxEventType.FormattingEnabled = true;
            comboBoxEventType.Location = new Point(25, 261);
            comboBoxEventType.Margin = new Padding(20, 3, 20, 3);
            comboBoxEventType.Name = "comboBoxEventType";
            comboBoxEventType.Size = new Size(200, 23);
            comboBoxEventType.TabIndex = 14;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(25, 290);
            labelLocation.Margin = new Padding(20, 3, 20, 0);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(83, 15);
            labelLocation.TabIndex = 16;
            labelLocation.Text = "Emplacement ";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(25, 308);
            textBoxLocation.Margin = new Padding(20, 3, 20, 3);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(200, 23);
            textBoxLocation.TabIndex = 15;
            // 
            // labelInvolvedTraffic
            // 
            labelInvolvedTraffic.AutoSize = true;
            labelInvolvedTraffic.Location = new Point(25, 337);
            labelInvolvedTraffic.Margin = new Padding(20, 3, 20, 0);
            labelInvolvedTraffic.Name = "labelInvolvedTraffic";
            labelInvolvedTraffic.Size = new Size(89, 15);
            labelInvolvedTraffic.TabIndex = 18;
            labelInvolvedTraffic.Text = "Traffic impliqué";
            // 
            // textBoxInvolvedTraffic
            // 
            textBoxInvolvedTraffic.Location = new Point(25, 355);
            textBoxInvolvedTraffic.Margin = new Padding(20, 3, 20, 3);
            textBoxInvolvedTraffic.Name = "textBoxInvolvedTraffic";
            textBoxInvolvedTraffic.Size = new Size(200, 23);
            textBoxInvolvedTraffic.TabIndex = 17;
            // 
            // dateTimePickerOccurrenceDate
            // 
            dateTimePickerOccurrenceDate.Location = new Point(25, 167);
            dateTimePickerOccurrenceDate.Margin = new Padding(20, 3, 20, 3);
            dateTimePickerOccurrenceDate.Name = "dateTimePickerOccurrenceDate";
            dateTimePickerOccurrenceDate.Size = new Size(200, 23);
            dateTimePickerOccurrenceDate.TabIndex = 29;
            // 
            // dateTimePickerNotificationDate
            // 
            dateTimePickerNotificationDate.Location = new Point(25, 214);
            dateTimePickerNotificationDate.Margin = new Padding(20, 3, 20, 3);
            dateTimePickerNotificationDate.Name = "dateTimePickerNotificationDate";
            dateTimePickerNotificationDate.Size = new Size(200, 23);
            dateTimePickerNotificationDate.TabIndex = 30;
            // 
            // dateTimePickerReportReceptionDate
            // 
            dateTimePickerReportReceptionDate.Location = new Point(265, 369);
            dateTimePickerReportReceptionDate.Margin = new Padding(20, 3, 20, 3);
            dateTimePickerReportReceptionDate.Name = "dateTimePickerReportReceptionDate";
            dateTimePickerReportReceptionDate.Size = new Size(200, 23);
            dateTimePickerReportReceptionDate.TabIndex = 32;
            // 
            // labelReportReceptionDate
            // 
            labelReportReceptionDate.AutoSize = true;
            labelReportReceptionDate.Location = new Point(265, 351);
            labelReportReceptionDate.Margin = new Padding(20, 3, 20, 0);
            labelReportReceptionDate.Name = "labelReportReceptionDate";
            labelReportReceptionDate.Size = new Size(153, 15);
            labelReportReceptionDate.TabIndex = 31;
            labelReportReceptionDate.Text = "Date de récption du rapport";
            // 
            // dateTimePickerLastElmReceptionDate
            // 
            dateTimePickerLastElmReceptionDate.Location = new Point(505, 41);
            dateTimePickerLastElmReceptionDate.Margin = new Padding(20, 3, 20, 3);
            dateTimePickerLastElmReceptionDate.Name = "dateTimePickerLastElmReceptionDate";
            dateTimePickerLastElmReceptionDate.Size = new Size(200, 23);
            dateTimePickerLastElmReceptionDate.TabIndex = 34;
            // 
            // labelLastElmReceptionDate
            // 
            labelLastElmReceptionDate.AutoSize = true;
            labelLastElmReceptionDate.Location = new Point(505, 8);
            labelLastElmReceptionDate.Margin = new Padding(20, 3, 20, 0);
            labelLastElmReceptionDate.Name = "labelLastElmReceptionDate";
            labelLastElmReceptionDate.Size = new Size(200, 30);
            labelLastElmReceptionDate.TabIndex = 33;
            labelLastElmReceptionDate.Text = "Date de récption du dernier élément d'analyse";
            // 
            // dateTimePickerReportElaborationDate
            // 
            dateTimePickerReportElaborationDate.Location = new Point(505, 88);
            dateTimePickerReportElaborationDate.Margin = new Padding(20, 3, 20, 3);
            dateTimePickerReportElaborationDate.Name = "dateTimePickerReportElaborationDate";
            dateTimePickerReportElaborationDate.Size = new Size(200, 23);
            dateTimePickerReportElaborationDate.TabIndex = 36;
            // 
            // labelReportElaborationDate
            // 
            labelReportElaborationDate.AutoSize = true;
            labelReportElaborationDate.Location = new Point(505, 70);
            labelReportElaborationDate.Margin = new Padding(20, 3, 20, 0);
            labelReportElaborationDate.Name = "labelReportElaborationDate";
            labelReportElaborationDate.Size = new Size(162, 15);
            labelReportElaborationDate.TabIndex = 35;
            labelReportElaborationDate.Text = "Date d'élaboration de rapport";
            // 
            // dateTimePickerRecommendationsReleaseDate
            // 
            dateTimePickerRecommendationsReleaseDate.Location = new Point(505, 135);
            dateTimePickerRecommendationsReleaseDate.Margin = new Padding(20, 3, 20, 3);
            dateTimePickerRecommendationsReleaseDate.Name = "dateTimePickerRecommendationsReleaseDate";
            dateTimePickerRecommendationsReleaseDate.Size = new Size(200, 23);
            dateTimePickerRecommendationsReleaseDate.TabIndex = 38;
            // 
            // labelRecommendationsReleaseDate
            // 
            labelRecommendationsReleaseDate.AutoSize = true;
            labelRecommendationsReleaseDate.Location = new Point(505, 117);
            labelRecommendationsReleaseDate.Margin = new Padding(20, 3, 20, 0);
            labelRecommendationsReleaseDate.Name = "labelRecommendationsReleaseDate";
            labelRecommendationsReleaseDate.Size = new Size(218, 15);
            labelRecommendationsReleaseDate.TabIndex = 37;
            labelRecommendationsReleaseDate.Text = "Date de diffusion des recommandations";
            // 
            // dateTimePickerEvidenceReceptionDate
            // 
            dateTimePickerEvidenceReceptionDate.Location = new Point(505, 182);
            dateTimePickerEvidenceReceptionDate.Margin = new Padding(20, 3, 20, 3);
            dateTimePickerEvidenceReceptionDate.Name = "dateTimePickerEvidenceReceptionDate";
            dateTimePickerEvidenceReceptionDate.Size = new Size(200, 23);
            dateTimePickerEvidenceReceptionDate.TabIndex = 40;
            // 
            // labelEvidenceReceptionDate
            // 
            labelEvidenceReceptionDate.AutoSize = true;
            labelEvidenceReceptionDate.Location = new Point(505, 164);
            labelEvidenceReceptionDate.Margin = new Padding(20, 3, 20, 0);
            labelEvidenceReceptionDate.Name = "labelEvidenceReceptionDate";
            labelEvidenceReceptionDate.Size = new Size(134, 15);
            labelEvidenceReceptionDate.TabIndex = 39;
            labelEvidenceReceptionDate.Text = "Date reception evidence";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(505, 229);
            comboBoxStatus.Margin = new Padding(20, 3, 20, 3);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 23);
            comboBoxStatus.TabIndex = 42;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(505, 211);
            labelStatus.Margin = new Padding(20, 3, 20, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(27, 15);
            labelStatus.TabIndex = 41;
            labelStatus.Text = "Etat";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(505, 258);
            labelColor.Margin = new Padding(20, 3, 20, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(49, 15);
            labelColor.TabIndex = 44;
            labelColor.Text = "Couleur";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(505, 276);
            textBoxColor.Margin = new Padding(20, 3, 20, 3);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(200, 23);
            textBoxColor.TabIndex = 43;
            // 
            // labelFlightPhase
            // 
            labelFlightPhase.AutoSize = true;
            labelFlightPhase.Location = new Point(505, 305);
            labelFlightPhase.Margin = new Padding(20, 3, 20, 0);
            labelFlightPhase.Name = "labelFlightPhase";
            labelFlightPhase.Size = new Size(73, 15);
            labelFlightPhase.TabIndex = 46;
            labelFlightPhase.Text = "Phase de vol";
            // 
            // textBoxFlightPhase
            // 
            textBoxFlightPhase.Location = new Point(505, 323);
            textBoxFlightPhase.Margin = new Padding(20, 3, 20, 3);
            textBoxFlightPhase.Name = "textBoxFlightPhase";
            textBoxFlightPhase.Size = new Size(200, 23);
            textBoxFlightPhase.TabIndex = 45;
            // 
            // labelAltitude
            // 
            labelAltitude.AutoSize = true;
            labelAltitude.Location = new Point(505, 352);
            labelAltitude.Margin = new Padding(20, 3, 20, 0);
            labelAltitude.Name = "labelAltitude";
            labelAltitude.Size = new Size(49, 15);
            labelAltitude.TabIndex = 48;
            labelAltitude.Text = "Altitude";
            // 
            // textBoxAltitude
            // 
            textBoxAltitude.Location = new Point(505, 370);
            textBoxAltitude.Margin = new Padding(20, 3, 20, 3);
            textBoxAltitude.Name = "textBoxAltitude";
            textBoxAltitude.Size = new Size(200, 23);
            textBoxAltitude.TabIndex = 47;
            // 
            // comboBoxSeverity
            // 
            comboBoxSeverity.FormattingEnabled = true;
            comboBoxSeverity.Items.AddRange(new object[] { "A : Accident", "B : Incident grave", "C : Incident majeur", "D : Incident significatif", "E : Aucune incidence immédiate sur la sécurité" });
            comboBoxSeverity.Location = new Point(265, 221);
            comboBoxSeverity.Margin = new Padding(20, 3, 20, 3);
            comboBoxSeverity.Name = "comboBoxSeverity";
            comboBoxSeverity.Size = new Size(200, 23);
            comboBoxSeverity.TabIndex = 26;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(265, 26);
            textBoxDescription.Margin = new Padding(20, 3, 20, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(196, 77);
            textBoxDescription.TabIndex = 19;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(265, 8);
            labelDescription.Margin = new Padding(20, 3, 20, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 20;
            labelDescription.Text = "Description";
            // 
            // labelCauses
            // 
            labelCauses.AutoSize = true;
            labelCauses.Location = new Point(265, 109);
            labelCauses.Margin = new Padding(20, 3, 20, 0);
            labelCauses.Name = "labelCauses";
            labelCauses.Size = new Size(39, 15);
            labelCauses.TabIndex = 21;
            labelCauses.Text = "Cause";
            // 
            // comboBoxCauses
            // 
            comboBoxCauses.FormattingEnabled = true;
            comboBoxCauses.Location = new Point(265, 127);
            comboBoxCauses.Margin = new Padding(20, 3, 20, 3);
            comboBoxCauses.Name = "comboBoxCauses";
            comboBoxCauses.Size = new Size(200, 23);
            comboBoxCauses.TabIndex = 22;
            // 
            // labelFrequency
            // 
            labelFrequency.AutoSize = true;
            labelFrequency.Location = new Point(265, 156);
            labelFrequency.Margin = new Padding(20, 3, 20, 0);
            labelFrequency.Name = "labelFrequency";
            labelFrequency.Size = new Size(62, 15);
            labelFrequency.TabIndex = 23;
            labelFrequency.Text = "Fréquence";
            // 
            // comboBoxFrequency
            // 
            comboBoxFrequency.FormattingEnabled = true;
            comboBoxFrequency.Items.AddRange(new object[] { "1 : Extrêmement rare", "2 : Rare", "3 : Occasionnel", "4 : Fréquent", "5 : Très fréquent" });
            comboBoxFrequency.Location = new Point(265, 174);
            comboBoxFrequency.Margin = new Padding(20, 3, 20, 3);
            comboBoxFrequency.Name = "comboBoxFrequency";
            comboBoxFrequency.Size = new Size(200, 23);
            comboBoxFrequency.TabIndex = 24;
            // 
            // labelSeverity
            // 
            labelSeverity.AutoSize = true;
            labelSeverity.Location = new Point(265, 203);
            labelSeverity.Margin = new Padding(20, 3, 20, 0);
            labelSeverity.Name = "labelSeverity";
            labelSeverity.Size = new Size(44, 15);
            labelSeverity.TabIndex = 25;
            labelSeverity.Text = "Gravité";
            // 
            // textBoxSecurityRecommandation
            // 
            textBoxSecurityRecommandation.Location = new Point(265, 268);
            textBoxSecurityRecommandation.Margin = new Padding(20, 3, 20, 3);
            textBoxSecurityRecommandation.Multiline = true;
            textBoxSecurityRecommandation.Name = "textBoxSecurityRecommandation";
            textBoxSecurityRecommandation.Size = new Size(200, 77);
            textBoxSecurityRecommandation.TabIndex = 27;
            // 
            // labelSecurityRecommandation
            // 
            labelSecurityRecommandation.AutoSize = true;
            labelSecurityRecommandation.Location = new Point(265, 250);
            labelSecurityRecommandation.Margin = new Padding(20, 3, 20, 0);
            labelSecurityRecommandation.Name = "labelSecurityRecommandation";
            labelSecurityRecommandation.Size = new Size(162, 15);
            labelSecurityRecommandation.TabIndex = 28;
            labelSecurityRecommandation.Text = "Recommandation de sécurité";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelCode);
            flowLayoutPanel1.Controls.Add(textBoxCode);
            flowLayoutPanel1.Controls.Add(labelReference);
            flowLayoutPanel1.Controls.Add(textBoxReference);
            flowLayoutPanel1.Controls.Add(labelSource);
            flowLayoutPanel1.Controls.Add(textBoxSource);
            flowLayoutPanel1.Controls.Add(labelOccurrenceDate);
            flowLayoutPanel1.Controls.Add(dateTimePickerOccurrenceDate);
            flowLayoutPanel1.Controls.Add(labelNotificationDate);
            flowLayoutPanel1.Controls.Add(dateTimePickerNotificationDate);
            flowLayoutPanel1.Controls.Add(labelEventType);
            flowLayoutPanel1.Controls.Add(comboBoxEventType);
            flowLayoutPanel1.Controls.Add(labelLocation);
            flowLayoutPanel1.Controls.Add(textBoxLocation);
            flowLayoutPanel1.Controls.Add(labelInvolvedTraffic);
            flowLayoutPanel1.Controls.Add(textBoxInvolvedTraffic);
            flowLayoutPanel1.Controls.Add(labelDescription);
            flowLayoutPanel1.Controls.Add(textBoxDescription);
            flowLayoutPanel1.Controls.Add(labelCauses);
            flowLayoutPanel1.Controls.Add(comboBoxCauses);
            flowLayoutPanel1.Controls.Add(labelFrequency);
            flowLayoutPanel1.Controls.Add(comboBoxFrequency);
            flowLayoutPanel1.Controls.Add(labelSeverity);
            flowLayoutPanel1.Controls.Add(comboBoxSeverity);
            flowLayoutPanel1.Controls.Add(labelSecurityRecommandation);
            flowLayoutPanel1.Controls.Add(textBoxSecurityRecommandation);
            flowLayoutPanel1.Controls.Add(labelReportReceptionDate);
            flowLayoutPanel1.Controls.Add(dateTimePickerReportReceptionDate);
            flowLayoutPanel1.Controls.Add(labelLastElmReceptionDate);
            flowLayoutPanel1.Controls.Add(dateTimePickerLastElmReceptionDate);
            flowLayoutPanel1.Controls.Add(labelReportElaborationDate);
            flowLayoutPanel1.Controls.Add(dateTimePickerReportElaborationDate);
            flowLayoutPanel1.Controls.Add(labelRecommendationsReleaseDate);
            flowLayoutPanel1.Controls.Add(dateTimePickerRecommendationsReleaseDate);
            flowLayoutPanel1.Controls.Add(labelEvidenceReceptionDate);
            flowLayoutPanel1.Controls.Add(dateTimePickerEvidenceReceptionDate);
            flowLayoutPanel1.Controls.Add(labelStatus);
            flowLayoutPanel1.Controls.Add(comboBoxStatus);
            flowLayoutPanel1.Controls.Add(labelColor);
            flowLayoutPanel1.Controls.Add(textBoxColor);
            flowLayoutPanel1.Controls.Add(labelFlightPhase);
            flowLayoutPanel1.Controls.Add(textBoxFlightPhase);
            flowLayoutPanel1.Controls.Add(labelAltitude);
            flowLayoutPanel1.Controls.Add(textBoxAltitude);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(138, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(778, 402);
            flowLayoutPanel1.TabIndex = 50;
            // 
            // buttonAddEvent
            // 
            buttonAddEvent.BackColor = SystemColors.Highlight;
            buttonAddEvent.ForeColor = Color.White;
            buttonAddEvent.Location = new Point(855, 505);
            buttonAddEvent.Margin = new Padding(1);
            buttonAddEvent.Name = "buttonAddEvent";
            buttonAddEvent.Padding = new Padding(2);
            buttonAddEvent.Size = new Size(61, 36);
            buttonAddEvent.TabIndex = 51;
            buttonAddEvent.Text = "Save";
            buttonAddEvent.UseVisualStyleBackColor = false;
            buttonAddEvent.Click += buttonAddEvent_Click;
            // 
            // buttonDeleteEvent
            // 
            buttonDeleteEvent.BackColor = Color.FromArgb(255, 192, 128);
            buttonDeleteEvent.ForeColor = Color.White;
            buttonDeleteEvent.Location = new Point(135, 505);
            buttonDeleteEvent.Margin = new Padding(1);
            buttonDeleteEvent.Name = "buttonDeleteEvent";
            buttonDeleteEvent.Padding = new Padding(2);
            buttonDeleteEvent.Size = new Size(61, 36);
            buttonDeleteEvent.TabIndex = 52;
            buttonDeleteEvent.Text = "Clear";
            buttonDeleteEvent.UseVisualStyleBackColor = false;
            buttonDeleteEvent.Click += buttonClear_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.Location = new Point(353, 505);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Padding = new Padding(2);
            button2.Size = new Size(64, 36);
            button2.TabIndex = 53;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateEvent
            // 
            buttonUpdateEvent.BackColor = Color.FromArgb(255, 128, 0);
            buttonUpdateEvent.ForeColor = Color.White;
            buttonUpdateEvent.Location = new Point(607, 505);
            buttonUpdateEvent.Margin = new Padding(1);
            buttonUpdateEvent.Name = "buttonUpdateEvent";
            buttonUpdateEvent.Padding = new Padding(2);
            buttonUpdateEvent.Size = new Size(63, 36);
            buttonUpdateEvent.TabIndex = 54;
            buttonUpdateEvent.Text = "Update";
            buttonUpdateEvent.UseVisualStyleBackColor = false;
            // 
            // CreateEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(994, 569);
            Controls.Add(buttonUpdateEvent);
            Controls.Add(button2);
            Controls.Add(buttonDeleteEvent);
            Controls.Add(buttonAddEvent);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Name = "CreateEvent";
            Text = "Ajouter un evenment";
            Load += CreateEvent_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private Label label1;
        private TextBox textBoxCode;
        private Label labelCode;
        private Label labelReference;
        private TextBox textBoxReference;
        private Label labelSource;
        private TextBox textBoxSource;
        private Label labelOccurrenceDate;
        private Label labelNotificationDate;
        private Label labelEventType;
        private ComboBox comboBoxEventType;
        private Label labelLocation;
        private TextBox textBoxLocation;
        private Label labelInvolvedTraffic;
        private TextBox textBoxInvolvedTraffic;
        private DateTimePicker dateTimePickerOccurrenceDate;
        private DateTimePicker dateTimePickerNotificationDate;
        private DateTimePicker dateTimePickerReportReceptionDate;
        private Label labelReportReceptionDate;
        private DateTimePicker dateTimePickerLastElmReceptionDate;
        private Label labelLastElmReceptionDate;
        private DateTimePicker dateTimePickerReportElaborationDate;
        private Label labelReportElaborationDate;
        private DateTimePicker dateTimePickerRecommendationsReleaseDate;
        private Label labelRecommendationsReleaseDate;
        private DateTimePicker dateTimePickerEvidenceReceptionDate;
        private Label labelEvidenceReceptionDate;
        private ComboBox comboBoxStatus;
        private Label labelStatus;
        private Label labelColor;
        private TextBox textBoxColor;
        private Label labelFlightPhase;
        private TextBox textBoxFlightPhase;
        private Label labelAltitude;
        private TextBox textBoxAltitude;
        private ComboBox comboBoxSeverity;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private Label labelCauses;
        private ComboBox comboBoxCauses;
        private Label labelFrequency;
        private ComboBox comboBoxFrequency;
        private Label labelSeverity;
        private TextBox textBoxSecurityRecommandation;
        private Label labelSecurityRecommandation;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAddEvent;
        private Button buttonDeleteEvent;
        private Button button2;
        private Button buttonUpdateEvent;
    }
}