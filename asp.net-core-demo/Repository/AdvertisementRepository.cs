using IRepository;
using Model;
using Repository.sugar;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public class AdvertisementRepository : IAdvertisementRepository
    {

        private DbContext context;
        private SqlSugarClient db;
        private SimpleClient<Advertisement> entityDB;

        internal SqlSugarClient Db
        {
            get { return db; }
            private set { db = value; }
        }
        public DbContext Context
        {
            get { return context; }
            set { context = value; }
        }
        public AdvertisementRepository()
        {
            DbContext.Init(BaseDBConfig.ConnectionString);
            context = DbContext.GetDbContext(); 
            db = context.Db;
            //创建数据库
            db.CodeFirst.SetStringDefaultLength(200).InitTables(typeof(Advertisement));
            entityDB = context.GetEntityDB<Advertisement>(db);
        }
        public int Add(Advertisement model)
        {
            //返回的i是long类型,这里你可以根据你的业务需要进行处理
            var i = db.Insertable(model).ExecuteReturnBigIdentity();
            return i.ObjToInt();
        }

        public bool Delete(Advertisement model)
        {
            var i = db.Deleteable(model).ExecuteCommand();
            return i > 0;
        }

        public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        {
            return entityDB.GetList(whereExpression);

        }

        public int Sum(int i, int j)
        {
            return i + j;
        }

        public bool Update(Advertisement model)
        {
            //这种方式会以主键为条件
            var i = db.Updateable(model).ExecuteCommand();
            return i > 0;
        }

        public Task<Advertisement> QueryByID(object objId)
        {
            throw new NotImplementedException();
        }

        public Task<Advertisement> QueryByID(object objId, bool blnUseCache = false)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> QueryByIDs(object[] lstIds)
        {
            throw new NotImplementedException();
        }

        Task<int> IBaseRepository<Advertisement>.Add(Advertisement model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseRepository<Advertisement>.Delete(Advertisement model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIds(object[] ids)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseRepository<Advertisement>.Update(Advertisement model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Advertisement entity, string strWhere)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Advertisement entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "")
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query()
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(string strWhere)
        {
            throw new NotImplementedException();
        }

        Task<List<Advertisement>> IBaseRepository<Advertisement>.Query(Expression<Func<Advertisement, bool>> whereExpression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(Expression<Func<Advertisement, bool>> whereExpression, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(Expression<Func<Advertisement, bool>> whereExpression, Expression<Func<Advertisement, object>> orderByExpression, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(string strWhere, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(Expression<Func<Advertisement, bool>> whereExpression, int intTop, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(string strWhere, int intTop, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(Expression<Func<Advertisement, bool>> whereExpression, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Advertisement>> QueryPage(Expression<Func<Advertisement, bool>> whereExpression, int intPageIndex = 0, int intPageSize = 20, string strOrderByFileds = null)
        {
            throw new NotImplementedException();
        }
    }
}
