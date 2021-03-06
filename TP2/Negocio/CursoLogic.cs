﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic
    {
        CursoAdapter CursoData;
        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }
        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }
        public Curso GetOne(int ID)
        {
            return CursoData.GetOne(ID);
        }
        public void Save(Curso cur)
        {
            CursoData.Save(cur);
        }
        public void Delete(int ID)
        {
            CursoData.Delete(ID);
        }
    }
}
