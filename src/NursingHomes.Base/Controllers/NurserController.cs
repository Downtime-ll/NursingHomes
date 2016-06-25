using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using NursingHomes.Base.Domain;
using NursingHomes.Base.Domain.Dtos;


namespace NursingHomes.Base.Controllers
{
    [Route("api/[controller]")]
    public class NurserController : Controller
    {
        private readonly INurserService _nurserService;

        public NurserController(INurserService nurserService)
        {
            _nurserService = nurserService;
        }

        /// <summary>
        /// 获取护理人员列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<ListResultOutput<NurserDto>> Get()
        {
           return _nurserService.Get();
        }

        /// <summary>
        /// 获取护理人员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Task<NurserDto> Get(Guid id)
        {
            return _nurserService.Get(id);
        }

        /// <summary>
        /// 创建护理人员
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]NurserDto value)
        {
        }

        /// <summary>
        /// 修改护理人员
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]NurserDto value)
        {
        }

        /// <summary>
        /// 删除护理人员
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
