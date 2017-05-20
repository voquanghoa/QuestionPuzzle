using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrepareQuestions
{
    [DataContract]
    public class Question
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "answer")]
        public string Answer { get; set; }

    }
}
