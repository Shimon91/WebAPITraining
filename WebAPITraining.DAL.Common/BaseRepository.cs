using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.DAL.Common
{
    public class BaseRepository
    {
        protected IList<object> Items { get; set; } = new List<object>();
    }
}
