using IronPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FileUploadApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [System.Web.Mvc.HttpPost]
        public JsonResult upload(HttpPostedFileBase file)
        {
            
            StringBuilder strbuild = new StringBuilder();
            try
            {
                if (file.ContentLength == 0)
                    throw new Exception("Zero length file!");
                else
                {
                    var fileName = Path.GetFileName(file.FileName);
                    //if (!Directory.Exists(Server.MapPath("~/uploads")))
                    //{
                    //    Directory.CreateDirectory(Server.MapPath("~/uploads"));
                    //}
                    //var filePath = Path.Combine(Server.MapPath("~/uploads"), fileName);
                    //file.SaveAs(filePath);
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        using (PdfDocument sr = new PdfDocument(file.InputStream))
                        {
                           
                                strbuild.AppendFormat(sr.ExtractTextFromPage(0));
                            
                        }
                    }
                }
            }
            catch (Exception)
            {
               
            }

            return new JsonResult()
            {
                Data = strbuild.ToString()
            };
        }
        public JsonResult uploadtext(HttpPostedFileBase file)
        {
           
            StringBuilder strbuild = new StringBuilder();
            try
            {
                if (file.ContentLength == 0)
                    throw new Exception("Zero length file!");
                else
                {
                    var fileName = Path.GetFileName(file.FileName);
                    //if (!Directory.Exists(Server.MapPath("~/uploads")))
                    //{
                    //    Directory.CreateDirectory(Server.MapPath("~/uploads"));
                    //}
                    //var filePath = Path.Combine(Server.MapPath("~/uploads"), fileName);
                    //file.SaveAs(filePath);
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        using (StreamReader sr = new StreamReader(file.InputStream))
                        {

                            strbuild.AppendFormat(sr.ReadToEnd());

                        }
                    }
                }
            }
            catch (Exception)
            {
              
            }

            return new JsonResult()
            {
                Data = strbuild.ToString()
            };
        }

    }
}
