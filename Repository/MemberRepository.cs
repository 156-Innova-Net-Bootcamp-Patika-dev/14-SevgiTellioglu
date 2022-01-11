using ApiExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample
{
    public class MemberRepository

    {
        static List<Member> members = new List<Member>
        {
            new Member{Id=1, Name="Ali", LastName="Yılmaz", Age=15 },
            new Member{Id=2, Name="Veli", LastName="Şahin", Age=20},
            new Member{Id=3, Name="Ahmet", LastName="Yılmaz", Age=25},
            new Member{Id=4, Name="Ayşe", LastName="Şahin", Age=30},
            new Member{Id=5, Name="Fatma", LastName="Yılmaz", Age=35},
            new Member{Id=6, Name="Aslı", LastName="Şahin", Age=40},
        };
        public List<Member> GetAll()
        {
            return members;
        }

        public Member Get(int id)
        {
            return members.Find(p => p.Id == id);
        }

        public void Add(Member item)
        {
            members.Add(item);
        }

        public void Remove(int id)
        {
            members.RemoveAll(p => p.Id == id);
        }

        public bool Update(Member item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = members.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            members.RemoveAt(index);
            members.Add(item);
            return true;
        }
    }
}

