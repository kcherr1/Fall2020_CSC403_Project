using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Item  {
    public string Name { get; private set; }
    public string Type { get; private set; }
    public int Value { get; private set; }

    public Item(string name, string type, int value) {
      Name = name;
      Type = type;
      Value = value;
    }
  }
}
