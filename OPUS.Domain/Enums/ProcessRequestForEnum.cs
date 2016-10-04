using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Enums
{
    public enum ProcessRequestForEnum
    {
        NotPossibleWithSelectedConnectionType,
        NotPossibleWithExistingInterfaceForLocationA,
        NotPossibleWithExistingInterfaceForLocationB,
        ServiceNotPossibleWithSelectedServiceType,
        RequiredCapacityDeliveryNotPossible,
        InterfaceTypeNotPossible,
        InterfacecategoryNotPossible,
        NotPossibleLastMileServiceTypeOfLocationABySelectedServiceType,
        NotPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType,
        NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType,
        NotPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType
    }
}
