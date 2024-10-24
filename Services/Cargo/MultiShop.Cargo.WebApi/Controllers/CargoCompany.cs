using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCompany : ControllerBase
	{
		private readonly ICargoCompanyService _cargoCompanyService;

		public CargoCompany(ICargoCompanyService cargoCompanyService)
		{
			_cargoCompanyService = cargoCompanyService;
		}
		[HttpGet]
		public IActionResult CargoCompanyList()
		{
			var values = _cargoCompanyService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoCompany()
		{
			return Ok("Kargo şirketi başarıyla oluşturuldu");
		}

		[HttpDelete]
		public IActionResult RemoveCargoCompany(int id)
		{
			_cargoCompanyService.TDelete(id);
			return Ok("Kargo şirketi başarıyla silindi.");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCompanyById(int id)
		{
			var values = _cargoCompanyService.TGetById(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCargoCompany()
		{
			return Ok("kargo şirketi başarıyla güncellendi");
		}
	}
}
