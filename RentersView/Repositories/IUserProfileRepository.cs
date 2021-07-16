using RentersView.Models;
using System.Collections.Generic;

namespace RentersView.Repositories
{
    public interface IUserProfileRepository
    {
        void Add(UserProfile userProfile);
        UserProfile GetByFirebaseId(string firebaseId);
        List<UserProfile> GetAll();
    }
}