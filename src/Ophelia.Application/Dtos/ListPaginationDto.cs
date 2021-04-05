using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Dtos
{
    public class ListPaginationDto<T>
    {
        public IReadOnlyList<T> Items { get; set; }
        public int totalCount { get; set; }
    }
}
