using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class UnderGroundAttachedFile
    {
        public int Id { get; set; }
        public int UgId { get; set; }
        public string ProvidedBy { get; set; }
        public string FileName { get; set; }
        
    }
}
