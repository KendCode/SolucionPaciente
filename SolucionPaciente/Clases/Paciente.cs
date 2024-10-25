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
	/// Description of Paciente.
	/// </summary>
	public class Paciente:Persona
	{
		private DateTime fecha;
		private RevisonMedica RM = new RevisonMedica();
		public Paciente():base()
		{
		}
		public DateTime Fecha{
			get{return fecha;}
			set{fecha=value;}
		}
		public RevisonMedica REVMED{
			get{return RM;}
			set{RM=value;}
		}
		//b)codigo RM
		public string GeneraCod(){
			return apellido.Substring(0,1).ToUpper()+
				nombre.Substring(0,1).ToUpper()+ci;
		}
		//c) Laboratorio , Radiografia
		public void LabRad(string sintoma){
			if(sintoma.Equals("Mareo")){
				REVMED.DIAG.Labo = "SI";
				REVMED.DIAG.Radiog = "NO";
			}
			else if(sintoma.Equals("Dolor")){
				REVMED.DIAG.Labo = "NO";
				REVMED.DIAG.Radiog = "SI";
			}
			else{
				REVMED.DIAG.Labo = "SI";
				REVMED.DIAG.Radiog = "SI";
			}
		}
		//d) Unidades
		public int CalPrecio(string med){
			switch(med){
				case "Paracetamol":
					return REVMED.DIAG.RESMED.Unidades=10;
				case "Dexametasona":
					return REVMED.DIAG.RESMED.Unidades=15;
				case "Eutirox":
					return REVMED.DIAG.RESMED.Unidades=20;
				case "Offidal":
					return REVMED.DIAG.RESMED.Unidades=30;
				default:
					return 0;
			}
		}
	}
}
