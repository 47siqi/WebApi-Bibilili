using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZhaoxiFlower.Model;
using ZhaoxiFlower.Service.BingeWatch;
using ZhaoxiFlower.Service.BingeWatch.Dot;
using ZhaoxiFlower.Service.FileCard.Dot;

namespace FlowerWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BingeWatchController : ControllerBase
    {
        public readonly IBingeWatchService _bingeWatchService;
        public BingeWatchController(IBingeWatchService bingeWatchService)
        {
            _bingeWatchService = bingeWatchService;
        }
        [HttpPost]
        public ApiResult GetBingeWatch(BingeWatchReq req)
        {
            ApiResult apiResult = new ApiResult() { IsSuccess = true };
            apiResult.Result = _bingeWatchService.GetBingeWatch(req);
            return apiResult;

        }
    }
}
