/*
 * Creado por SharpDevelop.
 * Usuario: Franc
 * Fecha: 12/10/2021
 * Hora: 16:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace AppTurnosEquipo
{
	partial class FregMedico
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbEspecialidadM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombreM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnVolverM;
		private System.Windows.Forms.Button btnLimpiarM;
		private System.Windows.Forms.Button btnRegistrarM;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbEspecialidadM = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnVolverM = new System.Windows.Forms.Button();
			this.btnLimpiarM = new System.Windows.Forms.Button();
			this.btnRegistrarM = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbEspecialidadM);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtApellidoM);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNombreM);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(325, 160);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Médico";
			// 
			// cmbEspecialidadM
			// 
			this.cmbEspecialidadM.FormattingEnabled = true;
			this.cmbEspecialidadM.Items.AddRange(new object[] {
			"Dermatologo",
			"Clinico",
			"Cardiologo",
			"Pediatra",
			"Traumatologo"});
			this.cmbEspecialidadM.Location = new System.Drawing.Point(122, 102);
			this.cmbEspecialidadM.Name = "cmbEspecialidadM";
			this.cmbEspecialidadM.Size = new System.Drawing.Size(155, 21);
			this.cmbEspecialidadM.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "ESPECIALIDAD";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Location = new System.Drawing.Point(122, 33);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(155, 20);
			this.txtApellidoM.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "APELLIDO:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombreM
			// 
			this.txtNombreM.Location = new System.Drawing.Point(122, 64);
			this.txtNombreM.Name = "txtNombreM";
			this.txtNombreM.Size = new System.Drawing.Size(155, 20);
			this.txtNombreM.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnVolverM
			// 
			this.btnVolverM.BackColor = System.Drawing.Color.GhostWhite;
			this.btnVolverM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolverM.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolverM.Location = new System.Drawing.Point(364, 139);
			this.btnVolverM.Name = "btnVolverM";
			this.btnVolverM.Size = new System.Drawing.Size(175, 33);
			this.btnVolverM.TabIndex = 14;
			this.btnVolverM.Text = "VOLVER";
			this.btnVolverM.UseVisualStyleBackColor = false;
			this.btnVolverM.Click += new System.EventHandler(this.BtnVolverMClick);
			// 
			// btnLimpiarM
			// 
			this.btnLimpiarM.BackColor = System.Drawing.Color.GhostWhite;
			this.btnLimpiarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiarM.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiarM.Location = new System.Drawing.Point(364, 76);
			this.btnLimpiarM.Name = "btnLimpiarM";
			this.btnLimpiarM.Size = new System.Drawing.Size(175, 33);
			this.btnLimpiarM.TabIndex = 13;
			this.btnLimpiarM.Text = "LIMPIAR";
			this.btnLimpiarM.UseVisualStyleBackColor = false;
			this.btnLimpiarM.Click += new System.EventHandler(this.BtnLimpiarMClick);
			// 
			// btnRegistrarM
			// 
			this.btnRegistrarM.BackColor = System.Drawing.Color.GhostWhite;
			this.btnRegistrarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarM.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarM.Location = new System.Drawing.Point(364, 12);
			this.btnRegistrarM.Name = "btnRegistrarM";
			this.btnRegistrarM.Size = new System.Drawing.Size(175, 33);
			this.btnRegistrarM.TabIndex = 12;
			this.btnRegistrarM.Text = "REGISTRAR";
			this.btnRegistrarM.UseVisualStyleBackColor = false;
			this.btnRegistrarM.Click += new System.EventHandler(this.BtnRegistrarMClick);
			// 
			// FregMedico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(568, 203);
			this.Controls.Add(this.btnVolverM);
			this.Controls.Add(this.btnLimpiarM);
			this.Controls.Add(this.btnRegistrarM);
			this.Controls.Add(this.groupBox1);
			this.Name = "FregMedico";
			this.Text = "Registro de Médicos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
