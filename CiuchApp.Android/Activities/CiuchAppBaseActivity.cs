using Android.App;
using CiuchApp.DataAccess;
using CiuchApp.ApiClient;
using Android.Content;

namespace CiuchApp.Mobile.Activities
{
    public abstract class CiuchAppBaseActivity : Activity
    {
        protected CiuchApp.ApiClient.ApiClient apiClientService = new CiuchApp.ApiClient.ApiClient();
        protected void Next<T>() where T : Activity
        {
            StartActivity(new Intent(this, typeof(T)));
        }
    }
}