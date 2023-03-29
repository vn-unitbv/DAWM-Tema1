using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class ApartmentUpdateAreaDto
    {
        public int ApartmentId { get; set; }

        public float TotalArea { get; set; }

        public float UsableArea { get; set; }
    }
}
