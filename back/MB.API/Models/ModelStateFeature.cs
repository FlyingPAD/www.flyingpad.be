using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MB.API.Models
{
    public class ModelStateFeature
    {
        public ModelStateDictionary ModelState { get; set; }

        public ModelStateFeature(ModelStateDictionary modelState)
        {
            ModelState = modelState;
        }
    }
}