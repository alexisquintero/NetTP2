﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic
    {
        MateriaAdapter MateriaData;
        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }
        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }
        public Materia GetOne(int ID)
        {
            return MateriaData.GetOne(ID);
        }
        public void Save(Materia mat)
        {
            MateriaData.Save(mat);
        }
        public void Delete(int ID)
        {
            MateriaData.Delete(ID);
        }
    }
}
