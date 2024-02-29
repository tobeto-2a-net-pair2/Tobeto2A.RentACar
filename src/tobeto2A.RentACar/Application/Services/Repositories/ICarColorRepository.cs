using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services.Repositories;
public interface ICarColorRepository : IAsyncRepository<CarColor, Guid>,IRepository<CarColor, Guid>
{
}
