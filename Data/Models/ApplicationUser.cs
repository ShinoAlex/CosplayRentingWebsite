using Microsoft.AspNetCore.Identity;


namespace Data.Models;

public class ApplicationUser : IdentityUser
{

    public int? RoleId { get; set; }

    public virtual ICollection<CosOrder> CosOrders { get; set; } = new List<CosOrder>();

    public virtual Role? Role { get; set; }
}
