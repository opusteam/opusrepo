using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Enums
{
    public enum FeasibilityStatusEnum
    {
        NewBorn,      //New feasibility by KAM.
        FeedBacked,  // Afetr feed back by planning on newborn feasibility its' status will be Feedbacked. 
        WorkOrdered, //After feedbacked by planning marketing will give work order and the feasibility
                     //status will be WorkOrdered.
        Cancelled,
        WorkOnProgress
    }
}
