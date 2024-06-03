using FCode_CRUD.AppModels;
using FCode_CRUD.Models;
using FCode_CRUD.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FCode_CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UsersList _UsersList;
        public UserController(UsersList usersList)
        {
            _UsersList = usersList;
        }

        [HttpGet]
        [Route("GetList")]
        public IActionResult GetList()
        {
            var List=_UsersList.GetList();
            return Ok(List);
        }
        [HttpPost]
        [Route("InsertRecord")]
        public IActionResult Get(DemoUsers1 demoUsers)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            string connection= configurationManager.GetConnectionString("DatabaseConnection");
            var Record=_UsersList.InsertRecord(demoUsers);
            return Ok(Record);
        }
        [HttpGet]
        [Route("GetById/{Id}")]
        public IActionResult GetById(int Id)
        {
            var record=_UsersList.GetUserById(Id);
            return Ok(record);
        }
        [HttpPut]
        [Route("UpdateRecord")]
        public IActionResult UpdateRecord([FromQuery]DemoUsers demoUsers)
        {
            var Record = _UsersList.UpdateRecord(demoUsers);
            return Ok(Record);
        }
    }
}
