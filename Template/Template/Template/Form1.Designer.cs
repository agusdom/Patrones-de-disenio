namespace Template
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
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboCreditos = new System.Windows.Forms.ComboBox();
            this.cmd_Solicitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creditos Disponibles:";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(26, 250);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(582, 151);
            this.resultado.TabIndex = 2;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(26, 62);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(320, 21);
            this.cboClientes.TabIndex = 3;
            // 
            // cboCreditos
            // 
            this.cboCreditos.FormattingEnabled = true;
            this.cboCreditos.Location = new System.Drawing.Point(26, 156);
            this.cboCreditos.Name = "cboCreditos";
            this.cboCreditos.Size = new System.Drawing.Size(320, 21);
            this.cboCreditos.TabIndex = 4;
            // 
            // cmd_Solicitar
            // 
            this.cmd_Solicitar.Location = new System.Drawing.Point(26, 210);
            this.cmd_Solicitar.Name = "cmd_Solicitar";
            this.cmd_Solicitar.Size = new System.Drawing.Size(132, 23);
            this.cmd_Solicitar.TabIndex = 5;
            this.cmd_Solicitar.Text = "Solicitar";
            this.cmd_Solicitar.UseVisualStyleBackColor = true;
            this.cmd_Solicitar.Click += new System.EventHandler(this.cmd_Solicitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 439);
            this.Controls.Add(this.cmd_Solicitar);
            this.Controls.Add(this.cboCreditos);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.ComboBox cboCreditos;
        private System.Windows.Forms.Button cmd_Solicitar;
    }
}

