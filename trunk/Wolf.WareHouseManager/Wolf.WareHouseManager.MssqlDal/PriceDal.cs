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
    public class PriceDal : IPriceDal
    {
        WareHouseDBContext context = new WareHouseDBContext();
        public Model.Models.TPrice AddEntity(Model.Models.TPrice entity)
        {
            return context.TPrices.Add(entity);
        }

        public int DeleteBy(Func<Model.Models.TPrice, bool> whereLambda)
        {
            IEnumerable<TPrice> modelList = context.TPrices.Where(whereLambda);
            foreach (TPrice model in modelList)
            {
                context.Entry(model).State = EntityState.Deleted;
            }
            return context.SaveChanges();
        }

        public bool DeleteEntity(Model.Models.TPrice entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges() > 0 ? true : false;
        }

        public long GetCount(Func<Model.Models.TPrice, bool> whereLambda)
        {
            return context.TPrices.Where(whereLambda).LongCount();
        }

        public IList<Model.Models.TPrice> GetEntities(Func<Model.Models.TPrice, bool> whereLambda)
        {
            return context.TPrices.Where(whereLambda).ToList();
        }

        public Model.Models.TPrice GetEntityByID(int id)
        {
            return context.TPrices.Where(c => c.FPriceID == id).FirstOrDefault();
        }

        public IList<Model.Models.TPrice> GetPageEntities<S>(Func<Model.Models.TPrice, bool> whereLambda, int? pageSize, int? pageIndex, bool isAsc, Func<Model.Models.TPrice, S> orderby)
        {
            pageIndex = pageIndex ?? 1;
            pageSize = pageSize ?? 10;

            if (isAsc)
            {
                return context.TPrices.Where(whereLambda)
                    .OrderBy(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
            else
            {
                return context.TPrices.Where(whereLambda)
                    .OrderByDescending(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
        }

        public bool UpdateEntity(Model.Models.TPrice entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? true : false ;
        }
    }
}
