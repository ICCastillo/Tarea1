using Tarea1;


string menu = "1. Introducir datos\n2. Mostrar datos\n3. Hacer foto\n4. Hacer llamada\n5. Factura\n6. Salir\n";
int opcion = 0;
Movil movil1 = new Movil();
Movil movil2 = new Movil();
Movil movil3 = new Movil();
do
{
	Console.WriteLine(menu);
	try
	{
		opcion = Int32.Parse(Console.ReadLine());
	}
	catch (FormatException e)
	{
		Console.WriteLine("Introduzca un valor correcto");
	}
	switch (opcion)
	{
		case 1:
			for (int i = 0; i < 3; i++)
			{
				try
				{
					Console.WriteLine("Introduce los datos del movil " + (i + 1));
					Console.WriteLine("Introduce la marca");
					string marca = Console.ReadLine();
					Console.WriteLine("Introduce el modelo");
					string modelo = Console.ReadLine();
					Console.WriteLine("Introduce el Imei");
					string imei = Console.ReadLine();
					Console.WriteLine("Introduce el numero de telefono");
					int numeroTelefono = Int32.Parse(Console.ReadLine());
					Console.WriteLine("Introduce el Sistema Operativo");
					string sistemaOperativo = Console.ReadLine();
					Console.WriteLine("Introduce el almacenamiento disponible");
					double almacenamientoDisponible = Double.Parse(Console.ReadLine());
					Console.WriteLine("Introduce el precio por minuto");
					double precioPorMinuto = Double.Parse(Console.ReadLine());
					Tarifa tarifa = new Tarifa(precioPorMinuto);
					Camara camaraFrontal = new Camara();
					Console.WriteLine("Introduce la resolucion de la camara trasera");
					int resolucionTrasera = Int32.Parse(Console.ReadLine());
					Console.WriteLine("Introduce el numero de lentes de la camara trasera");
					int numeroLentesTrasera = Int32.Parse(Console.ReadLine());
					Camara camaraTrasera = new Camara(resolucionTrasera, numeroLentesTrasera);
					Console.WriteLine("Introduce el ancho del movil");
					double ancho = Double.Parse(Console.ReadLine());
					Console.WriteLine("Introduce el alto del movil");
					double alto = Double.Parse(Console.ReadLine());
					Console.WriteLine("Introduce el largo del movil");
					double largo = Double.Parse(Console.ReadLine());
					Console.WriteLine("Introduce el peso del movil");
					int peso = Int32.Parse(Console.ReadLine());
					Dimensiones dimensiones = new Dimensiones(ancho, alto, largo, peso);
					if (i == 0)
					{
						movil1 = new Movil(marca, modelo, imei, numeroTelefono, camaraFrontal, camaraTrasera, tarifa, dimensiones, almacenamientoDisponible, sistemaOperativo);
					}
					else if (i == 1)
					{
						movil2 = new Movil(marca, modelo, imei, numeroTelefono, camaraFrontal, camaraTrasera, tarifa, dimensiones, almacenamientoDisponible, sistemaOperativo);
					}
					else if (i == 2)
					{
						movil3 = new Movil(marca, modelo, imei, numeroTelefono, camaraFrontal, camaraTrasera, tarifa, dimensiones, almacenamientoDisponible, sistemaOperativo);
					}
				}
				catch (FormatException e)
				{
					Console.WriteLine("Vuelva a crear un telefono, esta vez con el formato correcto");
					i -= 1;
				}
				catch (NullReferenceException e)
				{
					Console.WriteLine("Error al crear el teléfono");
					i -= 1;
				}
			}
			break;
		case 2:
			if (movil1.SistemaOperativo == null || movil2.SistemaOperativo == null || movil3.SistemaOperativo == null)
			{
				Console.WriteLine("No hay datos");
				break;
			}
			else
			{
				Console.WriteLine(movil1.ToString());
				Console.WriteLine(movil2.ToString());
				Console.WriteLine(movil3.ToString());
			}


			break;
		case 3:
			if (movil1.SistemaOperativo == null || movil2.SistemaOperativo == null || movil3.SistemaOperativo == null)
			{
				Console.WriteLine("No hay datos");
				break;
			}
			else
			{
				Console.WriteLine("Elige el movil para hacer la foto.");
				Console.WriteLine("1. Movil 1");
				Console.WriteLine("2. Movil 2");
				Console.WriteLine("3. Movil 3");
				int movil = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Elige la cámara para hacer la foto.");
				Console.WriteLine("1. Cámara frontal");
				Console.WriteLine("2. Cámara trasera");
				int camara = Int32.Parse(Console.ReadLine());
				if (movil == 1)
				{
					if (camara == 1)
					{
						movil1.HacerFoto("frontal");
					}
					else if (camara == 2)
					{
						movil1.HacerFoto("trasera");
					}
				}
				else if (movil == 2)
				{
					if (camara == 1)
					{
						movil2.HacerFoto("frontal");
					}
					else if (camara == 2)
					{
						movil2.HacerFoto("trasera");
					}
				}
				else if (movil == 3)
				{
					if (camara == 1)
					{
						movil3.HacerFoto("frontal");
					}
					else if (camara == 2)
					{
						movil3.HacerFoto("trasera");
					}
				}else
				{
					Console.WriteLine("Opcion no valida");
				}
			}
			break;
		case 4:
			if (movil1.SistemaOperativo == null || movil2.SistemaOperativo == null || movil3.SistemaOperativo == null)
			{
				Console.WriteLine("No hay datos");
				break;
			}
			else
			{


				Console.WriteLine("Elige el movil para hacer la llamada.");
				Console.WriteLine("1. Movil 1");
				Console.WriteLine("2. Movil 2");
				Console.WriteLine("3. Movil 3");
				int movilLlamada = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Introduce la duracion de la llamada");
				int duracion = Int32.Parse(Console.ReadLine());
				if (movilLlamada == 1)
				{
					movil1.HacerLlamada(duracion);
				}
				else if (movilLlamada == 2)
				{
					movil2.HacerLlamada(duracion);
				}
				else if (movilLlamada == 3)
				{
					movil3.HacerLlamada(duracion);
				}else
				{
					Console.WriteLine("Opcion no valida");
				}
			}
			break;
		case 5:
			if (movil1.SistemaOperativo == null || movil2.SistemaOperativo == null || movil3.SistemaOperativo == null)
			{
				Console.WriteLine("No hay datos");
				break;
			}
			else
			{
				Console.WriteLine("Elige el movil para consultar la factura.");
				Console.WriteLine("1. Movil 1");
				Console.WriteLine("2. Movil 2");
				Console.WriteLine("3. Movil 3");
				int movilFactura = Int32.Parse(Console.ReadLine());
				if (movilFactura == 1)
				{
					Console.WriteLine(movil1.Tarifa.Factura());
				}
				else if (movilFactura == 2)
				{
					Console.WriteLine(movil2.Tarifa.Factura());
				}
				else if (movilFactura == 3)
				{
					Console.WriteLine(movil3.Tarifa.Factura());
				}else
				{
					Console.WriteLine("Opcion no valida");
				}
			}
			break;
		case 6:
			Console.WriteLine("Salir");
			break;
		default:
			Console.WriteLine("Opcion no valida");
			break;
	}
} while (opcion != 6);
