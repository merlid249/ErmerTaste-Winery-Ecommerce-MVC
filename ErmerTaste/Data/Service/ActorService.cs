using ErmerTaste.Data.Base;
using ErmerTaste.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Data.Service
{
    public class ActorService : EntityBaseRespository<Actor>, IActorsService
    {
        public ActorService(AppDbContext context) : base(context)
        {
        }
    }
}
