using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{    
    public class PlanLogic
    {
        PlanAdapter PlanData;
        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }
        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }
        public Plan GetOne(int ID)
        {
            return PlanData.GetOne(ID);
        }
    }
}
