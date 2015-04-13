namespace SUGCH2015.Website.Pipelines.HttpRequest
{
    using System.Globalization;
    using System.Threading;
    using Sitecore.Pipelines.HttpRequest;

    public class CultureResolver : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            if (Sitecore.Context.Language == null || Sitecore.Context.Database == null || string.IsNullOrEmpty(Sitecore.Context.Language.Name)) return;

            var language = Sitecore.Context.Database.GetItem("/sitecore/system/Languages/" + Sitecore.Context.Language.Name);
            if (language == null) return;
            
            var culture = new CultureInfo(language["regional iso code"]);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}