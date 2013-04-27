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
    public class CustomerDal : ICustomerDal
    {
        WareHouseDBContext context = new WareHouseDBContext();
        public Model.Models.TCustomer AddEntity(Model.Models.TCustomer entity)
        {
            return context.TCustomers.Add(entity);
        }

        public int DeleteBy(Func<Model.Models.TCustomer, bool> whereLambda)
        {
            IEnumerable<TCustomer> modelList = context.TCustomers.Where(whereLambda);
            foreach (TCustomer model in modelList)
            {
                context.Entry(model).State = System.Data.EntityState.Deleted;
            }
            return context.SaveChanges();
        }

        public bool DeleteEntity(Model.Models.TCustomer entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges()>0?true:false;
        }

        public long GetCount(Func<Model.Models.TCustomer, bool> whereLambda)
        {
            return (long)context.TCustomers.Where(whereLambda).Count();
        }

        public IList<Model.Models.TCustomer> GetEntities(Func<Model.Models.TCustomer, bool> whereLambda)
        {
            return context.TCustomers.Where<TCustomer>(whereLambda).ToList();
        }

        public Model.Models.TCustomer GetEntityByID(int id)
        {
            return context.TCustomers.Where(c=>c.FCustomerID==id).FirstOrDefault();
        }

        public IList<Model.Models.TCustomer> GetPageEntities<S>(Func<Model.Models.TCustomer, bool> whereLambda, int? pageSize, int? pageIndex, bool isAsc, Func<Model.Models.TCustomer, S> orderby)
        {
            pageIndex = pageIndex ?? 1;
            pageSize = pageSize ?? 10;

            if (isAsc)
            {
                IEnumerable<TCustomer> modelList = context.TCustomers
                    .Where(whereLambda)
                    .OrderBy(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value);
                return modelList.ToList();
            }
            else
            {
                IEnumerable<TCustomer> modelList = context.TCustomers
                    .Where(whereLambda)
                    .OrderByDescending(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value);
                return modelList.ToList();
            }
        }

        public bool UpdateEntity(Model.Models.TCustomer entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
