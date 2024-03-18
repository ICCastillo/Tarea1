using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
	internal class Movil
	{
		private string marca;
		private string modelo;
		private string imei;
		private int numeroTelefono;
		private double almacenamientoDisponible;
		private string sistemaOperativo;
		private Camara camaraFrontal;
		private Camara camaraTrasera;
		private Tarifa tarifa;
		private Dimensiones dimensiones;

		public string Marca
		{
			get => marca;
		}
		public string Modelo
		{
			get => modelo;
		}
		public string Imei
		{
			get => imei;
		}
		public int NumeroTelefono
		{
			get => numeroTelefono;
			set => numeroTelefono = value;
		}
		public Camara CamaraFrontal
		{
			get => camaraFrontal;
		}
		public Camara CamaraTrasera
		{
			get => camaraTrasera;
		}
		public Tarifa Tarifa
		{
			get => tarifa;
			set => tarifa = value;
		}
		public Dimensiones Dimensiones
		{
			get => dimensiones;
		}
		public double AlmacenamientoDisponible
		{
			get => almacenamientoDisponible;
		}
		public string SistemaOperativo
		{
			get => sistemaOperativo;
		}

		public Movil() { }

		public Movil(string marca, string modelo, string imei, int numeroTelefono, Camara camaraFrontal, Camara camaraTrasera, Tarifa tarifa, Dimensiones dimensiones, double almacenamientoDisponible, string sistemaOperativo)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.imei = imei;
			this.numeroTelefono = numeroTelefono;
			this.camaraFrontal = camaraFrontal;
			this.camaraTrasera = camaraTrasera;
			this.almacenamientoDisponible = almacenamientoDisponible;
			this.sistemaOperativo = sistemaOperativo;
			this.tarifa = tarifa;
			this.dimensiones = dimensiones;
		}

		public string ToString()
		{
			return "Marca: " + marca + " Modeloo: " + modelo + " IMEI: " + imei + " Numero de telefono: " + numeroTelefono + " " + camaraFrontal.ToString() + " " + camaraTrasera.ToString() + " " + almacenamientoDisponible.ToString() + " " + sistemaOperativo +" " + tarifa.ToString() + " " + dimensiones.ToString();
		}

		public void HacerFoto(string camara)
		{
			if(camara.StartsWith("frontal"))
			{
				almacenamientoDisponible -= camaraFrontal.HacerFoto();
			}
			else if(camara.StartsWith("trasera"))
			{
				almacenamientoDisponible -= camaraTrasera.HacerFoto();
			}
		}

		public double HacerLlamada(int duracion)
		{
			var coste = tarifa.RegistrarLlamada(duracion);
			return coste;
		}

		public string EmitirFactura()
		{
			return tarifa.Factura();
		}
	}
}
