
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Model:Entity<Guid>
{
    public int BrandId { get; set; } // normalizasyon
    public string Name { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }
}
