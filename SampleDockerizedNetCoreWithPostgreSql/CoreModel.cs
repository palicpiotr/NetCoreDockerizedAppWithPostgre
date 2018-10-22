using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDockerizedNetCoreWithPostgreSql
{
    public class CoreModel
    {
        public string OsPlatform { get; set; }
        public string AspDotNetVersion { get; set; }
        public string TargetFramework { get; set; }
    }
}
