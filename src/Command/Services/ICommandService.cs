using System.Collections.Generic;
using Command.Models;

namespace Command.Services
{
    public interface ICommandService
    {
        IEnumerable<Commands> GetAllCommands();
        Commands GetCommandById(int id);
    }
}