using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.ViewComponents
{
    public class ContactFormViewComponent:ViewComponent
    {

        public ContactFormViewComponent(IUrlHelperFactory factory)
        {
            this.factory = factory;
        }
        private IUrlHelperFactory factory;


        public IViewComponentResult Invoke()
        {
            IUrlHelper helper = factory.GetUrlHelper(ViewContext);
            helper.Action("contactme","home"); // returns url to the current controller action

            return View();
        }

    }
}
