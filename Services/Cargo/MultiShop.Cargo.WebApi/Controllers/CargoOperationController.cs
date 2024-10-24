using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Carge.DtoLayer.Dtos.CargoOperationDto;
using MultiShop.Cargo.BusinessLayer.Abstract;
using Multishop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoOperationController : ControllerBase
	{
		private readonly ICargoOperationService _CargoOperationService;

		public CargoOperationController(ICargoOperationService CargoOperationService)
		{
			_CargoOperationService = CargoOperationService;
		}

		[HttpGet]
		public IActionResult CargoOperationList()
		{
			var values = _CargoOperationService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
		{
			CargoOperation CargoOperation = new CargoOperation()
			{
				Barcode = createCargoOperationDto.Barcode,
				Description = createCargoOperationDto.Description,
				OperationDate = createCargoOperationDto.OperationDate
			};
			_CargoOperationService.TInsert(CargoOperation);
			return Ok("Kargo işlemi başarıyla oluşturuldu");
		}

		[HttpDelete]
		public IActionResult RemoveCargoOperation(int id)
		{
			_CargoOperationService.TDelete(id);
			return Ok("Kargo işlemi başarıyla silindi.");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoOperationById(int id)
		{
			var values = _CargoOperationService.TGetById(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
		{
			CargoOperation CargoOperation = new CargoOperation()
			{
				Barcode= updateCargoOperationDto.Barcode,
				OperationDate= updateCargoOperationDto.OperationDate,
				Description= updateCargoOperationDto.Description,
				CargoOperationId = updateCargoOperationDto.CargoOperationId
			};
			_CargoOperationService.TUpdate(CargoOperation);
			return Ok("kargo işlemi başarıyla güncellendi");
		}
	}
}
