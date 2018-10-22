using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleDockerizedNetCoreWithPostgreSql.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        // GET api/values
        [HttpGet]
        public ApiResult<CoreModel> Get()
        {
            var framework = Assembly
                              .GetEntryAssembly()?
                              .GetCustomAttribute<TargetFrameworkAttribute>()?
                              .FrameworkName;
            var stats = new
            {
                OsPlatform = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                AspDotnetVersion = framework
            };
            string runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            return new ApiResult<CoreModel>
            (
                new CoreModel
                {
                    AspDotNetVersion = stats.AspDotnetVersion,
                    TargetFramework = framework,
                    OsPlatform = stats.OsPlatform
                }
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
