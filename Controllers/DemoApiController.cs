using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using templateAPI_core_7.Models;

namespace templateAPI_core_7.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemoApiController : ControllerBase
    {
        private readonly ApiDemoDbContext _apiDemoDbContext;

        public DemoApiController(ApiDemoDbContext apiDemoDbContext)
        {
            _apiDemoDbContext = apiDemoDbContext;
        }

        [HttpGet]
        [Route("get-users-list")]
        public async Task<IActionResult> GetAsync()
        {
            var users = await _apiDemoDbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet]
        [Route("get-users-by-id/{UserId}")]
        public async Task<IActionResult> GetUserByIdAsync(int UserId)
        {
            var user = await _apiDemoDbContext.Users.FindAsync(UserId);
            return Ok(user);
        }

        [HttpPost]
        [Route("create-user")]
        public async Task<IActionResult> PostAsync(Users user)
        {
            _apiDemoDbContext.Users.Add(user);
            await _apiDemoDbContext.SaveChangesAsync();
            return Created($"/get-user-by-id/{user.UserID}", user);
        }

        [HttpPut]
        [Route("update-user")]
        public async Task<IActionResult> PutAsync(Users userToUpdate)
        {
            _apiDemoDbContext.Users.Update(userToUpdate);
            await _apiDemoDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        [Route("delete-user/{UserId}")]
        public async Task<IActionResult> DeleteAsync(int UserId)
        {
            var userToDelete = await _apiDemoDbContext.Users.FindAsync(UserId);

            if (userToDelete == null)
            {
                return NotFound();
            }
            _apiDemoDbContext.Users.Remove(userToDelete);
            await _apiDemoDbContext.SaveChangesAsync();
            return NoContent();

        }

        // -- salas

        [HttpGet]
        [Route("get-salas-list")]
        public async Task<IActionResult> GetSalasAsync()
        {
            var salas = await _apiDemoDbContext.Salas.ToListAsync();
            return Ok(salas);
        }

        [HttpGet]
        [Route("get-sala-by-id/{salaId}")]
        public async Task<IActionResult> GetSalaByIdAsync(int salaId)
        {
            var sala = await _apiDemoDbContext.Users.FindAsync(salaId);
            return Ok(sala);
        }

        [HttpPost]
        [Route("create-sala")]
        public async Task<IActionResult> PostSalaAsync(Salas sala)
        {
            _apiDemoDbContext.Salas.Add(sala);
            await _apiDemoDbContext.SaveChangesAsync();
            return Created($"/get-sala-by-id/{sala.salaID}", sala);
        }

        [HttpPut]
        [Route("update-sala")]
        public async Task<IActionResult> PutSalaAsync(Salas salaToUpdate)
        {
            _apiDemoDbContext.Salas.Update(salaToUpdate);
            await _apiDemoDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        [Route("delete-sala/{SalaId}")]
        public async Task<IActionResult> DeleteSalaAsync(int salaId)
        {
            var salaToDelete = await _apiDemoDbContext.Salas.FindAsync(salaId);

            if (salaToDelete == null)
            {
                return NotFound();
            }
            _apiDemoDbContext.Salas.Remove(salaToDelete);
            await _apiDemoDbContext.SaveChangesAsync();
            return NoContent();

        }

    }
}
