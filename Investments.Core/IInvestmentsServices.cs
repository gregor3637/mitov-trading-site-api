using Investments.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments.Core
{
    public interface IInvestmentsServices
    {
        List<Investment> GetInvestments();
        Investment GetInvestment(int id);
        Investment CreateInvestment(Investment investment);

        void DeleteInvestment(Investment investment);

        Investment EditInvestment(int id);
    }
}
