using HZY.Framework.DependencyInjection;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ya.Helper;
using Ya.Model;

namespace Ya.DAL
{
    public class UserService : BaseService<UserEntity>, IScopedSelfDependency
    {
        public async Task<BaseResult<UserEntity>> LoginAsync(UserEntity entity)
        {
            BaseResult<UserEntity> result = new BaseResult<UserEntity>();

            var res = await DB.SqlSugarClient.Queryable<UserEntity>().Where(e => e.UserName == entity.UserName && e.UserPassword == entity.UserPassword).FirstAsync();
            if (res == null)
            {
                result.Status = SystemEnums.Result.Fail;
                result.Msg = "用户名或密码错误";
                return result;
            }

            result.Data = new List<UserEntity>() { res };
            return result;
        }

        public async Task<BaseResult> IsUserNameExistAsync(UserEntity entity)
        {
            BaseResult result = new BaseResult();

            var res = await ExistsAsync(e => e.UserName == entity.UserName);

            if (res)
            {
                result.Status = SystemEnums.Result.Fail;
                result.Msg = "用户名已存在";
                return result;
            }

            result.Status = SystemEnums.Result.Success;
            return result;

        }
    }
}
