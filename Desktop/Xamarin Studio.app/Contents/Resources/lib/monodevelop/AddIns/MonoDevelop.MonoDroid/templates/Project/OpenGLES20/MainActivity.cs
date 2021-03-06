﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace ${Namespace}
{
	// the ConfigurationChanges flags set here keep the EGL context
	// from being destroyed whenever the device is rotated or the
	// keyboard is shown (highly recommended for all GL apps)
	[Activity (Label = "${AppName}",
				ConfigurationChanges=ConfigChanges.KeyboardHidden,
				ScreenOrientation = ScreenOrientation.SensorLandscape,
				MainLauncher = true,
				Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		GLView1 view;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var manager = GetSystemService(Context.ActivityService) as ActivityManager;
			if (manager.DeviceConfigurationInfo.ReqGlEsVersion >= 0x20000)
			{
				// Create our OpenGL view, and display it
				view = new GLView1(this);
				SetContentView(view);
			}
			else
				SetContentView (Resource.Layout.Main);
		}
	}
}

