using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NguyenDuyThang_5951071100.Models
{
    public class StudentInfo
    {
        [DataMember(Name = "name")]

        public string Name { get; set; }

        [DataMember(Name = "age")]

        public int Age { get; set; }
        [DataMember(Name = "gender")]

        public int Gender { get; set; }
    }
}