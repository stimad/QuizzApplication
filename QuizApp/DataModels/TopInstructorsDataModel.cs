using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuizApp
{
    class TopInstructorsDataModel
    {
        public ObservableCollection<InstructorCardVM> TopInstructors { get; set; }
    }
}
