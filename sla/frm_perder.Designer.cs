﻿namespace sla
{
    partial class frm_perder
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_pares = new System.Windows.Forms.Label();
            this.lbl_paresEncontrados = new System.Windows.Forms.Label();
            this.brn_rank = new System.Windows.Forms.Button();
            this.btn_jogarNovamente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(-75, 7);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(625, 108);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Você perdeu!";
            // 
            // lbl_pares
            // 
            this.lbl_pares.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pares.AutoSize = true;
            this.lbl_pares.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pares.ForeColor = System.Drawing.Color.Black;
            this.lbl_pares.Location = new System.Drawing.Point(366, 128);
            this.lbl_pares.Name = "lbl_pares";
            this.lbl_pares.Size = new System.Drawing.Size(30, 31);
            this.lbl_pares.TabIndex = 6;
            this.lbl_pares.Text = "0";
            // 
            // lbl_paresEncontrados
            // 
            this.lbl_paresEncontrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_paresEncontrados.AutoSize = true;
            this.lbl_paresEncontrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paresEncontrados.ForeColor = System.Drawing.Color.Black;
            this.lbl_paresEncontrados.Location = new System.Drawing.Point(84, 128);
            this.lbl_paresEncontrados.Name = "lbl_paresEncontrados";
            this.lbl_paresEncontrados.Size = new System.Drawing.Size(276, 31);
            this.lbl_paresEncontrados.TabIndex = 5;
            this.lbl_paresEncontrados.Text = "Pares encontrados: ";
            // 
            // brn_rank
            // 
            this.brn_rank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brn_rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.brn_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_rank.ForeColor = System.Drawing.Color.White;
            this.brn_rank.Location = new System.Drawing.Point(90, 202);
            this.brn_rank.Name = "brn_rank";
            this.brn_rank.Size = new System.Drawing.Size(294, 98);
            this.brn_rank.TabIndex = 8;
            this.brn_rank.Text = "Ver Ranking";
            this.brn_rank.UseVisualStyleBackColor = false;
            this.brn_rank.Click += new System.EventHandler(this.brn_rank_Click);
            // 
            // btn_jogarNovamente
            // 
            this.btn_jogarNovamente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_jogarNovamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.btn_jogarNovamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogarNovamente.ForeColor = System.Drawing.Color.White;
            this.btn_jogarNovamente.Location = new System.Drawing.Point(90, 316);
            this.btn_jogarNovamente.Name = "btn_jogarNovamente";
            this.btn_jogarNovamente.Size = new System.Drawing.Size(294, 102);
            this.btn_jogarNovamente.TabIndex = 7;
            this.btn_jogarNovamente.Text = "Jogar Novamente";
            this.btn_jogarNovamente.UseVisualStyleBackColor = false;
            this.btn_jogarNovamente.Click += new System.EventHandler(this.Btn_jogarNovamente_Click);
            // 
            // frm_perder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.brn_rank);
            this.Controls.Add(this.btn_jogarNovamente);
            this.Controls.Add(this.lbl_pares);
            this.Controls.Add(this.lbl_paresEncontrados);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_perder";
            this.Text = "frm_perder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_pares;
        private System.Windows.Forms.Label lbl_paresEncontrados;
        private System.Windows.Forms.Button brn_rank;
        private System.Windows.Forms.Button btn_jogarNovamente;
    }
}