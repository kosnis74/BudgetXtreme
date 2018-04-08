/***********************************************************************
* Project           : Budget Xtreme
*
* Program name      : MainActivity.cs
*
* Author            : Scott Kosnicki, Emmanuel Mercado, Tess Miller,
*                     Matthew Vanden Hogen
*
* Date created      : 4/7/2018
*
* Purpose           : This application will allow the user to enter a 
*                     budget for their choice of time period, yearly,
*                     monthly, or weekly.  User will receive a 
*                     notification for upcoming bills that are due as 
*                     well as when the budget has been exceeded due to 
*                     purchases.
************************************************************************/

using Android.App;
using Android.Widget;
using Android.OS;

namespace BudgetXtreme
{
    [Activity(Label = "BudgetXtreme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

