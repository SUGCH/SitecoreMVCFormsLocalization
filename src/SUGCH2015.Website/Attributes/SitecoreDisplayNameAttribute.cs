namespace SUGCH2015.Website.Attributes
{
    using System.ComponentModel;
    using Sitecore.Globalization;

    public class SitecoreDisplayNameAttribute : DisplayNameAttribute
    {
        private readonly string name;

        public SitecoreDisplayNameAttribute(string name)
        {
            this.name = name;
        }

        public override string DisplayName
        {
            get { return Translate.Text(this.name); }
        }
    }
}