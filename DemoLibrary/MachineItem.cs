using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class MachineItem
    {
        public string Name { get; set; }
        public string Load { get; set; }
        public string Value { get; set; }
    }

    public class MachineItems
    {
        public List<MachineItem> List;

        public MachineItems()
        {
            List = new List<MachineItem>() {
                new MachineItem() { Name = "Shortleaf Pine with Oak", Load = "Low", Value = "3.0"},
                new MachineItem() { Name = "Shortleaf Pine with Oak", Load = "Moderate", Value = "4.0"},
                new MachineItem() { Name = "Shortleaf Pine with Oak", Load = "Heavy", Value = "4.4"},

                new MachineItem() { Name = "Shortleaf Pine Regeneration", Load = "Low", Value = "2.6"},
                new MachineItem() { Name = "Shortleaf Pine Regeneration", Load = "Moderate", Value = "3.8"},
                new MachineItem() { Name = "Shortleaf Pine Regeneration", Load = "Heavy", Value = "5.1"},

                new MachineItem() { Name = "Loblolly Pine with Oak", Load = "Low", Value = "6.4"},
                new MachineItem() { Name = "Loblolly Pine with Oak", Load = "Moderate", Value = "6.8"},
                new MachineItem() { Name = "Loblolly Pine with Oak", Load = "Heavy", Value = "7.9"},

                new MachineItem() { Name = "Loblolly Pine Regeneration", Load = "Low", Value = "4.4"},
                new MachineItem() { Name = "Loblolly Pine Regeneration", Load = "Moderate", Value = "7.6"},
                new MachineItem() { Name = "Loblolly Pine Regeneration", Load = "Heavy", Value = "8.5"},

                new MachineItem() { Name = "Hardwood Leaf Litter", Load = "Low", Value = "0.8"},
                new MachineItem() { Name = "Hardwood Leaf Litter", Load = "Moderate", Value = "1.5"},
                new MachineItem() { Name = "Hardwood Leaf Litter", Load = "Heavy", Value = "2.5"},

                new MachineItem() { Name = "Grass or Brush", Load = "Low", Value = "2.0"},
                new MachineItem() { Name = "Grass or Brush", Load = "Moderate", Value = "3.0"},
                new MachineItem() { Name = "Grass or Brush", Load = "Heavy", Value = "5.0"},

                new MachineItem() { Name = "Dispersed Slash", Load = "Low", Value = "4.0"},
                new MachineItem() { Name = "Dispersed Slash", Load = "Moderate", Value = "6.0"},
                new MachineItem() { Name = "Dispersed Slash", Load = "Heavy", Value = "8.0"},

                new MachineItem() { Name = "Piled Debris", Load = "Low", Value = "5.0"},
                new MachineItem() { Name = "Piled Debris", Load = "Moderate", Value = "7.5"},
                new MachineItem() { Name = "Piled Debris", Load = "Heavy", Value = "10.0"},

                new MachineItem() { Name = "Shortleaf Loblolly with Grass", Load = "Low", Value = "1.5"},
                new MachineItem() { Name = "Shortleaf Loblolly with Grass", Load = "Moderate", Value = "3.8"},
                new MachineItem() { Name = "Shortleaf Loblolly with Grass", Load = "Heavy", Value = "5.9"}

            };
        }
    }


}
