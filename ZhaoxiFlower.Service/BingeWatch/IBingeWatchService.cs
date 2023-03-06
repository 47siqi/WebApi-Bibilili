using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoxiFlower.Service.BingeWatch.Dot;

namespace ZhaoxiFlower.Service.BingeWatch
{
    public interface IBingeWatchService
    {
        List<BingeWatchRes> GetBingeWatch(BingeWatchReq req);
    }
}
