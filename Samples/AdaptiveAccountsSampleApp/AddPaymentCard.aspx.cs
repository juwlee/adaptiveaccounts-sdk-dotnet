using System;

namespace AdaptiveAccountsSampleApp
{
    public partial class AddPaymentCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentPath = System.Web.HttpContext.Current.Request.Url.OriginalString;
            this.returnURL.Value = currentPath;
            this.cancelURL.Value = currentPath;
        }
    }
}
