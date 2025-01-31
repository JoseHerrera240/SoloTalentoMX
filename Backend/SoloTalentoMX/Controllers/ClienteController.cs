﻿using Microsoft.AspNetCore.Mvc;
using SoloTalentoMX.Api.BussinessLogic.Dto;
using SoloTalentoMX.Api.BussinessLogic.Interfaces;
using SoloTalentoMX.Api.BussinessLogic.Utility;

namespace SoloTalentoMX.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesServices _iClientesServices;

        public ClienteController(IClientesServices iClientesServices)
        {
            _iClientesServices = iClientesServices;
        }

        [HttpPost("RegisterUser")]
        public async Task<ReturnWebApi> RegisterUser([FromBody] ClientesCreateDto dto)
        {
            return await _iClientesServices.RegistrarUsuario(dto);
        }
    }
}
