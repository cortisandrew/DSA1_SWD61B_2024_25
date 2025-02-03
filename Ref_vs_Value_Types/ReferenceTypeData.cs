using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_vs_Value_Types
{
    public class ReferenceTypeData
    {
        public int InstanceValue { get; set; }

        public ReferenceTypeData() { }

        public ReferenceTypeData(int instanceValue) {  this.InstanceValue = instanceValue; }
    }
}
