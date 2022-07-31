using System.Windows.Controls;
using ToDoList.Core;

namespace ToDoListWPF
{
    /// <summary>
    /// Logika interakcji dla klasy WorkTasksPG.xaml
    /// </summary>
    public partial class WorkTasksPage : Page
    {
        public WorkTasksPage()
        {
            InitializeComponent();

            DataContext = new WorkTasksPageViewModel();
        }
    }
}
