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
	/// Description of ResetaMedica.
	/// </summary>
	public class ResetaMedica
	{
		private string nomMed;
		private int unidades;
		public ResetaMedica()
		{
		}
		public string NomMed{
			get{return nomMed;}
			set{nomMed=value;}
		}
		public int Unidades{
			get{return unidades;}
			set{unidades=value;}
		}
	}
}
