
namespace sla
{
    partial class frm_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_nomeUsuario = new System.Windows.Forms.TextBox();
            this.lbl_digiteNome = new System.Windows.Forms.Label();
            this.btn_comecar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_informacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            resources.ApplyResources(this.lbl_titulo, "lbl_titulo");
            this.lbl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Name = "lbl_titulo";
            // 
            // txt_nomeUsuario
            // 
            resources.ApplyResources(this.txt_nomeUsuario, "txt_nomeUsuario");
            this.txt_nomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.txt_nomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nomeUsuario.Name = "txt_nomeUsuario";
            // 
            // lbl_digiteNome
            // 
            resources.ApplyResources(this.lbl_digiteNome, "lbl_digiteNome");
            this.lbl_digiteNome.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_digiteNome.Name = "lbl_digiteNome";
            // 
            // btn_comecar
            // 
            resources.ApplyResources(this.btn_comecar, "btn_comecar");
            this.btn_comecar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.btn_comecar.FlatAppearance.BorderSize = 0;
            this.btn_comecar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_comecar.Name = "btn_comecar";
            this.btn_comecar.UseVisualStyleBackColor = false;
            this.btn_comecar.Click += new System.EventHandler(this.btn_comecar_Click);
            // 
            // btn_sair
            // 
            resources.ApplyResources(this.btn_sair, "btn_sair");
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // btn_informacoes
            // 
            resources.ApplyResources(this.btn_informacoes, "btn_informacoes");
            this.btn_informacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(174)))));
            this.btn_informacoes.FlatAppearance.BorderSize = 0;
            this.btn_informacoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_informacoes.Name = "btn_informacoes";
            this.btn_informacoes.UseVisualStyleBackColor = false;
            this.btn_informacoes.Click += new System.EventHandler(this.btn_informacoes_Click);
            // 
            // frm_inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.btn_informacoes);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_comecar);
            this.Controls.Add(this.lbl_digiteNome);
            this.Controls.Add(this.txt_nomeUsuario);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "frm_inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_nomeUsuario;
        private System.Windows.Forms.Label lbl_digiteNome;
        private System.Windows.Forms.Button btn_comecar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_informacoes;
    }
}