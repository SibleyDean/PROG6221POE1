using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poeAssigmentTwo.Services
{
    public class validateService
    {
        public bool IsValidInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;
            if (input.Length > 250)
                return false;

            var invalidChars = new[] { '<', '>', '&', '|', ';' };
            return !invalidChars.Any(c => input.Contains(c));
        }
    }
}
