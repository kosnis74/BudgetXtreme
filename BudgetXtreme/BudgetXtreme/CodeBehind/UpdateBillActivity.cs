﻿/***********************************************************************
* Project           : Budget Xtreme
*
* Program name      : UpdateBillActivity.cs
*
* Author            : Scott Kosnicki, Emmanuel Mercado, Tess Miller,
*                     Matthew Vanden Hogen
*
* Date created      : 4/7/2018
*
* Purpose           : This allows the user to modify or delete bills
*                     that they have already stored in the database
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
    [Activity(Label = "UpdateBillActivity")]
    public class UpdateBillActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view to the Update Bill Layout
            SetContentView(Resource.Layout.UpdateBill);
        }
    }
}