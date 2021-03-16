using IRepository;
using IServer;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Server
{
    public class AdvertisementServices : IAdvertisementServices
    {
        public IAdvertisementRepository dal = new AdvertisementRepository();
        public int Sum(int i, int j)
        {
            return dal.Sum(i, j);

        }


        public int Add(Advertisement model)
        {
            return dal.Add(model);
        }

        public bool Delete(Advertisement model)
        {
            return dal.Delete(model);
        }

        public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        {
            return dal.Query(whereExpression);

        }

        public bool Update(Advertisement model)
        {
            return dal.Update(model);
        }

    }
}
