/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 1/10/2024
 * Hora: 08:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SolucionPaciente
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int n = 1;
		public MainForm()
		{
			InitializeComponent();
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			Limpiar();
			btnAgregar.Enabled = true;
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			Clases.Paciente Pa = new Clases.Paciente();
			Pa.Nombre = txtNombre.Text;
			Pa.Apellido = txtApellido.Text;
			Pa.CI = int.Parse(txtCi.Text);
			Pa.Fecha = dtpFecha.Value;
			if(rbtMasc.Checked)
				Pa.Genero = 'M';
			else
				Pa.Genero = 'F';
			//codigo
			Pa.REVMED.Codigo = Pa.GeneraCod();
			//sintoma
			Pa.REVMED.DIAG.Sintomas = cbbxSintoma.SelectedItem.ToString();
			Pa.LabRad(Pa.REVMED.DIAG.Sintomas);
			
			//unidades
			Pa.REVMED.DIAG.RESMED.NomMed = lbxMed.SelectedItem.ToString();
			Pa.REVMED.DIAG.RESMED.Unidades = Pa.CalPrecio(Pa.REVMED.DIAG.RESMED.NomMed);
			
			//agregamos a la tabla
			dgvPacientes.Rows.Add(n,Pa.Nombre,Pa.Apellido,Pa.CI, Pa.Fecha,Pa.Genero, Pa.REVMED.Codigo,
			                      Pa.REVMED.DIAG.Sintomas,Pa.REVMED.DIAG.Labo,Pa.REVMED.DIAG.Radiog,
			                      Pa.REVMED.DIAG.RESMED.NomMed, Pa.REVMED.DIAG.RESMED.Unidades);
			n++;
			Limpiar();
			
		}
		void Limpiar(){
			txtNombre.Clear();
			txtApellido.Clear();
			txtCi.Clear();
			rbtFem.Checked = false;
			rbtMasc.Checked = false;
			cbbxSintoma.SelectedIndex = -1;
			lbxMed.SelectedIndex = -1;
			txtNombre.Focus();
			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
		}
	}
}
