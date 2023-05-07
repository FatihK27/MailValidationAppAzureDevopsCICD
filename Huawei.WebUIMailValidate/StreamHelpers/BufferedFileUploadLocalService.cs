using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System;
using Serilog;

namespace Huawei.WebUIMailValidate.StreamHelpers
{
    public class BufferedFileUploadLocalService : IBufferedFileUploadService
    {
        

        public async Task<(bool sonuc,string filepath)> UploadFile(IFormFile file)
        {
            string path = "";
            try
            {
                Log.Information("Başlıyor");
                //System.Diagnostics.Debug.WriteLine("Başlıyor.");
                Log.Information("Gelen Dosya Adı:{0}",file.FileName);
                //Console.WriteLine("Gelen Dosya Adı:{0}", file.FileName);
                
                if (file.Length > 0)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "./wwwroot/uploadedfiles"));
                    Log.Information("Dosya yolu:{0}",path);
                    Console.WriteLine("Dosya yolu:{0}", path);

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return (true,path+"/"+file.FileName);
                }
                else
                {
                    return (false,"");
                }
            }
            catch (Exception ex)
            {
                Log.Information("Hata:{0}",ex.ToString());
                Console.WriteLine(ex.ToString());
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}
