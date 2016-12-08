namespace LiveSplit.StillbirthStreak {
    partial class StillbirthStreakSettings {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TableLayoutPanel Layout;
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label BackgroundColorLabel;
            this.Description = new System.Windows.Forms.TextBox();
            this.BackgroundColor = new System.Windows.Forms.Button();
            this.TextColorEnabled = new System.Windows.Forms.CheckBox();
            this.TextColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            Layout = new System.Windows.Forms.TableLayoutPanel();
            DescriptionLabel = new System.Windows.Forms.Label();
            BackgroundColorLabel = new System.Windows.Forms.Label();
            Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout
            // 
            Layout.ColumnCount = 4;
            Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            Layout.Controls.Add(DescriptionLabel, 0, 0);
            Layout.Controls.Add(this.Description, 1, 0);
            Layout.Controls.Add(BackgroundColorLabel, 0, 1);
            Layout.Controls.Add(this.BackgroundColor, 1, 1);
            Layout.Controls.Add(this.TextColorEnabled, 2, 1);
            Layout.Controls.Add(this.TextColor, 3, 1);
            Layout.Controls.Add(this.button1, 3, 0);
            Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            Layout.Location = new System.Drawing.Point(0, 0);
            Layout.Name = "Layout";
            Layout.RowCount = 3;
            Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            Layout.Size = new System.Drawing.Size(459, 57);
            Layout.TabIndex = 0;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            DescriptionLabel.Location = new System.Drawing.Point(16, 7);
            DescriptionLabel.Margin = new System.Windows.Forms.Padding(16, 7, 3, 3);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(63, 19);
            DescriptionLabel.TabIndex = 0;
            DescriptionLabel.Text = "Description:";
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(121, 3);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(124, 20);
            this.Description.TabIndex = 0;
            // 
            // BackgroundColorLabel
            // 
            BackgroundColorLabel.AutoSize = true;
            BackgroundColorLabel.Dock = System.Windows.Forms.DockStyle.Left;
            BackgroundColorLabel.Location = new System.Drawing.Point(20, 36);
            BackgroundColorLabel.Margin = new System.Windows.Forms.Padding(20, 7, 3, 3);
            BackgroundColorLabel.Name = "BackgroundColorLabel";
            BackgroundColorLabel.Size = new System.Drawing.Size(95, 19);
            BackgroundColorLabel.TabIndex = 2;
            BackgroundColorLabel.Text = "Background Color:";
            BackgroundColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackgroundColor.Location = new System.Drawing.Point(121, 32);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(23, 23);
            this.BackgroundColor.TabIndex = 2;
            this.BackgroundColor.UseVisualStyleBackColor = false;
            this.BackgroundColor.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // TextColorEnabled
            // 
            this.TextColorEnabled.AutoSize = true;
            this.TextColorEnabled.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextColorEnabled.Location = new System.Drawing.Point(251, 32);
            this.TextColorEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextColorEnabled.Name = "TextColorEnabled";
            this.TextColorEnabled.Size = new System.Drawing.Size(77, 23);
            this.TextColorEnabled.TabIndex = 3;
            this.TextColorEnabled.Text = "Text Color:";
            this.TextColorEnabled.UseVisualStyleBackColor = true;
            this.TextColorEnabled.CheckedChanged += new System.EventHandler(this.TextColorEnabledChanged);
            this.TextColorEnabled.Click += new System.EventHandler(this.TextColorEnabledChanged);
            // 
            // TextColor
            // 
            this.TextColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextColor.Enabled = false;
            this.TextColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TextColor.Location = new System.Drawing.Point(331, 32);
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(23, 23);
            this.TextColor.TabIndex = 4;
            this.TextColor.UseVisualStyleBackColor = false;
            this.TextColor.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reset Streak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StreakReset);
            // 
            // StillbirthStreakSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(Layout);
            this.Name = "StillbirthStreakSettings";
            this.Size = new System.Drawing.Size(459, 57);
            Layout.ResumeLayout(false);
            Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox TextColorEnabled;
        private System.Windows.Forms.Button BackgroundColor;
        private System.Windows.Forms.Button TextColor;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button button1;
    }
}
