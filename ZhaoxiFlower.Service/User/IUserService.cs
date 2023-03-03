using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoxiFlower.Model.Entitys;
using ZhaoxiFlower.Service.User.Dto;

namespace ZhaoxiFlower.Service
{
    public interface IUserService
    {
        //登录方法
        UserRes GetUsers(UserReq req);
        //注册方法
        UserRes RegisterUser(RegisterReq req, ref string msg);
    }
}
