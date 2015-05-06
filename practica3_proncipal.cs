using System;
using System.Collections;
namespace Practica3
{
	class MainClass
	{
		public static void agregarAlumno(string nombre,string codigo, Hashtable tabla,int contador){
			try{
					Alumno a = new Alumno(nombre, codigo);
					tabla.Add(codigo,a);
			}catch(ArgumentException){contador--; Console.WriteLine("codigo ya dado de alta [NO se COMPLETO la accione]\n");}
		}
		
		public static void mostrar(Hashtable tabla){
					
					ICollection key = tabla.Keys;
					foreach (string k in key){
						Object obj = tabla[k];
						Alumno alum = (Alumno) obj;
						Console.WriteLine(alum.getDatos());
         			}
		}
		
		public static void eliminar (string codigo, Hashtable tabla){
			if(tabla.ContainsKey(codigo)){
						tabla.Remove(codigo);
						Console.WriteLine("alumno con el codigo:"+codigo+"removido");
					}
					else
						Console.WriteLine("no se encontro"+codigo);
		
		}
		
		
		
		public static void Main (string[] args)
		{
		
			string nombre, codigo;
			//int opc;
			int menu,contador=0;
			
			Hashtable tabla = new Hashtable();
			do {
			Console.WriteLine ("Ingresa La Opcion Deseada");
				Console.WriteLine ("1-Ingresar Nombre Alumno\n2-ver\n3-eliminar\n4-salir\n ");
				menu=int.Parse(Console.ReadLine());
				switch (menu) {
				case 1 : 
					contador++;
					Console.Write("\t\tIngresar Nombre de Alumno : \n");
					nombre = Console.ReadLine();
					Console.Write("\t\tIngresar Codigo de Alumno : \n");
					codigo = Console.ReadLine();
					agregarAlumno(nombre, codigo,tabla,contador);
					break;
					
				case 2 : 
					if (contador == 0)
						Console.WriteLine(" ATENCION ¡campos vacios!\n");
					else{
						
						mostrar(tabla);
					
					}
					break;
				case 3 : 
					contador--;
					Console.WriteLine("alumno codigo");
					codigo = Console.ReadLine();
					eliminar(codigo,tabla);
					break;
				
				}
				}	while (menu!=4);
			Console.ReadLine();
		}
	}
}