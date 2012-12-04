using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using SportService.Models;

namespace SportService
{
    public interface ISportService
    {
        IList<PageNews> GetData();
    }
}
