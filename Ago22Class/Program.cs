namespace Ago22Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu para seleccionar que programa ejecutar con el numero y el nombre 
            //Ejercicios: del 6 al 16 (solo escoger 3) (10,9,8)
            //git config --global --remove-section user
            ExerciseOne.ExecuteExercise();
            Ejercicio9();
            Ejercicio10();
        }
        public static void Ejercicio9() {
            Console.WriteLine("Ingrese la primera letra: ");
            String first = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda letra: ");
            string second = Console.ReadLine();
            Letras.CambiarLetras(first, second);
        }
        public static void Ejercicio10() {
            Console.WriteLine("Calcular area y perimetro de un rectangulo");
            Console.WriteLine("Ingresa la altura del rectangulo: ");
            double altura=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la base de el rectangulo: ");
            double baseR=double.Parse(Console.ReadLine());
            Console.WriteLine("El perimetro de el rectangulo es de: "+(2*altura)+(2*baseR));

        }
    }
}