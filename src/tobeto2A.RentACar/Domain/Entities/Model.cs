
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Model:Entity<Guid>
{
    public Guid BrandId { get; set; }  // int?
    public string Name { get; set; } 
    public Guid FuelId { get; set; }  // int?
    public Guid TransmissionId { get; set; }  // int?
    //public decimal DailyPrice { get; set; }
    public short Year { get; set; }

    public Brand? Brand { get; set; } = null; 
    public Transmission? Transmission { get; set; } = null; 
    public Fuel? Fuel { get; set; } = null; 
    
}
