namespace SimulacroParcial1
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
            this.comboBoxEstudiantes = new System.Windows.Forms.ComboBox();
            this.comboBoxTalleres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTalleres = new System.Windows.Forms.DataGridView();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewInscripciones = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalleres)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEstudiantes
            // 
            this.comboBoxEstudiantes.FormattingEnabled = true;
            this.comboBoxEstudiantes.Location = new System.Drawing.Point(99, 42);
            this.comboBoxEstudiantes.Name = "comboBoxEstudiantes";
            this.comboBoxEstudiantes.Size = new System.Drawing.Size(275, 24);
            this.comboBoxEstudiantes.TabIndex = 0;
            // 
            // comboBoxTalleres
            // 
            this.comboBoxTalleres.FormattingEnabled = true;
            this.comboBoxTalleres.Location = new System.Drawing.Point(99, 81);
            this.comboBoxTalleres.Name = "comboBoxTalleres";
            this.comboBoxTalleres.Size = new System.Drawing.Size(275, 24);
            this.comboBoxTalleres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taller:";
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(412, 9);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.RowHeadersWidth = 51;
            this.dataGridViewEstudiantes.RowTemplate.Height = 24;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(402, 207);
            this.dataGridViewEstudiantes.TabIndex = 4;
            // 
            // dataGridViewTalleres
            // 
            this.dataGridViewTalleres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTalleres.Location = new System.Drawing.Point(415, 232);
            this.dataGridViewTalleres.Name = "dataGridViewTalleres";
            this.dataGridViewTalleres.RowHeadersWidth = 51;
            this.dataGridViewTalleres.RowTemplate.Height = 24;
            this.dataGridViewTalleres.Size = new System.Drawing.Size(402, 207);
            this.dataGridViewTalleres.TabIndex = 5;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(164, 143);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(75, 23);
            this.btnInscribir.TabIndex = 6;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 471);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxEstudiantes);
            this.tabPage1.Controls.Add(this.dataGridViewTalleres);
            this.tabPage1.Controls.Add(this.btnInscribir);
            this.tabPage1.Controls.Add(this.dataGridViewEstudiantes);
            this.tabPage1.Controls.Add(this.comboBoxTalleres);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inscripcion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOrdenar);
            this.tabPage2.Controls.Add(this.btnReporte);
            this.tabPage2.Controls.Add(this.dataGridViewInscripciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInscripciones
            // 
            this.dataGridViewInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscripciones.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewInscripciones.Name = "dataGridViewInscripciones";
            this.dataGridViewInscripciones.RowHeadersWidth = 51;
            this.dataGridViewInscripciones.RowTemplate.Height = 24;
            this.dataGridViewInscripciones.Size = new System.Drawing.Size(808, 270);
            this.dataGridViewInscripciones.TabIndex = 0;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(343, 331);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(444, 331);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inscripcion Alumnos a Taller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalleres)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstudiantes;
        private System.Windows.Forms.ComboBox comboBoxTalleres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.DataGridView dataGridViewTalleres;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewInscripciones;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

