﻿using DarkThemeApp.PageModels;
using Xamarin.Forms;

namespace DarkThemeApp.Helpers
{
    public static class ThemeHelper
    {
        public enum ThemeChoices
        {
            Random
        }
        public static void SetTheme()
        {
            switch(MainPageModel.Theme)
            {
                case 0:
                    App.Current.UserAppTheme = T.Unspecified;
                    break;

                case 1:
                    App.Current.UserAppTheme = OSAppTheme.Light;
                    break;

                case 2:
                    App.Current.UserAppTheme = OSAppTheme.Dark;
                    break;
            }
        }
    }
}