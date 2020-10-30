namespace Proyecto_Matematicas
{
    partial class Matrices
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
            this.Matriz_principal = new System.Windows.Forms.DataGridView();
            this.Coor_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coor_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_rotar = new System.Windows.Forms.Button();
            this.btn_escalar = new System.Windows.Forms.Button();
            this.Matriz_resultado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Matriz_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matriz_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // Matriz_principal
            // 
            this.Matriz_principal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Matriz_principal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Matriz_principal.ColumnHeadersHeight = 45;
            this.Matriz_principal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coor_X,
            this.Coor_Y});
            this.Matriz_principal.Location = new System.Drawing.Point(23, 55);
            this.Matriz_principal.Name = "Matriz_principal";
            this.Matriz_principal.Size = new System.Drawing.Size(268, 289);
            this.Matriz_principal.TabIndex = 0;
            // 
            // Coor_X
            // 
            this.Coor_X.HeaderText = "Coordenadas en X";
            this.Coor_X.Name = "Coor_X";
            // 
            // Coor_Y
            // 
            this.Coor_Y.HeaderText = "Coordenadas en Y";
            this.Coor_Y.Name = "Coor_Y";
            // 
            // button1
            // 
            this.button1.AccessibleName = "Add__rows";
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button1.Location = new System.Drawing.Point(23, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Delete_rows";
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button2.Location = new System.Drawing.Point(172, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "Add__rows";
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(213, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_rotar
            // 
            this.btn_rotar.AccessibleName = "Add__rows";
            this.btn_rotar.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btn_rotar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_rotar.Location = new System.Drawing.Point(118, 526);
            this.btn_rotar.Name = "btn_rotar";
            this.btn_rotar.Size = new System.Drawing.Size(89, 23);
            this.btn_rotar.TabIndex = 4;
            this.btn_rotar.Text = "Rotar";
            this.btn_rotar.UseVisualStyleBackColor = true;
            this.btn_rotar.Click += new System.EventHandler(this.btn_rotar_Click);
            // 
            // btn_escalar
            // 
            this.btn_escalar.AccessibleName = "Add__rows";
            this.btn_escalar.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btn_escalar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_escalar.Location = new System.Drawing.Point(23, 526);
            this.btn_escalar.Name = "btn_escalar";
            this.btn_escalar.Size = new System.Drawing.Size(89, 23);
            this.btn_escalar.TabIndex = 5;
            this.btn_escalar.Text = "Escalar";
            this.btn_escalar.UseVisualStyleBackColor = true;
            this.btn_escalar.Click += new System.EventHandler(this.btn_escalar_Click);
            // 
            // Matriz_resultado
            // 
            this.Matriz_resultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Matriz_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Matriz_resultado.ColumnHeadersHeight = 45;
            this.Matriz_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Matriz_resultado.Location = new System.Drawing.Point(572, 55);
            this.Matriz_resultado.Name = "Matriz_resultado";
            this.Matriz_resultado.Size = new System.Drawing.Size(268, 289);
            this.Matriz_resultado.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Coordenadas en X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Coordenadas en Y";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1043, 595);
            this.Controls.Add(this.Matriz_resultado);
            this.Controls.Add(this.btn_escalar);
            this.Controls.Add(this.btn_rotar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Matriz_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Matrices";
            this.Text = "Matrices";
            this.Load += new System.EventHandler(this.Matrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Matriz_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matriz_resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Matriz_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coor_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coor_Y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_rotar;
        private System.Windows.Forms.Button btn_escalar;
        private System.Windows.Forms.DataGridView Matriz_resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}