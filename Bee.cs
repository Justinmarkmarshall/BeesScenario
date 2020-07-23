using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.Core
{
    [Serializable]
    public abstract class Bee
    {
        #region Properties

        public int Id { get; set; } = 0;

        public double db_Health { get; private set; } = 0F;

        public bool bDead { get; set; } = false;

        #endregion Properties

        #region Constructors

        public Bee(double Health = 100) { db_Health = Health; }

        #endregion Constructors

        #region Public Methods

        public abstract void Inflict_Damage(int iDamage);

        public void UpdateHealth(double dValue)
        {
            this.db_Health = dValue;
        }

        #endregion Public Methods

    }
}
