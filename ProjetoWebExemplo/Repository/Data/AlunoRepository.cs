using Domain.Entities;
using Domain.Interfaces.Repositories;
using Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(EfDataContext db) : base(db)
        {
        }
        public IEnumerable<Aluno> FindByFilter(Aluno objAluno)
        {
            try
            {
                return GetAll().Where(x =>
                (objAluno.CPF == null || x.CPF == objAluno.CPF) &&
                (objAluno.nome == null || x.nome.Contains(objAluno.nome)) &&
                (objAluno.telefone == null || x.telefone.Contains(objAluno.telefone)) &&
                (objAluno.email == null || x.email.Contains(objAluno.email))).OrderBy(x => x.nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
