namespace ConnectingDb
    {
    partial class Form1
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
            this.cmbPueblo = new System.Windows.Forms.ComboBox();
            this.lblPueblo = new System.Windows.Forms.Label();
            this.lblProfesores = new System.Windows.Forms.Label();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.listViewProfesores = new System.Windows.Forms.ListView();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPueblo
            // 
            this.cmbPueblo.FormattingEnabled = true;
            this.cmbPueblo.Location = new System.Drawing.Point(59, 10);
            this.cmbPueblo.Name = "cmbPueblo";
            this.cmbPueblo.Size = new System.Drawing.Size(121, 21);
            this.cmbPueblo.TabIndex = 0;
            this.cmbPueblo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPueblo_SelectedIndexChanged);
            // 
            // lblPueblo
            // 
            this.lblPueblo.AutoSize = true;
            this.lblPueblo.Location = new System.Drawing.Point(13, 13);
            this.lblPueblo.Name = "lblPueblo";
            this.lblPueblo.Size = new System.Drawing.Size(40, 13);
            this.lblPueblo.TabIndex = 1;
            this.lblPueblo.Text = "Pueblo";
            // 
            // lblProfesores
            // 
            this.lblProfesores.AutoSize = true;
            this.lblProfesores.Location = new System.Drawing.Point(13, 42);
            this.lblProfesores.Name = "lblProfesores";
            this.lblProfesores.Size = new System.Drawing.Size(57, 13);
            this.lblProfesores.TabIndex = 2;
            this.lblProfesores.Text = "Profesores";
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Location = new System.Drawing.Point(9, 220);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(62, 13);
            this.lblEstudiantes.TabIndex = 3;
            this.lblEstudiantes.Text = "Estudiantes";
            // 
            // listViewProfesores
            // 
            this.listViewProfesores.HideSelection = false;
            this.listViewProfesores.Location = new System.Drawing.Point(12, 59);
            this.listViewProfesores.Name = "listViewProfesores";
            this.listViewProfesores.Size = new System.Drawing.Size(366, 148);
            this.listViewProfesores.TabIndex = 4;
            this.listViewProfesores.UseCompatibleStateImageBehavior = false;
            this.listViewProfesores.SelectedIndexChanged += new System.EventHandler(this.listViewProfesores_SelectedIndexChanged);
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(12, 236);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(370, 156);
            this.listViewEstudiantes.TabIndex = 5;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.SelectedIndexChanged += new System.EventHandler(this.listViewEstudiantes_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(222, 8);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(303, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.listViewProfesores);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.lblProfesores);
            this.Controls.Add(this.lblPueblo);
            this.Controls.Add(this.cmbPueblo);
            this.Name = "Form1";
            this.Text = "Información sobre Estudiantes y Profesores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.ComboBox cmbPueblo;
        private System.Windows.Forms.Label lblPueblo;
        private System.Windows.Forms.Label lblProfesores;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.ListView listViewProfesores;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnLimpiar;
        }
    }

