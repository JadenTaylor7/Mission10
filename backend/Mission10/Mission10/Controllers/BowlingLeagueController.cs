using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Data;

namespace Mission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private BowlDbContext _bowlContext;
        public BowlingLeagueController(BowlDbContext context)
        {
            _bowlContext = context;
        }

        ////IEnumerable is just a fast iterating list
        //[HttpGet(Name = "GetBowlingLeague")]
        //public IEnumerable<BowlingLeague> Get()
        //{
        //    var bowlerList = _bowlContext.Bowlers.ToList();
        //    //TODO: return only where teams = marlins or sharks
        //    return bowlerList;
        //}
        [HttpGet(Name = "GetBowlingLeague")]
        public IEnumerable<BowlingLeague> Get()
        {
            var bowlerList = _bowlContext.Bowlers
                .Join(
                    _bowlContext.Teams, // The second table to join
                    bowler => bowler.TeamID, // FK from Bowlers table
                    team => team.TeamID, // PK from Teams table
                    (bowler, team) => new BowlingLeague
                    {
                        BowlerID = bowler.BowlerID,
                        BowlerFirstName = bowler.BowlerFirstName,
                        BowlerMiddleInit = bowler.BowlerMiddleInit,
                        BowlerLastName = bowler.BowlerLastName,
                        TeamName = team.TeamName, // Include TeamName from Teams table
                        BowlerAddress = bowler.BowlerAddress,
                        BowlerCity = bowler.BowlerCity,
                        BowlerState = bowler.BowlerState,
                        BowlerZip = bowler.BowlerZip,
                        BowlerPhoneNumber = bowler.BowlerPhoneNumber
                    }
                )
                .Where(b => b.TeamName == "Marlins" || b.TeamName == "Sharks") // Filter by team
                .ToList();

            return bowlerList;
        }
    }
}
