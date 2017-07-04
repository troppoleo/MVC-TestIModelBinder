using System.Web.Mvc;

namespace TestIModelBinder.Models.Mapper
{
    public class ModelMapperPerson : System.Web.Mvc.IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
        {
            var f = controllerContext.HttpContext.Request.Form;
            var name_surname = f.Get("name") + f.Get("surname");
            var age = int.Parse(f.Get("age"));

            return new PersonCompact() { age = age, name_surname = name_surname };
        }
    }
}