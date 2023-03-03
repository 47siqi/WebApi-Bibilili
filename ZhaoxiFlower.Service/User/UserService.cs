using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoxiFlower.Common;
using ZhaoxiFlower.Model.Entitys;
using ZhaoxiFlower.Model.Enum;
using ZhaoxiFlower.Service.User.Dto;

namespace ZhaoxiFlower.Service
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper; 
        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }
        //登录方法
        public UserRes GetUsers(UserReq req)
        {
            //根据用户名查询数据库
            var user = DbComText.db.Queryable<Users>().First(p => p.UserName == req.UserName && p.Password == req.Password);
            if (user != null)
            {
                return _mapper.Map<UserRes>(user);
            }
            return new UserRes();
        }
        //注册方法
        public UserRes RegisterUser(RegisterReq req, ref string msg)
        {
            //根据用户名查询数据库，判断是否账号已存在
            var user = DbComText.db.Queryable<Users>().First(p => p.UserName == req.UserName);
            if (user != null)
            {
                msg = "账号已存在！";
                return _mapper.Map<UserRes>(user);
            }
            else
            {
                try
                {
                    Users users = _mapper.Map<Users>(req);
                    users.CreateTime = DateTime.Now;
                    users.UserType = (int)EnumUserType.普通用户;
                    //在数据库中新增用户
                    bool res = DbComText.db.Insertable(users).ExecuteCommand() > 0;  //大于0时，表示创建成功
                    if (res)
                    {
                        user = DbComText.db.Queryable<Users>().First(p => p.UserName == req.UserName && p.Password == req.Password);
                        //返回给前端
                        return _mapper.Map<UserRes>(user);
                    }
                }
                catch (Exception ex)
                {
                    msg = ex.Message; 
                }
            }
            return new UserRes();
        }
    }
}
