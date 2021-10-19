using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace AppTurnosEquipo
{
	
	public partial class FregTurn : Form
	{
		public FregTurn()
		{
			
			InitializeComponent();
			
			
		}
		string radioselected;
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			TextWriter Escribir = File.AppendText("RegistroPacientes.txt");
			Escribir.WriteLine(txtApellido.Text + "," + txtNombre.Text + "," + cmbSexo.SelectedItem +
			                   "," + radioselected + "," + dtpFecha.Value.ToString("dd/MM/yyyy") + "," + cmbHora.SelectedItem);
			
			Escribir.Close();
			
			MessageBox.Show("Registro exitoso","Informacion",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			limpiar();
			
		}
		void RdnConsultaCheckedChanged(object sender, EventArgs e)
		{
			radioselected = "Consulta";
		}
		void RdnRecetaCheckedChanged(object sender, EventArgs e)
		{
			radioselected = "Receta";
		}
		void RdnControlCheckedChanged(object sender, EventArgs e)
		{
			radioselected = "Control";
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			limpiar();
		}
		
		void limpiar(){
		
		txtApellido.Clear();
			txtNombre.Clear();
			rdnConsulta.Checked=false;
			rdnControl.Checked=false;
			rdnReceta.Checked=false;
			cmbSexo.ResetText();
			cmbHora.ResetText();
		
		}
		void BtnVolverClick(object sender, EventArgs e)
		{
			MainForm FormularioInicio = new MainForm();
			FormularioInicio.Show();
			this.Close();
		}
		
	}
}
