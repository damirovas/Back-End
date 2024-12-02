using SchoolApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SchoolApp
{
    public class Couse
    {
        private static int _id;
        public int Id { get; set;}
        public string Name { get; set;}
        public List<Group> Groups { get; set;}=new List<Group>();
        public Couse(string name)
        {
            Id =++_id;
            Name = name;
        }
        public void GetGroup()
        {
            foreach(Group group in Groups)
            {
                Console.WriteLine($"{group.Id} {group.Name}");
            }
        }

        //public Group GetGroupById(int groupid)
        //{
        //    return Groups.FirstOrDefault(g=>g.Id==groupid);
        //}
       
        public Group GetGroupById(int id)
        {
            Group group = Groups.FirstOrDefault(g => g.Id == id);
            if (group == null)
            {
                Console.WriteLine("Grup bulunamadı.");
            }
            return group;
        }
        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }

        public override string ToString()
        {
            return $" {Id} {Name}";
        }
    }
}
