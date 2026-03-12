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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalleres)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEstudiantes
            // 
            this.comboBoxEstudiantes.FormattingEnabled = true;
            this.comboBoxEstudiantes.Location = new System.Drawing.Point(91, 18);
            this.comboBoxEstudiantes.Name = "comboBoxEstudiantes";
            this.comboBoxEstudiantes.Size = new System.Drawing.Size(275, 24);
            this.comboBoxEstudiantes.TabIndex = 0;
            // 
            // comboBoxTalleres
            // 
            this.comboBoxTalleres.FormattingEnabled = true;
            this.comboBoxTalleres.Location = new System.Drawing.Point(91, 57);
            this.comboBoxTalleres.Name = "comboBoxTalleres";
            this.comboBoxTalleres.Size = new System.Drawing.Size(275, 24);
            this.comboBoxTalleres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taller:";
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(386, 18);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.RowHeadersWidth = 51;
            this.dataGridViewEstudiantes.RowTemplate.Height = 24;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(402, 207);
            this.dataGridViewEstudiantes.TabIndex = 4;
            // 
            // dataGridViewTalleres
            // 
            this.dataGridViewTalleres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTalleres.Location = new System.Drawing.Point(386, 231);
            this.dataGridViewTalleres.Name = "dataGridViewTalleres";
            this.dataGridViewTalleres.RowHeadersWidth = 51;
            this.dataGridViewTalleres.RowTemplate.Height = 24;
            this.dataGridViewTalleres.Size = new System.Drawing.Size(402, 207);
            this.dataGridViewTalleres.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTalleres);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTalleres);
            this.Controls.Add(this.comboBoxEstudiantes);
            this.Name = "Form1";
            this.Text = "Inscripcion Alumnos a Taller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalleres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstudiantes;
        private System.Windows.Forms.ComboBox comboBoxTalleres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.DataGridView dataGridViewTalleres;
    }
}

