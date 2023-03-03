using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoxiFlower.Common;
using ZhaoxiFlower.Model.Entitys;
using ZhaoxiFlower.Service.FileCard.Dot;
using ZhaoxiFlower.Service.Flower.Dto;

namespace ZhaoxiFlower.Service.FileCard
{
    public class FileCardService : IFileCardService
    {
        private readonly IMapper _mapper;
        public FileCardService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<FileCardRes> GetFileCards(FileCardReq req)
        {
            var res = DbComText.db.Queryable<FileCards>().WhereIF(req.Id > 0, x => x.Id == req.Id).ToList();
            return _mapper.Map<List<FileCardRes>>(res);
        }
    }
}
