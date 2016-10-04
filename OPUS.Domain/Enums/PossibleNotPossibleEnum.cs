using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Enums
{
    public enum PossibleNotPossibleEnum
    {
        [Display(Name ="Not possible")]
        Not_Possible,
        Possible
    }
}
