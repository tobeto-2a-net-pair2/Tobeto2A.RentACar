using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Model : Entity<Guid>
{
    public string Name { get; set; }
    public short Year { get; set; }    
    public decimal DailyPrice { get; set; }
    public Guid BrandId { get; set; }  // Normalizasyon
    public Guid FuelId { get; set; }  // Normalizasyon
    public Guid TransmissionId { get; set; }  // Normalizasyon
  
    // Lazy Loading
    public Brand? Brand { get; set; } = null;  // One to One
    public Fuel? Fuel { get; set; } = null;  // One to One
    public Transmission? Transmission { get; set; } = null;  // One to One
    public ICollection<Car>? Cars { get; set; } = null;  // One to Many

    public Model()
    {
    }

}