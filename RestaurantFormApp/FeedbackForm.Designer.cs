
namespace RestaurantFormApp
{
    partial class FeedbackForm
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
            this.ListFeedback = new System.Windows.Forms.DataGridView();
            this.LbFeedback = new System.Windows.Forms.Label();
            this.LbFeedbackFrom = new System.Windows.Forms.Label();
            this.TxtFeedbackFrom = new System.Windows.Forms.TextBox();
            this.LbFeedbackMessage = new System.Windows.Forms.Label();
            this.TxtFeedbackMessage = new System.Windows.Forms.RichTextBox();
            this.RdFeedback1Star = new System.Windows.Forms.RadioButton();
            this.RdFeedback2Stars = new System.Windows.Forms.RadioButton();
            this.RdFeedback3Stars = new System.Windows.Forms.RadioButton();
            this.RdFeedback4Stars = new System.Windows.Forms.RadioButton();
            this.RdFeedback5Stars = new System.Windows.Forms.RadioButton();
            this.BtnFeedbackSubmit = new System.Windows.Forms.Button();
            this.LbFeedbackDate = new System.Windows.Forms.Label();
            this.DtFeedbackDate = new System.Windows.Forms.DateTimePicker();
            this.BtnExportFeedbacks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // ListFeedback
            // 
            this.ListFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFeedback.Location = new System.Drawing.Point(12, 288);
            this.ListFeedback.Name = "ListFeedback";
            this.ListFeedback.Size = new System.Drawing.Size(372, 150);
            this.ListFeedback.TabIndex = 0;
            // 
            // LbFeedback
            // 
            this.LbFeedback.AutoSize = true;
            this.LbFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFeedback.Location = new System.Drawing.Point(12, 9);
            this.LbFeedback.Name = "LbFeedback";
            this.LbFeedback.Size = new System.Drawing.Size(158, 26);
            this.LbFeedback.TabIndex = 1;
            this.LbFeedback.Text = "Give Feedback";
            // 
            // LbFeedbackFrom
            // 
            this.LbFeedbackFrom.AutoSize = true;
            this.LbFeedbackFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFeedbackFrom.Location = new System.Drawing.Point(14, 80);
            this.LbFeedbackFrom.Name = "LbFeedbackFrom";
            this.LbFeedbackFrom.Size = new System.Drawing.Size(44, 17);
            this.LbFeedbackFrom.TabIndex = 2;
            this.LbFeedbackFrom.Text = "From:";
            // 
            // TxtFeedbackFrom
            // 
            this.TxtFeedbackFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFeedbackFrom.Location = new System.Drawing.Point(85, 80);
            this.TxtFeedbackFrom.Name = "TxtFeedbackFrom";
            this.TxtFeedbackFrom.Size = new System.Drawing.Size(299, 23);
            this.TxtFeedbackFrom.TabIndex = 3;
            // 
            // LbFeedbackMessage
            // 
            this.LbFeedbackMessage.AutoSize = true;
            this.LbFeedbackMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFeedbackMessage.Location = new System.Drawing.Point(14, 126);
            this.LbFeedbackMessage.Name = "LbFeedbackMessage";
            this.LbFeedbackMessage.Size = new System.Drawing.Size(69, 17);
            this.LbFeedbackMessage.TabIndex = 2;
            this.LbFeedbackMessage.Text = "Message:";
            // 
            // TxtFeedbackMessage
            // 
            this.TxtFeedbackMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFeedbackMessage.Location = new System.Drawing.Point(85, 126);
            this.TxtFeedbackMessage.Name = "TxtFeedbackMessage";
            this.TxtFeedbackMessage.Size = new System.Drawing.Size(299, 96);
            this.TxtFeedbackMessage.TabIndex = 4;
            this.TxtFeedbackMessage.Text = "";
            // 
            // RdFeedback1Star
            // 
            this.RdFeedback1Star.AutoSize = true;
            this.RdFeedback1Star.Location = new System.Drawing.Point(107, 228);
            this.RdFeedback1Star.Name = "RdFeedback1Star";
            this.RdFeedback1Star.Size = new System.Drawing.Size(31, 17);
            this.RdFeedback1Star.TabIndex = 5;
            this.RdFeedback1Star.TabStop = true;
            this.RdFeedback1Star.Text = "1";
            this.RdFeedback1Star.UseVisualStyleBackColor = true;
            // 
            // RdFeedback2Stars
            // 
            this.RdFeedback2Stars.AutoSize = true;
            this.RdFeedback2Stars.Location = new System.Drawing.Point(144, 228);
            this.RdFeedback2Stars.Name = "RdFeedback2Stars";
            this.RdFeedback2Stars.Size = new System.Drawing.Size(31, 17);
            this.RdFeedback2Stars.TabIndex = 6;
            this.RdFeedback2Stars.TabStop = true;
            this.RdFeedback2Stars.Text = "2";
            this.RdFeedback2Stars.UseVisualStyleBackColor = true;
            // 
            // RdFeedback3Stars
            // 
            this.RdFeedback3Stars.AutoSize = true;
            this.RdFeedback3Stars.Location = new System.Drawing.Point(181, 228);
            this.RdFeedback3Stars.Name = "RdFeedback3Stars";
            this.RdFeedback3Stars.Size = new System.Drawing.Size(31, 17);
            this.RdFeedback3Stars.TabIndex = 7;
            this.RdFeedback3Stars.TabStop = true;
            this.RdFeedback3Stars.Text = "3";
            this.RdFeedback3Stars.UseVisualStyleBackColor = true;
            // 
            // RdFeedback4Stars
            // 
            this.RdFeedback4Stars.AutoSize = true;
            this.RdFeedback4Stars.Location = new System.Drawing.Point(218, 228);
            this.RdFeedback4Stars.Name = "RdFeedback4Stars";
            this.RdFeedback4Stars.Size = new System.Drawing.Size(31, 17);
            this.RdFeedback4Stars.TabIndex = 8;
            this.RdFeedback4Stars.TabStop = true;
            this.RdFeedback4Stars.Text = "4";
            this.RdFeedback4Stars.UseVisualStyleBackColor = true;
            // 
            // RdFeedback5Stars
            // 
            this.RdFeedback5Stars.AutoSize = true;
            this.RdFeedback5Stars.Location = new System.Drawing.Point(255, 228);
            this.RdFeedback5Stars.Name = "RdFeedback5Stars";
            this.RdFeedback5Stars.Size = new System.Drawing.Size(31, 17);
            this.RdFeedback5Stars.TabIndex = 9;
            this.RdFeedback5Stars.TabStop = true;
            this.RdFeedback5Stars.Text = "5";
            this.RdFeedback5Stars.UseVisualStyleBackColor = true;
            // 
            // BtnFeedbackSubmit
            // 
            this.BtnFeedbackSubmit.Location = new System.Drawing.Point(309, 247);
            this.BtnFeedbackSubmit.Name = "BtnFeedbackSubmit";
            this.BtnFeedbackSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnFeedbackSubmit.TabIndex = 10;
            this.BtnFeedbackSubmit.Text = "Submit";
            this.BtnFeedbackSubmit.UseVisualStyleBackColor = true;
            this.BtnFeedbackSubmit.Click += new System.EventHandler(this.BtnFeedbackSubmit_Click);
            // 
            // LbFeedbackDate
            // 
            this.LbFeedbackDate.AutoSize = true;
            this.LbFeedbackDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFeedbackDate.Location = new System.Drawing.Point(14, 44);
            this.LbFeedbackDate.Name = "LbFeedbackDate";
            this.LbFeedbackDate.Size = new System.Drawing.Size(42, 17);
            this.LbFeedbackDate.TabIndex = 2;
            this.LbFeedbackDate.Text = "Date:";
            // 
            // DtFeedbackDate
            // 
            this.DtFeedbackDate.Location = new System.Drawing.Point(85, 44);
            this.DtFeedbackDate.Name = "DtFeedbackDate";
            this.DtFeedbackDate.Size = new System.Drawing.Size(299, 20);
            this.DtFeedbackDate.TabIndex = 11;
            // 
            // BtnExportFeedbacks
            // 
            this.BtnExportFeedbacks.Location = new System.Drawing.Point(17, 247);
            this.BtnExportFeedbacks.Name = "BtnExportFeedbacks";
            this.BtnExportFeedbacks.Size = new System.Drawing.Size(121, 23);
            this.BtnExportFeedbacks.TabIndex = 10;
            this.BtnExportFeedbacks.Text = "Export Feedbacks";
            this.BtnExportFeedbacks.UseVisualStyleBackColor = true;
            this.BtnExportFeedbacks.Click += new System.EventHandler(this.BtnExportFeedbacks_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.DtFeedbackDate);
            this.Controls.Add(this.BtnExportFeedbacks);
            this.Controls.Add(this.BtnFeedbackSubmit);
            this.Controls.Add(this.RdFeedback5Stars);
            this.Controls.Add(this.RdFeedback4Stars);
            this.Controls.Add(this.RdFeedback3Stars);
            this.Controls.Add(this.RdFeedback2Stars);
            this.Controls.Add(this.RdFeedback1Star);
            this.Controls.Add(this.TxtFeedbackMessage);
            this.Controls.Add(this.TxtFeedbackFrom);
            this.Controls.Add(this.LbFeedbackMessage);
            this.Controls.Add(this.LbFeedbackDate);
            this.Controls.Add(this.LbFeedbackFrom);
            this.Controls.Add(this.LbFeedback);
            this.Controls.Add(this.ListFeedback);
            this.Name = "FeedbackForm";
            this.Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.ListFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListFeedback;
        private System.Windows.Forms.Label LbFeedback;
        private System.Windows.Forms.Label LbFeedbackFrom;
        private System.Windows.Forms.TextBox TxtFeedbackFrom;
        private System.Windows.Forms.Label LbFeedbackMessage;
        private System.Windows.Forms.RichTextBox TxtFeedbackMessage;
        private System.Windows.Forms.RadioButton RdFeedback1Star;
        private System.Windows.Forms.RadioButton RdFeedback2Stars;
        private System.Windows.Forms.RadioButton RdFeedback3Stars;
        private System.Windows.Forms.RadioButton RdFeedback4Stars;
        private System.Windows.Forms.RadioButton RdFeedback5Stars;
        private System.Windows.Forms.Button BtnFeedbackSubmit;
        private System.Windows.Forms.Label LbFeedbackDate;
        private System.Windows.Forms.DateTimePicker DtFeedbackDate;
        private System.Windows.Forms.Button BtnExportFeedbacks;
    }
}