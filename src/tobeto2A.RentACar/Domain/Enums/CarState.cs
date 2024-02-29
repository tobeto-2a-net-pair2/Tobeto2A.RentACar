using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums;
public enum CarState
{
    Available,
    ForSale,        //Satılık
    ForRent,       //Kiralık
    UnderReapir,    //Tamirde
    OnService,     //Serviste
}
