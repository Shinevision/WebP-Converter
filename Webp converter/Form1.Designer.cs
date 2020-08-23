namespace Webp_converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.convertTextbox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.outputType = new System.Windows.Forms.ComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(12, 12);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(415, 20);
            this.InputTextbox.TabIndex = 0;
            this.InputTextbox.TextChanged += new System.EventHandler(this.InputTextbox_TextChanged);
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputButton.Location = new System.Drawing.Point(434, 12);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "Browse";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // convertTextbox
            // 
            this.convertTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convertTextbox.Location = new System.Drawing.Point(12, 71);
            this.convertTextbox.Name = "convertTextbox";
            this.convertTextbox.Size = new System.Drawing.Size(415, 20);
            this.convertTextbox.TabIndex = 2;
            this.convertTextbox.TextChanged += new System.EventHandler(this.convertTextbox_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.Location = new System.Drawing.Point(434, 68);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // outputType
            // 
            this.outputType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputType.FormattingEnabled = true;
            this.outputType.Location = new System.Drawing.Point(434, 41);
            this.outputType.Name = "outputType";
            this.outputType.Size = new System.Drawing.Size(75, 21);
            this.outputType.TabIndex = 4;
            this.outputType.SelectedIndexChanged += new System.EventHandler(this.outputType_SelectedIndexChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 94);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(521, 22);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            this.StatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip_ItemClicked);
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(0, 17);
            this.StatusStripLabel.Click += new System.EventHandler(this.StatusStripLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 116);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.outputType);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.convertTextbox);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebP converter";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.TextBox convertTextbox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.ComboBox outputType;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
    }
}

