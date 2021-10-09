using ReturningEnumValuesOverAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReturningEnumValuesOverAPI.DTOs
{
    public class EnumDTO
    {
        public int Key { get { return Convert.ToInt32(_enum); } }
        public string Name { get { return _enum.ToDescription(); } }
        private Enum _enum;
        public EnumDTO(Enum inputEnum)
        {
            _enum = inputEnum;
        }
    }
}
