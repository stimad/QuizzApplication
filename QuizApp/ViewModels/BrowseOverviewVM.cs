using QuizApp.DataModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace QuizApp
{
    class BrowseOverviewVM: BaseViewModel
    {
        public ObservableCollection<CourseCardVM> FeaturedCourses { get; set; }
        public ObservableCollection<CourseCategoryVM> TopCourses { get; set; }
        public ObservableCollection<InstructorCardVM> TopInstructors { get; set; }

        public async Task populateFeaturedCourses()
        {
            //try
            //{
            //    CourseCardsDataModel featuredCoursesContainer = await Constants.sendPostRequest<CourseCardsDataModel>(Constants.BASE_URL + "/featuredCourses");
            //    if (featuredCoursesContainer != null && featuredCoursesContainer.FeaturedCourses.Count > 0)
            //    {
            //        FeaturedCourses = featuredCoursesContainer.FeaturedCourses;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    //MessageBox.Show(ex.Message);
            //}
            ObservableCollection<CourseCardVM> featuredCourses = new ObservableCollection<CourseCardVM>();
            featuredCourses.Add(new CourseCardVM()
            {
                AverageMark = 4,
                CourseLecturer = "Marko",
                CourseName = "C# For Beginners",
                CoursePrice = "$100",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 12,
                NumberOfComments = 5
            });
            featuredCourses.Add(new CourseCardVM()
            {
                AverageMark = 4,
                CourseLecturer = "Darko",
                CourseName = "C# For Beginners",
                CoursePrice = "$100",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 12,
                NumberOfComments = 5
            });
            featuredCourses.Add(new CourseCardVM()
            {
                AverageMark = 4,
                CourseLecturer = "Janko",
                CourseName = "C# For Beginners",
                CoursePrice = "$100",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 12,
                NumberOfComments = 5
            });
            featuredCourses.Add(new CourseCardVM()
            {
                AverageMark = 4,
                CourseLecturer = "Marko",
                CourseName = "C# For Beginners",
                CoursePrice = "$100",
                ImagePath = "../images/courseImage.jpg",
                NumberOfAttenders = 12,
                NumberOfComments = 5
            });
            FeaturedCourses = featuredCourses;
        }
        public async Task populateTopCategories()
        {

            CourseCategoriesDataModel courseCategories = await Constants.sendPostRequest<CourseCategoriesDataModel>(Constants.BASE_URL + "/courseCategory");
            if (courseCategories != null && courseCategories.TopCategories.Count > 0)
            {
                TopCourses = courseCategories.TopCategories;
            }
        }

        public async Task populateTopInstructorsGrid()
        {
            TopInstructorsDataModel topINstructorsContainer = await Constants.sendPostRequest<TopInstructorsDataModel>(Constants.BASE_URL + "/topInstructors");
            if (topINstructorsContainer != null && topINstructorsContainer.TopInstructors.Count > 0)
            {
                TopInstructors = topINstructorsContainer.TopInstructors;
            }
        }
    }
}
