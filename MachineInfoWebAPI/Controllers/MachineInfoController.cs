using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MachineInfoWebAPI.Models;
using System;

namespace MachineInfoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineInfoController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            MachineInfo machineDetails = new MachineInfo();

            machineDetails.machineName = Environment.MachineName;
            machineDetails.machineIP = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            machineDetails.machineOS = Environment.OSVersion.VersionString;
            machineDetails.timestamp = DateTime.Now.ToString();
            return Ok(machineDetails);
        }

    }
}
