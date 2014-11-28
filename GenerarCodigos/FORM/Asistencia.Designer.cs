namespace GenerarCodigos.FORM
{
    partial class Asistencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.asistencia_button = new System.Windows.Forms.Button();
            this.codigo_textbox = new System.Windows.Forms.TextBox();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.grado_textbox = new System.Windows.Forms.TextBox();
            this.catecismo_textbox = new System.Windows.Forms.TextBox();
            this.por_nombre_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 92);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(394, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(359, 29);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor escoge la fecha que deseas realizar el pase de lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Catecismo";
            // 
            // asistencia_button
            // 
            this.asistencia_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asistencia_button.Location = new System.Drawing.Point(12, 362);
            this.asistencia_button.Name = "asistencia_button";
            this.asistencia_button.Size = new System.Drawing.Size(177, 45);
            this.asistencia_button.TabIndex = 3;
            this.asistencia_button.Text = "Asistencia";
            this.asistencia_button.UseVisualStyleBackColor = true;
            this.asistencia_button.Click += new System.EventHandler(this.asistencia_button_Click);
            // 
            // codigo_textbox
            // 
            this.codigo_textbox.Enabled = false;
            this.codigo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_textbox.Location = new System.Drawing.Point(116, 127);
            this.codigo_textbox.Name = "codigo_textbox";
            this.codigo_textbox.Size = new System.Drawing.Size(378, 29);
            this.codigo_textbox.TabIndex = 10;
            this.codigo_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_textbox_KeyPress);
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nombre_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.nombre_textbox.Enabled = false;
            this.nombre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_textbox.Location = new System.Drawing.Point(116, 181);
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(378, 29);
            this.nombre_textbox.TabIndex = 11;
            // 
            // grado_textbox
            // 
            this.grado_textbox.Enabled = false;
            this.grado_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grado_textbox.Location = new System.Drawing.Point(116, 245);
            this.grado_textbox.Name = "grado_textbox";
            this.grado_textbox.Size = new System.Drawing.Size(125, 29);
            this.grado_textbox.TabIndex = 12;
            // 
            // catecismo_textbox
            // 
            this.catecismo_textbox.Enabled = false;
            this.catecismo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catecismo_textbox.Location = new System.Drawing.Point(116, 298);
            this.catecismo_textbox.Name = "catecismo_textbox";
            this.catecismo_textbox.Size = new System.Drawing.Size(363, 29);
            this.catecismo_textbox.TabIndex = 13;
            // 
            // por_nombre_button
            // 
            this.por_nombre_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.por_nombre_button.Location = new System.Drawing.Point(521, 174);
            this.por_nombre_button.Name = "por_nombre_button";
            this.por_nombre_button.Size = new System.Drawing.Size(177, 45);
            this.por_nombre_button.TabIndex = 14;
            this.por_nombre_button.Text = "Por nombre";
            this.por_nombre_button.UseVisualStyleBackColor = true;
            this.por_nombre_button.Click += new System.EventHandler(this.por_nombre_button_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 505);
            this.Controls.Add(this.por_nombre_button);
            this.Controls.Add(this.catecismo_textbox);
            this.Controls.Add(this.grado_textbox);
            this.Controls.Add(this.nombre_textbox);
            this.Controls.Add(this.codigo_textbox);
            this.Controls.Add(this.asistencia_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button asistencia_button;
        private System.Windows.Forms.TextBox codigo_textbox;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.TextBox grado_textbox;
        private System.Windows.Forms.TextBox catecismo_textbox;
        private System.Windows.Forms.Button por_nombre_button;
    }
}