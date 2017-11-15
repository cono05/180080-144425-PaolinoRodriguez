namespace Dominio
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        public static int numeroId = 0;

        public Persona()
        {
            this.Nombre     = string.Empty;
            this.Apellido   = string.Empty;
            this.Cedula     = string.Empty;
        }

    }
}