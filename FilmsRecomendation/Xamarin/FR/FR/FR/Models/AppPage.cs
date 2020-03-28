﻿namespace FR.Models
{
    public class AppPage
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public AppPageType Type { get; set; }
        public object ViewModel { get; set; }
    }

    public enum AppPageType
    {
        Live,
        Movie,
        Show,
        Extra
    }
}
