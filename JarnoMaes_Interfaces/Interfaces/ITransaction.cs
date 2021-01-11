using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarnoMaes_Interfaces.Interfaces
{
    interface ITransaction
    {
        void ShowTransaction();
        double GetAmount();
        string ShowBankName();
    }
}
