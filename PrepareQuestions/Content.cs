using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrepareQuestions
{
    [DataContract]
    public class Content
    {
        [DataMember(Name = "column")]
        public int Column { get; set; }

        [DataMember(Name = "row")]
        public int Row { get; set; }

        [DataMember(Name = "questions")]
        public List<Question> Questions { get; set; }
    }
}
