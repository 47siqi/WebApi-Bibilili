using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoxiFlower.Service.FileCard.Dot;

namespace ZhaoxiFlower.Service.FileCard
{
    public interface IFileCardService
    {
        List<FileCardRes> GetFileCards(FileCardReq req);
    }
}
