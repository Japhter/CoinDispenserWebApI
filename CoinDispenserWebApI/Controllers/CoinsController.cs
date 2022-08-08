using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoinDispenserWebApI.Data;
using CoinDispenserWebApI.Domain;
using CoinDispenserWebApI.Dto;
using CoinDispenserWebApI.CoinDispenserService;
using AutoMapper;
using System.Collections;

namespace CoinDispenserWebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ICoinDispenserService _service;

        public CoinsController(DataContext context, ICoinDispenserService coinDispenserService)
        {
            _context = context;
            _service = coinDispenserService;
        }
 
        /**
         * This method finds the minimum number of coins needed for a given amount.
         *
         * @param ChangeRequestDto DTO containing a list of coins and target amount
         *                   Finds the the minimum number of coins that make a given value.
         **/
        [HttpPost]
        [Route("MinimumCombination")]
        public async Task<ActionResult<ChangeResponseDto>> MinCobination(ChangeRequestDto model)
        {
            if (model == null)
            {
                return Problem(" model cannot be   null.");
            }
            var minCombinationValue = _service.MinCombination(model.Coins.Select(e => e.Value).ToArray(), model.Amount);

            var reponseModel = new ChangeResponseDto
            {
                Amount = model.Amount,
                Coins = model.Coins,
                MinimumCombination = minCombinationValue
            };

            var change = new Change
            {
                Amount = reponseModel.Amount,
                StringOfCoins = String.Join(",", reponseModel.Coins.Select(e => e.Value)),
                MinimumChange = reponseModel.MinimumCombination
            };

            _context.Changes.Add(change);
            await _context.SaveChangesAsync();

            return reponseModel;
        }
        // GET: api/changes
        [HttpGet]
        [Route("Change/GetRequestResults")]
        public async Task<ActionResult<IEnumerable<ResultDto>>> GetRequestResults()
        {
            if (_context.Changes == null)
            {
                return NotFound();
            }
            var records = new List<ResultDto>();
            var results = await _context.Changes.ToListAsync();
            foreach (var result in results)
            {
                var resultDto = new ResultDto
                {
                    Id = result.Id,
                    Amount = result.Amount,
                    MinimumChange = result.MinimumChange,
                    StringOfCoins = result.StringOfCoins,
                };
                records.Add(resultDto);
            }

            return records;

        }

    }
}
