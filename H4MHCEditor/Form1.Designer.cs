namespace H4MHCEditor {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.advisorAddButton = new System.Windows.Forms.Button();
            this.advisorNameTextbox = new System.Windows.Forms.TextBox();
            this.advisorNameLabel = new System.Windows.Forms.Label();
            this.advisorGfxIdTextbox = new System.Windows.Forms.TextBox();
            this.advisorGfxIdLabel = new System.Windows.Forms.Label();
            this.advisorGfxIdCheckbox = new System.Windows.Forms.CheckBox();
            this.startupHighCheckbox = new System.Windows.Forms.CheckBox();
            this.advisorMhcIdNumeric = new System.Windows.Forms.NumericUpDown();
            this.advisorMhcIdLabel = new System.Windows.Forms.Label();
            this.advisorMhcIdCheckbox = new System.Windows.Forms.CheckBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.advisorTypeCheckboxList = new System.Windows.Forms.CheckedListBox();
            this.modDirectoryLabel = new System.Windows.Forms.Label();
            this.modDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.modDirectoryButton = new System.Windows.Forms.Button();
            this.countryTagLabel = new System.Windows.Forms.Label();
            this.countryTagTextbox = new System.Windows.Forms.TextBox();
            this.advisorLocKeyTextbox = new System.Windows.Forms.TextBox();
            this.advisorLocKeyLabel = new System.Windows.Forms.Label();
            this.advisorLocKeyButton = new System.Windows.Forms.Button();
            this.logTextbox = new System.Windows.Forms.RichTextBox();
            this.advisorTraitLabel = new System.Windows.Forms.Label();
            this.startupTraitNumeric = new System.Windows.Forms.NumericUpDown();
            this.startupButton = new System.Windows.Forms.Button();
            this.startupBookmarkCheckboxList = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.advisorMhcIdNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startupTraitNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // advisorAddButton
            // 
            this.advisorAddButton.Location = new System.Drawing.Point(12, 235);
            this.advisorAddButton.Name = "advisorAddButton";
            this.advisorAddButton.Size = new System.Drawing.Size(168, 20);
            this.advisorAddButton.TabIndex = 11;
            this.advisorAddButton.Text = "Add Advisor";
            this.advisorAddButton.UseVisualStyleBackColor = true;
            this.advisorAddButton.Click += new System.EventHandler(this.advisorAddButton_Click);
            // 
            // advisorNameTextbox
            // 
            this.advisorNameTextbox.Location = new System.Drawing.Point(12, 70);
            this.advisorNameTextbox.Name = "advisorNameTextbox";
            this.advisorNameTextbox.Size = new System.Drawing.Size(168, 20);
            this.advisorNameTextbox.TabIndex = 2;
            // 
            // advisorNameLabel
            // 
            this.advisorNameLabel.AutoSize = true;
            this.advisorNameLabel.Location = new System.Drawing.Point(9, 54);
            this.advisorNameLabel.Name = "advisorNameLabel";
            this.advisorNameLabel.Size = new System.Drawing.Size(87, 13);
            this.advisorNameLabel.TabIndex = 3;
            this.advisorNameLabel.Text = "Name of advisor:";
            // 
            // advisorGfxIdTextbox
            // 
            this.advisorGfxIdTextbox.Location = new System.Drawing.Point(196, 69);
            this.advisorGfxIdTextbox.Name = "advisorGfxIdTextbox";
            this.advisorGfxIdTextbox.Size = new System.Drawing.Size(168, 20);
            this.advisorGfxIdTextbox.TabIndex = 3;
            // 
            // advisorGfxIdLabel
            // 
            this.advisorGfxIdLabel.AutoSize = true;
            this.advisorGfxIdLabel.Location = new System.Drawing.Point(193, 53);
            this.advisorGfxIdLabel.Name = "advisorGfxIdLabel";
            this.advisorGfxIdLabel.Size = new System.Drawing.Size(45, 13);
            this.advisorGfxIdLabel.TabIndex = 5;
            this.advisorGfxIdLabel.Text = "GFX ID:";
            // 
            // advisorGfxIdCheckbox
            // 
            this.advisorGfxIdCheckbox.AutoSize = true;
            this.advisorGfxIdCheckbox.Location = new System.Drawing.Point(196, 92);
            this.advisorGfxIdCheckbox.Name = "advisorGfxIdCheckbox";
            this.advisorGfxIdCheckbox.Size = new System.Drawing.Size(78, 17);
            this.advisorGfxIdCheckbox.TabIndex = 4;
            this.advisorGfxIdCheckbox.Text = "No GFX ID";
            this.advisorGfxIdCheckbox.UseVisualStyleBackColor = true;
            this.advisorGfxIdCheckbox.CheckedChanged += new System.EventHandler(this.advisorGfxIdCheckbox_CheckedChanged);
            // 
            // startupHighCheckbox
            // 
            this.startupHighCheckbox.AutoSize = true;
            this.startupHighCheckbox.Location = new System.Drawing.Point(379, 138);
            this.startupHighCheckbox.Name = "startupHighCheckbox";
            this.startupHighCheckbox.Size = new System.Drawing.Size(125, 17);
            this.startupHighCheckbox.TabIndex = 14;
            this.startupHighCheckbox.Text = "Advisor is High Brass";
            this.startupHighCheckbox.UseVisualStyleBackColor = true;
            // 
            // advisorMhcIdNumeric
            // 
            this.advisorMhcIdNumeric.Location = new System.Drawing.Point(379, 70);
            this.advisorMhcIdNumeric.Name = "advisorMhcIdNumeric";
            this.advisorMhcIdNumeric.Size = new System.Drawing.Size(66, 20);
            this.advisorMhcIdNumeric.TabIndex = 5;
            this.advisorMhcIdNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // advisorMhcIdLabel
            // 
            this.advisorMhcIdLabel.AutoSize = true;
            this.advisorMhcIdLabel.Location = new System.Drawing.Point(376, 54);
            this.advisorMhcIdLabel.Name = "advisorMhcIdLabel";
            this.advisorMhcIdLabel.Size = new System.Drawing.Size(48, 13);
            this.advisorMhcIdLabel.TabIndex = 9;
            this.advisorMhcIdLabel.Text = "MHC ID:";
            // 
            // advisorMhcIdCheckbox
            // 
            this.advisorMhcIdCheckbox.AutoSize = true;
            this.advisorMhcIdCheckbox.Location = new System.Drawing.Point(379, 92);
            this.advisorMhcIdCheckbox.Name = "advisorMhcIdCheckbox";
            this.advisorMhcIdCheckbox.Size = new System.Drawing.Size(147, 17);
            this.advisorMhcIdCheckbox.TabIndex = 6;
            this.advisorMhcIdCheckbox.Text = "Autoincrease after adding";
            this.advisorMhcIdCheckbox.UseVisualStyleBackColor = true;
            this.advisorMhcIdCheckbox.CheckedChanged += new System.EventHandler(this.advisorMhcIdCheckbox_CheckedChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(193, 240);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // advisorTypeCheckboxList
            // 
            this.advisorTypeCheckboxList.FormattingEnabled = true;
            this.advisorTypeCheckboxList.Items.AddRange(new object[] {
            "Army",
            "Airforce",
            "Navy"});
            this.advisorTypeCheckboxList.Location = new System.Drawing.Point(12, 138);
            this.advisorTypeCheckboxList.Name = "advisorTypeCheckboxList";
            this.advisorTypeCheckboxList.Size = new System.Drawing.Size(168, 49);
            this.advisorTypeCheckboxList.TabIndex = 9;
            this.advisorTypeCheckboxList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.advisorTypeCheckboxList_ItemCheck);
            // 
            // modDirectoryLabel
            // 
            this.modDirectoryLabel.AutoSize = true;
            this.modDirectoryLabel.Location = new System.Drawing.Point(9, 6);
            this.modDirectoryLabel.Name = "modDirectoryLabel";
            this.modDirectoryLabel.Size = new System.Drawing.Size(74, 13);
            this.modDirectoryLabel.TabIndex = 14;
            this.modDirectoryLabel.Text = "Mod directory:";
            // 
            // modDirectoryTextbox
            // 
            this.modDirectoryTextbox.Location = new System.Drawing.Point(12, 22);
            this.modDirectoryTextbox.Name = "modDirectoryTextbox";
            this.modDirectoryTextbox.Size = new System.Drawing.Size(412, 20);
            this.modDirectoryTextbox.TabIndex = 0;
            // 
            // modDirectoryButton
            // 
            this.modDirectoryButton.Location = new System.Drawing.Point(430, 22);
            this.modDirectoryButton.Name = "modDirectoryButton";
            this.modDirectoryButton.Size = new System.Drawing.Size(97, 20);
            this.modDirectoryButton.TabIndex = 1;
            this.modDirectoryButton.Text = "Browse";
            this.modDirectoryButton.UseVisualStyleBackColor = true;
            this.modDirectoryButton.Click += new System.EventHandler(this.modDirectoryButton_Click);
            // 
            // countryTagLabel
            // 
            this.countryTagLabel.AutoSize = true;
            this.countryTagLabel.Location = new System.Drawing.Point(9, 193);
            this.countryTagLabel.Name = "countryTagLabel";
            this.countryTagLabel.Size = new System.Drawing.Size(153, 13);
            this.countryTagLabel.TabIndex = 16;
            this.countryTagLabel.Text = "Country Tag (3 Capital Letters):";
            // 
            // countryTagTextbox
            // 
            this.countryTagTextbox.Location = new System.Drawing.Point(12, 209);
            this.countryTagTextbox.Name = "countryTagTextbox";
            this.countryTagTextbox.Size = new System.Drawing.Size(168, 20);
            this.countryTagTextbox.TabIndex = 10;
            // 
            // advisorLocKeyTextbox
            // 
            this.advisorLocKeyTextbox.Location = new System.Drawing.Point(12, 112);
            this.advisorLocKeyTextbox.Name = "advisorLocKeyTextbox";
            this.advisorLocKeyTextbox.Size = new System.Drawing.Size(168, 20);
            this.advisorLocKeyTextbox.TabIndex = 7;
            // 
            // advisorLocKeyLabel
            // 
            this.advisorLocKeyLabel.AutoSize = true;
            this.advisorLocKeyLabel.Location = new System.Drawing.Point(9, 96);
            this.advisorLocKeyLabel.Name = "advisorLocKeyLabel";
            this.advisorLocKeyLabel.Size = new System.Drawing.Size(111, 13);
            this.advisorLocKeyLabel.TabIndex = 18;
            this.advisorLocKeyLabel.Text = "Advisor name loc key:";
            // 
            // advisorLocKeyButton
            // 
            this.advisorLocKeyButton.Location = new System.Drawing.Point(196, 112);
            this.advisorLocKeyButton.Name = "advisorLocKeyButton";
            this.advisorLocKeyButton.Size = new System.Drawing.Size(102, 20);
            this.advisorLocKeyButton.TabIndex = 8;
            this.advisorLocKeyButton.Text = "Generate Loc Key";
            this.advisorLocKeyButton.UseVisualStyleBackColor = true;
            this.advisorLocKeyButton.Click += new System.EventHandler(this.advisorLocKeyButton_Click);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(12, 264);
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.Size = new System.Drawing.Size(514, 87);
            this.logTextbox.TabIndex = 16;
            this.logTextbox.Text = "";
            // 
            // advisorTraitLabel
            // 
            this.advisorTraitLabel.AutoSize = true;
            this.advisorTraitLabel.Location = new System.Drawing.Point(193, 151);
            this.advisorTraitLabel.Name = "advisorTraitLabel";
            this.advisorTraitLabel.Size = new System.Drawing.Size(45, 13);
            this.advisorTraitLabel.TabIndex = 22;
            this.advisorTraitLabel.Text = "Trait ID:";
            // 
            // startupTraitNumeric
            // 
            this.startupTraitNumeric.Location = new System.Drawing.Point(196, 167);
            this.startupTraitNumeric.Name = "startupTraitNumeric";
            this.startupTraitNumeric.Size = new System.Drawing.Size(66, 20);
            this.startupTraitNumeric.TabIndex = 12;
            this.startupTraitNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startupButton
            // 
            this.startupButton.Location = new System.Drawing.Point(379, 167);
            this.startupButton.Name = "startupButton";
            this.startupButton.Size = new System.Drawing.Size(147, 20);
            this.startupButton.TabIndex = 15;
            this.startupButton.Text = "Add Advisor to Bookmark";
            this.startupButton.UseVisualStyleBackColor = true;
            this.startupButton.Click += new System.EventHandler(this.startupButton_Click);
            // 
            // startupBookmarkCheckboxList
            // 
            this.startupBookmarkCheckboxList.FormattingEnabled = true;
            this.startupBookmarkCheckboxList.Items.AddRange(new object[] {
            "1857"});
            this.startupBookmarkCheckboxList.Location = new System.Drawing.Point(277, 138);
            this.startupBookmarkCheckboxList.Name = "startupBookmarkCheckboxList";
            this.startupBookmarkCheckboxList.Size = new System.Drawing.Size(87, 49);
            this.startupBookmarkCheckboxList.TabIndex = 13;
            this.startupBookmarkCheckboxList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.startupBookmarkCheckboxList_ItemCheck);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 363);
            this.Controls.Add(this.startupBookmarkCheckboxList);
            this.Controls.Add(this.startupButton);
            this.Controls.Add(this.advisorTraitLabel);
            this.Controls.Add(this.startupTraitNumeric);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.advisorLocKeyButton);
            this.Controls.Add(this.advisorLocKeyLabel);
            this.Controls.Add(this.advisorLocKeyTextbox);
            this.Controls.Add(this.countryTagLabel);
            this.Controls.Add(this.countryTagTextbox);
            this.Controls.Add(this.modDirectoryButton);
            this.Controls.Add(this.modDirectoryLabel);
            this.Controls.Add(this.modDirectoryTextbox);
            this.Controls.Add(this.advisorTypeCheckboxList);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.advisorMhcIdCheckbox);
            this.Controls.Add(this.advisorMhcIdLabel);
            this.Controls.Add(this.advisorMhcIdNumeric);
            this.Controls.Add(this.startupHighCheckbox);
            this.Controls.Add(this.advisorGfxIdCheckbox);
            this.Controls.Add(this.advisorGfxIdLabel);
            this.Controls.Add(this.advisorGfxIdTextbox);
            this.Controls.Add(this.advisorNameLabel);
            this.Controls.Add(this.advisorNameTextbox);
            this.Controls.Add(this.advisorAddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "MHC Advisor Editor";
            ((System.ComponentModel.ISupportInitialize)(this.advisorMhcIdNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startupTraitNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button advisorAddButton;
        private System.Windows.Forms.TextBox advisorNameTextbox;
        private System.Windows.Forms.Label advisorNameLabel;
        private System.Windows.Forms.TextBox advisorGfxIdTextbox;
        private System.Windows.Forms.Label advisorGfxIdLabel;
        private System.Windows.Forms.CheckBox advisorGfxIdCheckbox;
        private System.Windows.Forms.CheckBox startupHighCheckbox;
        private System.Windows.Forms.NumericUpDown advisorMhcIdNumeric;
        private System.Windows.Forms.Label advisorMhcIdLabel;
        private System.Windows.Forms.CheckBox advisorMhcIdCheckbox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.CheckedListBox advisorTypeCheckboxList;
        private System.Windows.Forms.Label modDirectoryLabel;
        private System.Windows.Forms.TextBox modDirectoryTextbox;
        private System.Windows.Forms.Button modDirectoryButton;
        private System.Windows.Forms.Label countryTagLabel;
        private System.Windows.Forms.TextBox countryTagTextbox;
        private System.Windows.Forms.TextBox advisorLocKeyTextbox;
        private System.Windows.Forms.Label advisorLocKeyLabel;
        private System.Windows.Forms.Button advisorLocKeyButton;
        private System.Windows.Forms.RichTextBox logTextbox;
        private System.Windows.Forms.Label advisorTraitLabel;
        private System.Windows.Forms.NumericUpDown startupTraitNumeric;
        private System.Windows.Forms.Button startupButton;
        private System.Windows.Forms.CheckedListBox startupBookmarkCheckboxList;
    }
}