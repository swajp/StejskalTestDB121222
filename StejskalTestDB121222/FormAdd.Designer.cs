namespace StejskalTestDB121222
{
    partial class FormAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsertData = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.inputFirstname = new System.Windows.Forms.TextBox();
            this.inputLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputBirtday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // buttonInsertData
            // 
            this.buttonInsertData.Location = new System.Drawing.Point(218, 202);
            this.buttonInsertData.Name = "buttonInsertData";
            this.buttonInsertData.Size = new System.Drawing.Size(83, 32);
            this.buttonInsertData.TabIndex = 1;
            this.buttonInsertData.Text = "Vložit";
            this.buttonInsertData.UseVisualStyleBackColor = true;
            this.buttonInsertData.Click += new System.EventHandler(this.buttonInsertData_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(129, 202);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(83, 32);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Zavřít";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // inputFirstname
            // 
            this.inputFirstname.Location = new System.Drawing.Point(15, 48);
            this.inputFirstname.Name = "inputFirstname";
            this.inputFirstname.Size = new System.Drawing.Size(100, 20);
            this.inputFirstname.TabIndex = 3;
            // 
            // inputLastname
            // 
            this.inputLastname.Location = new System.Drawing.Point(129, 48);
            this.inputLastname.Name = "inputLastname";
            this.inputLastname.Size = new System.Drawing.Size(100, 20);
            this.inputLastname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lastname:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(15, 93);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(100, 20);
            this.inputEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(129, 93);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(100, 20);
            this.inputPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday";
            // 
            // inputBirtday
            // 
            this.inputBirtday.Location = new System.Drawing.Point(15, 140);
            this.inputBirtday.Name = "inputBirtday";
            this.inputBirtday.Size = new System.Drawing.Size(214, 20);
            this.inputBirtday.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Insert new data";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 251);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputBirtday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputFirstname);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInsertData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsertData;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox inputFirstname;
        private System.Windows.Forms.TextBox inputLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inputBirtday;
        private System.Windows.Forms.Label label6;
    }
}