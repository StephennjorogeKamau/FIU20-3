
namespace Persoen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Anlegen = new System.Windows.Forms.Button();
            this.txtb_KdNr = new System.Windows.Forms.TextBox();
            this.txtb_Firma = new System.Windows.Forms.TextBox();
            this.lb_KdNr = new System.Windows.Forms.Label();
            this.lb_Firmenname = new System.Windows.Forms.Label();
            this.lv_Anzeige = new System.Windows.Forms.ListView();
            this.KundenNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirmenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_Anzeigen = new System.Windows.Forms.Button();
            this.bt_Loeschen = new System.Windows.Forms.Button();
            this.bt_Speichern = new System.Windows.Forms.Button();
            this.bt_Laden = new System.Windows.Forms.Button();
            this.bt_LoeschenLV = new System.Windows.Forms.Button();
            this.txtb_Suchen = new System.Windows.Forms.TextBox();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Anlegen
            // 
            this.bt_Anlegen.Location = new System.Drawing.Point(77, 182);
            this.bt_Anlegen.Name = "bt_Anlegen";
            this.bt_Anlegen.Size = new System.Drawing.Size(75, 23);
            this.bt_Anlegen.TabIndex = 0;
            this.bt_Anlegen.Text = "Anlegen";
            this.bt_Anlegen.UseVisualStyleBackColor = true;
            this.bt_Anlegen.Click += new System.EventHandler(this.bt_Anlegen_Click);
            // 
            // txtb_KdNr
            // 
            this.txtb_KdNr.Location = new System.Drawing.Point(131, 56);
            this.txtb_KdNr.Name = "txtb_KdNr";
            this.txtb_KdNr.Size = new System.Drawing.Size(170, 20);
            this.txtb_KdNr.TabIndex = 1;
            // 
            // txtb_Firma
            // 
            this.txtb_Firma.Location = new System.Drawing.Point(131, 114);
            this.txtb_Firma.Name = "txtb_Firma";
            this.txtb_Firma.Size = new System.Drawing.Size(170, 20);
            this.txtb_Firma.TabIndex = 2;
            // 
            // lb_KdNr
            // 
            this.lb_KdNr.AutoSize = true;
            this.lb_KdNr.Location = new System.Drawing.Point(28, 62);
            this.lb_KdNr.Name = "lb_KdNr";
            this.lb_KdNr.Size = new System.Drawing.Size(81, 13);
            this.lb_KdNr.TabIndex = 3;
            this.lb_KdNr.Text = "Kundennummer";
            // 
            // lb_Firmenname
            // 
            this.lb_Firmenname.AutoSize = true;
            this.lb_Firmenname.Location = new System.Drawing.Point(31, 120);
            this.lb_Firmenname.Name = "lb_Firmenname";
            this.lb_Firmenname.Size = new System.Drawing.Size(64, 13);
            this.lb_Firmenname.TabIndex = 4;
            this.lb_Firmenname.Text = "Firmenname";
            // 
            // lv_Anzeige
            // 
            this.lv_Anzeige.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KundenNummer,
            this.FirmenName});
            this.lv_Anzeige.FullRowSelect = true;
            this.lv_Anzeige.GridLines = true;
            this.lv_Anzeige.HideSelection = false;
            this.lv_Anzeige.Location = new System.Drawing.Point(343, 56);
            this.lv_Anzeige.Name = "lv_Anzeige";
            this.lv_Anzeige.Size = new System.Drawing.Size(279, 266);
            this.lv_Anzeige.TabIndex = 5;
            this.lv_Anzeige.UseCompatibleStateImageBehavior = false;
            this.lv_Anzeige.View = System.Windows.Forms.View.Details;
            this.lv_Anzeige.Visible = false;
            // 
            // KundenNummer
            // 
            this.KundenNummer.Text = "KundenNummer";
            this.KundenNummer.Width = 122;
            // 
            // FirmenName
            // 
            this.FirmenName.Text = "FirmenName";
            this.FirmenName.Width = 147;
            // 
            // bt_Anzeigen
            // 
            this.bt_Anzeigen.Location = new System.Drawing.Point(343, 367);
            this.bt_Anzeigen.Name = "bt_Anzeigen";
            this.bt_Anzeigen.Size = new System.Drawing.Size(75, 23);
            this.bt_Anzeigen.TabIndex = 6;
            this.bt_Anzeigen.Text = "Anzeigen";
            this.bt_Anzeigen.UseVisualStyleBackColor = true;
            this.bt_Anzeigen.Click += new System.EventHandler(this.bt_Anzeigen_Click);
            // 
            // bt_Loeschen
            // 
            this.bt_Loeschen.Location = new System.Drawing.Point(77, 247);
            this.bt_Loeschen.Name = "bt_Loeschen";
            this.bt_Loeschen.Size = new System.Drawing.Size(75, 23);
            this.bt_Loeschen.TabIndex = 7;
            this.bt_Loeschen.Text = "Löschen";
            this.bt_Loeschen.UseVisualStyleBackColor = true;
            this.bt_Loeschen.Click += new System.EventHandler(this.bt_Loeschen_Click);
            // 
            // bt_Speichern
            // 
            this.bt_Speichern.Location = new System.Drawing.Point(208, 182);
            this.bt_Speichern.Name = "bt_Speichern";
            this.bt_Speichern.Size = new System.Drawing.Size(75, 23);
            this.bt_Speichern.TabIndex = 8;
            this.bt_Speichern.Text = "Speichern";
            this.bt_Speichern.UseVisualStyleBackColor = true;
            this.bt_Speichern.Click += new System.EventHandler(this.bt_Speichern_Click);
            // 
            // bt_Laden
            // 
            this.bt_Laden.Location = new System.Drawing.Point(208, 247);
            this.bt_Laden.Name = "bt_Laden";
            this.bt_Laden.Size = new System.Drawing.Size(75, 23);
            this.bt_Laden.TabIndex = 9;
            this.bt_Laden.Text = "Laden";
            this.bt_Laden.UseVisualStyleBackColor = true;
            this.bt_Laden.Click += new System.EventHandler(this.bt_Laden_Click);
            // 
            // bt_LoeschenLV
            // 
            this.bt_LoeschenLV.Location = new System.Drawing.Point(547, 367);
            this.bt_LoeschenLV.Name = "bt_LoeschenLV";
            this.bt_LoeschenLV.Size = new System.Drawing.Size(75, 23);
            this.bt_LoeschenLV.TabIndex = 10;
            this.bt_LoeschenLV.Text = "Löschen";
            this.bt_LoeschenLV.UseVisualStyleBackColor = true;
            this.bt_LoeschenLV.Click += new System.EventHandler(this.bt_LoeschenLV_Click);
            // 
            // txtb_Suchen
            // 
            this.txtb_Suchen.Location = new System.Drawing.Point(58, 340);
            this.txtb_Suchen.Name = "txtb_Suchen";
            this.txtb_Suchen.Size = new System.Drawing.Size(203, 20);
            this.txtb_Suchen.TabIndex = 11;
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Location = new System.Drawing.Point(116, 392);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(75, 23);
            this.bt_Suchen.TabIndex = 12;
            this.bt_Suchen.Text = "Suchen";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.bt_Suchen);
            this.Controls.Add(this.txtb_Suchen);
            this.Controls.Add(this.bt_LoeschenLV);
            this.Controls.Add(this.bt_Laden);
            this.Controls.Add(this.bt_Speichern);
            this.Controls.Add(this.bt_Loeschen);
            this.Controls.Add(this.bt_Anzeigen);
            this.Controls.Add(this.lv_Anzeige);
            this.Controls.Add(this.lb_Firmenname);
            this.Controls.Add(this.lb_KdNr);
            this.Controls.Add(this.txtb_Firma);
            this.Controls.Add(this.txtb_KdNr);
            this.Controls.Add(this.bt_Anlegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Anlegen;
        private System.Windows.Forms.TextBox txtb_KdNr;
        private System.Windows.Forms.TextBox txtb_Firma;
        private System.Windows.Forms.Label lb_KdNr;
        private System.Windows.Forms.Label lb_Firmenname;
        private System.Windows.Forms.ListView lv_Anzeige;
        private System.Windows.Forms.Button bt_Anzeigen;
        private System.Windows.Forms.ColumnHeader KundenNummer;
        private System.Windows.Forms.ColumnHeader FirmenName;
        private System.Windows.Forms.Button bt_Loeschen;
        private System.Windows.Forms.Button bt_Speichern;
        private System.Windows.Forms.Button bt_Laden;
        private System.Windows.Forms.Button bt_LoeschenLV;
        private System.Windows.Forms.TextBox txtb_Suchen;
        private System.Windows.Forms.Button bt_Suchen;
    }
}

