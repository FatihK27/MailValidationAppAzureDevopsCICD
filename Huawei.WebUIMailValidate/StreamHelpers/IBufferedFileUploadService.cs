using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Huawei.WebUIMailValidate.StreamHelpers
{
    public interface IBufferedFileUploadService
    {
        Task<(bool sonuc,string filepath)> UploadFile(IFormFile file);
    }
}
