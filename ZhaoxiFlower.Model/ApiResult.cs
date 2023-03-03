using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhaoxiFlower.Model
{
    //方便前端判断 
    public  class ApiResult
    {
        public bool IsSuccess { get; set; }  //api结果成功还是失败 做一个标记
        public object Result { get; set; }  //结果是什么
        public string Msg { get; set; }  //异常记录
    }
}
