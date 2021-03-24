using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Infrastruct.DTO;
using Repository.Data;
using Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Academico
{
    public class AlunoService : IAlunoService
    {
        IAlunoRepository _alunoRepository;
        EfDataContext _db;

        public AlunoService()
        {
            _db = new EfDataContext();
            _alunoRepository = new AlunoRepository(_db);
        }
        public void Add(AlunoDTO alunoDTO)
        {
            _alunoRepository.Add(convertAlunoDTOToAluno(alunoDTO));
        }
        public List<AlunoDTO> FindByFilter(AlunoDTO alunoDTO)
        {
            try
            {
                return convertListAlunoToAlunoDTO(_alunoRepository.FindByFilter(convertAlunoDTOToAluno(alunoDTO)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region InternalMethods
        private List<AlunoDTO> convertListAlunoToAlunoDTO(IEnumerable<Aluno> lstAluno)
        {
            List<AlunoDTO> lstAlunoDTO = new List<AlunoDTO>();

            foreach(Aluno objAluno in lstAluno)
            {
                lstAlunoDTO.Add(new AlunoDTO
                {
                    nome = objAluno.nome,
                    CPF = objAluno.CPF,
                    telefone = objAluno.telefone,
                    email = objAluno.email
                });
            }

            return lstAlunoDTO;
        }
        private List<Aluno> convertListAlunoDTOToAluno(IEnumerable<AlunoDTO> lstAlunoDTO)
        {
            List<Aluno> lstAluno = new List<Aluno>();

            foreach (AlunoDTO objAlunoDTO in lstAlunoDTO)
            {
                lstAluno.Add(new Aluno
                {
                    nome = objAlunoDTO.nome,
                    CPF = objAlunoDTO.CPF,
                    telefone = objAlunoDTO.telefone,
                    email = objAlunoDTO.email
                });
            }

            return lstAluno;
        }
        private Aluno convertAlunoDTOToAluno(AlunoDTO objAlunoDTO)
        {
            return new Aluno
            {
                nome = objAlunoDTO.nome,
                CPF = objAlunoDTO.CPF,
                telefone = objAlunoDTO.telefone,
                email = objAlunoDTO.email
            };
        }
        #endregion InternalMethods
    }
}
