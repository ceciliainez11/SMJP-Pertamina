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
    public class RegionsAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public RegionsAPIController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Regions> objList = _db.Regions.ToList();
                _response.Result = _mapper.Map<IEnumerable<RegionsDto>>(objList);
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
                var region = _db.Regions
                    .Include(r => r.Company)
                    .FirstOrDefault(r => r.RegionID == id);

                if (region != null)
                {
                    RegionsDto dto = _mapper.Map<RegionsDto>(region);
                    _response.Result = dto;
                    _response.IsSuccess = true;
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "Region not found.";
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
        //public ActionResult<ResponseDto> Post(RegionsDto regionsDto)
        //{
        //    try
        //    {
        //        if (regionsDto == null)
        //        {
        //            _response.IsSuccess = false;
        //            _response.Message = "Invalid request data.";
        //            return BadRequest(_response);
        //        }

        //        var existingCompany = _db.Companies.FirstOrDefault(c => c.CompanyID == regionsDto.CompanyID);

        //        if (existingCompany == null)
        //        {
        //            _response.IsSuccess = false;
        //            _response.Message = "Company with the specified ID not found.";
        //            return BadRequest(_response);
        //        }

        //        Regions newRegion = _mapper.Map<Regions>(regionsDto);
        //        newRegion.Company = existingCompany;

        //        _db.Regions.Add(newRegion);
        //        _db.SaveChanges();

        //        _response.Result = _mapper.Map<RegionsDto>(newRegion);

        //        return CreatedAtAction(nameof(Get), new { id = newRegion.RegionID }, _response);
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message = ex.Message;
        //        return StatusCode(StatusCodes.Status500InternalServerError, _response);
        //    }
        //}

        [HttpPost]
        public ActionResult<ResponseDto> Post(RegionsDto regionsDto)
        {
            try
            {
                if (regionsDto == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Invalid request data.";
                    return BadRequest(_response);
                }

                // Create a new Regions entity and populate its properties from regionsDto
                Regions newRegion = new Regions
                {
                    RegionID = regionsDto.RegionID,
                    CompanyID = regionsDto.CompanyID,
                    RegionName = regionsDto.RegionName,
                    RegionLatitude = regionsDto.RegionLatitude,
                    RegionLongitude = regionsDto.RegionLongitude,
                    CreatedBy = regionsDto.CreatedBy,
                    CreatedDate = regionsDto.CreatedDate,
                    ModifiedBy = regionsDto.ModifiedBy,
                    ModifiedDate = regionsDto.ModifiedDate
                };

                // Add the new region to the database
                _db.Regions.Add(newRegion);
                _db.SaveChanges();

                // Map the newly created region back to a DTO for the response
                _response.Result = _mapper.Map<RegionsDto>(newRegion);
                return CreatedAtAction(nameof(Get), new { id = newRegion.RegionID }, _response);
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
                Regions obj = _db.Regions.First(u => u.RegionID == id);
                _db.Regions.Remove(obj);
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
