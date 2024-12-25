using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ya.Model;

namespace Ya.DAL
{
    public class BaseService<T> where T : BaseEntity, new()
    {
        public async virtual Task<int> InsertAsync(T model) //插入
        {
            var res = DB.SqlSugarClient.Insertable<T>(model);
            return await res.ExecuteCommandAsync();

        }
        public async virtual Task<bool> UpdateAsync(T model) //更新
        {
            var runsql = DB.SqlSugarClient.Updateable(model);
            var rows = await runsql.ExecuteCommandAsync();
            return rows > 0;
        }

        public async virtual Task<bool> DeleteAsync(T model) //删除
        {
            var runsql = DB.SqlSugarClient.Deleteable(model);
            var rows = await runsql.ExecuteCommandAsync();
            return rows > 0;
        }

        public async virtual Task<T> GetByOneAsync(Expression<Func<T, bool>> where) //查询单个
        {
            var runsql = DB.SqlSugarClient.Queryable<T>().Where(where);
            return await runsql.FirstAsync();
        }



        public async virtual Task<List<T>> GetListAsync(Expression<Func<T, bool>> where)//查询多个
        {
            var runsql = DB.SqlSugarClient.Queryable<T>();
            return await runsql.ToListAsync();
        }

        /// <summary>
        /// 根据条件判断一条记录是否存在
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public async virtual Task<bool> ExistsAsync(Expression<Func<T, bool>> where) //判断是否存在
        {
            return await DB.SqlSugarClient.Queryable<T>()
                .Where(where)
                .AnyAsync();
        }
    }
}
