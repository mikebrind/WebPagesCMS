using System.Web.WebPages;

public class CmsWebPage : WebPage
{
    protected HelperResult RenderZone(int zone, object[] data = null) {
        var newData = data.AddProperty("ZoneId", zone);
	    return base.RenderPage("~/Render/_RenderWidgets.cshtml", newData);
	}

    public override void Execute() {
        
    }
}