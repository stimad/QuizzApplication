using System.Collections.ObjectModel;

namespace QuizApp
{
    public class InstructorExpandedFragmentVM: BaseViewModel
    {
        public string InstructorName { get; set; }
        public string ImagePath { get; set; }
        public string NumberOfStudents { get; set; }
        public string NumberOfCourses { get; set; }
        public string NumberOfReviews { get; set; }
        public string InstrucorHabits { get; set; }
        public string InstrucorDescription { get; set; }
        public string CourseListHeader {
            get { return $"Course taught by {InstructorName}"; }
        }
        public ObservableCollection<CourseCardVM> Courses { get; set; }

        public InstructorExpandedFragmentVM()
        {
            populateData();
        }

        private void populateData()
        {
            InstructorName = "Simon";
            ImagePath = "../images/avatar.png";
            NumberOfStudents = "200";
            NumberOfCourses = "53";
            NumberOfReviews = "9,365";
            InstrucorHabits = "The first thing he likes to do is...";
            InstrucorDescription = "This is some data about the instrucotr";
            Courses = new ObservableCollection<CourseCardVM>()
            {
                new CourseCardVM()
                {
                    AverageMark = 3,
                    CourseLecturer = "Simon",
                    CourseName = "C# For Beginners",
                    CoursePrice= "$238",
                    ImagePath = "../images/courseImage.jpg",
                    NumberOfAttenders = 26,
                    NumberOfComments = 17
                },
                new CourseCardVM()
                {
                    AverageMark = 3,
                    CourseLecturer = "Simon",
                    CourseName = "C# For Beginners",
                    CoursePrice= "$238",
                    ImagePath = "../images/courseImage.jpg",
                    NumberOfAttenders = 26,
                    NumberOfComments = 17
                },
                new CourseCardVM()
                {
                    AverageMark = 3,
                    CourseLecturer = "Simon",
                    CourseName = "C# For Beginners",
                    CoursePrice= "$238",
                    ImagePath = "../images/courseImage.jpg",
                    NumberOfAttenders = 26,
                    NumberOfComments = 17
                },
                new CourseCardVM()
                {
                    AverageMark = 3,
                    CourseLecturer = "Simon",
                    CourseName = "C# For Beginners",
                    CoursePrice= "$238",
                    ImagePath = "../images/courseImage.jpg",
                    NumberOfAttenders = 26,
                    NumberOfComments = 17
                },
                new CourseCardVM()
                {
                    AverageMark = 3,
                    CourseLecturer = "Simon",
                    CourseName = "C# For Beginners",
                    CoursePrice= "$238",
                    ImagePath = "../images/courseImage.jpg",
                    NumberOfAttenders = 26,
                    NumberOfComments = 17
                },
                new CourseCardVM()
                {
                    AverageMark = 3,
                    CourseLecturer = "Simon",
                    CourseName = "C# For Beginners",
                    CoursePrice= "$238",
                    ImagePath = "../images/courseImage.jpg",
                    NumberOfAttenders = 26,
                    NumberOfComments = 17
                },
                new CourseCardVM()
                {
                    AverageMark = 3,
                    CourseLecturer = "Simon",
                    CourseName = "C# For Beginners",
                    CoursePrice= "$238",
                    ImagePath = "../images/courseImage.jpg",
                    NumberOfAttenders = 26,
                    NumberOfComments = 17
                }
            };
        }
    }
}
