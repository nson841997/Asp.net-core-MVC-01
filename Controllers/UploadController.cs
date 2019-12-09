using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult UploadFiles(List<IFormFile> myfile)
        {
            // duyệt từng file lưu thư mục chỉ định
            foreach (IFormFile f in myfile)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "Myfiles", f.FileName);

                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    f.CopyTo(file);
                }
            }



            return View("Index");
        }
    }
}