namespace SimpleWpfApp.ViewModel
{
  public class ViewModelLocator
  {
    public ViewModelLocator()
    {
      MainWindowViewModel = new MainWindowViewModel();
    }


    public static MainWindowViewModel MainWindowViewModel { get; private set; }
  }
}