using System.Web;
using System.Web.Mvc;

namespace Calculadora_Prestamos__Tabla_Amortización_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
