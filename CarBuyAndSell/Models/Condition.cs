using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Models
{
    public class Condition
    {
        public int ConditionId { get; set; }
        public string ConditionName { get; set; }

        public Condition(int conditionId, string conditionName)
        {
            ConditionId = conditionId;
            ConditionName = conditionName;
        }
    }
}
