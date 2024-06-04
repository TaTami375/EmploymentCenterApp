using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmploymentCenterApp.db;
using EmploymentCenterApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmploymentCenterApp.Services
{
    /// <summary>
    /// Предоставляет сервис для работы трудоустройством.
    /// </summary>
    public class EmploymentService
    {
        private readonly db.ApplicationContext _context;

        /// <summary>
        /// Инициализирует новый экземпляр класса EmploymentService с заданным контекстом базы данных.
        /// </summary>
        /// <param name="context">Контекст базы данных.</param>
        public EmploymentService(db.ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Добавляет новое трудоустройство.
        /// </summary>
        /// <param name="employment">Трудоустройство для добавления.</param>
        public void AddEmployment(Employment employment)
        {
            _context.Employments.Add(employment);
            _context.SaveChanges();
        }

        /// <summary>
        /// Обновляет информацию о трудоустройстве.
        /// </summary>
        /// <param name="employment">Трудоустройство для обновления.</param>
        public void UpdateEmployment(Employment employment)
        {
            _context.Employments.Update(employment);
            _context.SaveChanges();
        }

        /// <summary>
        /// Удаляет резервацию книги по идентификаторам клиента и книги.
        /// </summary>
        /// <param name="ApplicantId">Идентификатор клиента.</param>
        /// <param name="WorkId">Идентификатор книги.</param>
        public void DeleteEmployment(uint ApplicantId, uint WorkId)
        {
            var reservation = _context.Employments.Find(ApplicantId, WorkId);
            if (reservation != null)
            {
                _context.Employments.Remove(reservation);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Удаляет резервацию книги по идентификатору.
        /// </summary>
        /// <param name="Id">Идентификатор резервации книги.</param>
        public void DeleteEmployment(uint Id)
        {
            var employment = _context.Employments.Find(Id);
            if (employment != null)
            {
                _context.Employments.Remove(employment);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Получает все резервации книг.
        /// </summary>
        /// <returns>Список всех резерваций книг.</returns>
        public List<Employment> GetAllEmployment()
        {
            return _context.Employments.ToList();
        }

        /// <summary>
        /// Получает резервацию книги по идентификаторам клиента и книги.
        /// </summary>
        /// <param name="clientId">Идентификатор клиента.</param>
        /// <param name="bookId">Идентификатор книги.</param>
        /// <returns>Резервация книги, если найдена; в противном случае — null.</returns>
        public Employment GetEmploymentById(uint ApplicantId, uint WorkId)
        {
            return _context.Employments.Find(ApplicantId, WorkId);
        }

        /// <summary>
        /// Получает резервацию книги по идентификатору.
        /// </summary>
        /// <param name="Id">Идентификатор резервации книги.</param>
        /// <returns>Резервация книги, если найдена; в противном случае — null.</returns>
        public Employment GetEmploymentById(uint Id)
        {
            return _context.Employments.Find(Id);
        }
    }
}
