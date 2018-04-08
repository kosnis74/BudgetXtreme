/***********************************************************************
* Project           : Budget Xtreme
*
* Program name      : CurrentBudgetsActivity.cs
*
* Author            : Scott Kosnicki, Emmanuel Mercado, Tess Miller,
*                     Matthew Vanden Hogen
*
* Date created      : 4/7/2018
*
* Purpose           : This shows the user their current daily, weekly,
*                     monthly and yearly budgets
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BudgetXtreme.CodeBehind
{
    [Activity(Label = "CurrentBudgetsActivity")]
    public class CurrentBudgetsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view to the Current Budgets Layout
            SetContentView(Resource.Layout.CurrentBudgets);
        }
    }
}