using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AppTurnosEquipo
{
	
	public partial class FregMedico : Form
	{
		public FregMedico()
		{
			
			InitializeComponent();
			
		
		}
		void BtnRegistrarMClick(object sender, EventArgs e)
		{
			TextWriter EscribirM = File.AppendText("RegistroMedicos.txt");
			EscribirM.WriteLine(txtApellidoM.Text +","+ txtNombreM.Text +","+ cmbEspecialidadM.SelectedItem);
			
			EscribirM.Close();
			MessageBox.Show("Registro exitoso","Informacion",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			txtNombreM.Clear();
			txtApellidoM.Clear();
			cmbEspecialidadM.ResetText();
		}
		void BtnLimpiarMClick(object sender, EventArgs e)
		{
			txtNombreM.Clear();
			txtApellidoM.Clear();
			cmbEspecialidadM.ResetText();
		}
		void BtnVolverMClick(object sender, EventArgs e)
		{
			MainForm FormularioInicio = new MainForm();
			FormularioInicio.Show();
			this.Close();
		}
	}
}
