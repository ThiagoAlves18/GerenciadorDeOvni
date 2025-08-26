namespace GerenciadorDeOvni
{
    partial class Gerenciador
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
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblPlanetaAt = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbAddTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAddTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAdicionarAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnMudarDePlaneta = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.pibTerra = new System.Windows.Forms.PictureBox();
            this.grbInformacoes.SuspendLayout();
            this.grbAddTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblPlanetaAt);
            this.grbInformacoes.Controls.Add(this.btnOff);
            this.grbInformacoes.Controls.Add(this.btnOn);
            this.grbInformacoes.Controls.Add(this.lblAbduzidos);
            this.grbInformacoes.Controls.Add(this.lblTripulantes);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.Location = new System.Drawing.Point(3, 18);
            this.grbInformacoes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbInformacoes.Size = new System.Drawing.Size(333, 348);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblPlanetaAt
            // 
            this.lblPlanetaAt.AutoSize = true;
            this.lblPlanetaAt.Location = new System.Drawing.Point(10, 150);
            this.lblPlanetaAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlanetaAt.Name = "lblPlanetaAt";
            this.lblPlanetaAt.Size = new System.Drawing.Size(110, 19);
            this.lblPlanetaAt.TabIndex = 5;
            this.lblPlanetaAt.Text = "Planeta Atual";
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(14, 298);
            this.btnOff.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(309, 33);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(14, 239);
            this.btnOn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(309, 33);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(10, 119);
            this.lblAbduzidos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(93, 19);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(6, 83);
            this.lblTripulantes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(97, 19);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(10, 49);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(78, 19);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbAddTripulantes
            // 
            this.grbAddTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbAddTripulantes.Controls.Add(this.btnAddTripulantes);
            this.grbAddTripulantes.Location = new System.Drawing.Point(3, 397);
            this.grbAddTripulantes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbAddTripulantes.Name = "grbAddTripulantes";
            this.grbAddTripulantes.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbAddTripulantes.Size = new System.Drawing.Size(333, 134);
            this.grbAddTripulantes.TabIndex = 5;
            this.grbAddTripulantes.TabStop = false;
            this.grbAddTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(10, 76);
            this.btnRemoverTripulantes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(313, 36);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAddTripulantes
            // 
            this.btnAddTripulantes.Location = new System.Drawing.Point(10, 27);
            this.btnAddTripulantes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddTripulantes.Name = "btnAddTripulantes";
            this.btnAddTripulantes.Size = new System.Drawing.Size(313, 39);
            this.btnAddTripulantes.TabIndex = 0;
            this.btnAddTripulantes.Text = "Add";
            this.btnAddTripulantes.UseVisualStyleBackColor = true;
            this.btnAddTripulantes.Click += new System.EventHandler(this.btnAddTripulantes_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAdicionarAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(347, 397);
            this.grbAbduzidos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbAbduzidos.Size = new System.Drawing.Size(333, 134);
            this.grbAbduzidos.TabIndex = 6;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(10, 76);
            this.btnRemoverAbduzidos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(313, 36);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzidos.Click += new System.EventHandler(this.btnRemoverAbduzidos_Click);
            // 
            // btnAdicionarAbduzidos
            // 
            this.btnAdicionarAbduzidos.Location = new System.Drawing.Point(10, 27);
            this.btnAdicionarAbduzidos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdicionarAbduzidos.Name = "btnAdicionarAbduzidos";
            this.btnAdicionarAbduzidos.Size = new System.Drawing.Size(313, 39);
            this.btnAdicionarAbduzidos.TabIndex = 0;
            this.btnAdicionarAbduzidos.Text = "Add";
            this.btnAdicionarAbduzidos.UseVisualStyleBackColor = true;
            this.btnAdicionarAbduzidos.Click += new System.EventHandler(this.btnAdicionarAbduzidos_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.pibTerra);
            this.grbPlaneta.Controls.Add(this.btnMudarDePlaneta);
            this.grbPlaneta.Controls.Add(this.btnRetornar);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(357, 18);
            this.grbPlaneta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grbPlaneta.Size = new System.Drawing.Size(333, 348);
            this.grbPlaneta.TabIndex = 7;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // btnMudarDePlaneta
            // 
            this.btnMudarDePlaneta.Location = new System.Drawing.Point(44, 83);
            this.btnMudarDePlaneta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMudarDePlaneta.Name = "btnMudarDePlaneta";
            this.btnMudarDePlaneta.Size = new System.Drawing.Size(247, 38);
            this.btnMudarDePlaneta.TabIndex = 8;
            this.btnMudarDePlaneta.Text = "Mudar de Planeta";
            this.btnMudarDePlaneta.UseVisualStyleBackColor = true;
            this.btnMudarDePlaneta.Click += new System.EventHandler(this.btnMudarDePlaneta_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(44, 150);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(247, 33);
            this.btnRetornar.TabIndex = 9;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(10, 27);
            this.cmbPlanetas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(311, 27);
            this.cmbPlanetas.TabIndex = 8;
            // 
            // pibTerra
            // 
            this.pibTerra.Image = global::GerenciadorDeOvni.Properties.Resources.Captura_de_tela_2025_08_26_194832;
            this.pibTerra.Location = new System.Drawing.Point(27, 184);
            this.pibTerra.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pibTerra.Name = "pibTerra";
            this.pibTerra.Size = new System.Drawing.Size(287, 154);
            this.pibTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTerra.TabIndex = 8;
            this.pibTerra.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(693, 558);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbAddTripulantes);
            this.Controls.Add(this.grbInformacoes);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbAddTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.GroupBox grbAddTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAddTripulantes;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAdicionarAbduzidos;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnMudarDePlaneta;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Label lblPlanetaAt;
        private System.Windows.Forms.PictureBox pibTerra;
    }
}