﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pihole_api.Services;

namespace pihole_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiholeController : ControllerBase
    {
        private readonly ILogger<PiholeController> _logger;
        private readonly IShellService _shellService;
        private readonly IPiholeService _piholeService;

        public PiholeController(ILogger<PiholeController> logger, IShellService shellService, IPiholeService piholeService)
        {
            _logger = logger;
            _shellService = shellService;
            _piholeService = piholeService;
        }

        /// <summary>
        /// Enables Pihole by running 'pihole enable'
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Enable")]
        public IActionResult Enable()
        {
            return Ok();
        }

        /// <summary>
        /// Disables Pihole by running 'pihole disable'
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("Disable")]
        public IActionResult Disable()
        {
            return Ok();
        }

        /// <summary>
        /// Gets status of Pihole by running 'pihole status'
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Status")]
        public IActionResult Status()
        {
            return Ok();
        }

        /// <summary>
        /// Restarts DNS resolver by running 'pihole restartdns'
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("RestartDns")]
        public IActionResult RestartDns()
        {
            return Ok();
        }

        /// <summary>
        /// Flushes ARP tables by running 'pihole arpflush'
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("ArpFlush")]
        public IActionResult ArpFlush()
        {
            return Ok();
        }

        /// <summary>
        /// Get all active DHCP leases
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ActiveDhcpLeases")]
        public IActionResult ActiveDhcpLeases()
        {
            return Ok();
        }

        /// <summary>
        /// Checks if a specified hostname has an active DHCP lease
        /// </summary>
        /// <param name="hostname">Hostname</param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeviceHasActiveDhcpLease")]
        public IActionResult DeviceHasActiveDhcpLease([FromBody] string hostname)
        {
            return Ok();
        }

        [HttpGet]
        [Route("TestShellService")]
        public async Task<IActionResult> TestShellService()
        {
            var result = await _shellService.ExecuteShellCommandAsync("echo hello");

            return Ok(result);
        }

    }
}
