
namespace ProiectPAW_ManolescuGabrielaVeronica
{
    partial class FormEditareActivitate
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
            this.cbDomeniiDeActivitate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataActivitati = new System.Windows.Forms.DateTimePicker();
            this.tbParticipantActivitate = new System.Windows.Forms.TextBox();
            this.tbNumeActivitate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvareActivitate = new System.Windows.Forms.Button();
            this.btnAnulareActivitate = new System.Windows.Forms.Button();
            this.cbNumeProiect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDomeniiDeActivitate
            // 
            this.cbDomeniiDeActivitate.FormattingEnabled = true;
            this.cbDomeniiDeActivitate.Items.AddRange(new object[] {
            "Contabilitate",
            "Management",
            "IT",
            "Marketing"});
            this.cbDomeniiDeActivitate.Location = new System.Drawing.Point(620, 109);
            this.cbDomeniiDeActivitate.Name = "cbDomeniiDeActivitate";
            this.cbDomeniiDeActivitate.Size = new System.Drawing.Size(160, 28);
            this.cbDomeniiDeActivitate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(423, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Domeniu Activitate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(423, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data:";
            // 
            // dtpDataActivitati
            // 
            this.dtpDataActivitati.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataActivitati.Location = new System.Drawing.Point(620, 53);
            this.dtpDataActivitati.Name = "dtpDataActivitati";
            this.dtpDataActivitati.Size = new System.Drawing.Size(160, 26);
            this.dtpDataActivitati.TabIndex = 12;
            // 
            // tbParticipantActivitate
            // 
            this.tbParticipantActivitate.Location = new System.Drawing.Point(243, 126);
            this.tbParticipantActivitate.Name = "tbParticipantActivitate";
            this.tbParticipantActivitate.Size = new System.Drawing.Size(121, 26);
            this.tbParticipantActivitate.TabIndex = 11;
            // 
            // tbNumeActivitate
            // 
            this.tbNumeActivitate.Location = new System.Drawing.Point(243, 65);
            this.tbNumeActivitate.Name = "tbNumeActivitate";
            this.tbNumeActivitate.Size = new System.Drawing.Size(121, 26);
            this.tbNumeActivitate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Participant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume Activitate:";
            // 
            // btnSalvareActivitate
            // 
            this.btnSalvareActivitate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvareActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvareActivitate.Location = new System.Drawing.Point(114, 286);
            this.btnSalvareActivitate.Name = "btnSalvareActivitate";
            this.btnSalvareActivitate.Size = new System.Drawing.Size(220, 35);
            this.btnSalvareActivitate.TabIndex = 16;
            this.btnSalvareActivitate.Text = "Salvare";
            this.btnSalvareActivitate.UseVisualStyleBackColor = true;
            this.btnSalvareActivitate.Click += new System.EventHandler(this.btnSalvareActivitate_Click);
            // 
            // btnAnulareActivitate
            // 
            this.btnAnulareActivitate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulareActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnulareActivitate.Location = new System.Drawing.Point(514, 286);
            this.btnAnulareActivitate.Name = "btnAnulareActivitate";
            this.btnAnulareActivitate.Size = new System.Drawing.Size(211, 35);
            this.btnAnulareActivitate.TabIndex = 17;
            this.btnAnulareActivitate.Text = "Anulare";
            this.btnAnulareActivitate.UseVisualStyleBackColor = true;
            // 
            // cbNumeProiect
            // 
            this.cbNumeProiect.FormattingEnabled = true;
            this.cbNumeProiect.Location = new System.Drawing.Point(620, 162);
            this.cbNumeProiect.Name = "cbNumeProiect";
            this.cbNumeProiect.Size = new System.Drawing.Size(160, 28);
            this.cbNumeProiect.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(423, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nume Proiect";
            // 
            // FormEditareActivitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 387);
            this.Controls.Add(this.cbNumeProiect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnulareActivitate);
            this.Controls.Add(this.btnSalvareActivitate);
            this.Controls.Add(this.cbDomeniiDeActivitate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataActivitati);
            this.Controls.Add(this.tbParticipantActivitate);
            this.Controls.Add(this.tbNumeActivitate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditareActivitate";
            this.Text = "Editare Activitate";
            this.Load += new System.EventHandler(this.FormEditareActivitate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDomeniiDeActivitate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataActivitati;
        private System.Windows.Forms.TextBox tbParticipantActivitate;
        private System.Windows.Forms.TextBox tbNumeActivitate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvareActivitate;
        private System.Windows.Forms.Button btnAnulareActivitate;
        private System.Windows.Forms.ComboBox cbNumeProiect;
        private System.Windows.Forms.Label label5;
    }
}