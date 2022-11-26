using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseRepository
    {
        protected string connectionString { get; set; }
        protected BaseRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
