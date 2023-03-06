using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoxiFlower.Common;
using ZhaoxiFlower.Model.Entitys;
using ZhaoxiFlower.Service.BingeWatch.Dot;
using ZhaoxiFlower.Service.FileCard.Dot;

namespace ZhaoxiFlower.Service.BingeWatch
{
    public class BingeWatchService : IBingeWatchService
    {
        public readonly IMapper _mapper;
        public BingeWatchService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<BingeWatchRes> GetBingeWatch(BingeWatchReq req)
        {

            var res = DbComText.db.Queryable<BingeWatchings>().WhereIF(req.Id > 0, x => x.Id == req.Id).ToList();
            return _mapper.Map<List<BingeWatchRes>>(res);
        }
    }
}
