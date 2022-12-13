namespace StejskalTestDB121222
{
    partial class FormEdit
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
            this.label6 = new System.Windows.Forms.Label();
            this.inputBirtday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFirstname = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonEditData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Edit existing data";
            // 
            // inputBirtday
            // 
            this.inputBirtday.Location = new System.Drawing.Point(15, 144);
            this.inputBirtday.Name = "inputBirtday";
            this.inputBirtday.Size = new System.Drawing.Size(214, 20);
            this.inputBirtday.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Birthday";
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(129, 97);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(100, 20);
            this.inputPhone.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(15, 97);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(100, 20);
            this.inputEmail.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // inputLastname
            // 
            this.inputLastname.Location = new System.Drawing.Point(129, 52);
            this.inputLastname.Name = "inputLastname";
            this.inputLastname.Size = new System.Drawing.Size(100, 20);
            this.inputLastname.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lastname:";
            // 
            // inputFirstname
            // 
            this.inputFirstname.Location = new System.Drawing.Point(15, 52);
            this.inputFirstname.Name = "inputFirstname";
            this.inputFirstname.Size = new System.Drawing.Size(100, 20);
            this.inputFirstname.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(129, 206);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(83, 32);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonEditData
            // 
            this.buttonEditData.Location = new System.Drawing.Point(218, 206);
            this.buttonEditData.Name = "buttonEditData";
            this.buttonEditData.Size = new System.Drawing.Size(83, 32);
            this.buttonEditData.TabIndex = 15;
            this.buttonEditData.Text = "Edit";
            this.buttonEditData.UseVisualStyleBackColor = true;
            this.buttonEditData.Click += new System.EventHandler(this.buttonEditData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Firstname:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(193, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(36, 13);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "ID: 12";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 251);
            this.Controls.Add(this.labelId);
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
            this.Controls.Add(this.buttonEditData);
            this.Controls.Add(this.label1);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker inputBirtday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputFirstname;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonEditData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
    }
}