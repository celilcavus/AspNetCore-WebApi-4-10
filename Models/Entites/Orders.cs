using System.ComponentModel.DataAnnotations.Schema;

namespace CelilCavus.WebApi.Entites
{
    public class Orders
    {
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
    }
}