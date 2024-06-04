using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmploymentCenterApp.Models;

namespace EmploymentCenterApp.Services
{
    /// <summary>
    /// Предоставляет сервис для работы с вакансиями.
    /// </summary>
    public class WorkService
    {
        private readonly db.ApplicationContext _context;

        /// <summary>
        /// Инициализирует новый экземпляр класса WorkService с заданным контекстом базы данных.
        /// </summary>
        /// <param name="context">Контекст базы данных.</param>
        public WorkService(db.ApplicationContext context)
        {
            _context = context;
        }

        // <summary>
        /// Добавляет новую вакансию.
        /// </summary>
        /// <param name="book">Книга для добавления.</param>
        public void AddWork(Work work)
        {
            _context.Works.Add(work);
            _context.SaveChanges();
        }

        /// <summary>
        /// Обновляет информацию о вакансии.
        /// </summary>
        /// <param name="work">Вакансия для обновления.</param>
        public void UpdateWork(Work work)
        {
            _context.Works.Update(work);
            _context.SaveChanges();
        }

        /// <summary>
        /// Удаляет вакансию по идентификатору.
        /// </summary>
        /// <param name="WorkId">Идентификатор вакансии.</param>
        public void DeleteBook(uint WorkId)
        {
            var work = _context.Works.Find(WorkId);
            if (work != null)
            {
                _context.Works.Remove(work);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Получает все вакансии.
        /// </summary>
        /// <returns>Список всех вакансий.</returns>
        public List<Work> GetAllWorks()
        {
            return _context.Works.ToList();
        }

        /// <summary>
        /// Получает вакансию по идентификатору.
        /// </summary>
        /// <param name="WorkId">Идентификатор вакансии.</param>
        /// <returns>Вакаечмя, если найдена; в противном случае — null.</returns>
        public Work GetWorkById(int WorkId)
        {
            return _context.Works.Find(WorkId);
        }

        /// <summary>
        /// Поиск вакансий по названию.
        /// </summary>
        /// <param name="query">Поисковой запрос.</param>
        /// <returns>Список вакансий, удовлетворяющих поисковому запросу по названию.</returns>
        public List<Work> SearchBooksByAuthor(string query)
        {
            return _context.Works.ToList().Where(work => work.Name.ToLower().Contains(query.ToLower())).ToList();
        }

        /// <summary>
        /// Поиск книг по месту.
        /// </summary>
        /// <param name="query">Поисковой запрос.</param>
        /// <returns>Список вакансий, удовлетворяющих поисковому запросу по месту.</returns>
        public List<Work> SearchBooksByTitle(string query)
        {
            return _context.Works.ToList().Where(work => work.Place.ToLower().Contains(query.ToLower())).ToList();
        }
    }
}
