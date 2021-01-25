namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreference = new System.Windows.Forms.TextBox();
            this.txtlot = new System.Windows.Forms.TextBox();
            this.txtproduits = new System.Windows.Forms.TextBox();
            this.txtorigine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.cmbcategorie = new System.Windows.Forms.ComboBox();
            this.dtpperemption = new System.Windows.Forms.DateTimePicker();
            this.lsvproduit = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnenregister = new System.Windows.Forms.Button();
            this.btnnouveau = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "pays d\'origine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date peremtion";
            // 
            // txtreference
            // 
            this.txtreference.Location = new System.Drawing.Point(205, 27);
            this.txtreference.Name = "txtreference";
            this.txtreference.ReadOnly = true;
            this.txtreference.Size = new System.Drawing.Size(171, 20);
            this.txtreference.TabIndex = 5;
            this.txtreference.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtlot
            // 
            this.txtlot.Location = new System.Drawing.Point(205, 117);
            this.txtlot.Name = "txtlot";
            this.txtlot.Size = new System.Drawing.Size(171, 20);
            this.txtlot.TabIndex = 7;
            // 
            // txtproduits
            // 
            this.txtproduits.Location = new System.Drawing.Point(205, 68);
            this.txtproduits.Name = "txtproduits";
            this.txtproduits.Size = new System.Drawing.Size(268, 20);
            this.txtproduits.TabIndex = 8;
            // 
            // txtorigine
            // 
            this.txtorigine.Location = new System.Drawing.Point(205, 206);
            this.txtorigine.Name = "txtorigine";
            this.txtorigine.Size = new System.Drawing.Size(171, 20);
            this.txtorigine.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prix";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Stock";
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(807, 71);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(171, 20);
            this.txtprix.TabIndex = 13;
            this.txtprix.TextChanged += new System.EventHandler(this.txtprix_TextChanged);
            this.txtprix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprix_KeyPress);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(807, 27);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(171, 20);
            this.txtstock.TabIndex = 14;
            this.txtstock.TextChanged += new System.EventHandler(this.txtstock_TextChanged);
            // 
            // cmbcategorie
            // 
            this.cmbcategorie.FormattingEnabled = true;
            this.cmbcategorie.Items.AddRange(new object[] {
            "Commestible",
            "Savons",
            "Livre"});
            this.cmbcategorie.Location = new System.Drawing.Point(807, 134);
            this.cmbcategorie.Name = "cmbcategorie";
            this.cmbcategorie.Size = new System.Drawing.Size(171, 21);
            this.cmbcategorie.TabIndex = 15;
            this.cmbcategorie.Text = "Indeterminée";
            this.cmbcategorie.SelectedIndexChanged += new System.EventHandler(this.cmbcategorie_SelectedIndexChanged);
            // 
            // dtpperemption
            // 
            this.dtpperemption.Location = new System.Drawing.Point(205, 165);
            this.dtpperemption.Name = "dtpperemption";
            this.dtpperemption.Size = new System.Drawing.Size(233, 20);
            this.dtpperemption.TabIndex = 16;
            this.dtpperemption.ValueChanged += new System.EventHandler(this.dtpperemption_ValueChanged);
            // 
            // lsvproduit
            // 
            this.lsvproduit.BackColor = System.Drawing.Color.White;
            this.lsvproduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvproduit.FullRowSelect = true;
            this.lsvproduit.GridLines = true;
            this.lsvproduit.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvproduit.Location = new System.Drawing.Point(62, 247);
            this.lsvproduit.Name = "lsvproduit";
            this.lsvproduit.Size = new System.Drawing.Size(992, 275);
            this.lsvproduit.TabIndex = 17;
            this.lsvproduit.UseCompatibleStateImageBehavior = false;
            this.lsvproduit.View = System.Windows.Forms.View.Details;
            this.lsvproduit.SelectedIndexChanged += new System.EventHandler(this.lsvproduit_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reference";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libellé";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prix";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date expiration";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 132;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Categorie";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 161;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Origine";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 168;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lot";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 88;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodifier.Image = ((System.Drawing.Image)(resources.GetObject("btnmodifier.Image")));
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(410, 528);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 39);
            this.btnmodifier.TabIndex = 18;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquitter.Image = ((System.Drawing.Image)(resources.GetObject("btnquitter.Image")));
            this.btnquitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquitter.Location = new System.Drawing.Point(919, 528);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(120, 39);
            this.btnquitter.TabIndex = 19;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnannuler.Image = ((System.Drawing.Image)(resources.GetObject("btnannuler.Image")));
            this.btnannuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnannuler.Location = new System.Drawing.Point(742, 528);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(116, 39);
            this.btnannuler.TabIndex = 20;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnsupprimer.Image")));
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(579, 528);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(125, 39);
            this.btnsupprimer.TabIndex = 21;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnenregister
            // 
            this.btnenregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenregister.Image = ((System.Drawing.Image)(resources.GetObject("btnenregister.Image")));
            this.btnenregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenregister.Location = new System.Drawing.Point(221, 528);
            this.btnenregister.Name = "btnenregister";
            this.btnenregister.Size = new System.Drawing.Size(144, 39);
            this.btnenregister.TabIndex = 22;
            this.btnenregister.Text = "Enregistrer";
            this.btnenregister.UseVisualStyleBackColor = true;
            this.btnenregister.Click += new System.EventHandler(this.btnenregister_Click);
            // 
            // btnnouveau
            // 
            this.btnnouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnouveau.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnnouveau.FlatAppearance.BorderSize = 2;
            this.btnnouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnnouveau.Image")));
            this.btnnouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnouveau.Location = new System.Drawing.Point(47, 528);
            this.btnnouveau.Name = "btnnouveau";
            this.btnnouveau.Size = new System.Drawing.Size(120, 39);
            this.btnnouveau.TabIndex = 23;
            this.btnnouveau.Text = "Nouveau";
            this.btnnouveau.UseVisualStyleBackColor = true;
            this.btnnouveau.Click += new System.EventHandler(this.btnnouveau_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1042, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "GStock   v1.0 by Leader   Enterprise";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 580);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(101, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1066, 612);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnnouveau);
            this.Controls.Add(this.btnenregister);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.lsvproduit);
            this.Controls.Add(this.dtpperemption);
            this.Controls.Add(this.cmbcategorie);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtorigine);
            this.Controls.Add(this.txtproduits);
            this.Controls.Add(this.txtlot);
            this.Controls.Add(this.txtreference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil GStock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtreference;
        private System.Windows.Forms.TextBox txtlot;
        private System.Windows.Forms.TextBox txtproduits;
        private System.Windows.Forms.TextBox txtorigine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.ComboBox cmbcategorie;
        private System.Windows.Forms.DateTimePicker dtpperemption;
        private System.Windows.Forms.ListView lsvproduit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnenregister;
        private System.Windows.Forms.Button btnnouveau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

