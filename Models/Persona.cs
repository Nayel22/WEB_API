namespace WEB_API.Models
{
    public class Persona
    {
      
            public int Id { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Email { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Telefono { get; set; }
            public string AdicionadoPor { get; set; }
            public DateTime FechaAdiccion { get; set; }
            public string ModificadoPor { get; set; }
            public DateTime? FechaModificacion { get; set; }
        
    }
}
