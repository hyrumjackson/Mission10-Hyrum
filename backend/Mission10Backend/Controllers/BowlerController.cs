using Microsoft.AspNetCore.Mvc;
using Mission10Backend.Data;
using System.Linq;

namespace Mission10Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository { get; set; }

        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BowlerDto>> Get()
        {
            var bowlerData = _bowlerRepository.GetBowlersByTeams("Marlins", "Sharks")
                                .Select(b => new BowlerDto
                                {
                                    FullName = $"{b.BowlerFirstName} {b.BowlerMiddleInit} {b.BowlerLastName}".Trim(),
                                    TeamName = b.Team.TeamName, // Assuming Team is properly included and not null
                                    Address = b.BowlerAddress,
                                    City = b.BowlerCity,
                                    State = b.BowlerState,
                                    Zip = b.BowlerZip,
                                    PhoneNumber = b.BowlerPhoneNumber
                                })
                                .ToArray();

            return Ok(bowlerData);
        }

        public class BowlerDto
        {
            public string FullName { get; set; }
            public string TeamName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }
        }
    }
}
