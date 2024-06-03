using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmploymentCenterApp.Models
{
    public class Applicant
    {
        // <summary>
        /// Имя соискателя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия клиента.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество соискателя.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Уникальный идентификатор соискателя.
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Стаж работы соискателя.
        /// </summary>
        public uint Experience { get; set; }

        /// <summary>
        /// Список заявок вакансий для данного соискателя.
        /// </summary>
        [JsonIgnore]
        public ICollection<Employment> Employments { get; set; }

        public Applicant()
        {
            Employments = new List<Employment>();
        }

        public Applicant(string name, string surname, string patronymic, uint id, uint experience)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Id = id;
            Experience = experience;
            Employments = new List<Employment>();
        }

        public override string ToString()
        {
            return $"Surname: {Surname}, Experience: {Experience}";
        }
    }
}
