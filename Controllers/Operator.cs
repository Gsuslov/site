using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    [ApiController]
    [Route("/Operator")]
    public class Operator : ControllerBase

   
    {

        [HttpGet("FishTypes")]
        public string FishTypes(string str)
        {
            return str; // Заполнение информации о видах рыб

        }

        [HttpPost("CreateFishType")]
        public string CreateFishType(string str)
        {
            return str; // Заполнение информации о видах рыб

        }

        [HttpPut("UpdateFishType")]
        public string UpdateFishType(string str)
        {
            return str; // Заполнение информации о видах рыб

        }

        [HttpDelete("DeleteFishType")]
        public string DeleteFishType(string str)
        {
            return str; // Заполнение информации о видах рыб

        }

        [HttpGet("GetRivers")]
        public string GetRivers(string str)
        {
            return str; // Заполнение информации о водоеме
        }

        [HttpPost("PostRivers")]
        public string PostRivers(string str)
        {
            return str; // Заполнение информации о водоеме
        }

        [HttpPut("PutRivers")]
        public string PutRivers(string str)
        {
            return str; // Заполнение информации о водоеме
        }

        [HttpDelete("DeleteRivers")]
        public string DeleteRivers(string str)
        {
            return str; // Заполнение информации о водоеме
        }

        [HttpGet("GetProcessingComments")]
        public string GetProcessingComments(string str)
        {
            return str; // обработка комментариев
        }

        [HttpPost("PostProcessingComments")]
        public string PostProcessingComments(string str)
        {
            return str; // обработка комментариев
        }

        [HttpPut("PutProcessingComments")]
        public string PutProcessingComments(string str)
        {
            return str; // обработка комментариев
        }

        [HttpDelete("DeleteProcessingComments")]
        public string DeleteProcessingComments(string str)
        {
            return str; // обработка комментариев
        }


        [HttpGet("TypesBaits")]
        public string TypesBaits(string str)
        {
            return str; // Виды прикормки
        }

        [HttpGet("LivingFish")]
        public string LivingFish(string str)
        {
            return str; // Перечень обитающих рыб в водоеме
        }

        [HttpGet("AllocationComment")]
        public string AllocationComments(string str)
        {
            return str; // Размещение комментариев пользователей
        }

        [HttpGet("RejectionComment")]
        public string RejectionComment(string str)
        {
            return str; // Мотивированный отказ на размещение коментария
        }
    }
    
}
