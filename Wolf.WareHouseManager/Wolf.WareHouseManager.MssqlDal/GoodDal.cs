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
    public class GoodDal : IGoodDal
    {
        WareHouseDBContext context = new WareHouseDBContext();
        public Model.Models.TGood AddEntity(Model.Models.TGood entity)
        {
            return context.TGoods.Add(entity);
        }

        public int DeleteBy(Func<Model.Models.TGood, bool> whereLambda)
        {
            IEnumerable<TGood> modelList =  context.TGoods.Where(whereLambda);
            foreach (TGood model in modelList)
            {
                context.Entry(model).State = EntityState.Deleted;
            }
            return context.SaveChanges();
        }

        public bool DeleteEntity(Model.Models.TGood entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges() > 0 ? true : false;
        }

        public long GetCount(Func<Model.Models.TGood, bool> whereLambda)
        {
            return (long)context.TGoods.Where(whereLambda).Count();
        }

        public IList<Model.Models.TGood> GetEntities(Func<Model.Models.TGood, bool> whereLambda)
        {
            return context.TGoods.Where(whereLambda).ToList();
        }

        public Model.Models.TGood GetEntityByID(int id)
        {
            return context.TGoods.Where(c => c.FGoodID == id).FirstOrDefault();
        }

        public IList<Model.Models.TGood> GetPageEntities<S>(Func<Model.Models.TGood, bool> whereLambda, int? pageSize, int? pageIndex, bool isAsc, Func<Model.Models.TGood, S> orderby)
        {
            pageIndex = pageIndex ?? 1;
            pageSize = pageSize ?? 10;

            if (isAsc)
            {
                IEnumerable<TGood> modelList = context.TGoods.Where(whereLambda)
                    .OrderBy(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value);
                return modelList.ToList();

            }
            else
            {
                IEnumerable<TGood> modelList = context.TGoods.Where(whereLambda)
                    .OrderByDescending(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value);
                return modelList.ToList();
            }
        }

        public bool UpdateEntity(Model.Models.TGood entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
