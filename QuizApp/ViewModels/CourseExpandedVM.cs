using System.Collections.ObjectModel;

namespace QuizApp
{
    class CourseExpandedVM : BaseViewModel
    {
        public string CourseTitle { get; set; }
        public string TeacherImage { get; set; }
        public string TeacherProfession { get; set; }
        public string TeacherName { get; set; }
        public int VotingMark { get; set; }
        public string ReviewNaumber { get; set; }
        public string CourseImage { get; set; }
        public string CourseDescription { get; set; }
        public ObservableCollection<CourseContentDataModel> CourseContent { get; set; }
        public ObservableCollection<CourseLessonsDataModel> CourseLessons { get; set; }
        public ObservableCollection<CourseListItem> SimilarCourses { get; set; } 
        public ObservableCollection<string> CourseCategories { get; set; }
        public string CoursePrice { get; set; }
        public string NumberOfStudents { get; set; }
        public string Duration { get; set; }
        public string Lectures { get; set; }
        public string VideoDuration { get; set; }
        public string Certificate { get; set; }

        public CourseExpandedVM()
        {
            populateModel();
        }
        private void populateModel()
        {
            CourseTitle = "C# For Beginners";
            TeacherImage = "../images/avatar.png";
            TeacherProfession = "Instructor";
            TeacherName = "Ben";
            //VotingMark = 4;
            ReviewNaumber = "(7 reviews)";
            CourseImage = "../images/courseImage.jpg";
            CourseDescription = "Lorem Ipsum ....";
            CourseContent = new ObservableCollection<CourseContentDataModel>()
            {
                new CourseContentDataModel()
                {
                    CourseContentItem = "Over 40 lectures"
                },
                new CourseContentDataModel()
                {
                    CourseContentItem = "Over 40 lectures"
                },
                new CourseContentDataModel()
                {
                    CourseContentItem = "Over 40 lectures"
                }
            };
            CourseLessons = new ObservableCollection<CourseLessonsDataModel>()
            {
                new CourseLessonsDataModel()
                {
                    LessonDuration = "19 days",
                    LessonName = "Lesson 1"
                },
                new CourseLessonsDataModel()
                {
                    LessonDuration = "19 days",
                    LessonName = "Lesson 1"
                },
                new CourseLessonsDataModel()
                {
                    LessonDuration = "19 days",
                    LessonName = "Lesson 1"
                },
                new CourseLessonsDataModel()
                {
                    LessonDuration = "19 days",
                    LessonName = "Lesson 1"
                },
                new CourseLessonsDataModel()
                {
                    LessonDuration = "19 days",
                    LessonName = "Lesson 1"
                }
              
            };

        }
    }
}
