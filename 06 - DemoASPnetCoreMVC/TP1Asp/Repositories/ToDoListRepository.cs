using System.Linq.Expressions;
using TP1Asp.Data;
using TP1Asp.Models;

namespace TP1Asp.Repositories
{
    public class ToDoListRepository : IRepository<ToDoList>
    {
        private ApplicationDbContext _dbContext;
        public ToDoListRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // CREATE
        public bool Add(ToDoList toDolist)
        {
            var addedObj = _dbContext.ToDoLists.Add(toDolist);
            _dbContext.SaveChanges();
            return addedObj.Entity.Id > 0;
        }

        // READ
        public ToDoList? GetById(int id)
        {
            return _dbContext.ToDoLists.Find(id);
        }
        public ToDoList? Get(Expression<Func<ToDoList, bool>> predicate)
        {
            return _dbContext.ToDoLists.FirstOrDefault(predicate);
        }
        public List<ToDoList> GetAll()
        {
            return _dbContext.ToDoLists.ToList();
        }
        public List<ToDoList> GetAll(Expression<Func<ToDoList, bool>> predicate)
        {
            return _dbContext.ToDoLists.Where(predicate).ToList();
        }

        // UPDATE
        public bool Update(ToDoList toDoList)
        {
            var todoFromDb = GetById(toDoList.Id);

            if (todoFromDb == null)
                return false;

            if (todoFromDb.TitleTask != toDoList.TitleTask)
                todoFromDb.TitleTask = toDoList.TitleTask;
            if (todoFromDb.Desc != toDoList.Desc)
                todoFromDb.Desc = toDoList.Desc;

            return _dbContext.SaveChanges() > 0;
        }

        // DELETE
        public bool Delete(int id)
        {
            var todo = GetById(id);
            if (todo == null)
                return false;
            _dbContext.ToDoLists.Remove(todo);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
