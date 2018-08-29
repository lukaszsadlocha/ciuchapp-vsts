using Android.App;
using CiuchApp.DataAccess;
using CiuchApp.Android.Services;

namespace CiuchApp.Android.Activities
{
    public abstract class CiuchAppBaseActivity : Activity
    {
        protected RestService restClient = new RestService();
    }
}