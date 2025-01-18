using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonTutCuf
{
    public class Config : IConfig
    {
        [Description("Plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug is enabled")]
        public bool Debug { get; set; } = true;
    }
}
