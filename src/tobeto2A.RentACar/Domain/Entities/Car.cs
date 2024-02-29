using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Car:Entity<Guid>
{
    public Guid ColorId { get; set; } // int?
    public Guid ModelId { get; set; } // int?
    public CarState CarState { get; set; } // TODO: Enums--->carstate
    public string Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; }
    public string Message { get; set; }

    //---
    public Model? Model { get; set; } = null;
    public CarColor? Color { get; set; } = null;


}
