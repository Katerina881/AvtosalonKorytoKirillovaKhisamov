namespace KorytoView
{
    partial class FormCarDetail
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
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxDetails = new System.Windows.Forms.ComboBox();
            this.label_DFC_AMOUNT = new System.Windows.Forms.Label();
            this.label_DFC_DNAME = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(92, 55);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(232, 20);
            this.textBoxAmount.TabIndex = 17;
            // 
            // comboBoxDetails
            // 
            this.comboBoxDetails.FormattingEnabled = true;
            this.comboBoxDetails.Location = new System.Drawing.Point(92, 6);
            this.comboBoxDetails.Name = "comboBoxDetails";
            this.comboBoxDetails.Size = new System.Drawing.Size(232, 21);
            this.comboBoxDetails.TabIndex = 16;
            // 
            // label_DFC_AMOUNT
            // 
            this.label_DFC_AMOUNT.AutoSize = true;
            this.label_DFC_AMOUNT.Location = new System.Drawing.Point(14, 58);
            this.label_DFC_AMOUNT.Name = "label_DFC_AMOUNT";
            this.label_DFC_AMOUNT.Size = new System.Drawing.Size(66, 13);
            this.label_DFC_AMOUNT.TabIndex = 19;
            this.label_DFC_AMOUNT.Text = "Количество";
            // 
            // label_DFC_DNAME
            // 
            this.label_DFC_DNAME.AutoSize = true;
            this.label_DFC_DNAME.Location = new System.Drawing.Point(12, 9);
            this.label_DFC_DNAME.Name = "label_DFC_DNAME";
            this.label_DFC_DNAME.Size = new System.Drawing.Size(57, 13);
            this.label_DFC_DNAME.TabIndex = 18;
            this.label_DFC_DNAME.Text = "Название";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(171, 81);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 32);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(33, 81);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 32);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormCarDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 127);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label_DFC_AMOUNT);
            this.Controls.Add(this.label_DFC_DNAME);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.comboBoxDetails);
            this.Name = "FormCarDetail";
            this.Text = "FormCarDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxDetails;
        private System.Windows.Forms.Label label_DFC_AMOUNT;
        private System.Windows.Forms.Label label_DFC_DNAME;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}