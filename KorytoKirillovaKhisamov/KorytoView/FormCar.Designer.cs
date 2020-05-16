namespace KorytoView
{
    partial class FormCar
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label_CNAME = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label_Mail = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.buttonDeleteElement = new System.Windows.Forms.Button();
            this.buttonChangeElement = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.Location = new System.Drawing.Point(12, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(469, 555);
            this.dataGridView.TabIndex = 13;
            // 
            // label_CNAME
            // 
            this.label_CNAME.AutoSize = true;
            this.label_CNAME.Location = new System.Drawing.Point(503, 19);
            this.label_CNAME.Name = "label_CNAME";
            this.label_CNAME.Size = new System.Drawing.Size(57, 13);
            this.label_CNAME.TabIndex = 14;
            this.label_CNAME.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(506, 44);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(274, 27);
            this.textBoxName.TabIndex = 15;
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.Location = new System.Drawing.Point(503, 89);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 16;
            this.label_Mail.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(506, 123);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(274, 27);
            this.textBoxPrice.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Год выпуска";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(506, 192);
            this.textBoxYear.Multiline = true;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(274, 27);
            this.textBoxYear.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Детали :";
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Location = new System.Drawing.Point(506, 268);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(184, 41);
            this.buttonAddElement.TabIndex = 26;
            this.buttonAddElement.Text = "Добавить";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // buttonDeleteElement
            // 
            this.buttonDeleteElement.Location = new System.Drawing.Point(506, 315);
            this.buttonDeleteElement.Name = "buttonDeleteElement";
            this.buttonDeleteElement.Size = new System.Drawing.Size(184, 41);
            this.buttonDeleteElement.TabIndex = 27;
            this.buttonDeleteElement.Text = "Удалить";
            this.buttonDeleteElement.UseVisualStyleBackColor = true;
            this.buttonDeleteElement.Click += new System.EventHandler(this.buttonDeleteElement_Click);
            // 
            // buttonChangeElement
            // 
            this.buttonChangeElement.Location = new System.Drawing.Point(506, 362);
            this.buttonChangeElement.Name = "buttonChangeElement";
            this.buttonChangeElement.Size = new System.Drawing.Size(184, 41);
            this.buttonChangeElement.TabIndex = 28;
            this.buttonChangeElement.Text = "Изменить";
            this.buttonChangeElement.UseVisualStyleBackColor = true;
            this.buttonChangeElement.Click += new System.EventHandler(this.buttonChangeElement_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(506, 409);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(184, 41);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(506, 542);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 32);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(656, 542);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 32);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonChangeElement);
            this.Controls.Add(this.buttonDeleteElement);
            this.Controls.Add(this.buttonAddElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label_Mail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label_CNAME);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormCar";
            this.Text = "FormCar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_CNAME;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.Button buttonDeleteElement;
        private System.Windows.Forms.Button buttonChangeElement;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}