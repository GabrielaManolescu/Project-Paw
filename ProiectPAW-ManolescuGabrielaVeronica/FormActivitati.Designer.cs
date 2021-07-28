
namespace ProiectPAW_ManolescuGabrielaVeronica
{
    partial class FormActivitati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivitati));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopiereDomeniu = new System.Windows.Forms.Button();
            this.cbNumeProiect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdaugaActivitate = new System.Windows.Forms.Button();
            this.cbDomeniiDeActivitate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataActivitati = new System.Windows.Forms.DateTimePicker();
            this.tbParticipantActivitate = new System.Windows.Forms.TextBox();
            this.tbNumeActivitate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lvActivitati = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorPr = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnStergereActivitate = new System.Windows.Forms.Button();
            this.btnEditareActivitate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPr)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCopiereDomeniu);
            this.groupBox1.Controls.Add(this.cbNumeProiect);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAdaugaActivitate);
            this.groupBox1.Controls.Add(this.cbDomeniiDeActivitate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDataActivitati);
            this.groupBox1.Controls.Add(this.tbParticipantActivitate);
            this.groupBox1.Controls.Add(this.tbNumeActivitate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare Activitate:";
            // 
            // btnCopiereDomeniu
            // 
            this.btnCopiereDomeniu.Location = new System.Drawing.Point(806, 63);
            this.btnCopiereDomeniu.Name = "btnCopiereDomeniu";
            this.btnCopiereDomeniu.Size = new System.Drawing.Size(155, 34);
            this.btnCopiereDomeniu.TabIndex = 11;
            this.btnCopiereDomeniu.Text = "Copiere Domeniu Activitate";
            this.btnCopiereDomeniu.UseVisualStyleBackColor = true;
            this.btnCopiereDomeniu.Click += new System.EventHandler(this.btnCopiereDomeniu_Click);
            // 
            // cbNumeProiect
            // 
            this.cbNumeProiect.FormattingEnabled = true;
            this.cbNumeProiect.Location = new System.Drawing.Point(605, 122);
            this.cbNumeProiect.Name = "cbNumeProiect";
            this.cbNumeProiect.Size = new System.Drawing.Size(160, 28);
            this.cbNumeProiect.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(408, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nume Proiect";
            // 
            // btnAdaugaActivitate
            // 
            this.btnAdaugaActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaActivitate.Location = new System.Drawing.Point(806, 113);
            this.btnAdaugaActivitate.Name = "btnAdaugaActivitate";
            this.btnAdaugaActivitate.Size = new System.Drawing.Size(243, 43);
            this.btnAdaugaActivitate.TabIndex = 8;
            this.btnAdaugaActivitate.Text = "Adauga Activitate";
            this.btnAdaugaActivitate.UseVisualStyleBackColor = true;
            this.btnAdaugaActivitate.Click += new System.EventHandler(this.btnAdaugaActivitate_Click);
            // 
            // cbDomeniiDeActivitate
            // 
            this.cbDomeniiDeActivitate.FormattingEnabled = true;
            this.cbDomeniiDeActivitate.Items.AddRange(new object[] {
            "Contabilitate",
            "Management",
            "IT",
            "Marketing"});
            this.cbDomeniiDeActivitate.Location = new System.Drawing.Point(605, 74);
            this.cbDomeniiDeActivitate.Name = "cbDomeniiDeActivitate";
            this.cbDomeniiDeActivitate.Size = new System.Drawing.Size(160, 28);
            this.cbDomeniiDeActivitate.TabIndex = 7;
            this.cbDomeniiDeActivitate.Validating += new System.ComponentModel.CancelEventHandler(this.cbDomeniiDeActivitate_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(408, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Domeniu Activitate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(408, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // dtpDataActivitati
            // 
            this.dtpDataActivitati.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataActivitati.Location = new System.Drawing.Point(605, 32);
            this.dtpDataActivitati.Name = "dtpDataActivitati";
            this.dtpDataActivitati.Size = new System.Drawing.Size(160, 26);
            this.dtpDataActivitati.TabIndex = 4;
            // 
            // tbParticipantActivitate
            // 
            this.tbParticipantActivitate.Location = new System.Drawing.Point(228, 105);
            this.tbParticipantActivitate.Name = "tbParticipantActivitate";
            this.tbParticipantActivitate.Size = new System.Drawing.Size(121, 26);
            this.tbParticipantActivitate.TabIndex = 3;
            this.tbParticipantActivitate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbParticipantActivitate_MouseDown);
            // 
            // tbNumeActivitate
            // 
            this.tbNumeActivitate.Location = new System.Drawing.Point(228, 44);
            this.tbNumeActivitate.Name = "tbNumeActivitate";
            this.tbNumeActivitate.Size = new System.Drawing.Size(121, 26);
            this.tbNumeActivitate.TabIndex = 2;
            this.tbNumeActivitate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNumeActivitate_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Participant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Activitate:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1247, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lvActivitati
            // 
            this.lvActivitati.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvActivitati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvActivitati.FullRowSelect = true;
            this.lvActivitati.GridLines = true;
            this.lvActivitati.HideSelection = false;
            this.lvActivitati.Location = new System.Drawing.Point(31, 249);
            this.lvActivitati.Name = "lvActivitati";
            this.lvActivitati.Size = new System.Drawing.Size(825, 148);
            this.lvActivitati.TabIndex = 2;
            this.lvActivitati.UseCompatibleStateImageBehavior = false;
            this.lvActivitati.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Participant";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Domeniu";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nume Proiect";
            this.columnHeader5.Width = 120;
            // 
            // errorPr
            // 
            this.errorPr.ContainerControl = this;
            // 
            // btnStergereActivitate
            // 
            this.btnStergereActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergereActivitate.Location = new System.Drawing.Point(899, 336);
            this.btnStergereActivitate.Name = "btnStergereActivitate";
            this.btnStergereActivitate.Size = new System.Drawing.Size(106, 45);
            this.btnStergereActivitate.TabIndex = 9;
            this.btnStergereActivitate.Text = "Stergere";
            this.btnStergereActivitate.UseVisualStyleBackColor = true;
            this.btnStergereActivitate.Click += new System.EventHandler(this.btnStergereActivitate_Click);
            // 
            // btnEditareActivitate
            // 
            this.btnEditareActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditareActivitate.Location = new System.Drawing.Point(899, 249);
            this.btnEditareActivitate.Name = "btnEditareActivitate";
            this.btnEditareActivitate.Size = new System.Drawing.Size(106, 45);
            this.btnEditareActivitate.TabIndex = 10;
            this.btnEditareActivitate.Text = "Editare";
            this.btnEditareActivitate.UseVisualStyleBackColor = true;
            this.btnEditareActivitate.Click += new System.EventHandler(this.btnEditareActivitate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 68);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(144, 32);
            this.backToolStripMenuItem.Text = "Anulare";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(144, 32);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 33);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormActivitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectPAW_ManolescuGabrielaVeronica.Properties.Resources.AccountGuard_Expansion_Blog_Image_1;
            this.ClientSize = new System.Drawing.Size(1247, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnEditareActivitate);
            this.Controls.Add(this.btnStergereActivitate);
            this.Controls.Add(this.lvActivitati);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormActivitati";
            this.Text = "Activitati";
            this.Load += new System.EventHandler(this.FormActivitati_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPr)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParticipantActivitate;
        private System.Windows.Forms.TextBox tbNumeActivitate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataActivitati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbDomeniiDeActivitate;
        private System.Windows.Forms.Button btnAdaugaActivitate;
        private System.Windows.Forms.ListView lvActivitati;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ErrorProvider errorPr;
        private System.Windows.Forms.Button btnEditareActivitate;
        private System.Windows.Forms.Button btnStergereActivitate;
        private System.Windows.Forms.ComboBox cbNumeProiect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCopiereDomeniu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    }
}