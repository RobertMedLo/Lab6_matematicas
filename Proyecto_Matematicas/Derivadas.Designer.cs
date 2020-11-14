namespace Proyecto_Matematicas
{
    partial class Derivadas
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
            this.txt_funcion = new System.Windows.Forms.TextBox();
            this.txt_parametro = new System.Windows.Forms.TextBox();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_funcion
            // 
            this.txt_funcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcion.Location = new System.Drawing.Point(109, 104);
            this.txt_funcion.Name = "txt_funcion";
            this.txt_funcion.Size = new System.Drawing.Size(215, 31);
            this.txt_funcion.TabIndex = 0;
            // 
            // txt_parametro
            // 
            this.txt_parametro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parametro.Location = new System.Drawing.Point(109, 189);
            this.txt_parametro.Name = "txt_parametro";
            this.txt_parametro.Size = new System.Drawing.Size(87, 31);
            this.txt_parametro.TabIndex = 1;
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuesta.Location = new System.Drawing.Point(109, 311);
            this.txt_respuesta.Multiline = true;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(428, 57);
            this.txt_respuesta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Funcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor evaluado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // btn_calculo
            // 
            this.btn_calculo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculo.Location = new System.Drawing.Point(113, 411);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(165, 60);
            this.btn_calculo.TabIndex = 6;
            this.btn_calculo.Text = "Calcular";
            this.btn_calculo.UseVisualStyleBackColor = true;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            // 
            // Derivadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1163, 632);
            this.Controls.Add(this.btn_calculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.txt_parametro);
            this.Controls.Add(this.txt_funcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Derivadas";
            this.Text = "Derivadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_funcion;
        private System.Windows.Forms.TextBox txt_parametro;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calculo;
    }
}