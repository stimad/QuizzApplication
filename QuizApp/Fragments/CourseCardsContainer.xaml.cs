using System.Diagnostics;
using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for CourseCardsContainer.xaml
    /// </summary>
    public partial class CourseCardsContainer : UserControl
    {
        CourseCardsContainerVM vm;
        public CourseCardsContainer()
        {
            InitializeComponent();
            vm = new CourseCardsContainerVM();
            DataContext = vm;
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            vm.populateAllCourses();
            vm.populateCourseCategories();
            vm.populatePopularCourses();
        }

        private void Grid_MouseDown(object sender, System.Windows.RoutedEventArgs e)
        {
            (DataContext as CourseCardsContainerVM).ViewModel = new CourseExpandedVM()
            {
                CourseContent = new System.Collections.ObjectModel.ObservableCollection<CourseContentDataModel>()
                {
                    new CourseContentDataModel()
                    {
                        CourseContentItem = "Over 40 lessons "
                    },
                    new CourseContentDataModel()
                    {
                        CourseContentItem = "Over 40 lessons "
                    },
                    new CourseContentDataModel()
                    {
                        CourseContentItem = "Over 40 lessons "
                    }
                },
                CourseDescription = "This is course description and This is course description and This is course description and This is course description and This is course description and This is course description and This is course description and This is course description and This is course description and This is course description and This is course description and This is course description and ",
                CourseImage = "../images/courseImage.jpg",
                CourseLessons = new System.Collections.ObjectModel.ObservableCollection<CourseLessonsDataModel>()
                {
                    new CourseLessonsDataModel()
                    {
                        LessonDuration = "40 days",
                        LessonName = "Lesson 1"
                    },
                    new CourseLessonsDataModel()
                    {
                        LessonDuration = "40 days",
                        LessonName = "Lesson 2"
                    },
                    new CourseLessonsDataModel()
                    {
                        LessonDuration = "40 days",
                        LessonName = "Lesson 3"
                    }
                },
                CourseTitle = "C# For beginners",
                ReviewNaumber = "(22 reviews)",
                TeacherImage = "../images/avatar.png",
                TeacherName = "Mirko",
                TeacherProfession = "Instructor",
                VotingMark = 3,
                SimilarCourses = new System.Collections.ObjectModel.ObservableCollection<CourseListItem>()
                {
                    new CourseListItem()
                    {
                        CourseName = "C# For Beginners",
                        CoursePrice = "FREE",
                        ImagePath = "../images/avatar.png"
                    },
                    new CourseListItem()
                    {
                        CourseName = "C# For Beginners",
                        CoursePrice = "FREE",
                        ImagePath = "../images/avatar.png"
                    },
                    new CourseListItem()
                    {
                        CourseName = "C# For Beginners",
                        CoursePrice = "FREE",
                        ImagePath = "../images/avatar.png"
                    }
                },
                CourseCategories =new System.Collections.ObjectModel.ObservableCollection<string>()
                {
                    "All Categories", "Business"
                },
                Certificate = "Certificate of Completition",
                CoursePrice = "PRICE: $250",
                Duration = "Duration: 30 days",
                Lectures = "Lectures: 10",
                NumberOfStudents = "199 Students",
                VideoDuration = "Video: 12 hours"
            };
            CContainer.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
