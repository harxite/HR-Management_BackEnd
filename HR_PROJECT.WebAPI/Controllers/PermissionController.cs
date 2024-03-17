﻿using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.PermissionQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        #region Permission Handlers

        private readonly CreatePermissionCommandHandler _createPermissionCommandHandler;
        private readonly GetPermissionsByEmployeeIDHandler _getPermissionsByEmployeeIDHandler;
        private readonly RemovePermissionCommandHandler _removePermissionCommandHandler;
        private readonly UpdatePermissionCommandHandler _updatePermissionCommandHandler;
        private readonly GetPermissionQueryHandler _getPermissionQueryHandler;
        #endregion


        #region Constructor

       public PermissionController(CreatePermissionCommandHandler createPermissionCommandHandler, GetPermissionsByEmployeeIDHandler getPermissionsByEmployeeIDHandler, RemovePermissionCommandHandler removePermissionCommandHandler, UpdatePermissionCommandHandler updatePermissionCommandHandler, GetPermissionQueryHandler getPermissionQueryHandler  )
        {
            _createPermissionCommandHandler = createPermissionCommandHandler;
            _getPermissionsByEmployeeIDHandler = getPermissionsByEmployeeIDHandler;
            _removePermissionCommandHandler = removePermissionCommandHandler;
            _updatePermissionCommandHandler = updatePermissionCommandHandler; 
            _getPermissionQueryHandler = getPermissionQueryHandler;
        }
        #endregion

   
        #region Read Methods

        [HttpGet("{employeeId}/byEmployee")]
        public async Task<IActionResult> GetPermissionsByEmployee(int employeeId)
        {
            var value = await _getPermissionsByEmployeeIDHandler.Handle(new GetPermissionsByEmployeeIDQuery(employeeId));
            return Ok(value);
        }

        [HttpGet]
        public async Task<IActionResult> GetPermissions()
        {
            var values = await _getPermissionQueryHandler.Handle();
            return Ok(values);
        }
        #endregion


        #region Write Methods

        [HttpPost]
        public async Task<IActionResult> CreatePermission(CreatePermissionCommand command)
        {
            await _createPermissionCommandHandler.Handle(command);
            return Ok("Izin talebi basarili bir sekilde gonderildi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemovePermission(int id)
        {
            await _removePermissionCommandHandler.Handle(new RemovePermissionCommand(id));
            return Ok("Izin talebi basarili bir sekilde  silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePermission(UpdatePermissionCommand command)
        {
            await _updatePermissionCommandHandler.Handle(command);
            return Ok("Izin talebi basarili bir sekilde güncellendi.");
        }

        #endregion
    }


}
