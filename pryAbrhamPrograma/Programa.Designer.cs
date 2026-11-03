namespace pryAbrhamPrograma
{
    partial class Programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            lblNombre = new Label();
            lblApellido = new Label();
            lblMail = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtNroTelefono = new TextBox();
            gpbCliente = new GroupBox();
            txtApellido = new TextBox();
            gpbEquipo = new GroupBox();
            lblDescripcionFalla = new Label();
            txtFalla = new TextBox();
            lblFalla = new Label();
            lblNroSerie = new Label();
            txtNroSerie = new TextBox();
            lblTipo = new Label();
            cboFalla = new ComboBox();
            cboTipo = new ComboBox();
            gpbTicket = new GroupBox();
            lblDescripcion = new Label();
            lblPresupuesto = new Label();
            lblNroTicket = new Label();
            txtDescripcion = new TextBox();
            txtPresupuesto = new TextBox();
            txtNroTicket = new TextBox();
            btnRegistrar = new Button();
            gpbCliente.SuspendLayout();
            gpbEquipo.SuspendLayout();
            gpbTicket.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(22, 73);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(174, 30);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(108, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "Correo Electronico:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(174, 73);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(95, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Nro de Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(79, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(288, 27);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(124, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtNroTelefono
            // 
            txtNroTelefono.Location = new Point(288, 70);
            txtNroTelefono.Name = "txtNroTelefono";
            txtNroTelefono.Size = new Size(124, 23);
            txtNroTelefono.TabIndex = 6;
            txtNroTelefono.KeyPress += txtNroTelefono_KeyPress;
            // 
            // gpbCliente
            // 
            gpbCliente.BackColor = Color.SlateGray;
            gpbCliente.Controls.Add(txtApellido);
            gpbCliente.Controls.Add(txtCorreo);
            gpbCliente.Controls.Add(txtNroTelefono);
            gpbCliente.Controls.Add(lblApellido);
            gpbCliente.Controls.Add(lblNombre);
            gpbCliente.Controls.Add(lblMail);
            gpbCliente.Controls.Add(txtNombre);
            gpbCliente.Controls.Add(lblTelefono);
            gpbCliente.Location = new Point(12, 12);
            gpbCliente.Name = "gpbCliente";
            gpbCliente.Size = new Size(488, 119);
            gpbCliente.TabIndex = 7;
            gpbCliente.TabStop = false;
            gpbCliente.Text = "Cliente";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(82, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(79, 23);
            txtApellido.TabIndex = 8;
            // 
            // gpbEquipo
            // 
            gpbEquipo.BackColor = SystemColors.ActiveBorder;
            gpbEquipo.Controls.Add(lblDescripcionFalla);
            gpbEquipo.Controls.Add(txtFalla);
            gpbEquipo.Controls.Add(lblFalla);
            gpbEquipo.Controls.Add(lblNroSerie);
            gpbEquipo.Controls.Add(txtNroSerie);
            gpbEquipo.Controls.Add(lblTipo);
            gpbEquipo.Controls.Add(cboFalla);
            gpbEquipo.Controls.Add(cboTipo);
            gpbEquipo.Location = new Point(12, 137);
            gpbEquipo.Name = "gpbEquipo";
            gpbEquipo.Size = new Size(488, 142);
            gpbEquipo.TabIndex = 8;
            gpbEquipo.TabStop = false;
            gpbEquipo.Text = "Equipo";
            // 
            // lblDescripcionFalla
            // 
            lblDescripcionFalla.AutoSize = true;
            lblDescripcionFalla.Location = new Point(285, 56);
            lblDescripcionFalla.Name = "lblDescripcionFalla";
            lblDescripcionFalla.Size = new Size(127, 15);
            lblDescripcionFalla.TabIndex = 7;
            lblDescripcionFalla.Text = "( descripcion del fallo )";
            // 
            // txtFalla
            // 
            txtFalla.Location = new Point(288, 74);
            txtFalla.Multiline = true;
            txtFalla.Name = "txtFalla";
            txtFalla.Size = new Size(121, 57);
            txtFalla.TabIndex = 6;
            // 
            // lblFalla
            // 
            lblFalla.AutoSize = true;
            lblFalla.Location = new Point(235, 33);
            lblFalla.Name = "lblFalla";
            lblFalla.Size = new Size(34, 15);
            lblFalla.TabIndex = 5;
            lblFalla.Text = "Falla:";
            // 
            // lblNroSerie
            // 
            lblNroSerie.AutoSize = true;
            lblNroSerie.Location = new Point(29, 68);
            lblNroSerie.Name = "lblNroSerie";
            lblNroSerie.Size = new Size(97, 15);
            lblNroSerie.TabIndex = 4;
            lblNroSerie.Text = "Número de serie:";
            // 
            // txtNroSerie
            // 
            txtNroSerie.Location = new Point(132, 65);
            txtNroSerie.Name = "txtNroSerie";
            txtNroSerie.Size = new Size(71, 23);
            txtNroSerie.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(29, 30);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";
            // 
            // cboFalla
            // 
            cboFalla.FormattingEnabled = true;
            cboFalla.Items.AddRange(new object[] { "No enciende", "Pantalla", "Disco", "Virus", "Otro" });
            cboFalla.Location = new Point(288, 30);
            cboFalla.Name = "cboFalla";
            cboFalla.Size = new Size(121, 23);
            cboFalla.TabIndex = 2;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Pc", "Notebook" });
            cboTipo.Location = new Point(82, 27);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 0;
            // 
            // gpbTicket
            // 
            gpbTicket.BackColor = Color.SlateGray;
            gpbTicket.Controls.Add(lblDescripcion);
            gpbTicket.Controls.Add(lblPresupuesto);
            gpbTicket.Controls.Add(lblNroTicket);
            gpbTicket.Controls.Add(txtDescripcion);
            gpbTicket.Controls.Add(txtPresupuesto);
            gpbTicket.Controls.Add(txtNroTicket);
            gpbTicket.Location = new Point(12, 285);
            gpbTicket.Name = "gpbTicket";
            gpbTicket.Size = new Size(488, 162);
            gpbTicket.TabIndex = 10;
            gpbTicket.TabStop = false;
            gpbTicket.Text = "Ticket";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(234, 31);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(140, 15);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripcion/Diagnostico:";
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Location = new Point(19, 94);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(84, 15);
            lblPresupuesto.TabIndex = 4;
            lblPresupuesto.Text = "Presupuesto $:";
            // 
            // lblNroTicket
            // 
            lblNroTicket.AutoSize = true;
            lblNroTicket.Location = new Point(19, 48);
            lblNroTicket.Name = "lblNroTicket";
            lblNroTicket.Size = new Size(81, 15);
            lblNroTicket.TabIndex = 3;
            lblNroTicket.Text = "Nro de Ticket:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(234, 49);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(233, 98);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TextChanged += textBox6_TextChanged;
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Location = new Point(103, 91);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(100, 23);
            txtPresupuesto.TabIndex = 1;
            // 
            // txtNroTicket
            // 
            txtNroTicket.Location = new Point(103, 47);
            txtNroTicket.Name = "txtNroTicket";
            txtNroTicket.ReadOnly = true;
            txtNroTicket.Size = new Size(100, 23);
            txtNroTicket.TabIndex = 0;
            txtNroTicket.Text = "126";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(396, 453);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(101, 33);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Programa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(509, 493);
            Controls.Add(btnRegistrar);
            Controls.Add(gpbEquipo);
            Controls.Add(gpbTicket);
            Controls.Add(gpbCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Programa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PC-BACKUP - Servicio Técnico";
            Load += Programa_Load;
            gpbCliente.ResumeLayout(false);
            gpbCliente.PerformLayout();
            gpbEquipo.ResumeLayout(false);
            gpbEquipo.PerformLayout();
            gpbTicket.ResumeLayout(false);
            gpbTicket.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblMail;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtNroTelefono;
        private GroupBox gpbCliente;
        private TextBox txtApellido;
        private GroupBox gpbEquipo;
        private Label lblFalla;
        private Label lblNroSerie;
        private Label lblTipo;
        private ComboBox cboFalla;
        private ComboBox cboTipo;
        private TextBox txtNroSerie;
        private GroupBox gpbTicket;
        private Label lblPresupuesto;
        private Label lblNroTicket;
        private TextBox txtDescripcion;
        private TextBox txtPresupuesto;
        private TextBox txtNroTicket;
        private Label lblDescripcion;
        private TextBox txtFalla;
        private Button btnRegistrar;
        private Label lblDescripcionFalla;
    }
}