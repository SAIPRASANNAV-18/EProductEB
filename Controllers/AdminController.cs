using EProductEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace EProductEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        [HttpPost]
        [Route("addUpdateProduct")]
        public Response addUpdateProduct(Products products)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("").ToString());
            Response response = dal.addUpdateProduct(Products, connection);
            return response;
        }
        [HttpGet]
        [Route("userList")]
        public Response userList()
        {
            DAL dal= new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("").ToString());
            Response response = dal.userList(connection);
            return response;

        }
    }
}
