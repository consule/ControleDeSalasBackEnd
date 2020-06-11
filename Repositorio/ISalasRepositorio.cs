using ControleDeSalasBackEnd.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Repositorio
{
    public interface ISalasRepositorio
    {
        IEnumerable<Salas> GetAll();
    }
}
