using System.Web.Mvc;

namespace TeleDermUI.Areas.Reader
{
    public class ReaderAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Reader";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Reader_default",
                "Reader/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
