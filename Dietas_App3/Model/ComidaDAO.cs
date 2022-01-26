using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensionsAsync.Extensions;
namespace Dietas_App.Model
{
    public class ComidaDAO
    {
        static public Task<List<Comida>> GetAllAsync()
        {
            return DataBase.ConnectionDatabase.GetAllWithChildrenAsync<Comida>();
        }
    }
}
