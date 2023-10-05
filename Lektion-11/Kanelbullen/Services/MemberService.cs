﻿using Kanelbullen.Mvvm.Models;

namespace Kanelbullen.Services;

public class MemberService
{

    private List<MemberModel> _members;
    public event Action MembersUpdated;

    public MemberService()
    {
        _members = new List<MemberModel>();
    }

    public void AddMemberToList(MemberModel member)
    {
        _members.Add(member);
        MembersUpdated.Invoke();
    }

    public List<MemberModel> GetMembersFromList()
    {
        return _members;
    }
    /*
    public List<MemberModel> GetMembersFromList()
    {
        var member = _members.FirstOrDefault(x => )
    }
    */

}

