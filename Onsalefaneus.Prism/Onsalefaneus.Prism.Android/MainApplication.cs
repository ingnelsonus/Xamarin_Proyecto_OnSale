using System;
using Android.App;
using Android.Runtime;
using FFImageLoading.Forms.Platform;
using Syncfusion.SfBusyIndicator.XForms.Droid;

namespace Onsalefaneus.Prism.Droid
{
    [Application(
        Theme = "@style/MainTheme"
        )]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);           
            //CachedImageRenderer.Init(true);            
        }
    }
}
