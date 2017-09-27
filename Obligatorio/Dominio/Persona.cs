namespace Dominio
{
    public abstract class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        

        public Persona()
        {
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
        }

    }
}