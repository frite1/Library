using System;
using System.Collections.Generic;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class MemberService : IService
    {
        MemberRepository _memberRepository;

        public event EventHandler Updated;
        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }

        public void AddMember(string name, int persId)
        {
            Member member = new Member();
            member.Name = name;
            member.PersId = persId;
            _memberRepository.Add(member);
        }
    }
}