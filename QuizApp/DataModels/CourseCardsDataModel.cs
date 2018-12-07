using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuizApp.DataModels
{
    class CourseCardsDataModel
    {
        public ObservableCollection<CourseCardVM> FeaturedCourses { get; set; }
    }
}
