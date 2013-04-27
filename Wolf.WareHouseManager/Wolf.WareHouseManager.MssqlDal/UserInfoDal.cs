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
    public class UserInfoDal : IUserInfoDal
    {
        WareHouseDBContext context = new WareHouseDBContext();
        public Model.Models.TUserInfo AddEntity(Model.Models.TUserInfo entity)
        {
            return context.TUserInfoes.Add(entity);
        }

        public int DeleteBy(Func<Model.Models.TUserInfo, bool> whereLambda)
        {
            IEnumerable<TUserInfo> modelList = context.TUserInfoes.Where(whereLambda);
            foreach (TUserInfo model in modelList)
            {
                context.Entry(model).State = EntityState.Deleted;
            }
            return context.SaveChanges();
        }

        public bool DeleteEntity(Model.Models.TUserInfo entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges() > 0 ? true : false;
        }

        public long GetCount(Func<Model.Models.TUserInfo, bool> whereLambda)
        {
            return context.TUserInfoes.Where(whereLambda).LongCount();
        }

        public IList<Model.Models.TUserInfo> GetEntities(Func<Model.Models.TUserInfo, bool> whereLambda)
        {
            return context.TUserInfoes.Where(whereLambda).ToList();
        }

        public Model.Models.TUserInfo GetEntityByID(int id)
        {
            return context.TUserInfoes.Where(c => c.FUserID == id).FirstOrDefault();
        }

        public IList<Model.Models.TUserInfo> GetPageEntities<S>(Func<Model.Models.TUserInfo, bool> whereLambda, int? pageSize, int? pageIndex, bool isAsc, Func<Model.Models.TUserInfo, S> orderby)
        {
            pageIndex = pageIndex ?? 1;
            pageSize = pageSize ?? 10;

            if (isAsc)
            {
                return context.TUserInfoes.Where(whereLambda)
                    .OrderBy(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
            else
            {
                return context.TUserInfoes.Where(whereLambda)
                    .OrderByDescending(orderby)
                    .Skip((pageIndex.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .ToList();
            }
        }

        public bool UpdateEntity(Model.Models.TUserInfo entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? true : false ;
        }
    }
}
