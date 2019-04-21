namespace Dierenpark
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
            this.components = new System.ComponentModel.Container();
            this.AmountChildren = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.Tweede = new System.Windows.Forms.DateTimePicker();
            this.NO = new System.Windows.Forms.Label();
            this.AddPersoon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioPersoonlijk = new System.Windows.Forms.RadioButton();
            this.Tarief = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmountChildren
            // 
            this.AmountChildren.Location = new System.Drawing.Point(108, 65);
            this.AmountChildren.Name = "AmountChildren";
            this.AmountChildren.Size = new System.Drawing.Size(105, 20);
            this.AmountChildren.TabIndex = 0;
            this.AmountChildren.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoeveel kinderen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Persoonlijk:";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(108, 91);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(105, 23);
            this.Bereken.TabIndex = 12;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Tweede
            // 
            this.Tweede.Location = new System.Drawing.Point(108, 12);
            this.Tweede.Name = "Tweede";
            this.Tweede.Size = new System.Drawing.Size(200, 20);
            this.Tweede.TabIndex = 13;
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Location = new System.Drawing.Point(50, 15);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(46, 13);
            this.NO.TabIndex = 14;
            this.NO.Text = "Persoon";
            // 
            // AddPersoon
            // 
            this.AddPersoon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPersoon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPersoon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddPersoon.Location = new System.Drawing.Point(314, 12);
            this.AddPersoon.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AddPersoon.Name = "AddPersoon";
            this.AddPersoon.Size = new System.Drawing.Size(17, 20);
            this.AddPersoon.TabIndex = 15;
            this.AddPersoon.Text = "+";
            this.AddPersoon.UseVisualStyleBackColor = true;
            this.AddPersoon.Click += new System.EventHandler(this.AddPersoon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.RadioPersoonlijk);
            this.panel1.Location = new System.Drawing.Point(108, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 21);
            this.panel1.TabIndex = 16;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(45, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Nee";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioPersoonlijk
            // 
            this.RadioPersoonlijk.AutoSize = true;
            this.RadioPersoonlijk.Location = new System.Drawing.Point(3, 4);
            this.RadioPersoonlijk.Name = "RadioPersoonlijk";
            this.RadioPersoonlijk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioPersoonlijk.Size = new System.Drawing.Size(36, 17);
            this.RadioPersoonlijk.TabIndex = 17;
            this.RadioPersoonlijk.Text = "Ja";
            this.RadioPersoonlijk.UseVisualStyleBackColor = true;
            // 
            // Tarief
            // 
            this.Tarief.Location = new System.Drawing.Point(108, 117);
            this.Tarief.Name = "Tarief";
            this.Tarief.Size = new System.Drawing.Size(100, 23);
            this.Tarief.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 141);
            this.Controls.Add(this.Tarief);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddPersoon);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.Tweede);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountChildren);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Abonnement berekenen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountChildren;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.DateTimePicker Tweede;
        private System.Windows.Forms.Label NO;
        private System.Windows.Forms.Button AddPersoon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton RadioPersoonlijk;
        private System.Windows.Forms.Label Tarief;
    }
}

