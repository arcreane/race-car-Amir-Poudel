using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndSlowCar
{
    public class Fast_Car
    {
        public Fast_Car()
        {
            AddPartsToCar(PARTS_TYPE.ENGINE
                , PARTS_TYPE.RIGHT_WHEEL
                , PARTS_TYPE.LEFT_WHEEL
                , PARTS_TYPE.RIGHT_REAR_WHEEL
                , PARTS_TYPE.LEFT_REAR_WHEEL
                , PARTS_TYPE.STRING_WHEEL
                , PARTS_TYPE.BRAKES);

        }
    }
}