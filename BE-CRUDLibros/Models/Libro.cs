namespace BE_CRUDLibros.Models
{
    public class Libro
    {
        public int isbn { get; set; }
        public string autor { get; set; }
        public string titulo { get; set; }

        public string fechaPublicacion { get; set; }
        public string categoria { get; set; }

        public string editorial { get; set; }
    }
}
