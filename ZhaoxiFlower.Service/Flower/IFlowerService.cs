using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoxiFlower.Service.Flower.Dto;

namespace ZhaoxiFlower.Service
{
    public interface IFlowerService
    {
        List<FlowerRes> GetFlowers(FlowerReq req);  //获取鲜花
    }
}
