using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Pakohuone.Models.Bootstrap;

namespace Pakohuone.Extensions
{
    public static class TempDataBootstrapExtensions
    {
        public static void PutAlert(this ITempDataDictionary tempData, Alert alert)
        {
            tempData.Put("Alert", alert);
        }

        public static Alert GetAlert(this ITempDataDictionary tempData)
        {
            return tempData.Get<Alert>("Alert");
        }
    }
}
