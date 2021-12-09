using System.Threading.Tasks;

namespace TestGenerator.Interfaces
{
    public interface ITestGenerator
    {
        Task GenerateTestsAsync(string inputDirectory, string outputDirectory);
    }
}