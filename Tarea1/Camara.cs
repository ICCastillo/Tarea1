using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
	internal class Camara
	{
		private int resolucion;
		private int numeroLentes;
		private int contadorDeFotos;
		private bool aiActivado;

		public int Resolucion
		{
			get => resolucion;
		}
		public int NumeroLentes
		{
			get => numeroLentes;
		}
		public int ContadorDeFotos
		{
			get => contadorDeFotos;
		}
		public bool AiActivado
		{
			get => aiActivado;
		}

		public Camara(int resolucion, int numeroLentes)
		{
			this.resolucion = resolucion;
			this.numeroLentes = numeroLentes;
			aiActivado = true;
			contadorDeFotos = 0;
		}

		public Camara() 
		{ 	
			resolucion = 24;
			numeroLentes = 1;
			aiActivado = true;
			contadorDeFotos = 0;
		}

		public double HacerFoto()
		{
			contadorDeFotos++;
			double mb = (resolucion * 24) / 80;
			return aiActivado ? mb * 0.03 : mb;
		}

		public string ToString()
		{
			return "Resolucion: " + resolucion + " Numero de lentes: " + numeroLentes + " Fotos tomadas: " + contadorDeFotos + " AI activado: " + aiActivado;
		}
	}
}
