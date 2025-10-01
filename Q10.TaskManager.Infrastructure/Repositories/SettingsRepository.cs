using Q10.TaskManager.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10.TaskManager.Infrastructure.Repositories
{
    public class SettingsRepository : IConfig
    {
        public IConfiguration _configuration;

        public SettingsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetValue(string key)
        {
            return _configuration[key];
        }
    }
}
