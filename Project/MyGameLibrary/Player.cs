using System;
using System.Collections.Generic;https://github.com/CSC403-Murcs/Fall2020_CSC403_Project/pull/2/conflict?name=Project%252FMyGameLibrary%252FMyGameLibrary.csproj&ancestor_oid=73f9e6813048abe4b408d6722bc8bdbbac8ce132&base_oid=1a60c83ddce178cf5fe4353517db271f91aa8058&head_oid=1819e4bb5155bf3276c95e6d133f74421dcc8bae
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    Inventory inventory;

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
      AttackEvent += GainExperience;
      this.inventory = new Inventory();
    }

    // Enable the player to add items to the inventory
    public void addItemToInventory(Item item){
      inventory.addItem(item);
    }
    
    // Enable the player to remove an item from the inventory
    public void removeItemFromInventory(Item item){
      
    }

    public override int EquipmentBonus(Skill skill)
    {
      return 0;
    }

    private void GainExperience(string skillType, int damage)
    {
      // Gain experience depending on the type of skill used
      int exp = damage * 4;
      Skills[skillType].AddExperience(exp);

      // Globally increment health exp
      int hpexp = damage;
      Skills[Defs.SKILL_HP].AddExperience(hpexp);
    }

    // Enable the player to use an item from the inventory
    public void useItemFromInventory(Item item){

    }

  }
}
