namespace PracticaParaElFinal.Recetario
{
    internal class Receta
    {
        private string nombre;
        private string descripcion;
        private string categoria;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public Receta() { }
        public Receta ( string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public Receta(string nombre, string descripcion, string categoria)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Categoria = categoria;
        }

        public override string ToString()
        {
            return $"{Nombre};{Descripcion};{Categoria}";
        }
    }
}
