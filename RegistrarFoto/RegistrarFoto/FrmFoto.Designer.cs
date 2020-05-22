namespace RegistrarFoto
{
    partial class FrmFoto
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
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cboDispositivo = new System.Windows.Forms.ComboBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(12, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(389, 363);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // cboDispositivo
            // 
            this.cboDispositivo.FormattingEnabled = true;
            this.cboDispositivo.Location = new System.Drawing.Point(12, 421);
            this.cboDispositivo.Name = "cboDispositivo";
            this.cboDispositivo.Size = new System.Drawing.Size(389, 21);
            this.cboDispositivo.TabIndex = 1;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(12, 381);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(389, 34);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // FrmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 452);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.cboDispositivo);
            this.Controls.Add(this.picFoto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Imagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFoto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cboDispositivo;
        private System.Windows.Forms.Button btnCapturar;
    }
}

