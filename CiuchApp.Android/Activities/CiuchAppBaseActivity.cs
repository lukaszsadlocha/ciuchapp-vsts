using Android.App;
using CiuchApp.DataAccess;
using CiuchApp.ApiClient;

namespace CiuchApp.Mobile.Activities
{
    public abstract class CiuchAppBaseActivity : Activity
    {
        protected CiuchApp.ApiClient.ApiClient apiClientService = new CiuchApp.ApiClient.ApiClient();
    }
}