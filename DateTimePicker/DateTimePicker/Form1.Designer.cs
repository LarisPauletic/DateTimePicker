namespace DateTimePicker
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
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.Vrijeme = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(253, 12);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(200, 22);
            this.Datum.TabIndex = 0;
            // 
            // Vrijeme
            // 
            this.Vrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Vrijeme.Location = new System.Drawing.Point(253, 72);
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ShowUpDown = true;
            this.Vrijeme.Size = new System.Drawing.Size(200, 22);
            this.Vrijeme.TabIndex = 1;
            this.Vrijeme.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(64, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(592, 214);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnRez
            // 
            this.btnRez.Location = new System.Drawing.Point(64, 359);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(131, 61);
            this.btnRez.TabIndex = 3;
            this.btnRez.Text = "Rezervacija";
            this.btnRez.UseVisualStyleBackColor = true;
            this.btnRez.Click += new System.EventHandler(this.btnRez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upisi datum leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Upisite vrijeme polaska:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRez);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Vrijeme);
            this.Controls.Add(this.Datum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.DateTimePicker Vrijeme;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

