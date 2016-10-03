using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class DocenteCursosLogic
    {
        DocenteCursoAdapter DocenteCursoData;
        public DocenteCursosLogic()
        {
            DocenteCursoData = new DocenteCursoAdapter();
        }
        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }
        public DocenteCurso GetOne(int ID)
        {
            return DocenteCursoData.GetOne(ID);
        }
    }
}
