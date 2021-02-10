
namespace TriggerTestAssieme
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dgvStoricoCancellazioni = new System.Windows.Forms.DataGridView();
            this.dgvStoricoAggiornamenti = new System.Windows.Forms.DataGridView();
            this.btnAggDB = new System.Windows.Forms.Button();
            this.txtNazione = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCercaF1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPodio = new System.Windows.Forms.TextBox();
            this.btnCercaF2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(13, 13);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(323, 196);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsDeletedDriver);
            // 
            // dgvStoricoCancellazioni
            // 
            this.dgvStoricoCancellazioni.AllowUserToAddRows = false;
            this.dgvStoricoCancellazioni.AllowUserToDeleteRows = false;
            this.dgvStoricoCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoCancellazioni.Location = new System.Drawing.Point(352, 13);
            this.dgvStoricoCancellazioni.Name = "dgvStoricoCancellazioni";
            this.dgvStoricoCancellazioni.RowHeadersVisible = false;
            this.dgvStoricoCancellazioni.Size = new System.Drawing.Size(323, 196);
            this.dgvStoricoCancellazioni.TabIndex = 1;
            // 
            // dgvStoricoAggiornamenti
            // 
            this.dgvStoricoAggiornamenti.AllowUserToAddRows = false;
            this.dgvStoricoAggiornamenti.AllowUserToDeleteRows = false;
            this.dgvStoricoAggiornamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoAggiornamenti.Location = new System.Drawing.Point(13, 242);
            this.dgvStoricoAggiornamenti.Name = "dgvStoricoAggiornamenti";
            this.dgvStoricoAggiornamenti.RowHeadersVisible = false;
            this.dgvStoricoAggiornamenti.Size = new System.Drawing.Size(662, 196);
            this.dgvStoricoAggiornamenti.TabIndex = 2;
            // 
            // btnAggDB
            // 
            this.btnAggDB.Location = new System.Drawing.Point(13, 216);
            this.btnAggDB.Name = "btnAggDB";
            this.btnAggDB.Size = new System.Drawing.Size(159, 23);
            this.btnAggDB.TabIndex = 3;
            this.btnAggDB.Text = "Aggiorna Data Base";
            this.btnAggDB.UseVisualStyleBackColor = true;
            this.btnAggDB.Click += new System.EventHandler(this.btnAggDB_Click);
            // 
            // txtNazione
            // 
            this.txtNazione.Location = new System.Drawing.Point(145, 451);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.Size = new System.Drawing.Size(100, 20);
            this.txtNazione.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserisci la nazione:";
            // 
            // btnCercaF1
            // 
            this.btnCercaF1.Location = new System.Drawing.Point(261, 449);
            this.btnCercaF1.Name = "btnCercaF1";
            this.btnCercaF1.Size = new System.Drawing.Size(75, 23);
            this.btnCercaF1.TabIndex = 7;
            this.btnCercaF1.Text = "CERCA";
            this.btnCercaF1.UseVisualStyleBackColor = true;
            this.btnCercaF1.Click += new System.EventHandler(this.btnCercaF1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inserisci il numero di podi:";
            // 
            // txtPodio
            // 
            this.txtPodio.Location = new System.Drawing.Point(145, 485);
            this.txtPodio.Name = "txtPodio";
            this.txtPodio.Size = new System.Drawing.Size(100, 20);
            this.txtPodio.TabIndex = 9;
            // 
            // btnCercaF2
            // 
            this.btnCercaF2.Location = new System.Drawing.Point(261, 483);
            this.btnCercaF2.Name = "btnCercaF2";
            this.btnCercaF2.Size = new System.Drawing.Size(75, 23);
            this.btnCercaF2.TabIndex = 10;
            this.btnCercaF2.Text = "CERCA";
            this.btnCercaF2.UseVisualStyleBackColor = true;
            this.btnCercaF2.Click += new System.EventHandler(this.btnCercaF2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 556);
            this.Controls.Add(this.btnCercaF2);
            this.Controls.Add(this.txtPodio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCercaF1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazione);
            this.Controls.Add(this.btnAggDB);
            this.Controls.Add(this.dgvStoricoAggiornamenti);
            this.Controls.Add(this.dgvStoricoCancellazioni);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvStoricoCancellazioni;
        private System.Windows.Forms.DataGridView dgvStoricoAggiornamenti;
        private System.Windows.Forms.Button btnAggDB;
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCercaF1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPodio;
        private System.Windows.Forms.Button btnCercaF2;
    }
}

