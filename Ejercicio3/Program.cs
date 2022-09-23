// See https://aka.ms/new-console-template for more information




namespace Ejercicio3
{
    public class Program{

      private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
  
        static void Main(string[] args)
        {
          int id,doc,cur,cantidad;
          string a,n;
         
           var  listaATletismo = new List<alumno>();
           var  listaVoley = new List<alumno>();
           var  listaFutbol = new List<alumno>();
            var marchivo = new manejoArchivo();
          
           
    
          try
          {
        

            Console.WriteLine("\nIngrese la cantidad de añumnos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());


            for(int i = 0; i < cantidad; i++)
            {
                   Console.WriteLine($"\n---------Alumno {i + 1}------------");

                     id = i + 1;
                    Console.WriteLine("Apellido: ");
                     a = Console.ReadLine();
                    Console.WriteLine("Nombre: ");
                     n = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI");
                     doc = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Eliga el curso 1:Atletismo 2:Voley 3:Futbol");
                      cur= Convert.ToInt32(Console.ReadLine()); 

                 alumno nuevoAlumno = new alumno(id,a,n,doc,cur); 
                 string narchivo="";  


                 switch(nuevoAlumno.Curso)
                 
                 {
                    case 1:
                    listaATletismo.Add(nuevoAlumno);
                    narchivo="Atletismo.csv";
                    manejoArchivo.GuardarArchivoTexto(narchivo, listaATletismo);
                    break;
                    case 2:
                    listaVoley.Add(nuevoAlumno);
                    narchivo="Voley.csv";
                    manejoArchivo.GuardarArchivoTexto(narchivo, listaVoley);
                    break;
                    case 3 :
                    listaFutbol.Add(nuevoAlumno);
                    narchivo="Futbol.csv";
                    manejoArchivo.GuardarArchivoTexto(narchivo, listaFutbol);

                    break;
                    default:
                    break;

                 }

                 
                 
                   
            }

            } 
             catch (FormatException )
            {
                Logger.Error("\nError el valor ingresado no es un número");
            }
            catch(OverflowException)
            {
                   Logger.Error("\nError de representacion");
            }
             catch(FileNotFoundException)
            {
                   Logger.Error("\nError archivo no encontrado");
            }
               catch(Exception e)
            {
                   Logger.Error("\nError ",e);
            }

            }
        }
    }

