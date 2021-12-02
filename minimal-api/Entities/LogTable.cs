using System;
using System.Collections.Generic;

#nullable disable

namespace minimal_api.Entities
{
    public partial class LogTable
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        public int? RowId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}
