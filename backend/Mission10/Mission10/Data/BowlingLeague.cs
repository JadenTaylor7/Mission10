using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
//Something I learned: Instead of calling this file BowlingLeague, I should've named it after the table it was calling, which was Bowlers.
namespace Mission10.Data
{
    public class BowlingLeague
    {
        [Key]
        public int BowlerID { get; set; }
        public string? BowlerFirstName {  get; set; }
        public string? BowlerMiddleInit {  get; set; }
        public string? BowlerLastName { get; set; }

        //[ForeignKey(nameof(TeamID))]
        [ForeignKey("TeamID")]
        public int TeamID { get; set; } // TeamID from both Bowlers table and Teams table
        public string? TeamName { get; set; } // TeamName from Teams table

        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public int? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }

     
    }
}
