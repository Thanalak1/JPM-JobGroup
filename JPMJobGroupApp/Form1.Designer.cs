namespace JPMJobGroupApp
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
            this.btnFoundry = new System.Windows.Forms.Button();
            this.btnDress = new System.Windows.Forms.Button();
            this.btnPolish = new System.Windows.Forms.Button();
            this.btnBury = new System.Windows.Forms.Button();
            this.btnBathe = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnLee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFoundry
            // 
            this.btnFoundry.Location = new System.Drawing.Point(79, 82);
            this.btnFoundry.Name = "btnFoundry";
            this.btnFoundry.Size = new System.Drawing.Size(75, 23);
            this.btnFoundry.TabIndex = 0;
            this.btnFoundry.Text = "หล่อ";
            this.btnFoundry.UseVisualStyleBackColor = true;
            // 
            // btnDress
            // 
            this.btnDress.Location = new System.Drawing.Point(198, 82);
            this.btnDress.Name = "btnDress";
            this.btnDress.Size = new System.Drawing.Size(75, 23);
            this.btnDress.TabIndex = 1;
            this.btnDress.Text = "แต่ง";
            this.btnDress.UseVisualStyleBackColor = true;
            // 
            // btnPolish
            // 
            this.btnPolish.Location = new System.Drawing.Point(315, 82);
            this.btnPolish.Name = "btnPolish";
            this.btnPolish.Size = new System.Drawing.Size(75, 23);
            this.btnPolish.TabIndex = 2;
            this.btnPolish.Text = "ขัด";
            this.btnPolish.UseVisualStyleBackColor = true;
            // 
            // btnBury
            // 
            this.btnBury.Location = new System.Drawing.Point(422, 82);
            this.btnBury.Name = "btnBury";
            this.btnBury.Size = new System.Drawing.Size(75, 23);
            this.btnBury.TabIndex = 3;
            this.btnBury.Text = "ฝัง";
            this.btnBury.UseVisualStyleBackColor = true;
            // 
            // btnBathe
            // 
            this.btnBathe.Location = new System.Drawing.Point(79, 121);
            this.btnBathe.Name = "btnBathe";
            this.btnBathe.Size = new System.Drawing.Size(75, 23);
            this.btnBathe.TabIndex = 4;
            this.btnBathe.Text = "ชุบ";
            this.btnBathe.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(191, 121);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(87, 23);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "ตัวเรือนสำเร็จ";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnLee
            // 
            this.btnLee.Location = new System.Drawing.Point(315, 121);
            this.btnLee.Name = "btnLee";
            this.btnLee.Size = new System.Drawing.Size(75, 23);
            this.btnLee.TabIndex = 6;
            this.btnLee.Text = "ขึ้นแบบใหม่";
            this.btnLee.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLee);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnBathe);
            this.Controls.Add(this.btnBury);
            this.Controls.Add(this.btnPolish);
            this.Controls.Add(this.btnDress);
            this.Controls.Add(this.btnFoundry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "เมนูหลัก";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFoundry;
        private System.Windows.Forms.Button btnDress;
        private System.Windows.Forms.Button btnPolish;
        private System.Windows.Forms.Button btnBury;
        private System.Windows.Forms.Button btnBathe;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnLee;
    }
}

