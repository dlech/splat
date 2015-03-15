using System;

using Gdk;

namespace Splat
{
    public static class ColorExtensions
    {
        public static RGBA ToNative(this System.Drawing.Color This)
        {
            return new RGBA () {
                Alpha = This.A / 255.0, Red = This.R / 255.0, Green = This.G / 255.0, Blue = This.B / 255.0
            };
        }

        public static System.Drawing.Color FromNative(this RGBA This)
        {
            return System.Drawing.Color.FromArgb((int)(This.Alpha * 255.0), (int)(This.Red * 255.0),
                (int)(This.Green * 255.0), (int)(This.Blue * 255.0));
        }
    }
}
