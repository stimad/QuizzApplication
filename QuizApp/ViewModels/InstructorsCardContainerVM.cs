using System.Collections.ObjectModel;
using System.Windows;

namespace QuizApp
{
    public class InstructorsCardContainerVM: BaseViewModel
    {
        public Visibility ContentVisibility { get; set; } = Visibility.Visible;
        public BaseViewModel ViewModel { get; set; } = null;
        public ObservableCollection<CourseCardVM> DesirableCourses { get; set; }
        public ObservableCollection<CourseCategoryVM> CourseCategories { get; set; }
        public ObservableCollection<CourseCardVM> PopularCourses { get; set; }
        public ObservableCollection<InstructorCardVM> Instructors { get; set; }

        public InstructorsCardContainerVM()
        {
            populateAllCourses();
            populateCourseCategories();
            populatePopularCourses();
            populateInstrucorCard();
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

            DesirableCourses = courses;
        }

        public void populateCourseCategories()
        {
            CourseCategories = new ObservableCollection<CourseCategoryVM>()
            {
                new CourseCategoryVM()
                {
                    CourseCategoryName = "Business"
                },
                new CourseCategoryVM()
                {
                    CourseCategoryName = "Design"
                },
                new CourseCategoryVM()
                {
                    CourseCategoryName = "Programming"
                },
                new CourseCategoryVM()
                {
                    CourseCategoryName = "Photography"
                },
                new CourseCategoryVM()
                {
                    CourseCategoryName = "Language"
                },
                new CourseCategoryVM()
                {
                    CourseCategoryName = "Lifestyle"
                },
                new CourseCategoryVM()
                {
                    CourseCategoryName = "IT & Software"
                }
            };
        }

        public void populatePopularCourses()
        {
            PopularCourses = new ObservableCollection<CourseCardVM>()
            {
                new CourseCardVM
                {
                    ImagePath = "../images/courseImage.jpg",
                    CourseName = "C# For Beginners",
                    CoursePrice = "$324"
                },
                new CourseCardVM
                {
                    ImagePath = "../images/courseImage.jpg",
                    CourseName = "C# For Beginners",
                    CoursePrice = "$324"
                },
                new CourseCardVM
                {
                    ImagePath = "../images/courseImage.jpg",
                    CourseName = "C# For Beginners",
                    CoursePrice = "$324"
                }
            };
        }

        public void populateInstrucorCard()
        {
            Instructors = new ObservableCollection<InstructorCardVM>()
            {
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
                new InstructorCardVM()
                {
                    InstructorImagePath = "../images/avatar.png",
                    InstructorName = "Marijana",
                    InstructorProfession = "Designer"
                },
            };
        }
    }
}
