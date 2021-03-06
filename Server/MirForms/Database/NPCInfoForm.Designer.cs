﻿namespace Server
{
    partial class NPCInfoForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NPCInfoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MapComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OpenNButton = new System.Windows.Forms.Button();
            this.NFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.NRateTextBox = new System.Windows.Forms.TextBox();
            this.ClearHButton = new System.Windows.Forms.Button();
            this.NNameTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NPCIndexTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NImageTextBox = new System.Windows.Forms.TextBox();
            this.NXTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.NYTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NPCInfoListBox = new System.Windows.Forms.ListBox();
            this.PasteMButton = new System.Windows.Forms.Button();
            this.CopyMButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportSelectedButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.NPCInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(174, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 234);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NPCInfoPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NPCInfoPanel
            // 
            this.NPCInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NPCInfoPanel.Controls.Add(this.label2);
            this.NPCInfoPanel.Controls.Add(this.MapComboBox);
            this.NPCInfoPanel.Controls.Add(this.label11);
            this.NPCInfoPanel.Controls.Add(this.OpenNButton);
            this.NPCInfoPanel.Controls.Add(this.NFileNameTextBox);
            this.NPCInfoPanel.Controls.Add(this.label29);
            this.NPCInfoPanel.Controls.Add(this.NRateTextBox);
            this.NPCInfoPanel.Controls.Add(this.ClearHButton);
            this.NPCInfoPanel.Controls.Add(this.NNameTextBox);
            this.NPCInfoPanel.Controls.Add(this.label13);
            this.NPCInfoPanel.Controls.Add(this.NPCIndexTextBox);
            this.NPCInfoPanel.Controls.Add(this.label24);
            this.NPCInfoPanel.Controls.Add(this.label1);
            this.NPCInfoPanel.Controls.Add(this.NImageTextBox);
            this.NPCInfoPanel.Controls.Add(this.NXTextBox);
            this.NPCInfoPanel.Controls.Add(this.label28);
            this.NPCInfoPanel.Controls.Add(this.label30);
            this.NPCInfoPanel.Controls.Add(this.NYTextBox);
            this.NPCInfoPanel.Enabled = false;
            this.NPCInfoPanel.Location = new System.Drawing.Point(3, 6);
            this.NPCInfoPanel.Name = "NPCInfoPanel";
            this.NPCInfoPanel.Size = new System.Drawing.Size(585, 196);
            this.NPCInfoPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Map:";
            // 
            // MapComboBox
            // 
            this.MapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapComboBox.FormattingEnabled = true;
            this.MapComboBox.Location = new System.Drawing.Point(87, 84);
            this.MapComboBox.Name = "MapComboBox";
            this.MapComboBox.Size = new System.Drawing.Size(132, 21);
            this.MapComboBox.TabIndex = 31;
            this.MapComboBox.SelectedIndexChanged += new System.EventHandler(this.MapComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "File Name:";
            // 
            // OpenNButton
            // 
            this.OpenNButton.Location = new System.Drawing.Point(140, 2);
            this.OpenNButton.Name = "OpenNButton";
            this.OpenNButton.Size = new System.Drawing.Size(75, 23);
            this.OpenNButton.TabIndex = 30;
            this.OpenNButton.Text = "Open Script";
            this.OpenNButton.UseVisualStyleBackColor = true;
            this.OpenNButton.Click += new System.EventHandler(this.OpenNButton_Click);
            // 
            // NFileNameTextBox
            // 
            this.NFileNameTextBox.Location = new System.Drawing.Point(87, 32);
            this.NFileNameTextBox.MaxLength = 50;
            this.NFileNameTextBox.Name = "NFileNameTextBox";
            this.NFileNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.NFileNameTextBox.TabIndex = 22;
            this.NFileNameTextBox.TextChanged += new System.EventHandler(this.NFileNameTextBox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Cursor = System.Windows.Forms.Cursors.Default;
            this.label29.Location = new System.Drawing.Point(143, 141);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 13);
            this.label29.TabIndex = 21;
            this.label29.Text = "Rate:";
            // 
            // NRateTextBox
            // 
            this.NRateTextBox.Location = new System.Drawing.Point(182, 136);
            this.NRateTextBox.MaxLength = 3;
            this.NRateTextBox.Name = "NRateTextBox";
            this.NRateTextBox.Size = new System.Drawing.Size(37, 20);
            this.NRateTextBox.TabIndex = 20;
            this.NRateTextBox.TextChanged += new System.EventHandler(this.NRateTextBox_TextChanged);
            // 
            // ClearHButton
            // 
            this.ClearHButton.Location = new System.Drawing.Point(155, 162);
            this.ClearHButton.Name = "ClearHButton";
            this.ClearHButton.Size = new System.Drawing.Size(75, 23);
            this.ClearHButton.TabIndex = 19;
            this.ClearHButton.Text = "Clear History";
            this.ClearHButton.UseVisualStyleBackColor = true;
            // 
            // NNameTextBox
            // 
            this.NNameTextBox.Location = new System.Drawing.Point(87, 58);
            this.NNameTextBox.Name = "NNameTextBox";
            this.NNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.NNameTextBox.TabIndex = 14;
            this.NNameTextBox.TextChanged += new System.EventHandler(this.NNameTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Name:";
            // 
            // NPCIndexTextBox
            // 
            this.NPCIndexTextBox.Location = new System.Drawing.Point(87, 4);
            this.NPCIndexTextBox.Name = "NPCIndexTextBox";
            this.NPCIndexTextBox.ReadOnly = true;
            this.NPCIndexTextBox.Size = new System.Drawing.Size(47, 20);
            this.NPCIndexTextBox.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.Location = new System.Drawing.Point(42, 141);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Image:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NPC Index:";
            // 
            // NImageTextBox
            // 
            this.NImageTextBox.Location = new System.Drawing.Point(87, 137);
            this.NImageTextBox.MaxLength = 3;
            this.NImageTextBox.Name = "NImageTextBox";
            this.NImageTextBox.Size = new System.Drawing.Size(28, 20);
            this.NImageTextBox.TabIndex = 11;
            this.NImageTextBox.TextChanged += new System.EventHandler(this.NImageTextBox_TextChanged);
            // 
            // NXTextBox
            // 
            this.NXTextBox.Location = new System.Drawing.Point(87, 111);
            this.NXTextBox.MaxLength = 5;
            this.NXTextBox.Name = "NXTextBox";
            this.NXTextBox.Size = new System.Drawing.Size(37, 20);
            this.NXTextBox.TabIndex = 2;
            this.NXTextBox.TextChanged += new System.EventHandler(this.NXTextBox_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(133, 114);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "From Y:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(38, 114);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "From X:";
            // 
            // NYTextBox
            // 
            this.NYTextBox.Location = new System.Drawing.Point(182, 111);
            this.NYTextBox.MaxLength = 5;
            this.NYTextBox.Name = "NYTextBox";
            this.NYTextBox.Size = new System.Drawing.Size(37, 20);
            this.NYTextBox.TabIndex = 3;
            this.NYTextBox.TextChanged += new System.EventHandler(this.NYTextBox_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(93, 12);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NPCInfoListBox
            // 
            this.NPCInfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NPCInfoListBox.FormattingEnabled = true;
            this.NPCInfoListBox.Location = new System.Drawing.Point(12, 41);
            this.NPCInfoListBox.Name = "NPCInfoListBox";
            this.NPCInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.NPCInfoListBox.Size = new System.Drawing.Size(156, 238);
            this.NPCInfoListBox.TabIndex = 15;
            this.NPCInfoListBox.SelectedIndexChanged += new System.EventHandler(this.NPCInfoListBox_SelectedIndexChanged);
            // 
            // PasteMButton
            // 
            this.PasteMButton.Location = new System.Drawing.Point(255, 12);
            this.PasteMButton.Name = "PasteMButton";
            this.PasteMButton.Size = new System.Drawing.Size(75, 23);
            this.PasteMButton.TabIndex = 22;
            this.PasteMButton.Text = "Paste";
            this.PasteMButton.UseVisualStyleBackColor = true;
            this.PasteMButton.Click += new System.EventHandler(this.PasteMButton_Click);
            // 
            // CopyMButton
            // 
            this.CopyMButton.Location = new System.Drawing.Point(174, 12);
            this.CopyMButton.Name = "CopyMButton";
            this.CopyMButton.Size = new System.Drawing.Size(75, 23);
            this.CopyMButton.TabIndex = 21;
            this.CopyMButton.Text = "Copy";
            this.CopyMButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(701, 12);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 23;
            this.ExportButton.Text = "Export All";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportAllButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(498, 12);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 24;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportSelectedButton
            // 
            this.ExportSelectedButton.Location = new System.Drawing.Point(578, 12);
            this.ExportSelectedButton.Name = "ExportSelectedButton";
            this.ExportSelectedButton.Size = new System.Drawing.Size(117, 23);
            this.ExportSelectedButton.TabIndex = 25;
            this.ExportSelectedButton.Text = "Export Selected";
            this.ExportSelectedButton.UseVisualStyleBackColor = true;
            this.ExportSelectedButton.Click += new System.EventHandler(this.ExportSelected_Click);
            // 
            // NPCInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 287);
            this.Controls.Add(this.ExportSelectedButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.PasteMButton);
            this.Controls.Add(this.CopyMButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NPCInfoListBox);
            this.Name = "NPCInfoForm";
            this.Text = "NPCInfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NPCInfoForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.NPCInfoPanel.ResumeLayout(false);
            this.NPCInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel NPCInfoPanel;
        private System.Windows.Forms.TextBox NPCIndexTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button PasteMButton;
        private System.Windows.Forms.Button CopyMButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportSelectedButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button OpenNButton;
        private System.Windows.Forms.TextBox NFileNameTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox NRateTextBox;
        private System.Windows.Forms.Button ClearHButton;
        private System.Windows.Forms.TextBox NNameTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox NImageTextBox;
        private System.Windows.Forms.TextBox NXTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox NYTextBox;
        private System.Windows.Forms.ListBox NPCInfoListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MapComboBox;
    }
}