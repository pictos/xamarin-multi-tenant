﻿using Android.App;
using Android.Content.PM;
using XamarinMultiTenant.Android.Core;
using XamarinMultiTenant.Common;

namespace XamarinMultiTenant.Droid
{
    [Activity(Label = "XamarinMultiTenant", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MainActivityBase
    {
        protected override ITenant Tenant => Tenants.TenantA.GetTenant();
    }
}