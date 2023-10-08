namespace OrdenesTrabajoApp
{
    partial class Agregar
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
            label1 = new Label();
            tbDescripcion = new TextBox();
            label2 = new Label();
            cbxEstado = new ComboBox();
            label3 = new Label();
            datePickerCreacion = new DateTimePicker();
            label4 = new Label();
            datePickerResolucion = new DateTimePicker();
            label5 = new Label();
            cbxPrioridad = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            tbInformador = new TextBox();
            tbResponsable = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            label1.Click += label1_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(167, 12);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(483, 27);
            tbDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 105);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Pendiente", "En Progreso", "Finalizado" });
            cbxEstado.Location = new Point(167, 97);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(197, 28);
            cbxEstado.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 56);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha Creacion";
            // 
            // datePickerCreacion
            // 
            datePickerCreacion.Location = new Point(167, 51);
            datePickerCreacion.Name = "datePickerCreacion";
            datePickerCreacion.Size = new Size(250, 27);
            datePickerCreacion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 152);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha Resolucion";
            label4.Click += label4_Click;
            // 
            // datePickerResolucion
            // 
            datePickerResolucion.Location = new Point(167, 147);
            datePickerResolucion.Name = "datePickerResolucion";
            datePickerResolucion.Size = new Size(250, 27);
            datePickerResolucion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 193);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 8;
            label5.Text = "Prioridad";
            // 
            // cbxPrioridad
            // 
            cbxPrioridad.FormattingEnabled = true;
            cbxPrioridad.Items.AddRange(new object[] { "Baja", "Media", "Alta" });
            cbxPrioridad.Location = new Point(167, 190);
            cbxPrioridad.Name = "cbxPrioridad";
            cbxPrioridad.Size = new Size(151, 28);
            cbxPrioridad.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 241);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 10;
            label6.Text = "Informador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 284);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 11;
            label7.Text = "Responsable";
            // 
            // tbInformador
            // 
            tbInformador.Location = new Point(167, 241);
            tbInformador.Name = "tbInformador";
            tbInformador.Size = new Size(483, 27);
            tbInformador.TabIndex = 12;
            // 
            // tbResponsable
            // 
            tbResponsable.Location = new Point(167, 281);
            tbResponsable.Name = "tbResponsable";
            tbResponsable.Size = new Size(483, 27);
            tbResponsable.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(509, 331);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 29);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 383);
            Controls.Add(btnAgregar);
            Controls.Add(tbResponsable);
            Controls.Add(tbInformador);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbxPrioridad);
            Controls.Add(label5);
            Controls.Add(datePickerResolucion);
            Controls.Add(label4);
            Controls.Add(datePickerCreacion);
            Controls.Add(label3);
            Controls.Add(cbxEstado);
            Controls.Add(label2);
            Controls.Add(tbDescripcion);
            Controls.Add(label1);
            Name = "Agregar";
            Text = "AddOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDescripcion;
        private Label label2;
        private ComboBox cbxEstado;
        private Label label3;
        private DateTimePicker datePickerCreacion;
        private Label label4;
        private DateTimePicker datePickerResolucion;
        private Label label5;
        private ComboBox cbxPrioridad;
        private Label label6;
        private Label label7;
        private TextBox tbInformador;
        private TextBox tbResponsable;
        private Button btnAgregar;
    }
}