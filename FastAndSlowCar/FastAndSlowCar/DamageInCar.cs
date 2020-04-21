using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndSlowCar
{
    public class DamageInCar
    {
        private bool m_EngineDamage = true;
        private Fast_Car.Engine m_currentEngine;
        public event EventHandler EngineDamage; 

        override public Fast_Car.Engine EngineProp
        {
            get
            {
                if (m_bEngineChange)
                {
                    m_currentEngine = Fast_CarProp.GetRandomEngine();

                }
                return m_currentEngine;
            }
        }

    }
}
