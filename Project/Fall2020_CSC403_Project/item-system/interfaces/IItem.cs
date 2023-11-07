using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.item_system.interfaces
{
    public interface IItem
    {
        string itemName { get; }
        Collider collider { get; set; }
        Vector2 initPos { get; set; }

        void ExecuteEffect(FrmLevel frmLevel);
        
    }

}
