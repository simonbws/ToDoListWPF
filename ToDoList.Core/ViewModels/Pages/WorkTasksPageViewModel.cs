using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ToDoList.Core
{
    public class WorkTasksPageViewModel : BaseViewModel
    {
        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();   

        public string NewWorkTaskTitle { get; set; }
        public string NewWorkTaskDescription { get; set; }

        public ICommand AddNewTaskCommand { get; set; }
        public ICommand DeleteSelectedTaskCommand { get; set; }

        public WorkTasksPageViewModel()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
            DeleteSelectedTaskCommand = new RelayCommand(DeleteSelectedTask);
        }


        private void AddNewTask()
        {
            var newTask = new WorkTaskViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now
            };
            WorkTaskList.Add(newTask);

            NewWorkTaskTitle = string.Empty;
            NewWorkTaskDescription = string.Empty;

            //OnPropertyChanged(nameof(NewWorkTaskTitle));
            //OnPropertyChanged(nameof(NewWorkTaskDescription));

        }
        private void DeleteSelectedTask()
        {
            var selectedTask = WorkTaskList.Where(x => x.IsSelected).ToList();
            
            foreach (var task in selectedTask)
            {
                WorkTaskList.Remove(task);
            }
        }

    }
}
