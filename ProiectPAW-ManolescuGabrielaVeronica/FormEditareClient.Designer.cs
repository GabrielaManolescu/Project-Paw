
namespace ProiectPAW_ManolescuGabrielaVeronica
{
    partial class FormEditareClient
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
            this.btnAnulareClient = new System.Windows.Forms.Button();
            this.btnSalvareClient = new System.Windows.Forms.Button();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNrComanda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNrTelefon = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnulareClient
            // 
            this.btnAnulareClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulareClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnulareClient.Location = new System.Drawing.Point(259, 328);
            this.btnAnulareClient.Name = "btnAnulareClient";
            this.btnAnulareClient.Size = new System.Drawing.Size(122, 38);
            this.btnAnulareClient.TabIndex = 19;
            this.btnAnulareClient.Text = "Anulare";
            this.btnAnulareClient.UseVisualStyleBackColor = true;
            // 
            // btnSalvareClient
            // 
            this.btnSalvareClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvareClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvareClient.Location = new System.Drawing.Point(98, 328);
            this.btnSalvareClient.Name = "btnSalvareClient";
            this.btnSalvareClient.Size = new System.Drawing.Size(114, 38);
            this.btnSalvareClient.TabIndex = 20;
            this.btnSalvareClient.Text = "Salvare";
            this.btnSalvareClient.UseVisualStyleBackColor = true;
            this.btnSalvareClient.Click += new System.EventHandler(this.btnSalvareClient_Click);
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.Location = new System.Drawing.Point(212, 58);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(169, 26);
            this.tbNumeClient.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nume Client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(78, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nr. Comanda:";
            // 
            // tbNrComanda
            // 
            this.tbNrComanda.Location = new System.Drawing.Point(212, 256);
            this.tbNrComanda.Name = "tbNrComanda";
            this.tbNrComanda.Size = new System.Drawing.Size(169, 26);
            this.tbNrComanda.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(78, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "CNP:";
            // 
            // tbNrTelefon
            // 
            this.tbNrTelefon.Location = new System.Drawing.Point(212, 208);
            this.tbNrTelefon.Name = "tbNrTelefon";
            this.tbNrTelefon.Size = new System.Drawing.Size(169, 26);
            this.tbNrTelefon.TabIndex = 29;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(212, 106);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(169, 26);
            this.tbCNP.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(78, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(78, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nr. Telefon:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(212, 156);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(169, 26);
            this.tbAdresa.TabIndex = 26;
            // 
            // FormEditareClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 418);
            this.Controls.Add(this.tbNumeClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNrComanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNrTelefon);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.btnSalvareClient);
            this.Controls.Add(this.btnAnulareClient);
            this.Name = "FormEditareClient";
            this.Text = "Editare Client";
            this.Load += new System.EventHandler(this.FormEditareClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnulareClient;
        private System.Windows.Forms.Button btnSalvareClient;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNrComanda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNrTelefon;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdresa;
    }
}