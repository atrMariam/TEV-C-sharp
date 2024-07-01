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
            buttonSubmit = new Button();
            buttonDeleteEvent = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(417, 23);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 31);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "Selectioner une categorie";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSubmit.BackColor = SystemColors.Highlight;
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(739, 505);
            buttonSubmit.Margin = new Padding(1);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Padding = new Padding(2);
            buttonSubmit.Size = new Size(61, 36);
            buttonSubmit.TabIndex = 51;
            buttonSubmit.Text = "Save";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonDeleteEvent
            // 
            buttonDeleteEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDeleteEvent.BackColor = Color.FromArgb(255, 192, 128);
            buttonDeleteEvent.ForeColor = Color.White;
            buttonDeleteEvent.Location = new Point(43, 505);
            buttonDeleteEvent.Margin = new Padding(1);
            buttonDeleteEvent.Name = "buttonDeleteEvent";
            buttonDeleteEvent.Padding = new Padding(2);
            buttonDeleteEvent.Size = new Size(61, 36);
            buttonDeleteEvent.TabIndex = 52;
            buttonDeleteEvent.Text = "Clear";
            buttonDeleteEvent.UseVisualStyleBackColor = false;
            buttonDeleteEvent.Click += buttonClear_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(43, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 413);
            panel1.TabIndex = 0;
            // 
            // CreateEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(855, 569);
            Controls.Add(panel1);
            Controls.Add(buttonDeleteEvent);
            Controls.Add(buttonSubmit);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Name = "CreateEvent";
            Text = "Ajouter un evenment";
            Load += CreateEvent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private Label label1;
        private Button buttonSubmit;
        private Button buttonDeleteEvent;
        private Panel panel1;
    }
}