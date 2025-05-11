namespace Lab5._1
{
    partial class fBicycle
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbFrameLoadCapacity = new System.Windows.Forms.TextBox();
            this.tbColour = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbWasDamaged = new System.Windows.Forms.CheckBox();
            this.chbWasUsed = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(495, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(259, 69);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 22);
            this.tbYear.TabIndex = 11;
            // 
            // tbFrameLoadCapacity
            // 
            this.tbFrameLoadCapacity.Location = new System.Drawing.Point(259, 113);
            this.tbFrameLoadCapacity.Name = "tbFrameLoadCapacity";
            this.tbFrameLoadCapacity.Size = new System.Drawing.Size(100, 22);
            this.tbFrameLoadCapacity.TabIndex = 12;
            // 
            // tbColour
            // 
            this.tbColour.Location = new System.Drawing.Point(261, 148);
            this.tbColour.Name = "tbColour";
            this.tbColour.Size = new System.Drawing.Size(100, 22);
            this.tbColour.TabIndex = 9;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(261, 187);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 8;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(259, 225);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 22);
            this.tbWeight.TabIndex = 7;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(261, 31);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 22);
            this.tbModel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вага велосипеда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ціна";
            // 
            // chbWasDamaged
            // 
            this.chbWasDamaged.AutoSize = true;
            this.chbWasDamaged.Location = new System.Drawing.Point(26, 77);
            this.chbWasDamaged.Name = "chbWasDamaged";
            this.chbWasDamaged.Size = new System.Drawing.Size(193, 20);
            this.chbWasDamaged.TabIndex = 1;
            this.chbWasDamaged.Text = "Велосипед пошкоджений";
            this.chbWasDamaged.UseVisualStyleBackColor = true;
            // 
            // chbWasUsed
            // 
            this.chbWasUsed.AutoSize = true;
            this.chbWasUsed.Location = new System.Drawing.Point(26, 34);
            this.chbWasUsed.Name = "chbWasUsed";
            this.chbWasUsed.Size = new System.Drawing.Size(172, 20);
            this.chbWasUsed.TabIndex = 0;
            this.chbWasUsed.Text = "Велосипед  вживаний";
            this.chbWasUsed.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbWasDamaged);
            this.groupBox2.Controls.Add(this.chbWasUsed);
            this.groupBox2.Location = new System.Drawing.Point(38, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 153);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Користування транспортом";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Колір";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимальне навантаження рами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рік виготовлення";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(495, 50);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(127, 32);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель велосипеда";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbFrameLoadCapacity);
            this.groupBox1.Controls.Add(this.tbColour);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbWeight);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 316);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // fBicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 546);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "fBicycle";
            this.Text = "fBicycle";
            this.Load += new System.EventHandler(this.fBicycle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbFrameLoadCapacity;
        private System.Windows.Forms.TextBox tbColour;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbWasDamaged;
        private System.Windows.Forms.CheckBox chbWasUsed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}