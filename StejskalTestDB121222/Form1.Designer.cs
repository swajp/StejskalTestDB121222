namespace StejskalTestDB121222
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonMaximum = new System.Windows.Forms.Button();
            this.buttonMinimum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(526, 387);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firstname";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lastname";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Birthday";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(544, 50);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(51, 34);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(544, 90);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(51, 32);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Add";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(544, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(51, 32);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCount.Location = new System.Drawing.Point(544, 253);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(51, 32);
            this.buttonCount.TabIndex = 4;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAverage.Location = new System.Drawing.Point(544, 291);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(51, 32);
            this.buttonAverage.TabIndex = 5;
            this.buttonAverage.Text = "Avg";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonMaximum
            // 
            this.buttonMaximum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximum.Location = new System.Drawing.Point(544, 329);
            this.buttonMaximum.Name = "buttonMaximum";
            this.buttonMaximum.Size = new System.Drawing.Size(51, 32);
            this.buttonMaximum.TabIndex = 6;
            this.buttonMaximum.Text = "Max";
            this.buttonMaximum.UseVisualStyleBackColor = true;
            this.buttonMaximum.Click += new System.EventHandler(this.buttonMaximum_Click);
            // 
            // buttonMinimum
            // 
            this.buttonMinimum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimum.Location = new System.Drawing.Point(544, 367);
            this.buttonMinimum.Name = "buttonMinimum";
            this.buttonMinimum.Size = new System.Drawing.Size(51, 32);
            this.buttonMinimum.TabIndex = 7;
            this.buttonMinimum.Text = "Min";
            this.buttonMinimum.UseVisualStyleBackColor = true;
            this.buttonMinimum.Click += new System.EventHandler(this.buttonMinimum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(605, 413);
            this.Controls.Add(this.buttonMinimum);
            this.Controls.Add(this.buttonMaximum);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonMaximum;
        private System.Windows.Forms.Button buttonMinimum;
    }
}

