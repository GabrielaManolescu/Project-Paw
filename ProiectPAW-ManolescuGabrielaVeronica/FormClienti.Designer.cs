
namespace ProiectPAW_ManolescuGabrielaVeronica
{
    partial class FormClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienti));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNrTelefon = new System.Windows.Forms.TextBox();
            this.tbNrComanda = new System.Windows.Forms.TextBox();
            this.lvClienti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdaugareClient = new System.Windows.Forms.Button();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnStergereClient = new System.Windows.Forms.Button();
            this.btnEditareClient = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CNP:";
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.Location = new System.Drawing.Point(175, 28);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(169, 26);
            this.tbNumeClient.TabIndex = 9;
            this.tbNumeClient.MouseLeave += new System.EventHandler(this.tbNumeClient_MouseLeave);
            this.tbNumeClient.MouseHover += new System.EventHandler(this.tbNumeClient_MouseHover);
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(175, 76);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(169, 26);
            this.tbCNP.TabIndex = 10;
            this.tbCNP.MouseLeave += new System.EventHandler(this.tbCNP_MouseLeave);
            this.tbCNP.MouseHover += new System.EventHandler(this.tbCNP_MouseHover);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(175, 126);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(169, 26);
            this.tbAdresa.TabIndex = 11;
            this.tbAdresa.MouseLeave += new System.EventHandler(this.tbAdresa_MouseLeave);
            this.tbAdresa.MouseHover += new System.EventHandler(this.tbAdresa_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(41, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nr. Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(41, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nr. Comanda:";
            // 
            // tbNrTelefon
            // 
            this.tbNrTelefon.Location = new System.Drawing.Point(175, 178);
            this.tbNrTelefon.Name = "tbNrTelefon";
            this.tbNrTelefon.Size = new System.Drawing.Size(169, 26);
            this.tbNrTelefon.TabIndex = 14;
            // 
            // tbNrComanda
            // 
            this.tbNrComanda.Location = new System.Drawing.Point(175, 226);
            this.tbNrComanda.Name = "tbNrComanda";
            this.tbNrComanda.Size = new System.Drawing.Size(169, 26);
            this.tbNrComanda.TabIndex = 15;
            // 
            // lvClienti
            // 
            this.lvClienti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvClienti.FullRowSelect = true;
            this.lvClienti.GridLines = true;
            this.lvClienti.HideSelection = false;
            this.lvClienti.Location = new System.Drawing.Point(396, 99);
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(863, 226);
            this.lvClienti.TabIndex = 16;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CNP";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nr.Telefon";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nr.Comanda";
            this.columnHeader5.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNumeClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNrComanda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNrTelefon);
            this.groupBox1.Controls.Add(this.tbCNP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAdresa);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 274);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare Client:";
            // 
            // btnAdaugareClient
            // 
            this.btnAdaugareClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugareClient.Location = new System.Drawing.Point(187, 369);
            this.btnAdaugareClient.Name = "btnAdaugareClient";
            this.btnAdaugareClient.Size = new System.Drawing.Size(158, 45);
            this.btnAdaugareClient.TabIndex = 18;
            this.btnAdaugareClient.Text = "Adauga Client";
            this.btnAdaugareClient.UseVisualStyleBackColor = true;
            this.btnAdaugareClient.Click += new System.EventHandler(this.btnAdaugareClient_Click);
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // btnStergereClient
            // 
            this.btnStergereClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergereClient.Location = new System.Drawing.Point(644, 369);
            this.btnStergereClient.Name = "btnStergereClient";
            this.btnStergereClient.Size = new System.Drawing.Size(118, 32);
            this.btnStergereClient.TabIndex = 19;
            this.btnStergereClient.Text = "Stergere";
            this.btnStergereClient.UseVisualStyleBackColor = true;
            this.btnStergereClient.Click += new System.EventHandler(this.btnStergereClient_Click);
            // 
            // btnEditareClient
            // 
            this.btnEditareClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditareClient.Location = new System.Drawing.Point(793, 369);
            this.btnEditareClient.Name = "btnEditareClient";
            this.btnEditareClient.Size = new System.Drawing.Size(108, 32);
            this.btnEditareClient.TabIndex = 20;
            this.btnEditareClient.Text = "Editare";
            this.btnEditareClient.UseVisualStyleBackColor = true;
            this.btnEditareClient.Click += new System.EventHandler(this.btnEditareClient_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1445, 22);
            this.statusStrip.TabIndex = 21;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1445, 34);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 29);
            this.toolStripButton1.Text = "Iesire";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectPAW_ManolescuGabrielaVeronica.Properties.Resources._151325727_business_landing_page_abstract_concept_vector_illustration_set_clients_portfolio_feedback_corporate_1;
            this.ClientSize = new System.Drawing.Size(1445, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnEditareClient);
            this.Controls.Add(this.btnStergereClient);
            this.Controls.Add(this.btnAdaugareClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvClienti);
            this.Name = "FormClienti";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.FormClienti_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNrTelefon;
        private System.Windows.Forms.TextBox tbNrComanda;
        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdaugareClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.Button btnStergereClient;
        private System.Windows.Forms.Button btnEditareClient;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}