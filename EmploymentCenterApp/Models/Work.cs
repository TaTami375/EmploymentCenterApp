using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmploymentCenterApp.Models
{
    public enum Qualif
    {
        Low, Medium, High
    }
    /// <summary>
    /// Представляет собой модель вакансии.
    /// </summary>
    public class Work
    {
        /// <summary>
        /// Уникальный идентификатор вакансии.
        /// </summary>
        public uint Id { get; set; }

        public string Name { get; set; }

        public Qualif Qualification { get; set; }

        public string Place { get; set; }

        public uint Sallary { get; set; }

        [JsonIgnore]
        public Employment Employment { get; set; }

        public Work() { }


        public Work(uint id, string name, Qualif qualification, string place, uint sallsry, Employment employment)
        {
            Id = id;
            Name = name;
            Qualification = qualification;
            Place = place;
            Sallary = sallsry;
            Employment = employment;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Qualification: {Qualification}, Place: {Place}, Sallary: {Sallary}";
        }
    }
}
