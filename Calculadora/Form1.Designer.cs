namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnSeis = new Button();
            btnQuatro = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnCinco = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnIgual = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.GradientInactiveCaption;
            txtResultado.Location = new Point(12, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(258, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            btnSete.BackColor = SystemColors.GradientActiveCaption;
            btnSete.Location = new Point(28, 115);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(56, 53);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = SystemColors.GradientActiveCaption;
            btnOito.Location = new Point(90, 115);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(56, 53);
            btnOito.TabIndex = 2;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = SystemColors.GradientActiveCaption;
            btnNove.Location = new Point(152, 115);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(56, 53);
            btnNove.TabIndex = 3;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.GradientActiveCaption;
            btnSeis.Location = new Point(152, 181);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(56, 53);
            btnSeis.TabIndex = 4;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = SystemColors.GradientActiveCaption;
            btnQuatro.Location = new Point(28, 181);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(56, 53);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = SystemColors.GradientActiveCaption;
            btnUm.Location = new Point(28, 240);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(56, 53);
            btnUm.TabIndex = 6;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = SystemColors.GradientActiveCaption;
            btnDois.Location = new Point(90, 240);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(56, 53);
            btnDois.TabIndex = 7;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.GradientActiveCaption;
            btnTres.Location = new Point(152, 240);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(56, 53);
            btnTres.TabIndex = 8;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.GradientActiveCaption;
            btnCinco.Location = new Point(90, 181);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(56, 53);
            btnCinco.TabIndex = 9;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.GradientActiveCaption;
            btnZero.Location = new Point(90, 299);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(56, 53);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = SystemColors.GradientActiveCaption;
            btnVirgula.Location = new Point(28, 299);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(56, 53);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = SystemColors.GradientActiveCaption;
            btnDivisao.Location = new Point(214, 115);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(56, 53);
            btnDivisao.TabIndex = 12;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = SystemColors.GradientActiveCaption;
            btnMultiplicacao.Location = new Point(214, 181);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(56, 53);
            btnMultiplicacao.TabIndex = 13;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.GradientActiveCaption;
            btnIgual.Location = new Point(152, 299);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(56, 53);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = SystemColors.GradientActiveCaption;
            btnAdicao.Location = new Point(214, 240);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(56, 53);
            btnAdicao.TabIndex = 15;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = SystemColors.GradientActiveCaption;
            btnSubtracao.Location = new Point(214, 299);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(56, 53);
            btnSubtracao.TabIndex = 16;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.GradientActiveCaption;
            btnLimpar.Location = new Point(214, 56);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 53);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(289, 380);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btnIgual);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnCinco);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnQuatro);
            Controls.Add(btnSeis);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnSeis;
        private Button btnQuatro;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnCinco;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnIgual;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnLimpar;
        private Label label1;
    }
}
