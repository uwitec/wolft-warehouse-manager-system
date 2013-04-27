using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wolf.WareHouseManager.IDAL;
using Wolf.WareHouseManager.Context;
using System.Data;

namespace Wolf.WareHouseManager.MssqlDal
{
    public class R_Model_Comp_RoleDal : IR_Model_Comp_RoleDal
    {
        WareHouseDBContext context = new WareHouseDBContext();
        public Model.Models.TR_Model_Comp_Role AddEntity(Model.Models.TR_Model_Comp_Role entity)
        {
            return context.TR_Model_Comp_Role.Add(entity);
        }

        public int DeleteBy(Func<Model.Models.TR_Model_Comp_Role, bool> whereLambda)
        {
            return context.TR_Model_Comp_Role.Where(whereLambda).Count();
        }

        public bool DeleteEntity(Model.Models.TR_Model_Comp_Role entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges() > 0 ? true : false;
        }

        public long GetCount(Func<Model.Models.TR_Model_Comp_Role, bool> whereLambda)
        {
            return context.TR_Model_Comp_Role.Where(whereLambda).LongCount();
        }

        public IList<Model.Models.TR_Model_Comp_Role> GetEntities(Func<Model.Models.TR_Model_Comp_Role, bool> whereLambda)
        {
            return context.TR_Model_Comp_Role.Where(whereLambda).ToList();
        }

        public Model.Models.TR_Model_Comp_Role GetEntityByID(int id)
        {
            return context.TR_Model_Comp_Role.Where(c => c.FRelationID == id).FirstOrDefault();
        }

        public IList<Model.Models.TR_Model_Comp_Role> GetPageEntities<S>(Func<Model.Models.TR_Model_Comp_Role, bool> whereLambda, int? pageSize, int? pageIndex, bool isAsc, Func<Model.Models.TR_Model_Comp_Role, S> orderby)
        {
            pageIndex = pageIndex ?? 1;
            pageSize = pageSize ?? 10;

            if (isAsc)
            {
                return context.TR_Model_Comp_Role.Where(whereLambda)
                    .OrderBy(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
            else
            {
                return context.TR_Model_Comp_Role.Where(whereLambda)
                    .OrderByDescending(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
        }

        public bool UpdateEntity(Model.Models.TR_Model_Comp_Role entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
