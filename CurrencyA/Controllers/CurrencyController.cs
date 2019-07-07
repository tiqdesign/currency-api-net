using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyA.Models;
using CurrencyA.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyA.Controllers
{
    //https://localhost:44307/api/currency/getCurrency/2019-07-05/USD/TRY


    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        Api_Connection _con = new Api_Connection();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="basec"></param>
        /// <param name="rates"></param>
        /// <returns></returns>
        [HttpGet("[action]/{date}/{basec}/{rates}")]
        public Task<Currency> getCurrency(string date, string basec, string rates)
        {
            var currency = _con.GetCurrency(basec,rates,date);
            return currency;
        }
    }
}