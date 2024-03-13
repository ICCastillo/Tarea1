using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
	internal class Tarifa
	{
		private int contadorDeLlamadas;
		private double costeTotalDeLlamadas;
		private double precioPorMinuto;
		private int bonoDeMinutos;

		public int ContadorDeLlamadas
		{
			get => contadorDeLlamadas;
			set => contadorDeLlamadas = value;
		}
		public double CosteTotalDeLlamadas
		{
			get => costeTotalDeLlamadas;
			set => costeTotalDeLlamadas = value;
		}

		public Tarifa(double precioPorMinuto)
		{
			this.precioPorMinuto = precioPorMinuto;
			contadorDeLlamadas = 0;
			costeTotalDeLlamadas = 0;
			bonoDeMinutos = 60;
		}

		public double RegistrarLlamada(int duracion)
		{
			double costeLlamada = duracion * precioPorMinuto;
			costeTotalDeLlamadas += 0.18;
			duracion -= 3;
			if (duracion > 0)
			{
				bonoDeMinutos -= duracion;
			}
			if (bonoDeMinutos <= 0)
			{
				costeTotalDeLlamadas += costeLlamada;
			}
			contadorDeLlamadas++;
			return costeLlamada;
		}

		public double ConsultarConsumo()
		{
			return costeTotalDeLlamadas;
		}

		public string Factura()
		{
			int contadorLlamadas = contadorDeLlamadas;
			double costeTotal = costeTotalDeLlamadas;
			contadorDeLlamadas = 0;
			costeTotalDeLlamadas = 0;
			bonoDeMinutos = 60;

			return "Llamadas realizadas: " + contadorLlamadas + " Coste total: " + costeTotal;
		}
	}
}
