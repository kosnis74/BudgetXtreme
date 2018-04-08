/***********************************************************************
* Project           : Budget Xtreme
*
* Program name      : AddNewBillActivity.cs
*
* Author            : Scott Kosnicki, Emmanuel Mercado, Tess Miller,
*                     Matthew Vanden Hogen
*
* Date created      : 4/7/2018
*
* Purpose           : This will allow a user to add a new bill to their
*                     budget
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
    [Activity(Label = "AddNewBillActivity")]
    public class AddNewBillActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view to the Add New Bill Layout
            SetContentView(Resource.Layout.AddNewBill);
        }
    }
}