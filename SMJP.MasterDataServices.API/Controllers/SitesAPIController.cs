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
    public class SitesAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public SitesAPIController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Sites> objList = _db.Sites.ToList();
                _response.Result = _mapper.Map<IEnumerable<SitesDto>>(objList);
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
                var site = _db.Sites
                    .Include(s => s.Company)
                    .Include(s => s.Region)
                    .FirstOrDefault(s => s.SiteID == id);

                if (site != null)
                {
                    SitesDto dto = _mapper.Map<SitesDto>(site);
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
        //public ActionResult<ResponseDto> Post(SitesDto sitesDto)
        //{
        //    try
        //    {
        //        if (sitesDto == null)
        //        {
        //            _response.IsSuccess = false;
        //            _response.Message = "Invalid request data.";
        //            return BadRequest(_response);
        //        }

        //        Sites newSites = _mapper.Map<Sites>(sitesDto);
        //        _db.Sites.Add(newSites);
        //        _db.SaveChanges();

        //        _response.Result = _mapper.Map<SitesDto>(newSites);
        //        return CreatedAtAction(nameof(Get), new { id = newSites.SiteID }, _response);
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message = ex.Message;
        //        return StatusCode(StatusCodes.Status500InternalServerError, _response);
        //    }
        //}

        [HttpPost]
        public ActionResult<ResponseDto> Post(SitesDto sitesDto)
        {
            try
            {
                if (sitesDto == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Invalid request data.";
                    return BadRequest(_response);
                }

                // Create a new Sites entity and populate its properties from sitesDto
                Sites newSites = new Sites
                {
                    SiteID = sitesDto.SiteID,
                    CompanyID = sitesDto.CompanyID,
                    RegionID = sitesDto.RegionID,
                    SiteName = sitesDto.SiteName,
                    SiteDesc = sitesDto.SiteDesc,
                    SiteLatitude = sitesDto.SiteLatitude,
                    SiteLongitude = sitesDto.SiteLongitude,
                    CreatedBy = sitesDto.CreatedBy,
                    CreatedDate = sitesDto.CreatedDate,
                    ModifiedBy = sitesDto.ModifiedBy,
                    ModifiedDate = sitesDto.ModifiedDate
                };

                // Add the new region to the database
                _db.Sites.Add(newSites);
                _db.SaveChanges();

                // Map the newly created region back to a DTO for the response
                _response.Result = _mapper.Map<SitesDto>(newSites);
                return CreatedAtAction(nameof(Get), new { id = newSites.SiteID }, _response);
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
                Sites obj = _db.Sites.First(u => u.SiteID == id);
                _db.Sites.Remove(obj);
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
