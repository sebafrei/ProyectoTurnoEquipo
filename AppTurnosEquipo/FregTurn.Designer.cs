/*
 * Creado por SharpDevelop.
 * Usuario: Franc
 * Fecha: 12/10/2021
 * Hora: 16:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace AppTurnosEquipo
{
	partial class FregTurn
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdnControl;
		private System.Windows.Forms.RadioButton rdnReceta;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cmbHora;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.RadioButton rdnConsulta;
		private System.Windows.Forms.Button btnVolver;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdnControl = new System.Windows.Forms.RadioButton();
			this.rdnReceta = new System.Windows.Forms.RadioButton();
			this.rdnConsulta = new System.Windows.Forms.RadioButton();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmbHora = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "APELLIDO:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(110, 33);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(155, 20);
			this.txtApellido.TabIndex = 2;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(110, 64);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(155, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbSexo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(303, 160);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Paciente";
			// 
			// cmbSexo
			// 
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
			"MASCULINO",
			"FEMENINO",
			"OTRO"});
			this.cmbSexo.Location = new System.Drawing.Point(110, 102);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(155, 21);
			this.cmbSexo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "SEXO:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdnControl);
			this.groupBox2.Controls.Add(this.rdnReceta);
			this.groupBox2.Controls.Add(this.rdnConsulta);
			this.groupBox2.Location = new System.Drawing.Point(12, 178);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 134);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Motivo";
			// 
			// rdnControl
			// 
			this.rdnControl.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdnControl.Location = new System.Drawing.Point(19, 86);
			this.rdnControl.Name = "rdnControl";
			this.rdnControl.Size = new System.Drawing.Size(104, 24);
			this.rdnControl.TabIndex = 6;
			this.rdnControl.TabStop = true;
			this.rdnControl.Text = "Control";
			this.rdnControl.UseVisualStyleBackColor = true;
			this.rdnControl.CheckedChanged += new System.EventHandler(this.RdnControlCheckedChanged);
			// 
			// rdnReceta
			// 
			this.rdnReceta.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdnReceta.Location = new System.Drawing.Point(19, 56);
			this.rdnReceta.Name = "rdnReceta";
			this.rdnReceta.Size = new System.Drawing.Size(104, 24);
			this.rdnReceta.TabIndex = 7;
			this.rdnReceta.TabStop = true;
			this.rdnReceta.Text = "Receta";
			this.rdnReceta.UseVisualStyleBackColor = true;
			this.rdnReceta.CheckedChanged += new System.EventHandler(this.RdnRecetaCheckedChanged);
			// 
			// rdnConsulta
			// 
			this.rdnConsulta.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdnConsulta.Location = new System.Drawing.Point(19, 26);
			this.rdnConsulta.Name = "rdnConsulta";
			this.rdnConsulta.Size = new System.Drawing.Size(104, 24);
			this.rdnConsulta.TabIndex = 0;
			this.rdnConsulta.TabStop = true;
			this.rdnConsulta.Text = "Consulta";
			this.rdnConsulta.UseVisualStyleBackColor = true;
			this.rdnConsulta.CheckedChanged += new System.EventHandler(this.RdnConsultaCheckedChanged);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(6, 26);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 6;
			// 
			// cmbHora
			// 
			this.cmbHora.FormattingEnabled = true;
			this.cmbHora.Items.AddRange(new object[] {
			"7:00",
			"7:30",
			"8:00",
			"8:30",
			"9:00",
			"9:30",
			"10:00",
			"10:30",
			"11:00",
			"11:30",
			"12:00",
			"15:00",
			"15:30",
			"16:00",
			"16:30",
			"17:00",
			"17:30",
			"18:00"});
			this.cmbHora.Location = new System.Drawing.Point(6, 57);
			this.cmbHora.Name = "cmbHora";
			this.cmbHora.Size = new System.Drawing.Size(121, 21);
			this.cmbHora.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dtpFecha);
			this.groupBox3.Controls.Add(this.cmbHora);
			this.groupBox3.Location = new System.Drawing.Point(321, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(222, 126);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Fecha y Hora";
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.GhostWhite;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(368, 201);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(175, 33);
			this.btnAceptar.TabIndex = 9;
			this.btnAceptar.Text = "REGISTRAR";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.GhostWhite;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(368, 240);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(175, 33);
			this.btnLimpiar.TabIndex = 10;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.GhostWhite;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.Location = new System.Drawing.Point(368, 279);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(175, 33);
			this.btnVolver.TabIndex = 11;
			this.btnVolver.Text = "VOLVER";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// FregTurn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(562, 339);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "FregTurn";
			this.Text = "Registrar Turnos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
