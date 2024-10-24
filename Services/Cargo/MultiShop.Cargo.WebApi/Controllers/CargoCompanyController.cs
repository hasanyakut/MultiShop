﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Carge.DtoLayer.Dtos.CargoCompanyDto;
using Multishop.Cargo.EntityLayer.Concrete;
using MultiShop.Cargo.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCompanyController : ControllerBase
	{
		private readonly ICargoCompanyService _cargoCompanyService;

		public CargoCompanyController(ICargoCompanyService cargoCompanyService)
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
		public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
		{
			CargoCompany cargoCompany = new CargoCompany()
			{
				CargoCompanyName=createCargoCompanyDto.CargoCompanyName
			};
			_cargoCompanyService.TInsert(cargoCompany);
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
		public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
		{
			CargoCompany cargoCompany = new CargoCompany()
			{
				CargoCompanyId = updateCargoCompanyDto.CargoCompanyId,
				CargoCompanyName = updateCargoCompanyDto.CargoCompanyName
			};
			_cargoCompanyService.TUpdate(cargoCompany);
			return Ok("kargo şirketi başarıyla güncellendi");
		}
	}
}
