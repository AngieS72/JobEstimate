namespace Ch12_Lab5_JobEstimate_Revised
{
    partial class FormJobEstimate
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
            this.textBoxTripFee = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCurrentTotalFee = new System.Windows.Forms.Label();
            this.label1CurrentRate = new System.Windows.Forms.Label();
            this.labelCurrentHours = new System.Windows.Forms.Label();
            this.labelCurrentValue = new System.Windows.Forms.Label();
            this.labelServiceRequested = new System.Windows.Forms.Label();
            this.textBoxHoursToComplete = new System.Windows.Forms.TextBox();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelHoursToComplete = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelNewValue = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTripFee
            // 
            this.textBoxTripFee.Location = new System.Drawing.Point(349, 215);
            this.textBoxTripFee.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.textBoxTripFee.Name = "textBoxTripFee";
            this.textBoxTripFee.ReadOnly = true;
            this.textBoxTripFee.Size = new System.Drawing.Size(436, 26);
            this.textBoxTripFee.TabIndex = 12;
            this.textBoxTripFee.Text = "35.00";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(614, 392);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(157, 53);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(348, 392);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(157, 53);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelCurrentTotalFee
            // 
            this.labelCurrentTotalFee.Location = new System.Drawing.Point(813, 208);
            this.labelCurrentTotalFee.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCurrentTotalFee.Name = "labelCurrentTotalFee";
            this.labelCurrentTotalFee.Size = new System.Drawing.Size(422, 38);
            this.labelCurrentTotalFee.TabIndex = 6;
            // 
            // label1CurrentRate
            // 
            this.label1CurrentRate.Location = new System.Drawing.Point(813, 149);
            this.label1CurrentRate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1CurrentRate.Name = "label1CurrentRate";
            this.label1CurrentRate.Size = new System.Drawing.Size(422, 38);
            this.label1CurrentRate.TabIndex = 7;
            // 
            // labelCurrentHours
            // 
            this.labelCurrentHours.Location = new System.Drawing.Point(813, 97);
            this.labelCurrentHours.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCurrentHours.Name = "labelCurrentHours";
            this.labelCurrentHours.Size = new System.Drawing.Size(422, 38);
            this.labelCurrentHours.TabIndex = 8;
            // 
            // labelCurrentValue
            // 
            this.labelCurrentValue.AutoSize = true;
            this.labelCurrentValue.Location = new System.Drawing.Point(813, 10);
            this.labelCurrentValue.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCurrentValue.Name = "labelCurrentValue";
            this.labelCurrentValue.Size = new System.Drawing.Size(113, 19);
            this.labelCurrentValue.TabIndex = 10;
            this.labelCurrentValue.Text = "Current Value";
            // 
            // labelServiceRequested
            // 
            this.labelServiceRequested.Location = new System.Drawing.Point(813, 42);
            this.labelServiceRequested.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelServiceRequested.Name = "labelServiceRequested";
            this.labelServiceRequested.Size = new System.Drawing.Size(422, 38);
            this.labelServiceRequested.TabIndex = 9;
            // 
            // textBoxHoursToComplete
            // 
            this.textBoxHoursToComplete.Location = new System.Drawing.Point(349, 99);
            this.textBoxHoursToComplete.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.textBoxHoursToComplete.Name = "textBoxHoursToComplete";
            this.textBoxHoursToComplete.Size = new System.Drawing.Size(436, 26);
            this.textBoxHoursToComplete.TabIndex = 1;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(349, 151);
            this.textBoxHourlyRate.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(436, 26);
            this.textBoxHourlyRate.TabIndex = 2;
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFee.Location = new System.Drawing.Point(16, 218);
            this.labelTotalFee.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(273, 28);
            this.labelTotalFee.TabIndex = 13;
            this.labelTotalFee.Text = "Total Fee";
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.Location = new System.Drawing.Point(16, 159);
            this.labelHourlyRate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(273, 28);
            this.labelHourlyRate.TabIndex = 14;
            this.labelHourlyRate.Text = "Hourly Rate";
            // 
            // labelHoursToComplete
            // 
            this.labelHoursToComplete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursToComplete.Location = new System.Drawing.Point(13, 107);
            this.labelHoursToComplete.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelHoursToComplete.Name = "labelHoursToComplete";
            this.labelHoursToComplete.Size = new System.Drawing.Size(273, 28);
            this.labelHoursToComplete.TabIndex = 15;
            this.labelHoursToComplete.Text = "Hours To Complete";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(16, 53);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(218, 28);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(349, 44);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(436, 26);
            this.textBoxDescription.TabIndex = 0;
            // 
            // labelNewValue
            // 
            this.labelNewValue.AutoSize = true;
            this.labelNewValue.Location = new System.Drawing.Point(342, 12);
            this.labelNewValue.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(89, 19);
            this.labelNewValue.TabIndex = 11;
            this.labelNewValue.Text = "New Value";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(481, 278);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(157, 53);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormJobEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1262, 486);
            this.Controls.Add(this.textBoxTripFee);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelCurrentTotalFee);
            this.Controls.Add(this.label1CurrentRate);
            this.Controls.Add(this.labelCurrentHours);
            this.Controls.Add(this.labelCurrentValue);
            this.Controls.Add(this.labelServiceRequested);
            this.Controls.Add(this.textBoxHoursToComplete);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.labelTotalFee);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.labelHoursToComplete);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelNewValue);
            this.Controls.Add(this.buttonUpdate);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormJobEstimate";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormJobEstimate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTripFee;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCurrentTotalFee;
        private System.Windows.Forms.Label label1CurrentRate;
        private System.Windows.Forms.Label labelCurrentHours;
        private System.Windows.Forms.Label labelCurrentValue;
        private System.Windows.Forms.Label labelServiceRequested;
        private System.Windows.Forms.TextBox textBoxHoursToComplete;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label labelHoursToComplete;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelNewValue;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

