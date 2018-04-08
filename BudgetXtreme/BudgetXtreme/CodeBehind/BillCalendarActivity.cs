﻿/***********************************************************************
* Project           : Budget Xtreme
*
* Program name      : BillCalendarActivity.cs
*
* Author            : Scott Kosnicki, Emmanuel Mercado, Tess Miller,
*                     Matthew Vanden Hogen
*
* Date created      : 4/7/2018
*
* Purpose           : This shows the user their upcoming bills in text
*                     and calendar format
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
    [Activity(Label = "BillCalendarActivity")]
    public class BillCalendarActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view to the Bill Calendar Layout
            SetContentView(Resource.Layout.BillCalendar);
        }
    }
}