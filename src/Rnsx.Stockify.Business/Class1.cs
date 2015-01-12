namespace Rnsx.Stockify.Business
{
    public interface IRunner
    {
        string Run();
    }

    public class Runner : IRunner
    {
        public string Run()
        {
            var something = new Something();

            return something.GetText();
        }
    }

    internal interface ISomething
    {
        string GetText();
    }

    internal class Something : ISomething
    {
        public string GetText()
        {
            return "Some text";
        }
    }
}