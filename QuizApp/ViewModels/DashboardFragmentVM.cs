using System.Collections.ObjectModel;

namespace QuizApp
{
    public class DashboardFragmentVM: BaseViewModel
    {
        public DashboardFragmentVM()
        {
            load();
        }

        public ObservableCollection<DashboardCoursesItemVM> Courses { get; set; }

        public ObservableCollection<CommunityActivityItemVM> CommunityQuestions { get; set; }

        public ObservableCollection<UserPerformanceListItemVM> QuizPerformance { get; set; }

        public void load()
        {
            ObservableCollection<DashboardCoursesItemVM> downloadedCourses = new ObservableCollection<DashboardCoursesItemVM>();
            downloadedCourses.Add(new DashboardCoursesItemVM()
            {
                CourseName = "HTML Basics",
                CourseProgress = 28,
                CourseProgressText = "28%"
            });
            downloadedCourses.Add(new DashboardCoursesItemVM()
            {
                CourseName = "Angular in steps",
                CourseProgress = 55,
                CourseProgressText = "55%"
            });
            downloadedCourses.Add(new DashboardCoursesItemVM()
            {
                CourseName = "Bootstrap Foundations",
                CourseProgress = 95,
                CourseProgressText = "95%"
            });

            ObservableCollection<CommunityActivityItemVM> downloadedCommunityQuestions = new ObservableCollection<CommunityActivityItemVM>();
            downloadedCommunityQuestions.Add(new CommunityActivityItemVM()
            {
                ImagePath = "../images/avatar.png",
                QuestionText = "Where to find C# courses?"
            });
            downloadedCommunityQuestions.Add(new CommunityActivityItemVM()
            {
                ImagePath = "../images/avatar.png",
                QuestionText = "Where to find C# courses?"
            });
            downloadedCommunityQuestions.Add(new CommunityActivityItemVM()
            {
                ImagePath = "../images/avatar.png",
                QuestionText = "Where to find C# courses?"
            });
            downloadedCommunityQuestions.Add(new CommunityActivityItemVM()
            {
                ImagePath = "../images/avatar.png",
                QuestionText = "Where to find C# courses?"
            });

            ObservableCollection<UserPerformanceListItemVM> downloadedQuizPerformance = new ObservableCollection<UserPerformanceListItemVM>();
            downloadedQuizPerformance.Add(new UserPerformanceListItemVM()
            {
                CourseName = "Course: C# Quiz",
                QuizMark = "6/10",
                QuizTitle = "C#"
            });
            downloadedQuizPerformance.Add(new UserPerformanceListItemVM()
            {
                CourseName = "Course: Java Quiz",
                QuizMark = "3/10",
                QuizTitle = "Java"
            });
            downloadedQuizPerformance.Add(new UserPerformanceListItemVM()
            {
                CourseName = "Course: Kotlin Quiz",
                QuizMark = "7/10",
                QuizTitle = "Kotlin"
            });

            Courses = downloadedCourses;
            CommunityQuestions = downloadedCommunityQuestions;
            QuizPerformance = downloadedQuizPerformance;
        }
    }
}
