using RecrutTask.Models;
using RecrutTask.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RecrutTask.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
    

        DalContext db = new DalContext();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public ActionResult GetInput()
        {
            return View("GetInput");
        }
        

        /// <summary>
        ///
        /// </summary>
        /// <param name="dataModelEntity"></param>
        /// <returns></returns>

    
        [HttpPost]
        public async Task<ActionResult> GetInput(DataModelEntity dataModelEntity)
        { 
            if (ModelState.IsValid)
            {
                var caller = new ApiCaller();
                var cos = await caller.CallToApi(dataModelEntity.InputString);
                dataModelEntity.TranslatedString = cos.ToString();
                db.dataModelEntities.Add(dataModelEntity);
                db.SaveChanges();

                return View("TranslatedString",dataModelEntity);
            }

            return Content("Please, enter the text!");
        }
    }
}