namespace SimpleWpfApp.Model
{
  public class SomeClass : ISomeInterface
  {
    public string Value { get; set; }


    public override string ToString() => Value;
  }
}