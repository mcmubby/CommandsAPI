using System.Collections.Generic;
using System.Linq;
using Command.Data;
using Command.Models;

namespace Command.Services
{
    public class SqlCommandRepo : ICommandService
    {
        private readonly CommandDbContext _context;

        public SqlCommandRepo(CommandDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Commands> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Commands GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}