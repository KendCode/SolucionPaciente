/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 25/9/2024
 * Hora: 08:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace SolucionPaciente.Clases
{
	/// <summary>
	/// Description of RevisonMedica.
	/// </summary>
	public class RevisonMedica
	{
		private string codigo;
		private Diagnostico DG = new Diagnostico();
		public RevisonMedica()
		{
		}
		public string Codigo{
			get{return codigo;}
			set{codigo=value;}
		}
		public Diagnostico DIAG{
			get{return DG;}
			set{DG=value;}
		}
	}
}
