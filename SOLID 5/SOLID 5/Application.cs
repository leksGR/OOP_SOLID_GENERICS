using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_5
{
    public class Application
    {
        public ILogger logger { get; set; }
        public Application(ILogger logger)
        {
            this.logger = logger;
        }
        public void Action()
        {
            logger.Log("Процесс начался");
        }
    }
}
