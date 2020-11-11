namespace Proyecto_Matematicas
{
    partial class Funciones
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
            this.btn_grafica = new System.Windows.Forms.Button();
            this.pic_grafica = new System.Windows.Forms.PictureBox();
            this.txt_funcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_grafica
            // 
            this.btn_grafica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_grafica.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grafica.Location = new System.Drawing.Point(287, 832);
            this.btn_grafica.Name = "btn_grafica";
            this.btn_grafica.Size = new System.Drawing.Size(135, 70);
            this.btn_grafica.TabIndex = 0;
            this.btn_grafica.Text = "Graficar";
            this.btn_grafica.UseVisualStyleBackColor = true;
            this.btn_grafica.Click += new System.EventHandler(this.btn_grafica_Click);
            // 
            // pic_grafica
            // 
            this.pic_grafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_grafica.BackColor = System.Drawing.Color.White;
            this.pic_grafica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_grafica.Location = new System.Drawing.Point(428, 2);
            this.pic_grafica.Name = "pic_grafica";
            this.pic_grafica.Size = new System.Drawing.Size(900, 900);
            this.pic_grafica.TabIndex = 1;
            this.pic_grafica.TabStop = false;
            this.pic_grafica.Click += new System.EventHandler(this.pic_grafica_Click);
            // 
            // txt_funcion
            // 
            this.txt_funcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcion.Location = new System.Drawing.Point(12, 738);
            this.txt_funcion.Name = "txt_funcion";
            this.txt_funcion.Size = new System.Drawing.Size(298, 31);
            this.txt_funcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 705);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Funcion:";
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1340, 905);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_funcion);
            this.Controls.Add(this.pic_grafica);
            this.Controls.Add(this.btn_grafica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funciones";
            this.Text = "Funciones";
            this.Load += new System.EventHandler(this.Funciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_grafica;
        private System.Windows.Forms.PictureBox pic_grafica;
        private System.Windows.Forms.TextBox txt_funcion;
        private System.Windows.Forms.Label label1;
    }
}