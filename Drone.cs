using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.Core
{
    [Serializable]
    public class Drone : Bee
    {
        #region Public Methods

        public override void Inflict_Damage(int iDamage)
        {
            if (bDead == false)
            {
                var oldHealth = db_Health;

                var newHealth = oldHealth - Convert.ToDouble(iDamage);

                UpdateHealth(newHealth);

                if (newHealth < 50)
                {
                    this.bDead = true;
                }
            }
        }

        #endregion Public Methods
    }
}
