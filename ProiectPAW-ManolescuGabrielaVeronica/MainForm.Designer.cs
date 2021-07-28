
using Control;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
    partial class AgendaDeActivitati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaDeActivitati));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumeProiect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataInceput = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSfarsit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdaugareProiect = new System.Windows.Forms.Button();
            this.lvProiecte = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNumeClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.tbNrProiect = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLista = new System.Windows.Forms.Button();
            this.btnDetalii = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateGeneraleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintare = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.textBox1 = new Control.CalculatorUC();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Proiect:";
            // 
            // tbNumeProiect
            // 
            this.tbNumeProiect.Location = new System.Drawing.Point(181, 72);
            this.tbNumeProiect.Name = "tbNumeProiect";
            this.tbNumeProiect.Size = new System.Drawing.Size(172, 26);
            this.tbNumeProiect.TabIndex = 1;
            this.tbNumeProiect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNumeProiect_MouseDown);
            this.tbNumeProiect.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeProiect_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(390, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Inceput a Proiectului: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(390, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Sfarsit a Proiectului: ";
            // 
            // dtpDataInceput
            // 
            this.dtpDataInceput.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataInceput.CustomFormat = "dd/MM/yyyy";
            this.dtpDataInceput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInceput.Location = new System.Drawing.Point(656, 21);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(159, 26);
            this.dtpDataInceput.TabIndex = 4;
            this.dtpDataInceput.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataInceput_Validating);
            // 
            // dtpDataSfarsit
            // 
            this.dtpDataSfarsit.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataSfarsit.CustomFormat = "dd/MM/yyyy";
            this.dtpDataSfarsit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataSfarsit.Location = new System.Drawing.Point(656, 60);
            this.dtpDataSfarsit.Name = "dtpDataSfarsit";
            this.dtpDataSfarsit.Size = new System.Drawing.Size(159, 26);
            this.dtpDataSfarsit.TabIndex = 5;
            this.dtpDataSfarsit.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataSfarsit_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost Proiect:";
            // 
            // btnAdaugareProiect
            // 
            this.btnAdaugareProiect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugareProiect.Location = new System.Drawing.Point(872, 91);
            this.btnAdaugareProiect.Name = "btnAdaugareProiect";
            this.btnAdaugareProiect.Size = new System.Drawing.Size(163, 37);
            this.btnAdaugareProiect.TabIndex = 8;
            this.btnAdaugareProiect.Text = "Adaugare Proiect";
            this.btnAdaugareProiect.UseVisualStyleBackColor = true;
            this.btnAdaugareProiect.Click += new System.EventHandler(this.btnAdaugareProiect_Click);
            // 
            // lvProiecte
            // 
            this.lvProiecte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProiecte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader4});
            this.lvProiecte.FullRowSelect = true;
            this.lvProiecte.GridLines = true;
            this.lvProiecte.HideSelection = false;
            this.lvProiecte.Location = new System.Drawing.Point(78, 248);
            this.lvProiecte.Name = "lvProiecte";
            this.lvProiecte.Size = new System.Drawing.Size(978, 251);
            this.lvProiecte.TabIndex = 9;
            this.lvProiecte.UseCompatibleStateImageBehavior = false;
            this.lvProiecte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr. Proiect";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume Proiect";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Inceput";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data Sfarsit";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cost Proiect";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nume Client";
            this.columnHeader4.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cbNumeClient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAnulare);
            this.groupBox1.Controls.Add(this.tbNrProiect);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAdaugareProiect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNumeProiect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDataSfarsit);
            this.groupBox1.Controls.Add(this.tbCost);
            this.groupBox1.Controls.Add(this.dtpDataInceput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(78, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare Proiect";
            // 
            // cbNumeClient
            // 
            this.cbNumeClient.FormattingEnabled = true;
            this.cbNumeClient.Location = new System.Drawing.Point(656, 105);
            this.cbNumeClient.Name = "cbNumeClient";
            this.cbNumeClient.Size = new System.Drawing.Size(166, 28);
            this.cbNumeClient.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(390, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nume Client:";
            // 
            // btnAnulare
            // 
            this.btnAnulare.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnAnulare.Location = new System.Drawing.Point(1075, 91);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(89, 40);
            this.btnAnulare.TabIndex = 11;
            this.btnAnulare.Text = "&Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // tbNrProiect
            // 
            this.tbNrProiect.Location = new System.Drawing.Point(181, 32);
            this.tbNrProiect.Name = "tbNrProiect";
            this.tbNrProiect.Size = new System.Drawing.Size(172, 26);
            this.tbNrProiect.TabIndex = 10;
            this.tbNrProiect.Validating += new System.ComponentModel.CancelEventHandler(this.tbNrProiect_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nr. Proiect";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(181, 108);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(172, 26);
            this.tbCost.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLista.Location = new System.Drawing.Point(410, 528);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(99, 41);
            this.btnLista.TabIndex = 11;
            this.btnLista.Text = "&Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnDetalii
            // 
            this.btnDetalii.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetalii.Location = new System.Drawing.Point(298, 528);
            this.btnDetalii.Name = "btnDetalii";
            this.btnDetalii.Size = new System.Drawing.Size(96, 41);
            this.btnDetalii.TabIndex = 12;
            this.btnDetalii.Text = "&Detalii";
            this.btnDetalii.UseVisualStyleBackColor = true;
            this.btnDetalii.Click += new System.EventHandler(this.btnDetalii_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateGeneraleToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.fisiereToolStripMenuItem,
            this.printareToolStripMenuItem,
            this.btnIesire});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1471, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateGeneraleToolStripMenuItem
            // 
            this.dateGeneraleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activitatiToolStripMenuItem,
            this.clientiToolStripMenuItem});
            this.dateGeneraleToolStripMenuItem.Name = "dateGeneraleToolStripMenuItem";
            this.dateGeneraleToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.dateGeneraleToolStripMenuItem.Text = "Date generale";
            // 
            // activitatiToolStripMenuItem
            // 
            this.activitatiToolStripMenuItem.Name = "activitatiToolStripMenuItem";
            this.activitatiToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.activitatiToolStripMenuItem.Text = "Activitati";
            this.activitatiToolStripMenuItem.Click += new System.EventHandler(this.activitatiToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializareXML,
            this.btnDeserializareXML});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.fileToolStripMenuItem.Text = "Fisier XML";
            // 
            // btnSerializareXML
            // 
            this.btnSerializareXML.Name = "btnSerializareXML";
            this.btnSerializareXML.Size = new System.Drawing.Size(212, 34);
            this.btnSerializareXML.Text = "Serializare";
            this.btnSerializareXML.Click += new System.EventHandler(this.btnSerializareXML_Click);
            // 
            // btnDeserializareXML
            // 
            this.btnDeserializareXML.Name = "btnDeserializareXML";
            this.btnDeserializareXML.Size = new System.Drawing.Size(212, 34);
            this.btnDeserializareXML.Text = "Deserializare";
            this.btnDeserializareXML.Click += new System.EventHandler(this.btnDeserializareXML_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.fisiereToolStripMenuItem.Text = "Fisiere ";
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(165, 34);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrintare,
            this.btnPrintPreview});
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.printareToolStripMenuItem.Text = "Printare Fisiere";
            // 
            // btnPrintare
            // 
            this.btnPrintare.Name = "btnPrintare";
            this.btnPrintare.Size = new System.Drawing.Size(215, 34);
            this.btnPrintare.Text = "Printare";
            this.btnPrintare.Click += new System.EventHandler(this.btnPrintare_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(215, 34);
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(69, 29);
            this.btnIesire.Text = "Iesire";
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnEditare
            // 
            this.btnEditare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditare.Location = new System.Drawing.Point(78, 528);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(87, 41);
            this.btnEditare.TabIndex = 14;
            this.btnEditare.Text = "&Editare";
            this.btnEditare.UseVisualStyleBackColor = true;
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergere.Location = new System.Drawing.Point(181, 528);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(101, 41);
            this.btnStergere.TabIndex = 15;
            this.btnStergere.Text = "&Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // textBox1
            // 
            this.textBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox1.BackgroundImage")));
            this.textBox1.Location = new System.Drawing.Point(1101, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 198);
            this.textBox1.TabIndex = 16;
            // 
            // AgendaDeActivitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1471, 611);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.btnDetalii);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvProiecte);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AgendaDeActivitati";
            this.Text = "Agenda de Activitati";
            this.Load += new System.EventHandler(this.AgendaDeActivitati_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumeProiect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataInceput;
        private System.Windows.Forms.DateTimePicker dtpDataSfarsit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdaugareProiect;
        private System.Windows.Forms.ListView lvProiecte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNrProiect;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnDetalii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializareXML;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializareXML;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.ToolStripMenuItem dateGeneraleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitatiToolStripMenuItem;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbNumeClient;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPrintare;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private CalculatorUC textBox1;//eu
    }
}

