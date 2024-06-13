using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMJP.MasterDataServices.API.Data;
using SMJP.MasterDataServices.API.Models;
using SMJP.MasterDataServices.API.Models.Dto;

namespace SMJP.MasterDataServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CompaniesAPIController(AppDbContext db, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            _response = new ResponseDto();
        }

        [HttpPost("upload-image")]
        public async Task<ActionResult<CompaniesDto>> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            try
            {
                // Generate a unique file name
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads/master_data/companies");

                if (!Directory.Exists(uploadsPath))
                {
                    Directory.CreateDirectory(uploadsPath);
                }

                var filePath = Path.Combine(uploadsPath, fileName);

                // Save the file
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                var imageUrl = $"{Request.Scheme}://{Request.Host}/uploads/master_data/companies/{fileName}";

                return new CompaniesDto { LogoUrl = imageUrl };
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }
        }

        //[HttpPost]
        //public async Task<ResponseDto> Post([FromForm] CompaniesDto companiesDto)
        //{
        //    try
        //    {
        //        if (companiesDto.LogoFile != null && companiesDto.LogoFile.Length > 0)
        //        {
        //            if (string.IsNullOrEmpty(_webHostEnvironment.WebRootPath))
        //            {
        //                throw new Exception("WebRootPath is not set.");
        //            }

        //            // Generate a unique file name
        //            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(companiesDto.LogoFile.FileName);
        //            var uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");

        //            if (!Directory.Exists(uploadsPath))
        //            {
        //                Directory.CreateDirectory(uploadsPath);
        //            }

        //            var filePath = Path.Combine(uploadsPath, fileName);

        //            // Save the file
        //            using (var fileStream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await companiesDto.LogoFile.CopyToAsync(fileStream);
        //            }

        //            var imageUrl = $"{Request.Scheme}://{Request.Host}/uploads/{fileName}";
        //            companiesDto.LogoUrl = imageUrl; // Set the LogoUrl to the uploaded file's URL
        //        }

        //        Companies obj = _mapper.Map<Companies>(companiesDto);
        //        _db.Companies.Add(obj);
        //        _db.SaveChanges();

        //        _response.Result = _mapper.Map<CompaniesDto>(obj);
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message = ex.Message;
        //    }
        //    return _response;
        //}

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Companies> objList = _db.Companies.ToList();
                _response.Result = _mapper.Map<IEnumerable<CompaniesDto>>(objList);
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
                Companies obj = _db.Companies.First(u => u.CompanyID == id);
                _response.Result = _mapper.Map<CompaniesDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] CompaniesDto companiesDto)
        {
            try
            {
                Companies obj = _mapper.Map<Companies>(companiesDto);
                _db.Companies.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CompaniesDto>(obj);
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
                Companies obj = _db.Companies.First(u => u.CompanyID == id);
                _db.Companies.Remove(obj);
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
