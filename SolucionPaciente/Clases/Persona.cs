/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 25/9/2024
 * Hora: 08:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace SolucionPaciente.Clases
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected int ci;
		protected string nombre;
		protected string apellido;
		protected char genero;
		public Persona()
		{
		}
		public int CI{
			get{return ci;}
			set{ci=value;}
		}
		public string Nombre{
			get{return nombre;}
			set{nombre=value;}
		}
		public string Apellido{
			get{return apellido;}
			set{apellido=value;}
		}
		public char Genero{
			get{return genero;}
			set{genero=value;}
		}
	}
}
