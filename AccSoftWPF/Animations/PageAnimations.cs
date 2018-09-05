﻿using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace AccSoftWPF

{
    public static class PageAnimations
    {
        public static async Task FadeIn(this Page page, float seconds)
        {
            var sb = new Storyboard();

            sb.AddFadeIn(seconds);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds * 1000);
        }

        public static async Task FadeOut(this Page page, float seconds)
        {
            var sb = new Storyboard();

            sb.AddFadeOut(seconds);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds * 1000);
        }

        public static async Task SlideInFromLeft(this Page page, float seconds)
        {
            var sb = new Storyboard();

            sb.AddSlideFromLeft(seconds, 1200);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds * 1000);
        }

        public static async Task SlideInFromRight(this Page page, float seconds)
        {
            var sb = new Storyboard();

            sb.AddSlideFromRight(seconds, 1200);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds * 1000);
        }

        public static async Task SlideOutToLeft(this Page page, float seconds)
        {
            var sb = new Storyboard();

            sb.AddSlideToLeft(seconds, 1200);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds * 1000);
        }

        public static async Task SlideOutToRight(this Page page, float seconds)
        {
            var sb = new Storyboard();

            sb.AddSlideToRight(seconds, 1200);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds * 1000);
        }
    }
}
