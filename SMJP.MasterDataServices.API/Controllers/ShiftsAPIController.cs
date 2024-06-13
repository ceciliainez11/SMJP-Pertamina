using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMJP.MasterDataServices.API.Data;
using SMJP.MasterDataServices.API.Models;
using SMJP.MasterDataServices.API.Models.Dto;

namespace SMJP.MasterDataServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public ShiftsAPIController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Shifts> objList = _db.Shifts.ToList();
                _response.Result = _mapper.Map<IEnumerable<ShiftsDto>>(objList);
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
                Shifts obj = _db.Shifts.First(u => u.ShiftID == id);
                _response.Result = _mapper.Map<ShiftsDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] ShiftsDto shiftsDto)
        {
            try
            {
                Shifts obj = _mapper.Map<Shifts>(shiftsDto);
                _db.Shifts.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ShiftsDto>(obj);
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
                Shifts obj = _db.Shifts.First(u => u.ShiftID == id);
                _db.Shifts.Remove(obj);
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
