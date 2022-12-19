using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amouzesh_1
{
    public interface IDamagable
    {
        float Health { get; set; }
        void TakeDamage(float damage);
    }

    // Version Control
    // Git
}
