using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wolf.WareHouseManager.IDAL;
using Wolf.WareHouseManager.Context;
using Wolf.WareHouseManager.Model.Models;
using System.Data;

namespace Wolf.WareHouseManager.MssqlDal
{
    public class GoodStatuDal : IGoodStatuDal
    {
        WareHouseDBContext context = new WareHouseDBContext();
        public Model.Models.TGoodStatu AddEntity(Model.Models.TGoodStatu entity)
        {
            return context.TGoodStatus.Add(entity);
        }

        public int DeleteBy(Func<Model.Models.TGoodStatu, bool> whereLambda)
        {
            IEnumerable<TGoodStatu> modelList = context.TGoodStatus.Where(whereLambda);
            foreach (TGoodStatu model in modelList)
            {
                context.Entry(model).State = EntityState.Deleted;
            }
            return context.SaveChanges();
        }

        public bool DeleteEntity(Model.Models.TGoodStatu entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges() > 0 ? true : false;
        }

        public long GetCount(Func<Model.Models.TGoodStatu, bool> whereLambda)
        {
            return (long)context.TGoodStatus.Where(whereLambda).Count();
        }

        public IList<Model.Models.TGoodStatu> GetEntities(Func<Model.Models.TGoodStatu, bool> whereLambda)
        {
            return context.TGoodStatus.Where(whereLambda).ToList();
        }

        public Model.Models.TGoodStatu GetEntityByID(int id)
        {
            return context.TGoodStatus.Where(c => c.FStatusID == id).FirstOrDefault();
        }

        public IList<Model.Models.TGoodStatu> GetPageEntities<S>(Func<Model.Models.TGoodStatu, bool> whereLambda, int? pageSize, int? pageIndex, bool isAsc, Func<Model.Models.TGoodStatu, S> orderby)
        {
            pageIndex = pageIndex ?? 1;
            pageSize = pageSize ?? 10;

            if (isAsc)
            {
                return context.TGoodStatus.Where(whereLambda)
                    .OrderBy(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
            else
            {
                return context.TGoodStatus.Where(whereLambda)
                    .OrderByDescending(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
        }

        public bool UpdateEntity(Model.Models.TGoodStatu entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
