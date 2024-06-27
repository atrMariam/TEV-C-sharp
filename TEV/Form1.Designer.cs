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
            dataGridView1 = new DataGridView();
            buttonCreateEvent = new Button();
            buttonDeleteEvent = new Button();
            buttonEditerEvent = new Button();
            buttonShowEventDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.Location = new Point(42, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(925, 323);
            dataGridView1.TabIndex = 0;
            // 
            // buttonCreateEvent
            // 
            buttonCreateEvent.Location = new Point(42, 57);
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
            buttonDeleteEvent.Location = new Point(811, 57);
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
            buttonEditerEvent.Location = new Point(892, 57);
            buttonEditerEvent.Name = "buttonEditerEvent";
            buttonEditerEvent.Size = new Size(75, 23);
            buttonEditerEvent.TabIndex = 3;
            buttonEditerEvent.Text = "Editer";
            buttonEditerEvent.UseVisualStyleBackColor = false;
            buttonEditerEvent.Click += buttonEditerEvent_Click;
            // 
            // buttonShowEventDetails
            // 
            buttonShowEventDetails.Location = new Point(123, 57);
            buttonShowEventDetails.Name = "buttonShowEventDetails";
            buttonShowEventDetails.Size = new Size(75, 23);
            buttonShowEventDetails.TabIndex = 4;
            buttonShowEventDetails.Text = "Details";
            buttonShowEventDetails.UseVisualStyleBackColor = true;
            buttonShowEventDetails.Click += buttonShowEventDetails_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 476);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonCreateEvent;
        private Button buttonDeleteEvent;
        private Button buttonEditerEvent;
        private Button buttonShowEventDetails;
    }
}
