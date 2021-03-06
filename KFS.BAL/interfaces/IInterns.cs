using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFS.BAL.interfaces
{
    public interface IInterns
    {
        List<InternInfo> GetAllIntern();
        int AddInter(InternInfo model);
        InternInfo GetPerticulartInter(int iid);
        int UpdateInter(InternInfo model);
        int DeleteInter(int iid);
    }
}
