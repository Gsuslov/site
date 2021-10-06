using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    [ApiController]
    [Route("/User")]
    public class User : ControllerBase


    {

        [HttpGet("SeatchRiver")]
        public string SeatchRiver(string str)
        {
            return str; // Поиск водоема

        }

        [HttpGet("RiverInfo")]
        public string RiverInfo(string str)
        {
            return str; // Просмотр информации о водоеме
        }

        [HttpPost("CreateComments")]
        public string CreateComments(string str)
        {
            return str; // Создание коментария
        }

        [HttpGet("Comments")]
        public string Comments(string str)
        {
            return str; // Комментирование
        }

      
        [HttpGet("LivingFish")]
        public string LivingFish(string str)
        {
            return str; // желаемая рыба
        }

        [HttpGet("Region")]
        public string Region(string str)
        {
            return str; // Выбор региона
        }
    }

}
