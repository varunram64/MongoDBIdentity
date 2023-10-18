using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace MongoDBIdentity.Models
{
    [CollectionName("Users")]
    public class ApplicationUsers : MongoIdentityUser<Guid>
    {
    }
}
