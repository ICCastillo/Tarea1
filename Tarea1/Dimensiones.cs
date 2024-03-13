using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
	internal class Dimensiones
	{
		private double ancho;
		private double alto;
		private double largo;
		private int peso;

		public double Ancho
		{
			get => ancho;
		}
		public double Alto
		{
			get => alto;
		}
		public double Largo
		{
			get => largo;
		}
		public int Peso
		{
			get => peso;
		}

		public Dimensiones(double ancho, double alto, double largo, int peso)
		{
			this.ancho = ancho;
			this.alto = alto;
			this.largo = largo;
			this.peso = peso;
		}

		public string ToString()
		{
			return "Ancho: " + ancho + " Alto: " + alto + " Largo: " + largo + " Peso: " + peso;
		}
	}
}
