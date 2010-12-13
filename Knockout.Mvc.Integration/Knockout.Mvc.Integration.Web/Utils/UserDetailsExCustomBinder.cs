using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Knockout.Mvc.Integration.Web.Utils
{
    /// <summary>
    /// Custom model binder for UserDetails class
    /// </summary>
    public class UserDetailsExCustomBinder : DefaultModelBinder
    {
        public static readonly JavaScriptSerializer _serializer = new JavaScriptSerializer();

        protected override void BindProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor)
        {
            if (propertyDescriptor.PropertyType == typeof(List<string>))
            {
                ValueProviderResult value = bindingContext.ValueProvider.GetValue(propertyDescriptor.Name);
                List<string> result = _serializer.Deserialize<List<string>>(value.AttemptedValue);

                propertyDescriptor.SetValue(bindingContext.Model, result);
                return;
            }

            base.BindProperty(controllerContext, bindingContext, propertyDescriptor);
        }
    }
}