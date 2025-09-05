using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        [Key]
        public int Id { get; set; }

        public List<Zombie> zombies { get; set; }
    }
}
