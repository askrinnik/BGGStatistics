using System.Threading.Tasks;
using BggApi.Models;

namespace BggApi.Clients
{
  public interface IBggReader
  {
    Task<PlayCollection> LoadPlays(string userName, int page);
  }
}