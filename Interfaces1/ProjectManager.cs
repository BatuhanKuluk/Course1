using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    class ProjectManager
    {
        public void Add(IPerson person)
        {
            person.Add();
        }
    }
}
