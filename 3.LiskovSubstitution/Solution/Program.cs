namespace LiskovSubstitution.Solution
{
    internal class Program
    {
        /// <summary>
        ///  si S es un subtipo de T, entonces los objetos de tipo T en un programa de computadora pueden ser sustituidos por objetos de tipo S 
        ///  (es decir, los objetos de tipo S pueden sustituir objetos de tipo T), 
        ///  sin alterar ninguna de las propiedades deseables de ese programa (la corrección, la tarea que realiza, etc.).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Car vehicle = new();
            vehicle.Park();
            vehicle.Break();

            Plane plane = new();
            plane.TakeOff();
            plane.Land();
        }
    }
}
