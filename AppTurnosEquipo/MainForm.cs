using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AppTurnosEquipo
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
			
		}
		
		
		void ToolStripLabel1Click(object sender, EventArgs e)
		{
			FregTurn registroTurnos = new FregTurn();
			
			registroTurnos.Show();
			this.Hide();
		}
		void ToolStripLabel2Click(object sender, EventArgs e)
		{
			FlistaTurn listaTurnos = new FlistaTurn();
			listaTurnos.Show();
		}
		void ToolStripLabel3Click(object sender, EventArgs e)
		{
			FregMedico registroMedicos= new FregMedico();
			registroMedicos.Show();
			this.Hide();
		}
		void ToolStripLabel4Click(object sender, EventArgs e)
		{
			FlistaMedicos listaMedicos = new FlistaMedicos();
			listaMedicos.Show();
		}
		void ToolStripLabel5Click(object sender, EventArgs e)
		{
			FhistoPaci historialPacientes = new FhistoPaci();
			historialPacientes.Show();
		}
		void ToolStripLabel6Click(object sender, EventArgs e)
		{
			FturnDispo turnosDisponibles = new FturnDispo();
			turnosDisponibles.Show();
		}
		
	}
}
