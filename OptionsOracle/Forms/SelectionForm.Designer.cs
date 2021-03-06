namespace OptionsOracle.Forms
{
    partial class SelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.descWebBrowser = new System.Windows.Forms.WebBrowser();
            this.listComboBox = new System.Windows.Forms.ComboBox();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addStrategyCheckBox = new System.Windows.Forms.CheckBox();
            this.moreOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.moreOptionsButton = new System.Windows.Forms.Button();
            this.moreOptionsLabel = new System.Windows.Forms.Label();
            this.startMonthComboBox = new System.Windows.Forms.ComboBox();
            this.startMonthCheckBox = new System.Windows.Forms.CheckBox();
            this.moreOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // descWebBrowser
            // 
            this.descWebBrowser.Location = new System.Drawing.Point(12, 52);
            this.descWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.descWebBrowser.Name = "descWebBrowser";
            this.descWebBrowser.ScrollBarsEnabled = false;
            this.descWebBrowser.Size = new System.Drawing.Size(268, 206);
            this.descWebBrowser.TabIndex = 2;
            // 
            // listComboBox
            // 
            this.listComboBox.FormattingEnabled = true;
            this.listComboBox.Location = new System.Drawing.Point(12, 24);
            this.listComboBox.Name = "listComboBox";
            this.listComboBox.Size = new System.Drawing.Size(268, 21);
            this.listComboBox.TabIndex = 1;
            this.listComboBox.SelectedIndexChanged += new System.EventHandler(this.strategyComboBox_SelectedIndexChanged);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(12, 8);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(120, 13);
            this.selectionLabel.TabIndex = 0;
            this.selectionLabel.Text = "Select <selection-type>:";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(190, 393);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 24);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Select";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(94, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 24);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addStrategyCheckBox
            // 
            this.addStrategyCheckBox.AutoSize = true;
            this.addStrategyCheckBox.Location = new System.Drawing.Point(10, 21);
            this.addStrategyCheckBox.Name = "addStrategyCheckBox";
            this.addStrategyCheckBox.Size = new System.Drawing.Size(238, 17);
            this.addStrategyCheckBox.TabIndex = 5;
            this.addStrategyCheckBox.Text = "Add (don\'t replace) to current market strategy";
            this.addStrategyCheckBox.UseVisualStyleBackColor = true;
            // 
            // moreOptionsGroupBox
            // 
            this.moreOptionsGroupBox.Controls.Add(this.startMonthCheckBox);
            this.moreOptionsGroupBox.Controls.Add(this.startMonthComboBox);
            this.moreOptionsGroupBox.Controls.Add(this.addStrategyCheckBox);
            this.moreOptionsGroupBox.Location = new System.Drawing.Point(12, 269);
            this.moreOptionsGroupBox.Name = "moreOptionsGroupBox";
            this.moreOptionsGroupBox.Size = new System.Drawing.Size(268, 102);
            this.moreOptionsGroupBox.TabIndex = 6;
            this.moreOptionsGroupBox.TabStop = false;
            // 
            // moreOptionsButton
            // 
            this.moreOptionsButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreOptionsButton.Location = new System.Drawing.Point(12, 264);
            this.moreOptionsButton.Name = "moreOptionsButton";
            this.moreOptionsButton.Size = new System.Drawing.Size(20, 20);
            this.moreOptionsButton.TabIndex = 7;
            this.moreOptionsButton.Text = "-";
            this.moreOptionsButton.UseVisualStyleBackColor = true;
            this.moreOptionsButton.Click += new System.EventHandler(this.moreOptionsButton_Click);
            // 
            // moreOptionsLabel
            // 
            this.moreOptionsLabel.AutoSize = true;
            this.moreOptionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.moreOptionsLabel.Location = new System.Drawing.Point(36, 268);
            this.moreOptionsLabel.Name = "moreOptionsLabel";
            this.moreOptionsLabel.Size = new System.Drawing.Size(85, 13);
            this.moreOptionsLabel.TabIndex = 8;
            this.moreOptionsLabel.Text = "More Options ... ";
            // 
            // startMonthComboBox
            // 
            this.startMonthComboBox.Enabled = false;
            this.startMonthComboBox.FormattingEnabled = true;
            this.startMonthComboBox.Location = new System.Drawing.Point(100, 44);
            this.startMonthComboBox.Name = "startMonthComboBox";
            this.startMonthComboBox.Size = new System.Drawing.Size(90, 21);
            this.startMonthComboBox.TabIndex = 6;
            // 
            // startMonthCheckBox
            // 
            this.startMonthCheckBox.AutoSize = true;
            this.startMonthCheckBox.Location = new System.Drawing.Point(10, 46);
            this.startMonthCheckBox.Name = "startMonthCheckBox";
            this.startMonthCheckBox.Size = new System.Drawing.Size(84, 17);
            this.startMonthCheckBox.TabIndex = 8;
            this.startMonthCheckBox.Text = "Start Month:";
            this.startMonthCheckBox.UseVisualStyleBackColor = true;
            this.startMonthCheckBox.CheckedChanged += new System.EventHandler(this.startMonthCheckBox_CheckedChanged);
            // 
            // SelectionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(292, 425);
            this.Controls.Add(this.moreOptionsLabel);
            this.Controls.Add(this.moreOptionsButton);
            this.Controls.Add(this.moreOptionsGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.listComboBox);
            this.Controls.Add(this.descWebBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a <selection-type>...";
            this.moreOptionsGroupBox.ResumeLayout(false);
            this.moreOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser descWebBrowser;
        private System.Windows.Forms.ComboBox listComboBox;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox addStrategyCheckBox;
        private System.Windows.Forms.GroupBox moreOptionsGroupBox;
        private System.Windows.Forms.Button moreOptionsButton;
        private System.Windows.Forms.Label moreOptionsLabel;
        private System.Windows.Forms.ComboBox startMonthComboBox;
        private System.Windows.Forms.CheckBox startMonthCheckBox;
    }
}