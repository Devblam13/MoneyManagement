using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.DataTransferObjects
{
    public class BetImageDto
    {
        public int BetImageId { get; set; }

        public byte[] Image { get; set; }
    }
}
