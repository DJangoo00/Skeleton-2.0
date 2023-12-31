namespace Domain.Entities;
public class Mascota : BaseEntity
{
    public int IdPropietarioFk { get; set; }
    public Propietario Propietario { get; set; }
    public int IdEspecieFk { get; set; }
    public int IdRazaFk { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
}
