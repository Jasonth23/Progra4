namespace Ejemplos.Enumerables
{
    partial class frmEstrucEnum
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
            this.tbAgregar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbSalida = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.chbAgreg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto a agregar";
            // 
            // tbAgregar
            // 
            this.tbAgregar.Location = new System.Drawing.Point(148, 24);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Size = new System.Drawing.Size(100, 20);
            this.tbAgregar.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(74, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // cbSalida
            // 
            this.cbSalida.FormattingEnabled = true;
            this.cbSalida.Location = new System.Drawing.Point(370, 131);
            this.cbSalida.Name = "cbSalida";
            this.cbSalida.Size = new System.Drawing.Size(121, 21);
            this.cbSalida.TabIndex = 3;
            this.cbSalida.SelectedIndexChanged += new System.EventHandler(this.cbSalida_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(349, 224);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(489, 224);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar Combo";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(416, 278);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(117, 23);
            this.btnLista.TabIndex = 6;
            this.btnLista.Text = "Refrescar Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbAgreg
            // 
            this.chbAgreg.AutoSize = true;
            this.chbAgreg.Location = new System.Drawing.Point(123, 79);
            this.chbAgreg.Name = "chbAgreg";
            this.chbAgreg.Size = new System.Drawing.Size(84, 17);
            this.chbAgreg.TabIndex = 7;
            this.chbAgreg.Text = "agregar final";
            this.chbAgreg.UseVisualStyleBackColor = true;
            // 
            // frmEstrucEnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbAgreg);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbSalida);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbAgregar);
            this.Controls.Add(this.label1);
            this.Name = "frmEstrucEnum";
            this.Text = "Estructuras Enumeradores";
            this.Load += new System.EventHandler(this.frmEstrucEnum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbSalida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.CheckBox chbAgreg;
    }
}

