using Microsoft.AspNetCore.Identity;
using ProductionApp.Entities.Abstract;

namespace ProductionApp.Entities.Models;

public class AppRole : IdentityRole<int>, IBaseEntity
{
}
