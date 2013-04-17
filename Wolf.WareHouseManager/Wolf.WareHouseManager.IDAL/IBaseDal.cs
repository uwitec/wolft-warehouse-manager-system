using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wolf.WareHouseManager.IDAL
{
    public interface IBaseDal<T> where T:class,new()
    {
        bool AddEntity(T entity);
        bool UpdateEntity(T entity);
        bool DeleteEntity(T entity);

        int DeleteBy(Func<T,bool> whereLambda);

        T GetEntityByID(int id);

        IList<T> GetEntities(Func<T,bool> whereLambda);

        IList<T> GetPageEntities<S>(Func<T,bool> whereLambda,int? pageSize,int? pageIndex);


    }
}
