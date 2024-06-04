using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmploymentCenterApp.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmploymentCenterApp.Services
{
    /// <summary>
    /// Предоставляет сервис для работы с клиентами библиотеки.
    /// </summary>
    internal class ApplicantService
    {
        private readonly db.ApplicationContext _context;

        /// <summary>
        /// Инициализирует новый экземпляр класса ClientService с заданным контекстом базы данных.
        /// </summary>
        /// <param name="context">Контекст базы данных.</param>
        public ApplicantService(db.ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Добавляет нового соискателя.
        /// </summary>
        /// <param name="applicant">Соискатель для добавления.</param>
        public void AddApplicant(Applicant applicant)
        {
            _context.Applicants.Add(applicant);
            _context.SaveChanges();
        }

        /// <summary>
        /// Обновляет информацию о соискателе.
        /// </summary>
        /// <param name="applicant">Соискатель для обновления.</param>
        public void UpdateApplicant(Applicant applicant)
        {
            _context.Applicants.Update(applicant);
            _context.SaveChanges();
        }

        /// <summary>
        /// Удаляет соискателя по идентификатору.
        /// </summary>
        /// <param name="ApplicantId">Идентификатор соискателя.</param>
        public void DeleteApplicant(uint ApplicantId)
        {
            var applicant = _context.Applicants.Find(ApplicantId);
            if (applicant != null)
            {
                _context.Applicants.Remove(applicant);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Получает всех соискателей.
        /// </summary>
        /// <returns>Список всех соискателей.</returns>
        public List<Applicant> GetAllApplicants()
        {
            return _context.Applicants.ToList();
        }

        /// <summary>
        /// Получает соискателя по идентификатору.
        /// </summary>
        /// <param name="ApplicantId">Идентификатор соискателя.</param>
        /// <returns>Соискатель, если найден; в противном случае — null.</returns>
        public Applicant GetApplicantById(int ApplicantId)
        {
            return _context.Applicants.Find(ApplicantId);
        }


        public List<Applicant> GetUnemployed()
        {
            var applicantsWithcEmployed = _context.Applicants.Include(c => c.Employments).ToList();

            var unemployedApplicants = applicantsWithcEmployed.Where(applicant => applicant.Employments.Count == 0).ToList();

            return unemployedApplicants;
        }

        public List<Applicant> GetEmployed()
        {
            var applicantsWithcEmployed = _context.Applicants.Include(c => c.Employments).ToList();

            var result = applicantsWithcEmployed.Where(applicant =>
                applicant.Employments != null &&
                applicant.Employments.Any(hiring =>
                    hiring.DismissalDate == DateTime.MinValue || hiring.DismissalDate<hiring.EmploymentDate)).ToList();
            return result;
        }

        public bool IsSurnameExisist(string surname)
        {
            return _context.Applicants.Any(c => c.Surname == surname);
        }

        public bool IsNameExisist(string name)
        {
            return _context.Applicants.Any(c => c.Name == name);
        }

        public bool IsPatronymicExisist(string patronymic)
        {
            return _context.Applicants.Any(c => c.Patronymic ==patronymic);
        }
    }
}
