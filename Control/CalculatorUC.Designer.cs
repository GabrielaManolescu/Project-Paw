
namespace Control
{
    partial class CalculatorUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEgal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRezultatScadere = new System.Windows.Forms.TextBox();
            this.tbNumar2 = new System.Windows.Forms.TextBox();
            this.tbNumar1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEgal
            // 
            this.btnEgal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEgal.Location = new System.Drawing.Point(41, 116);
            this.btnEgal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(41, 38);
            this.btnEgal.TabIndex = 15;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = false;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "-";
            // 
            // tbRezultatScadere
            // 
            this.tbRezultatScadere.Location = new System.Drawing.Point(6, 164);
            this.tbRezultatScadere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRezultatScadere.Name = "tbRezultatScadere";
            this.tbRezultatScadere.ReadOnly = true;
            this.tbRezultatScadere.Size = new System.Drawing.Size(111, 26);
            this.tbRezultatScadere.TabIndex = 13;
            // 
            // tbNumar2
            // 
            this.tbNumar2.Location = new System.Drawing.Point(4, 80);
            this.tbNumar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumar2.Name = "tbNumar2";
            this.tbNumar2.Size = new System.Drawing.Size(111, 26);
            this.tbNumar2.TabIndex = 12;
            // 
            // tbNumar1
            // 
            this.tbNumar1.Location = new System.Drawing.Point(6, 9);
            this.tbNumar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumar1.Name = "tbNumar1";
            this.tbNumar1.Size = new System.Drawing.Size(111, 26);
            this.tbNumar1.TabIndex = 11;
            // 
            // CalculatorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Control.Properties.Resources.istockphoto_1047234038_612x612;
            this.Controls.Add(this.btnEgal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRezultatScadere);
            this.Controls.Add(this.tbNumar2);
            this.Controls.Add(this.tbNumar1);
            this.Name = "CalculatorUC";
            this.Size = new System.Drawing.Size(123, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRezultatScadere;
        private System.Windows.Forms.TextBox tbNumar2;
        private System.Windows.Forms.TextBox tbNumar1;
    }
}
