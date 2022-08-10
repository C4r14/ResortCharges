namespace Carla_Pretorius_36184950_CH6ChargesInALuxuryResort
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumDaysStayed = new System.Windows.Forms.TextBox();
            this.txtResturantCharges = new System.Windows.Forms.TextBox();
            this.txtSpaTreatmentCharges = new System.Windows.Forms.TextBox();
            this.txtCarRentalCharges = new System.Windows.Forms.TextBox();
            this.txtMedicationCharges = new System.Windows.Forms.TextBox();
            this.btnCalculateTotalCharges = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. of days stayed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resturant charges (including VAT):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spa treatment charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medication and rehabilitation bill:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Charges for car rental:";
            // 
            // txtNumDaysStayed
            // 
            this.txtNumDaysStayed.Location = new System.Drawing.Point(213, 19);
            this.txtNumDaysStayed.Name = "txtNumDaysStayed";
            this.txtNumDaysStayed.Size = new System.Drawing.Size(100, 20);
            this.txtNumDaysStayed.TabIndex = 5;
            // 
            // txtResturantCharges
            // 
            this.txtResturantCharges.Location = new System.Drawing.Point(213, 52);
            this.txtResturantCharges.Name = "txtResturantCharges";
            this.txtResturantCharges.Size = new System.Drawing.Size(100, 20);
            this.txtResturantCharges.TabIndex = 6;
            // 
            // txtSpaTreatmentCharges
            // 
            this.txtSpaTreatmentCharges.Location = new System.Drawing.Point(213, 84);
            this.txtSpaTreatmentCharges.Name = "txtSpaTreatmentCharges";
            this.txtSpaTreatmentCharges.Size = new System.Drawing.Size(100, 20);
            this.txtSpaTreatmentCharges.TabIndex = 7;
            // 
            // txtCarRentalCharges
            // 
            this.txtCarRentalCharges.Location = new System.Drawing.Point(213, 116);
            this.txtCarRentalCharges.Name = "txtCarRentalCharges";
            this.txtCarRentalCharges.Size = new System.Drawing.Size(100, 20);
            this.txtCarRentalCharges.TabIndex = 8;
            // 
            // txtMedicationCharges
            // 
            this.txtMedicationCharges.Location = new System.Drawing.Point(213, 149);
            this.txtMedicationCharges.Name = "txtMedicationCharges";
            this.txtMedicationCharges.Size = new System.Drawing.Size(100, 20);
            this.txtMedicationCharges.TabIndex = 9;
            // 
            // btnCalculateTotalCharges
            // 
            this.btnCalculateTotalCharges.Location = new System.Drawing.Point(24, 193);
            this.btnCalculateTotalCharges.Name = "btnCalculateTotalCharges";
            this.btnCalculateTotalCharges.Size = new System.Drawing.Size(157, 23);
            this.btnCalculateTotalCharges.TabIndex = 10;
            this.btnCalculateTotalCharges.Text = "Calculate total charges";
            this.btnCalculateTotalCharges.UseVisualStyleBackColor = true;
            this.btnCalculateTotalCharges.Click += new System.EventHandler(this.btnCalculateTotalCharges_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(24, 238);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(289, 96);
            this.rtbOutput.TabIndex = 13;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 353);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateTotalCharges);
            this.Controls.Add(this.txtMedicationCharges);
            this.Controls.Add(this.txtCarRentalCharges);
            this.Controls.Add(this.txtSpaTreatmentCharges);
            this.Controls.Add(this.txtResturantCharges);
            this.Controls.Add(this.txtNumDaysStayed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Resort Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumDaysStayed;
        private System.Windows.Forms.TextBox txtResturantCharges;
        private System.Windows.Forms.TextBox txtSpaTreatmentCharges;
        private System.Windows.Forms.TextBox txtCarRentalCharges;
        private System.Windows.Forms.TextBox txtMedicationCharges;
        private System.Windows.Forms.Button btnCalculateTotalCharges;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

