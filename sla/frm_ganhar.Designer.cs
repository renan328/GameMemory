
namespace sla
{
    partial class frm_ganhar
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
            this.lbl_vcGanhou = new System.Windows.Forms.Label();
            this.btn_jogarNovamente = new System.Windows.Forms.Button();
            this.brn_rank = new System.Windows.Forms.Button();
            this.lbl_tempoGasto = new System.Windows.Forms.Label();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_vcGanhou
            // 
            this.lbl_vcGanhou.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_vcGanhou.AutoSize = true;
            this.lbl_vcGanhou.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vcGanhou.ForeColor = System.Drawing.Color.White;
            this.lbl_vcGanhou.Location = new System.Drawing.Point(42, 21);
            this.lbl_vcGanhou.Name = "lbl_vcGanhou";
            this.lbl_vcGanhou.Size = new System.Drawing.Size(461, 73);
            this.lbl_vcGanhou.TabIndex = 0;
            this.lbl_vcGanhou.Text = "Você ganhou!!";
            // 
            // btn_jogarNovamente
            // 
            this.btn_jogarNovamente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_jogarNovamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.btn_jogarNovamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogarNovamente.ForeColor = System.Drawing.Color.White;
            this.btn_jogarNovamente.Location = new System.Drawing.Point(117, 327);
            this.btn_jogarNovamente.Name = "btn_jogarNovamente";
            this.btn_jogarNovamente.Size = new System.Drawing.Size(294, 84);
            this.btn_jogarNovamente.TabIndex = 1;
            this.btn_jogarNovamente.Text = "Jogar Novamente";
            this.btn_jogarNovamente.UseVisualStyleBackColor = false;
            this.btn_jogarNovamente.Click += new System.EventHandler(this.btn_jogarNovamente_Click);
            // 
            // brn_rank
            // 
            this.brn_rank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brn_rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.brn_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_rank.ForeColor = System.Drawing.Color.White;
            this.brn_rank.Location = new System.Drawing.Point(117, 221);
            this.brn_rank.Name = "brn_rank";
            this.brn_rank.Size = new System.Drawing.Size(294, 84);
            this.brn_rank.TabIndex = 2;
            this.brn_rank.Text = "Ver Ranking";
            this.brn_rank.UseVisualStyleBackColor = false;
            // 
            // lbl_tempoGasto
            // 
            this.lbl_tempoGasto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tempoGasto.AutoSize = true;
            this.lbl_tempoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempoGasto.ForeColor = System.Drawing.Color.White;
            this.lbl_tempoGasto.Location = new System.Drawing.Point(86, 128);
            this.lbl_tempoGasto.Name = "lbl_tempoGasto";
            this.lbl_tempoGasto.Size = new System.Drawing.Size(192, 31);
            this.lbl_tempoGasto.TabIndex = 3;
            this.lbl_tempoGasto.Text = "Tempo gasto:";
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.ForeColor = System.Drawing.Color.White;
            this.lbl_tempo.Location = new System.Drawing.Point(284, 128);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(164, 31);
            this.lbl_tempo.TabIndex = 4;
            this.lbl_tempo.Text = "0 segundos";
            // 
            // frm_ganhar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.lbl_tempoGasto);
            this.Controls.Add(this.brn_rank);
            this.Controls.Add(this.btn_jogarNovamente);
            this.Controls.Add(this.lbl_vcGanhou);
            this.Name = "frm_ganhar";
            this.Text = "frm_ganhar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vcGanhou;
        private System.Windows.Forms.Button btn_jogarNovamente;
        private System.Windows.Forms.Button brn_rank;
        private System.Windows.Forms.Label lbl_tempoGasto;
        private System.Windows.Forms.Label lbl_tempo;
    }
}