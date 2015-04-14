namespace SUGCH2015.Website.Attributes
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using Sitecore.Globalization;

    public class SitecoreRequiredAttribute : RequiredAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return string.Format(CultureInfo.CurrentCulture, Translate.Text(this.ErrorMessageString), name);
        }
    }
}