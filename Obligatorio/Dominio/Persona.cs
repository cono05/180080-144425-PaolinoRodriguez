namespace Dominio
{
    public abstract class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        public int Id;

        public Persona()
        {
            this.Nombre     = string.Empty;
            this.Apellido   = string.Empty;
            this.Cedula     = string.Empty;
        }

    }
}