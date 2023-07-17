namespace Mediator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnviarUser1 = new System.Windows.Forms.Button();
            this.EnviarUser2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstMensajesU1 = new System.Windows.Forms.ListBox();
            this.lstMensajesU2 = new System.Windows.Forms.ListBox();
            this.lstRoom = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De Usuario 1 a Usuario 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 1;
            // 
            // EnviarUser1
            // 
            this.EnviarUser1.Location = new System.Drawing.Point(15, 111);
            this.EnviarUser1.Name = "EnviarUser1";
            this.EnviarUser1.Size = new System.Drawing.Size(75, 23);
            this.EnviarUser1.TabIndex = 2;
            this.EnviarUser1.Text = "Enviar";
            this.EnviarUser1.UseVisualStyleBackColor = true;
            this.EnviarUser1.Click += new System.EventHandler(this.EnviarUser1_Click);
            // 
            // EnviarUser2
            // 
            this.EnviarUser2.Location = new System.Drawing.Point(1031, 111);
            this.EnviarUser2.Name = "EnviarUser2";
            this.EnviarUser2.Size = new System.Drawing.Size(75, 23);
            this.EnviarUser2.TabIndex = 7;
            this.EnviarUser2.Text = "Enviar";
            this.EnviarUser2.UseVisualStyleBackColor = true;
            this.EnviarUser2.Click += new System.EventHandler(this.EnviarUser2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1031, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 20);
            this.textBox5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1028, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "De Usuario 2 a Usuario 1";
            // 
            // lstMensajesU1
            // 
            this.lstMensajesU1.FormattingEnabled = true;
            this.lstMensajesU1.Location = new System.Drawing.Point(15, 162);
            this.lstMensajesU1.Name = "lstMensajesU1";
            this.lstMensajesU1.Size = new System.Drawing.Size(382, 277);
            this.lstMensajesU1.TabIndex = 8;
            // 
            // lstMensajesU2
            // 
            this.lstMensajesU2.FormattingEnabled = true;
            this.lstMensajesU2.Location = new System.Drawing.Point(1031, 161);
            this.lstMensajesU2.Name = "lstMensajesU2";
            this.lstMensajesU2.Size = new System.Drawing.Size(382, 277);
            this.lstMensajesU2.TabIndex = 9;
            // 
            // lstRoom
            // 
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.Location = new System.Drawing.Point(473, 9);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(491, 433);
            this.lstRoom.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 450);
            this.Controls.Add(this.lstRoom);
            this.Controls.Add(this.lstMensajesU2);
            this.Controls.Add(this.lstMensajesU1);
            this.Controls.Add(this.EnviarUser2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnviarUser1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EnviarUser1;
        private System.Windows.Forms.Button EnviarUser2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstMensajesU1;
        private System.Windows.Forms.ListBox lstMensajesU2;
        private System.Windows.Forms.ListBox lstRoom;
    }
}

