using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentersView.Models;
using RentersView.Repositories;

namespace RentersView.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileRepository _userProfileRepo;
        public UserProfileController(IUserProfileRepository userProfileRepo)
        {
            _userProfileRepo = userProfileRepo;
        }

        [HttpGet("{firebaseUserId}")]
        public IActionResult GetLandlord(string firebaseId)
        {
            return Ok(_userProfileRepo.GetByFirebaseId(firebaseId));
        }

        [HttpPost]
        public IActionResult Post(UserProfile landlord)
        {
            _userProfileRepo.Add(landlord);
            return CreatedAtAction(
                nameof(GetLandlord),
                new { firebaseId = landlord.FirebaseId },
                landlord);
        }

        [HttpGet("getusers")]
        public IActionResult GetAll()
        {
            return Ok(_userProfileRepo.GetAll());
        }
    }
}
