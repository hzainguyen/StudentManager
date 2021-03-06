﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Models
{
    public class Student : BaseModel
    {
        public string FullName { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; }

        [ForeignKey("Nation")]
        public int NationId { get; set; }
        public virtual Nation Nation { get; set; }

        [ForeignKey("Religion")]
        [JsonIgnore]
        public int ReligionId { get; set; }
        public Religion Religion { get; set; }

        public string FatherName { get; set; }

        [ForeignKey("FatherJob")]
        [JsonIgnore]
        public int FatherJobId { get; set; }
        public  Job FatherJob { get; set; }
        public string MotherName { get; set; }

        [ForeignKey("Job")]
        [JsonIgnore]
        public int MotherJobId { get; set; }
        public virtual Job MotherJob { get; set; }

        public string ReadableGender()
        {
            if (Gender == 1) return "Nam";
            else return "Nữ";
        }
    }
}
