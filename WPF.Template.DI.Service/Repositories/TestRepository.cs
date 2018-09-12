namespace WPF.Template.DI.Service.Repositories
{
    public interface ITestRepository
    {
        string GetTestValue();
    }

    public class TestRepository : ITestRepository
    {
        public string GetTestValue()
        {
            return "Prepared DI";
        }
    }
}
