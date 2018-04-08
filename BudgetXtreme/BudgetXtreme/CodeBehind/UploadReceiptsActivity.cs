/***********************************************************************
* Project           : Budget Xtreme
*
* Program name      : UploadReceiptsActivity.cs
*
* Author            : Scott Kosnicki, Emmanuel Mercado, Tess Miller,
*                     Matthew Vanden Hogen
*
* Date created      : 4/7/2018
*
* Purpose           : This allows the user to upload their receipts
*                     by either camera or their saved pictures
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
    [Activity(Label = "UploadReceiptsActivity")]
    public class UploadReceiptsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view to the Upload Receipts Layout
            SetContentView(Resource.Layout.UploadReceipts);
        }
    }
}