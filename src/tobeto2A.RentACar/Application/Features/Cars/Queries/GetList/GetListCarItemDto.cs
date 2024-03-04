﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Queries.GetList;
public class GetListCarItemDto
{
    public Guid ModelId { get; set; }
    public Guid ColorId { get; set; }
    public short ModelYear { get; set; }
    public string CarState { get; set; }
    public string Kilometer { get; set; }
}