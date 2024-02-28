using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface IViewRender
    {
        string Render<TModel>(string name, TModel model);
    }
}
