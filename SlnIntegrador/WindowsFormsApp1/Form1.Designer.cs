namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.medicosEspecialidad = new System.Windows.Forms.ListBox();
            this.btn_medicoEspecialidad = new System.Windows.Forms.Button();
            this.estadoHabitaciones = new System.Windows.Forms.ListBox();
            this.btn_estadoHabitaciones = new System.Windows.Forms.Button();
            this.lbl_cantMedicos = new System.Windows.Forms.Label();
            this.btn_mostrarTodos = new System.Windows.Forms.Button();
            this.btn_mostrarEspecialidad = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_traerUno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(45, 49);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.RowHeadersWidth = 51;
            this.gridMedicos.RowTemplate.Height = 24;
            this.gridMedicos.Size = new System.Drawing.Size(712, 149);
            this.gridMedicos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Médicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de Pacientes";
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(45, 264);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.RowHeadersWidth = 51;
            this.gridPacientes.RowTemplate.Height = 24;
            this.gridPacientes.Size = new System.Drawing.Size(712, 149);
            this.gridPacientes.TabIndex = 3;
            // 
            // medicosEspecialidad
            // 
            this.medicosEspecialidad.FormattingEnabled = true;
            this.medicosEspecialidad.ItemHeight = 16;
            this.medicosEspecialidad.Location = new System.Drawing.Point(860, 79);
            this.medicosEspecialidad.Name = "medicosEspecialidad";
            this.medicosEspecialidad.Size = new System.Drawing.Size(227, 84);
            this.medicosEspecialidad.TabIndex = 4;
            // 
            // btn_medicoEspecialidad
            // 
            this.btn_medicoEspecialidad.Location = new System.Drawing.Point(884, 169);
            this.btn_medicoEspecialidad.Name = "btn_medicoEspecialidad";
            this.btn_medicoEspecialidad.Size = new System.Drawing.Size(167, 33);
            this.btn_medicoEspecialidad.TabIndex = 5;
            this.btn_medicoEspecialidad.Text = "Ver Médicos Clínicos";
            this.btn_medicoEspecialidad.UseVisualStyleBackColor = true;
            this.btn_medicoEspecialidad.Click += new System.EventHandler(this.btn_medicoEspecialidad_Click);
            // 
            // estadoHabitaciones
            // 
            this.estadoHabitaciones.FormattingEnabled = true;
            this.estadoHabitaciones.ItemHeight = 16;
            this.estadoHabitaciones.Location = new System.Drawing.Point(860, 264);
            this.estadoHabitaciones.Name = "estadoHabitaciones";
            this.estadoHabitaciones.Size = new System.Drawing.Size(227, 100);
            this.estadoHabitaciones.TabIndex = 6;
            // 
            // btn_estadoHabitaciones
            // 
            this.btn_estadoHabitaciones.Location = new System.Drawing.Point(884, 370);
            this.btn_estadoHabitaciones.Name = "btn_estadoHabitaciones";
            this.btn_estadoHabitaciones.Size = new System.Drawing.Size(167, 45);
            this.btn_estadoHabitaciones.TabIndex = 7;
            this.btn_estadoHabitaciones.Text = "Ver Estado de Habitaciones";
            this.btn_estadoHabitaciones.UseVisualStyleBackColor = true;
            this.btn_estadoHabitaciones.Click += new System.EventHandler(this.btn_estadoHabitaciones_Click);
            // 
            // lbl_cantMedicos
            // 
            this.lbl_cantMedicos.AutoSize = true;
            this.lbl_cantMedicos.Location = new System.Drawing.Point(860, 49);
            this.lbl_cantMedicos.Name = "lbl_cantMedicos";
            this.lbl_cantMedicos.Size = new System.Drawing.Size(0, 16);
            this.lbl_cantMedicos.TabIndex = 8;
            // 
            // btn_mostrarTodos
            // 
            this.btn_mostrarTodos.Location = new System.Drawing.Point(48, 495);
            this.btn_mostrarTodos.Name = "btn_mostrarTodos";
            this.btn_mostrarTodos.Size = new System.Drawing.Size(118, 56);
            this.btn_mostrarTodos.TabIndex = 9;
            this.btn_mostrarTodos.Text = "Mostrar todos los médicos";
            this.btn_mostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btn_mostrarEspecialidad
            // 
            this.btn_mostrarEspecialidad.Location = new System.Drawing.Point(189, 495);
            this.btn_mostrarEspecialidad.Name = "btn_mostrarEspecialidad";
            this.btn_mostrarEspecialidad.Size = new System.Drawing.Size(118, 56);
            this.btn_mostrarEspecialidad.TabIndex = 10;
            this.btn_mostrarEspecialidad.Text = "Mostrar médicos por especialidad";
            this.btn_mostrarEspecialidad.UseVisualStyleBackColor = true;

            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(339, 495);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(118, 56);
            this.btn_Insertar.TabIndex = 11;
            this.btn_Insertar.Text = "Insertar médico";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(492, 495);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(118, 56);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar médico";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_traerUno
            // 
            this.btn_traerUno.Location = new System.Drawing.Point(640, 495);
            this.btn_traerUno.Name = "btn_traerUno";
            this.btn_traerUno.Size = new System.Drawing.Size(118, 56);
            this.btn_traerUno.TabIndex = 13;
            this.btn_traerUno.Text = "Traer uno por ID";
            this.btn_traerUno.UseVisualStyleBackColor = true;
            this.btn_traerUno.Click += new System.EventHandler(this.btn_traerUno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Inserte ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 456);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 601);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_traerUno);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.btn_mostrarEspecialidad);
            this.Controls.Add(this.btn_mostrarTodos);
            this.Controls.Add(this.lbl_cantMedicos);
            this.Controls.Add(this.btn_estadoHabitaciones);
            this.Controls.Add(this.estadoHabitaciones);
            this.Controls.Add(this.btn_medicoEspecialidad);
            this.Controls.Add(this.medicosEspecialidad);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.ListBox medicosEspecialidad;
        private System.Windows.Forms.Button btn_medicoEspecialidad;
        private System.Windows.Forms.ListBox estadoHabitaciones;
        private System.Windows.Forms.Button btn_estadoHabitaciones;
        private System.Windows.Forms.Label lbl_cantMedicos;
        private System.Windows.Forms.Button btn_mostrarTodos;
        private System.Windows.Forms.Button btn_mostrarEspecialidad;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_traerUno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
    }
}

