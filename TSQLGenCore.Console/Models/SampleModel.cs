using System;
using TSQLGen.Annotations;

namespace TSQLGen.Console.Models
{
    [Table("TEST_TABLE_NAME")]
    public class SampleModel
    {
        [Field(true, true)]
        public Guid Id { get; set; }

        [Field]
        public String Name { get; set; }

        [Field]
        public String Code { get; set; }

        [Field]
        public DateTime Date { get; set; }

        [Field]
        public Boolean Active { get; set; }


        public Object ExcludeThisProperty { get; set; }
    }
}
