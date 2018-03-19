using System;
using System.Collections.Generic;
using System.Text;

namespace Dolphin
{
    class MembershipFee
    {
        string typeName;
        double fee;

        public string TypeName { get => typeName; set => typeName = value; }
        public double Fee { get => fee; set => fee = value; }
    }
}
