
namespace JoKenPo
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pedra = new System.Windows.Forms.RadioButton();
            papel = new System.Windows.Forms.RadioButton();
            tesoura = new System.Windows.Forms.RadioButton();
            enviar = new System.Windows.Forms.Button();
            player = new System.Windows.Forms.Label();
            IA = new System.Windows.Forms.Label();
            resul = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(110, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 36);
            label1.TabIndex = 0;
            label1.Text = "Jokenpô";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(74, 84);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(186, 23);
            label2.TabIndex = 1;
            label2.Text = "Faça Sua Escolha";
            // 
            // pedra
            // 
            pedra.AutoSize = true;
            pedra.Location = new System.Drawing.Point(74, 143);
            pedra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pedra.Name = "pedra";
            pedra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            pedra.Size = new System.Drawing.Size(86, 27);
            pedra.TabIndex = 2;
            pedra.TabStop = true;
            pedra.Text = "Pedra";
            pedra.UseVisualStyleBackColor = true;
            // 
            // papel
            // 
            papel.AutoSize = true;
            papel.Location = new System.Drawing.Point(74, 202);
            papel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            papel.Name = "papel";
            papel.Size = new System.Drawing.Size(86, 27);
            papel.TabIndex = 3;
            papel.TabStop = true;
            papel.Text = "Papel";
            papel.UseVisualStyleBackColor = true;
            // 
            // tesoura
            // 
            tesoura.AutoSize = true;
            tesoura.Location = new System.Drawing.Point(74, 257);
            tesoura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tesoura.Name = "tesoura";
            tesoura.Size = new System.Drawing.Size(108, 27);
            tesoura.TabIndex = 4;
            tesoura.TabStop = true;
            tesoura.Text = "Tesoura";
            tesoura.UseVisualStyleBackColor = true;
            // 
            // enviar
            // 
            enviar.Location = new System.Drawing.Point(108, 341);
            enviar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            enviar.Name = "enviar";
            enviar.Size = new System.Drawing.Size(129, 33);
            enviar.TabIndex = 5;
            enviar.Text = "Enviar";
            enviar.UseVisualStyleBackColor = true;
            // 
            // player
            // 
            player.AutoSize = true;
            player.Location = new System.Drawing.Point(27, 422);
            player.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            player.Name = "player";
            player.Size = new System.Drawing.Size(98, 23);
            player.TabIndex = 6;
            player.Text = "Jogador:";
            // 
            // IA
            // 
            IA.AutoSize = true;
            IA.Location = new System.Drawing.Point(45, 463);
            IA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IA.Name = "IA";
            IA.Size = new System.Drawing.Size(43, 23);
            IA.TabIndex = 7;
            IA.Text = "IA:";
            // 
            // resul
            // 
            resul.AutoSize = true;
            resul.Location = new System.Drawing.Point(212, 448);
            resul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resul.Name = "resul";
            resul.Size = new System.Drawing.Size(109, 23);
            resul.TabIndex = 8;
            resul.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(389, 535);
            Controls.Add(resul);
            Controls.Add(IA);
            Controls.Add(player);
            Controls.Add(enviar);
            Controls.Add(tesoura);
            Controls.Add(papel);
            Controls.Add(pedra);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton pedra;
        private System.Windows.Forms.RadioButton papel;
        private System.Windows.Forms.RadioButton tesoura;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label IA;
        private System.Windows.Forms.Label resul;
    }
}

