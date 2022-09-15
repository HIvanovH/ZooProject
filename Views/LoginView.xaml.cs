using System.Windows;
using System.Windows.Controls;

namespace Zoo.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }
        //passwordbox binding is not allowed by security reasons so code-behind is used
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) 
        { 
            if (this.DataContext != null) 
            { 
                ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; 
            } 
        }
    }
}
