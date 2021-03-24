using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastruct.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IAlunoService
    {
        List<AlunoDTO> FindByFilter(AlunoDTO alunoDTO);
        void Add(AlunoDTO alunoDTO);
    }
}
