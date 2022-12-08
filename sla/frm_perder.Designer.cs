namespace sla
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
            this.lbl_titulo.Font = new System.Drawing.Font("Trebuchet MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(81, 29);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(646, 119);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Você perdeu!";
            // 
            // lbl_pares
            // 
            this.lbl_pares.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pares.AutoSize = true;
            this.lbl_pares.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pares.ForeColor = System.Drawing.Color.Black;
            this.lbl_pares.Location = new System.Drawing.Point(493, 150);
            this.lbl_pares.Name = "lbl_pares";
            this.lbl_pares.Size = new System.Drawing.Size(31, 35);
            this.lbl_pares.TabIndex = 6;
            this.lbl_pares.Text = "0";
            // 
            // lbl_paresEncontrados
            // 
            this.lbl_paresEncontrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_paresEncontrados.AutoSize = true;
            this.lbl_paresEncontrados.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paresEncontrados.ForeColor = System.Drawing.Color.Black;
            this.lbl_paresEncontrados.Location = new System.Drawing.Point(240, 150);
            this.lbl_paresEncontrados.Name = "lbl_paresEncontrados";
            this.lbl_paresEncontrados.Size = new System.Drawing.Size(266, 35);
            this.lbl_paresEncontrados.TabIndex = 5;
            this.lbl_paresEncontrados.Text = "Pares encontrados: ";
            // 
            // brn_rank
            // 
            this.brn_rank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brn_rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.brn_rank.FlatAppearance.BorderSize = 0;
            this.brn_rank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_rank.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_rank.ForeColor = System.Drawing.Color.Transparent;
            this.brn_rank.Location = new System.Drawing.Point(246, 224);
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
            this.btn_jogarNovamente.FlatAppearance.BorderSize = 0;
            this.btn_jogarNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jogarNovamente.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogarNovamente.ForeColor = System.Drawing.Color.White;
            this.btn_jogarNovamente.Location = new System.Drawing.Point(246, 338);
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
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.brn_rank);
            this.Controls.Add(this.btn_jogarNovamente);
            this.Controls.Add(this.lbl_pares);
            this.Controls.Add(this.lbl_paresEncontrados);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_perder";
            this.Text = "Você perdeu!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_perder_Load);
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