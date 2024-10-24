using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Cargo.EntityLayer.Concrete;
using MultiShop.Carge.DtoLayer.Dtos.CargoCustomerDto;
using MultiShop.Cargo.BusinessLayer.Abstract;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCustomerController : ControllerBase
	{
		private readonly ICargoCustomerService _cargoCustomerService;

		public CargoCustomerController(ICargoCustomerService cargoCustomerService)
		{
			_cargoCustomerService = cargoCustomerService;
		}
		[HttpGet]
		public IActionResult CargoCustomerList()
		{
			var values = _cargoCustomerService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCustomerById(int id)
		{
			var value = _cargoCustomerService.TGetById(id);
			return Ok(value);
		}

		[HttpPost]
		public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				Address = createCargoCustomerDto.Address,
				City = createCargoCustomerDto.City,
				District = createCargoCustomerDto.District,
				Email = createCargoCustomerDto.Email,
				Name = createCargoCustomerDto.Name,
				Phone = createCargoCustomerDto.Phone,
				Surname = createCargoCustomerDto.Surname
			};
			_cargoCustomerService.TInsert(cargoCustomer);
			return Ok("Kargo müşteri ekleme işlemi başarılı");
		}
		[HttpDelete]
		public IActionResult RemoveCargoCustomer(int id)
		{
			_cargoCustomerService.TDelete(id);
			return Ok("Müşteri silme işlemi başarılı");
		}
		[HttpPut]
		public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				Address = updateCargoCustomerDto.Address,
				CargoCustomerId = updateCargoCustomerDto.CargoCustomerId,
				City = updateCargoCustomerDto.City,
				District = updateCargoCustomerDto.District,
				Email = updateCargoCustomerDto.Email,
				Name = updateCargoCustomerDto.Name,
				Phone = updateCargoCustomerDto.Phone,
				Surname = updateCargoCustomerDto.Surname
			};
			_cargoCustomerService.TUpdate(cargoCustomer);
			return Ok("Kargo müşteri Güncelleme İşlemi Başarılı");
		}
	}
}
