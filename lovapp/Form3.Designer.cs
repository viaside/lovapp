namespace lovapp_with_DB
{
    partial class Form3
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
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.newAge = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.Man_gender = new System.Windows.Forms.CheckBox();
            this.woman_gender = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Purple;
            this.exit.ForeColor = System.Drawing.Color.Fuchsia;
            this.exit.Location = new System.Drawing.Point(713, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(315, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(315, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Age";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(315, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your Gender";
            // 
            // newName
            // 
            this.newName.ForeColor = System.Drawing.Color.Fuchsia;
            this.newName.Location = new System.Drawing.Point(387, 200);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(100, 23);
            this.newName.TabIndex = 10;
            this.newName.TextChanged += new System.EventHandler(this.newName_TextChanged);
            // 
            // newAge
            // 
            this.newAge.ForeColor = System.Drawing.Color.Fuchsia;
            this.newAge.Location = new System.Drawing.Point(387, 230);
            this.newAge.Name = "newAge";
            this.newAge.Size = new System.Drawing.Size(22, 23);
            this.newAge.TabIndex = 11;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Purple;
            this.create.ForeColor = System.Drawing.Color.Fuchsia;
            this.create.Location = new System.Drawing.Point(399, 286);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 12;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Man_gender
            // 
            this.Man_gender.AutoSize = true;
            this.Man_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Man_gender.Location = new System.Drawing.Point(387, 260);
            this.Man_gender.Name = "Man_gender";
            this.Man_gender.Size = new System.Drawing.Size(50, 19);
            this.Man_gender.TabIndex = 13;
            this.Man_gender.Text = "Man";
            this.Man_gender.UseVisualStyleBackColor = true;
            this.Man_gender.Click += new System.EventHandler(this.click_gender_man);
            // 
            // woman_gender
            // 
            this.woman_gender.AutoSize = true;
            this.woman_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.woman_gender.Location = new System.Drawing.Point(443, 261);
            this.woman_gender.Name = "woman_gender";
            this.woman_gender.Size = new System.Drawing.Size(68, 19);
            this.woman_gender.TabIndex = 14;
            this.woman_gender.Text = "Woman";
            this.woman_gender.UseVisualStyleBackColor = true;
            this.woman_gender.Click += new System.EventHandler(this.click_gender_woman);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(340, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 46);
            this.label4.TabIndex = 15;
            this.label4.Text = "LovApp";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.woman_gender);
            this.Controls.Add(this.Man_gender);
            this.Controls.Add(this.create);
            this.Controls.Add(this.newAge);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox newName;
        private TextBox newAge;
        private Button create;
        private CheckBox Man_gender;
        private CheckBox woman_gender;
        private Label label4;
    }
}