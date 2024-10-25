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
	/// Description of Diagnostico.
	/// </summary>
	public class Diagnostico
	{
		private string sintomas;
		private string labo;
		private string radio;
		private ResetaMedica RM=new ResetaMedica();
		public Diagnostico()
		{
		}
		public string Sintomas{
			get{return sintomas;}
			set{sintomas=value;}
		}
		public string Labo{
			get{return labo;}
			set{labo=value;}
		}
		public string Radiog{
			get{return radio;}
			set{radio=value;}
		}
		public ResetaMedica RESMED{
			get{return RM;}
			set{RM=value;}
		}
	}
}
