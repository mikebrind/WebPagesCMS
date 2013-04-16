using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;


public static class Check
{
	public static void User(string action) {
	    User(new[] {action});
	}

    public static void User(IEnumerable<string> actions) {
        if (actions.Any(Permissions.User)) {
            return;
        }
        HttpContext.Current.Response.StatusCode = (int) HttpStatusCode.Unauthorized;
    }
}