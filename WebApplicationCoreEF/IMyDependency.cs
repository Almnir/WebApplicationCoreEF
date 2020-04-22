using System.Threading.Tasks;

namespace WebApplicationCoreEF
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}
