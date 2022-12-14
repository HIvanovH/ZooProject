using System;
using System.Windows.Input;
using Zoo.View_Models;

namespace Zoo.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;
        
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
          
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //choose which view to be displayed by parameter 
            switch (parameter)
            {
                case "Menu":
                    viewModel.SelectedViewModel = new MenuViewModel();
                    break;
                case "Animals":
                    viewModel.SelectedViewModel = new AnimalViewModel();
                    break;
                case "Events":
                    viewModel.SelectedViewModel = new EventsViewModel();
                    break;
                case "Tickets":
                    viewModel.SelectedViewModel = new TicketsViewModel();
                    break;
                default:
                    break;
            }
            

        }
        
    }
}
