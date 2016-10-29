using System;
using System.Collections.Generic;
using System.Linq;
using Library.Models;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }

        public void Add(Member Member)
        {
            _context.Members.Add(Member);
            _context.SaveChanges();
        }

        public void Remove(Member Member)
        {
            _context.Members.Remove(Member);
            _context.SaveChanges();
        }

        public void Edit(Member member)
        {
            Member orginalMember = Find(member.MemId);
            orginalMember.PersId = member.PersId;
            orginalMember.MemId = member.MemId;
            orginalMember.Loans = member.Loans;
            _context.SaveChanges();
        }

        public Member Find(int id)
        {
            Member member = _context.Members.Find(id);
            return member;
        }
    }
}