using Android.App;
using CiuchApp.DataAccess;

namespace CiuchApp.Android.Activities
{
    public abstract class CiuchAppBaseActivity : Activity
    {
        protected CiuchAppContext ciuchAppContext = new CiuchAppContext();
    }
}