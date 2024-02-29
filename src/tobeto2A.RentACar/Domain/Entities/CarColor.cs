using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class CarColor : Entity<Guid>
{
    public Guid ColorId { get; set; }
    public CarColorName CarColorName { get; set; }
}
