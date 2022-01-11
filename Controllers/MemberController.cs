using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiExample.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        MemberRepository repository = new MemberRepository();
        [HttpGet]
        public IEnumerable<Member> GetAllMembers()
        {
            return repository.GetAll();
        }
        [HttpGet("{id}")]
        public Member GetMembersById(int id)
        {
           return repository.Get(id);
        }
        [HttpPost]
        public List<Member> PostMember(Member item)
        {
            repository.Add(item);
            return repository.GetAll();
            
        }
        [HttpPut("{id}")]
        public void PutMember(int id,int age,string name,string lastName,Member member)
        {
            member.Id = Convert.ToInt32(id);
            member.Name = name;
            member.LastName = lastName;
            member.Age = Convert.ToInt32(age);
            repository.Update(member);
               
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            Member item = repository.Get(id);
             repository.Remove(id);
        }

    }
}
