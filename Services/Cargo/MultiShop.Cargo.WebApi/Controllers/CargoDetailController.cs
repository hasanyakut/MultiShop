using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Carge.DtoLayer.Dtos.CargoDetailDto;
using MultiShop.Cargo.BusinessLayer.Abstract;
using Multishop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoDetailController : ControllerBase
	{
		private readonly ICargoDetailService _CargoDetailService;

		public CargoDetailController(ICargoDetailService CargoDetailService)
		{
			_CargoDetailService = CargoDetailService;
		}

		[HttpGet]
		public IActionResult CargoDetailList()
		{
			var values = _CargoDetailService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
		{
			CargoDetail CargoDetail = new CargoDetail()
			{
				Barcode = createCargoDetailDto.Barcode,
				CargoCompanyId = createCargoDetailDto.CargoCompanyId,
				ReceiverCustomer = createCargoDetailDto.ReceiverCustomer,
				SenderCustomer = createCargoDetailDto.SenderCustomer
			};
			_CargoDetailService.TInsert(CargoDetail);
			return Ok("Kargo detayları başarıyla oluşturuldu");
		}

		[HttpDelete]
		public IActionResult RemoveCargoDetail(int id)
		{
			_CargoDetailService.TDelete(id);
			return Ok("Kargo Detayları başarıyla silindi.");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoDetailById(int id)
		{
			var values = _CargoDetailService.TGetById(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
		{
			CargoDetail CargoDetail = new CargoDetail()
			{
				Barcode=updateCargoDetailDto.Barcode,
				CargoCompanyId = updateCargoDetailDto.CargoCompanyId,
				CargoDetailId = updateCargoDetailDto.CargoDetailId,
				ReceiverCustomer = updateCargoDetailDto.ReceiverCustomer,
				SenderCustomer= updateCargoDetailDto.SenderCustomer
			};
			_CargoDetailService.TUpdate(CargoDetail);
			return Ok("kargo detayları başarıyla güncellendi");
		}
	}
}
