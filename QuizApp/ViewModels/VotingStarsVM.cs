using System;
using System.Windows.Media;

namespace QuizApp
{
    public class VotingStarsVM : BaseViewModel
    {
        private double mMark;
        public double Mark
        {
            get
            {
                return mMark;
            }
            set
            {
                setMarks(value);
            }
        }
        public void setMarks(double markValue)
        {
            mMark = markValue;
            double numOfFullStars;
            MaterialDesignThemes.Wpf.PackIcon[] starIcons = new MaterialDesignThemes.Wpf.PackIcon[5];
            double rounded = Math.Round(markValue, 1);
            if (rounded >= 4.5)
            {
                //5 stars
                numOfFullStars = 5;
            }
            else if (rounded >= 3.5)
            {
                //4 stars
                numOfFullStars = 4;
            }
            else if (rounded >= 2.5)
            {
                //3 stars
                numOfFullStars = 3;
            }
            else if (rounded >= 1.5)
            {
                //2 stars
                numOfFullStars = 2;
            }
            else if (rounded >= 0.5)
            {
                //1 star
                numOfFullStars = 1;
            }
            else
            {
                numOfFullStars = 0;
            }
            int i;
            for (i = 0; i < numOfFullStars; i++)
            {
                MaterialDesignThemes.Wpf.PackIcon star = new MaterialDesignThemes.Wpf.PackIcon();
                star.Kind = MaterialDesignThemes.Wpf.PackIconKind.Star;
                star.Foreground = Brushes.Yellow;
                starIcons[i] = star;
            }
            for (int k = i; k < 5; k++)
            {
                MaterialDesignThemes.Wpf.PackIcon star = new MaterialDesignThemes.Wpf.PackIcon();
                star.Kind = MaterialDesignThemes.Wpf.PackIconKind.StarBorder;
                star.Foreground = Brushes.Yellow;
                starIcons[k] = star;
            }
        }
    }
}
