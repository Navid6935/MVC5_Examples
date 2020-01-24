using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controller01.Controllers
{
    /// <summary>
    /// کنترلر خودش یک کلاس است
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// حالت اول
        /// کاربر درخواست می دهد
        /// از کنترلر جواب می گیرد
        /// انواع نام برده از اکشن ریزالت ارث بری می کنند
        /// این اکشن حتما باید پارامتری اینتیجر به عنوان آی دی داشته باشد 
        /// اگر نداشته باشد ارور مناسب می دهد
        /// وقتی از علامت سوال  بعد از نوع اسنفاده می کنیم
        /// آن متغیر  دارای پراپرتی هز ولیو می شود
        /// هز ولیو جهت چک کردن اینکه آیا مقدار دارد یا خیر
        /// </summary>
        /// <returns></returns>
        public ActionResult session01_08(int? id)
        {
            string strContent = string.Empty;
            if (id.HasValue)
            {
                strContent = id.Value.ToString();
            }
            else
            {
                strContent = "Id Has A null Value";
            }
            return (Content(strContent));
        }
    }
}