using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMJP.MasterDataServices.API.Data;
using SMJP.MasterDataServices.API.Models.Dto;
using SMJP.MasterDataServices.API.Models;

namespace SMJP.MasterDataServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public UsersAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Users> objList = _db.Users.ToList();
                _response.Result = _mapper.Map<IEnumerable<UsersDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Users obj = _db.Users.First(u => u.UserID == id);
                _response.Result = _mapper.Map<UsersDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] UsersDto usersDto)
        {
            try
            {
                Users obj = _mapper.Map<Users>(usersDto);
                _db.Users.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<UsersDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        public ResponseDto Delete(int id)
        {
            try
            {
                Users obj = _db.Users.First(u => u.UserID == id);
                _db.Users.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
