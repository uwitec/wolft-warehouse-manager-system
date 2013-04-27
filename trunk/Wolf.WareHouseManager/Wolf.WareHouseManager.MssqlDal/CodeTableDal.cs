using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wolf.WareHouseManager.IDAL;
using Wolf.WareHouseManager.Context;
using System.Data;
using Wolf.WareHouseManager.Model.Models;

namespace Wolf.WareHouseManager.MssqlDal
{
    public class CodeTableDal : ICodeTableDal
    {
        WareHouseDBContext context = new WareHouseDBContext();
        public Model.Models.TCodeTable AddEntity(Model.Models.TCodeTable entity)
        {
            context.Entry(entity).State = EntityState.Added;
            return context.SaveChanges() > 0 ? entity : null;
        }

        public int DeleteBy(Func<Model.Models.TCodeTable, bool> whereLambda)
        {
            IEnumerable<TCodeTable> modelList = context.TCodeTables.Where<TCodeTable>(whereLambda);
            foreach (TCodeTable model in modelList)
            {
                context.Entry(model).State = EntityState.Deleted;
            }
            return context.SaveChanges();
        }

        public bool DeleteEntity(Model.Models.TCodeTable entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges()>0?true:false;
        }

        public long GetCount(Func<Model.Models.TCodeTable, bool> whereLambda)
        {
            return context.TCodeTables.Where<TCodeTable>(whereLambda).Count();
        }

        public IList<Model.Models.TCodeTable> GetEntities(Func<Model.Models.TCodeTable, bool> whereLambda)
        {
            return context.TCodeTables.Where<TCodeTable>(whereLambda).ToList();
        }

        public Model.Models.TCodeTable GetEntityByID(int id)
        {
            return context.TCodeTables.Where<TCodeTable>(c => c.FID == id).FirstOrDefault();
        }

        
        public bool UpdateEntity(Model.Models.TCodeTable entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? true : false;
        }


        public IList<TCodeTable> GetPageEntities<S>(Func<TCodeTable, bool> whereLambda, int? pageSize, int? pageIndex, bool isAsc, Func<TCodeTable, S> orderby)
        {
            pageIndex = pageIndex ?? 1;
            pageSize = pageSize ?? 10;

            if (isAsc)
            {
                var temp = context.TCodeTables
                    .Where<TCodeTable>(whereLambda)
                    .OrderBy(orderby)
                    .Skip<TCodeTable>((pageIndex.Value - 1) * pageSize.Value)
                    .Take<TCodeTable>(pageSize.Value);
                return temp.ToList<TCodeTable>();
            }
            else
            {
                var temp = context.TCodeTables
                    .Where<TCodeTable>(whereLambda)
                    .OrderByDescending(orderby)
                    .Skip<TCodeTable>((pageIndex.Value - 1) * pageSize.Value)
                    .Take<TCodeTable>(pageSize.Value);
                return temp.ToList<TCodeTable>();
            }
        }
    }
}
