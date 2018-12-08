using System.Collections.ObjectModel;
using System.Windows.Input;

namespace QuizApp
{
    public class CourseCardGridVM: BaseViewModel
    {
        public ObservableCollection<CourseCardVM> DiserableCourses { get; set; }

        public CourseCardGridVM()
        {
            populateAllCourses();
        }

        public void populateAllCourses()
        {
            ObservableCollection<CourseCardVM> courses = new ObservableCollection<CourseCardVM>();
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });
            courses.Add(new CourseCardVM()
            {
                AverageMark = 3,
                CourseLecturer = "Ben",
                CourseName = "C# For Beginners",
                CoursePrice = "$250",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 14,
                NumberOfComments = 5
            });

            DiserableCourses = courses;
        }
    }
}
