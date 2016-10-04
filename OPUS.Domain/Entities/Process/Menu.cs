using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string AreaName { get; set; }
    }
}
