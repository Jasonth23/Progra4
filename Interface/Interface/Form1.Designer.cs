namespace Interface
{
    partial class frmInvocarWcf
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMensj1 = new System.Windows.Forms.TextBox();
            this.tbMensj2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbSalida2 = new System.Windows.Forms.TextBox();
            this.tbSalida1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensaje1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensaje2";
            // 
            // tbMensj1
            // 
            this.tbMensj1.Location = new System.Drawing.Point(83, 25);
            this.tbMensj1.Name = "tbMensj1";
            this.tbMensj1.Size = new System.Drawing.Size(100, 20);
            this.tbMensj1.TabIndex = 2;
            // 
            // tbMensj2
            // 
            this.tbMensj2.Location = new System.Drawing.Point(83, 69);
            this.tbMensj2.Name = "tbMensj2";
            this.tbMensj2.Size = new System.Drawing.Size(100, 20);
            this.tbMensj2.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(83, 139);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbSalida2
            // 
            this.tbSalida2.Location = new System.Drawing.Point(83, 247);
            this.tbSalida2.Name = "tbSalida2";
            this.tbSalida2.Size = new System.Drawing.Size(100, 20);
            this.tbSalida2.TabIndex = 8;
            // 
            // tbSalida1
            // 
            this.tbSalida1.Location = new System.Drawing.Point(83, 203);
            this.tbSalida1.Name = "tbSalida1";
            this.tbSalida1.Size = new System.Drawing.Size(100, 20);
            this.tbSalida1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "salida2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "salida1";
            // 
            // frmInvocarWcf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 328);
            this.Controls.Add(this.tbSalida2);
            this.Controls.Add(this.tbSalida1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbMensj2);
            this.Controls.Add(this.tbMensj1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInvocarWcf";
            this.Text = "Invocacion de interfaces WCF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMensj1;
        private System.Windows.Forms.TextBox tbMensj2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbSalida2;
        private System.Windows.Forms.TextBox tbSalida1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

