namespace Login
{
    partial class AltaPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboBoxCarreras = new System.Windows.Forms.ComboBox();
            this.grilla1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(131, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(215, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(215, 155);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(71, 20);
            this.txtFechaNac.TabIndex = 6;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Dìa, Mes, Año)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carrera";
            // 
            // cmboBoxCarreras
            // 
            this.cmboBoxCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxCarreras.FormattingEnabled = true;
            this.cmboBoxCarreras.Location = new System.Drawing.Point(214, 192);
            this.cmboBoxCarreras.Name = "cmboBoxCarreras";
            this.cmboBoxCarreras.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxCarreras.TabIndex = 9;
            this.cmboBoxCarreras.SelectedIndexChanged += new System.EventHandler(this.cmboBoxCarreras_SelectedIndexChanged);
            // 
            // grilla1
            // 
            this.grilla1.AllowUserToAddRows = false;
            this.grilla1.AllowUserToDeleteRows = false;
            this.grilla1.AllowUserToResizeColumns = false;
            this.grilla1.AllowUserToResizeRows = false;
            this.grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.fecha_Nacimiento,
            this.carrera});
            this.grilla1.Location = new System.Drawing.Point(430, 37);
            this.grilla1.Name = "grilla1";
            this.grilla1.Size = new System.Drawing.Size(408, 221);
            this.grilla1.TabIndex = 10;
            this.grilla1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // fecha_Nacimiento
            // 
            this.fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.fecha_Nacimiento.Name = "fecha_Nacimiento";
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Carrera";
            this.carrera.Name = "carrera";
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(247, 235);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPersona.TabIndex = 11;
            this.btnAgregarPersona.Text = "Agregar";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 541);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.grilla1);
            this.Controls.Add(this.cmboBoxCarreras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Name = "AltaPersona";
            this.Text = "AltaPersona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboBoxCarreras;
        private System.Windows.Forms.DataGridView grilla1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.Button btnAgregarPersona;
    }
}