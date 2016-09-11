using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleWpfApp.Model;

namespace SimpleWpfApp.ViewModel
{
  public class MainWindowViewModel
  {
    public ObservableCollection<ISomeInterface> SomeThings
    {
      get
      {
        var list = new List<ISomeInterface>
        {
          new SomeClass {Value = "initialised"},
          new SomeClass {Value = "in"},
          new SomeClass {Value = "code"}
        };

        return new ObservableCollection<ISomeInterface>(list);
      }
    }


    public List<object> SomeOtherThings => new List<object>
    {
      new SomeClass {Value = "initialised"},
      new SomeClass {Value = "in"},
      new SomeClass {Value = "code"}
    };
  }
}