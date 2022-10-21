
namespace clean_adesk_collab_locs
{
    partial class inputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRevit = new System.Windows.Forms.Button();
            this.buttonP3d = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBox_2020 = new System.Windows.Forms.CheckBox();
            this.checkBox_2021 = new System.Windows.Forms.CheckBox();
            this.checkBox_2022 = new System.Windows.Forms.CheckBox();
            this.checkBox_2023 = new System.Windows.Forms.CheckBox();
            this.checkBoxCefCache = new System.Windows.Forms.CheckBox();
            this.checkBoxCollabCache = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Clear Revit Collaboration Cache?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(71, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(317, 32);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Clear Plant 3D Collaboration Cache?";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonRevit
            // 
            this.buttonRevit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRevit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevit.Location = new System.Drawing.Point(174, 165);
            this.buttonRevit.Name = "buttonRevit";
            this.buttonRevit.Size = new System.Drawing.Size(97, 38);
            this.buttonRevit.TabIndex = 2;
            this.buttonRevit.Text = "Clear";
            this.buttonRevit.UseVisualStyleBackColor = false;
            this.buttonRevit.Click += new System.EventHandler(this.buttonRevit_Click);
            // 
            // buttonP3d
            // 
            this.buttonP3d.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonP3d.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP3d.Location = new System.Drawing.Point(174, 292);
            this.buttonP3d.Name = "buttonP3d";
            this.buttonP3d.Size = new System.Drawing.Size(97, 38);
            this.buttonP3d.TabIndex = 3;
            this.buttonP3d.Text = "Clear";
            this.buttonP3d.UseVisualStyleBackColor = false;
            this.buttonP3d.Click += new System.EventHandler(this.buttonP3d_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(340, 360);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(97, 38);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBox_2020
            // 
            this.checkBox_2020.AutoSize = true;
            this.checkBox_2020.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_2020.Location = new System.Drawing.Point(157, 102);
            this.checkBox_2020.Name = "checkBox_2020";
            this.checkBox_2020.Size = new System.Drawing.Size(56, 24);
            this.checkBox_2020.TabIndex = 5;
            this.checkBox_2020.Text = "2020";
            this.checkBox_2020.UseVisualStyleBackColor = true;
            this.checkBox_2020.CheckedChanged += new System.EventHandler(this.checkBox_2020_CheckedChanged);
            // 
            // checkBox_2021
            // 
            this.checkBox_2021.AutoSize = true;
            this.checkBox_2021.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_2021.Location = new System.Drawing.Point(157, 128);
            this.checkBox_2021.Name = "checkBox_2021";
            this.checkBox_2021.Size = new System.Drawing.Size(56, 24);
            this.checkBox_2021.TabIndex = 6;
            this.checkBox_2021.Text = "2021";
            this.checkBox_2021.UseVisualStyleBackColor = true;
            this.checkBox_2021.CheckedChanged += new System.EventHandler(this.checkBox_2021_CheckedChanged);
            // 
            // checkBox_2022
            // 
            this.checkBox_2022.AutoSize = true;
            this.checkBox_2022.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_2022.Location = new System.Drawing.Point(268, 102);
            this.checkBox_2022.Name = "checkBox_2022";
            this.checkBox_2022.Size = new System.Drawing.Size(56, 24);
            this.checkBox_2022.TabIndex = 7;
            this.checkBox_2022.Text = "2022";
            this.checkBox_2022.UseVisualStyleBackColor = true;
            this.checkBox_2022.CheckedChanged += new System.EventHandler(this.checkBox_2022_CheckedChanged);
            // 
            // checkBox_2023
            // 
            this.checkBox_2023.AutoSize = true;
            this.checkBox_2023.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_2023.Location = new System.Drawing.Point(268, 128);
            this.checkBox_2023.Name = "checkBox_2023";
            this.checkBox_2023.Size = new System.Drawing.Size(56, 24);
            this.checkBox_2023.TabIndex = 8;
            this.checkBox_2023.Text = "2023";
            this.checkBox_2023.UseVisualStyleBackColor = true;
            this.checkBox_2023.CheckedChanged += new System.EventHandler(this.checkBox_2023_CheckedChanged);
            // 
            // checkBoxCefCache
            // 
            this.checkBoxCefCache.AutoSize = true;
            this.checkBoxCefCache.Checked = true;
            this.checkBoxCefCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCefCache.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCefCache.Location = new System.Drawing.Point(110, 68);
            this.checkBoxCefCache.Name = "checkBoxCefCache";
            this.checkBoxCefCache.Size = new System.Drawing.Size(84, 24);
            this.checkBoxCefCache.TabIndex = 9;
            this.checkBoxCefCache.Text = "CefCache";
            this.checkBoxCefCache.UseVisualStyleBackColor = true;
            this.checkBoxCefCache.CheckedChanged += new System.EventHandler(this.checkBoxCefCache_CheckedChanged);
            // 
            // checkBoxCollabCache
            // 
            this.checkBoxCollabCache.AutoSize = true;
            this.checkBoxCollabCache.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCollabCache.Location = new System.Drawing.Point(231, 68);
            this.checkBoxCollabCache.Name = "checkBoxCollabCache";
            this.checkBoxCollabCache.Size = new System.Drawing.Size(142, 24);
            this.checkBoxCollabCache.TabIndex = 10;
            this.checkBoxCollabCache.Text = "Collaboration Cache";
            this.checkBoxCollabCache.UseVisualStyleBackColor = true;
            this.checkBoxCollabCache.CheckedChanged += new System.EventHandler(this.checkBoxCollabCache_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(9, 348);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(237, 55);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Note: If experiencing errors with a Revit file try clearing only the CefCache. If" +
    " errors persist, Clear the Collaboration Cache.";
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(467, 410);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBoxCollabCache);
            this.Controls.Add(this.checkBoxCefCache);
            this.Controls.Add(this.checkBox_2023);
            this.Controls.Add(this.checkBox_2022);
            this.Controls.Add(this.checkBox_2021);
            this.Controls.Add(this.checkBox_2020);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonP3d);
            this.Controls.Add(this.buttonRevit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "inputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clear Autodesk Collaboration Cache Locations";
            this.Load += new System.EventHandler(this.inputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonRevit;
        private System.Windows.Forms.Button buttonP3d;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBox_2020;
        private System.Windows.Forms.CheckBox checkBox_2021;
        private System.Windows.Forms.CheckBox checkBox_2022;
        private System.Windows.Forms.CheckBox checkBox_2023;
        private System.Windows.Forms.CheckBox checkBoxCefCache;
        private System.Windows.Forms.CheckBox checkBoxCollabCache;
        private System.Windows.Forms.TextBox textBox3;
    }
}

