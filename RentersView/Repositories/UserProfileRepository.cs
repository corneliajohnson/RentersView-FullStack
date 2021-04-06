using RentersView.Data;
using RentersView.Models;
using System.Linq;

namespace RentersView.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserProfile GetByFirebaseId(string firebaseId)
        {
            return _context.UserProfile
                .FirstOrDefault(up => up.FirebaseId == firebaseId);

        }

        public void Add(UserProfile userProfile)
        {
            _context.Add(userProfile);
            _context.SaveChanges();
        }

    }
}
