namespace project_selection
{
    partial class plantProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plantProjects));
            this.projectsfound = new System.Windows.Forms.ListBox();
            this.projectsdelete = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectsfound
            // 
            this.projectsfound.FormattingEnabled = true;
            this.projectsfound.HorizontalScrollbar = true;
            this.projectsfound.Location = new System.Drawing.Point(19, 48);
            this.projectsfound.Name = "projectsfound";
            this.projectsfound.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.projectsfound.Size = new System.Drawing.Size(200, 355);
            this.projectsfound.TabIndex = 0;
            this.projectsfound.SelectedIndexChanged += new System.EventHandler(this.projectsfound_SelectedIndexChanged);
            // 
            // projectsdelete
            // 
            this.projectsdelete.FormattingEnabled = true;
            this.projectsdelete.HorizontalScrollbar = true;
            this.projectsdelete.Location = new System.Drawing.Point(269, 48);
            this.projectsdelete.Name = "projectsdelete";
            this.projectsdelete.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.projectsdelete.Size = new System.Drawing.Size(189, 355);
            this.projectsdelete.TabIndex = 1;
            this.projectsdelete.SelectedIndexChanged += new System.EventHandler(this.projectsdelete_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(481, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Projects";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(481, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plant 3D Projects on PC.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plant 3D Projects to Delete.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "-->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "Select All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(17, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "Remove All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(464, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 152);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Selection";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 34);
            this.button6.TabIndex = 10;
            this.button6.Text = "<--";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // plantProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(662, 443);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectsdelete);
            this.Controls.Add(this.projectsfound);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "plantProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plant 3D Projects Found";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox projectsfound;
        private System.Windows.Forms.ListBox projectsdelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
    }
}