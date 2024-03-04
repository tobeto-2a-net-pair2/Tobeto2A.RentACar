﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Car : Entity<Guid>
{
    public Guid ModelId { get; set; }
    public Guid ColorId { get; set; }
    public short ModelYear { get; set; }
    public string Kilometer { get; set; }
    public string Plate { get; set; }
    public string CarState { get; set; }

    public Model? Model { get; set; } = null;

    public Car()
    {
    }

}