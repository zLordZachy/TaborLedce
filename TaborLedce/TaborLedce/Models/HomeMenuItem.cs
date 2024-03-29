﻿namespace TaborLedce.Models
{
    public enum MenuItemType
    {
        MorseCode = 0,
        About =1
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }

        public object FontFamily { get; set; }
    }
}
