using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMJP.MasterDataServices.API.Data;
using SMJP.MasterDataServices.API.Models;
using SMJP.MasterDataServices.API.Models.Dto;

namespace SMJP.MasterDataServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public SchedulesAPIController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Schedules> objList = _db.Schedules.ToList();
                _response.Result = _mapper.Map<IEnumerable<Schedules>>(objList);
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
                var schedule = _db.Schedules
                    .Include(s => s.Company)
                    .Include(s => s.Region)
                    .Include(s => s.Site)
                    .Include(s => s.Shift)
                    .FirstOrDefault(s => s.ScheduleID == id);

                if (schedule != null)
                {
                    SchedulesDto dto = _mapper.Map<SchedulesDto>(schedule);
                    _response.Result = dto;
                    _response.IsSuccess = true;
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "Site not found.";
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        //[HttpPost]
        //public ActionResult<ResponseDto> Post(SchedulesDto schedulesDto)
        //{
        //    try
        //    {
        //        if (schedulesDto == null)
        //        {
        //            _response.IsSuccess = false;
        //            _response.Message = "Invalid request data.";
        //            return BadRequest(_response);
        //        }

        //        Schedules newSchedules = _mapper.Map<Schedules>(schedulesDto);
        //        _db.Schedules.Add(newSchedules);
        //        _db.SaveChanges();

        //        _response.Result = _mapper.Map<SchedulesDto>(newSchedules);
        //        return CreatedAtAction(nameof(Get), new { id = newSchedules.ScheduleID }, _response);
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message = ex.Message;
        //        return StatusCode(StatusCodes.Status500InternalServerError, _response);
        //    }
        //}

        [HttpPost]
        public ActionResult<ResponseDto> Post(SchedulesDto schedulesDto)
        {
            try
            {
                if (schedulesDto == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Invalid request data.";
                    return BadRequest(_response);
                }

                // Create a new Regions entity and populate its properties from regionsDto
                Schedules newSchedules = new Schedules
                {
                    ScheduleID = schedulesDto.ScheduleID,
                    CompanyID = schedulesDto.CompanyID,
                    Company = schedulesDto.Company,
                    RegionID = schedulesDto.RegionID,
                    Region = schedulesDto.Region,
                    SiteID = schedulesDto.SiteID,
                    Site = schedulesDto.Site,
                    ShiftID = schedulesDto.ShiftID,
                    Shift = schedulesDto.Shift,
                    Date = schedulesDto.Date,
                    CreatedBy = schedulesDto.CreatedBy,
                    CreatedDate = schedulesDto.CreatedDate,
                    ModifiedBy = schedulesDto.ModifiedBy,
                    ModifiedDate = schedulesDto.ModifiedDate
                };

                // Add the new region to the database
                _db.Schedules.Add(newSchedules);
                _db.SaveChanges();

                // Map the newly created region back to a DTO for the response
                _response.Result = _mapper.Map<SchedulesDto>(newSchedules);
                return CreatedAtAction(nameof(Get), new { id = newSchedules.ScheduleID }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }
        }

        [HttpDelete]
        public ResponseDto Delete(int id)
        {
            try
            {
                Schedules obj = _db.Schedules.First(u => u.ScheduleID == id);
                _db.Schedules.Remove(obj);
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
