namespace TEV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            buttonCreateEvent = new Button();
            buttonDeleteEvent = new Button();
            buttonEditerEvent = new Button();
            buttonShowEventDetails = new Button();
            pictureBoxSetting = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(42, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(925, 323);
            dataGridView1.TabIndex = 0;
            // 
            // buttonCreateEvent
            // 
            buttonCreateEvent.Location = new Point(42, 77);
            buttonCreateEvent.Name = "buttonCreateEvent";
            buttonCreateEvent.Size = new Size(75, 23);
            buttonCreateEvent.TabIndex = 1;
            buttonCreateEvent.Text = "Ajouter";
            buttonCreateEvent.UseVisualStyleBackColor = true;
            buttonCreateEvent.Click += buttonCreateEvent_Click;
            // 
            // buttonDeleteEvent
            // 
            buttonDeleteEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteEvent.BackColor = Color.FromArgb(255, 128, 128);
            buttonDeleteEvent.Location = new Point(811, 77);
            buttonDeleteEvent.Name = "buttonDeleteEvent";
            buttonDeleteEvent.Size = new Size(75, 23);
            buttonDeleteEvent.TabIndex = 2;
            buttonDeleteEvent.Text = "Supprimer";
            buttonDeleteEvent.UseVisualStyleBackColor = false;
            buttonDeleteEvent.Click += buttonDeleteEvent_Click;
            // 
            // buttonEditerEvent
            // 
            buttonEditerEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditerEvent.BackColor = Color.FromArgb(255, 192, 128);
            buttonEditerEvent.Location = new Point(892, 77);
            buttonEditerEvent.Name = "buttonEditerEvent";
            buttonEditerEvent.Size = new Size(75, 23);
            buttonEditerEvent.TabIndex = 3;
            buttonEditerEvent.Text = "Editer";
            buttonEditerEvent.UseVisualStyleBackColor = false;
            buttonEditerEvent.Click += buttonEditerEvent_Click;
            // 
            // buttonShowEventDetails
            // 
            buttonShowEventDetails.Location = new Point(123, 77);
            buttonShowEventDetails.Name = "buttonShowEventDetails";
            buttonShowEventDetails.Size = new Size(75, 23);
            buttonShowEventDetails.TabIndex = 4;
            buttonShowEventDetails.Text = "Details";
            buttonShowEventDetails.UseVisualStyleBackColor = true;
            buttonShowEventDetails.Click += buttonShowEventDetails_Click;
            // 
            // pictureBoxSetting
            // 
            pictureBoxSetting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxSetting.Image = (Image)resources.GetObject("pictureBoxSetting.Image");
            pictureBoxSetting.Location = new Point(938, 12);
            pictureBoxSetting.Name = "pictureBoxSetting";
            pictureBoxSetting.Size = new Size(29, 26);
            pictureBoxSetting.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSetting.TabIndex = 5;
            pictureBoxSetting.TabStop = false;
            pictureBoxSetting.Click += pictureBoxSetting_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 476);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxSetting);
            Controls.Add(buttonShowEventDetails);
            Controls.Add(buttonEditerEvent);
            Controls.Add(buttonDeleteEvent);
            Controls.Add(buttonCreateEvent);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "TEV";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonCreateEvent;
        private Button buttonDeleteEvent;
        private Button buttonEditerEvent;
        private Button buttonShowEventDetails;
        private PictureBox pictureBoxSetting;
        private PictureBox pictureBox2;
    }
}
