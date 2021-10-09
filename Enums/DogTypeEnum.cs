using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ReturningEnumValuesOverAPI.Enums
{
    public enum DogTypeEnum
    {
        [Description("German shepherd")]
        GERMAN_SHEPHERD = 1,

        [Description("Labrador retreiver")]
        LABRADOR_RETREIVER = 2,

        [Description("Siberian huskey")]
        SIBERIAN_HUSKEY = 3
    }
}
