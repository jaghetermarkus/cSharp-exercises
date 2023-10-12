using CommunityToolkit.Mvvm.ComponentModel;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Services;

namespace Kanelbullen.Mvvm.ViewModels;

public partial class DetailViewModel : ObservableObject
{
    //[ObservableProperty]
    private Guid _memberId;
    private readonly MemberService _memberService;

    [ObservableProperty]
    private MemberModel member;

    public DetailViewModel(Guid memberId, MemberService memberService)
    {
        _memberId = memberId;
        _memberService = memberService;

        var _member = _memberService.GetMembersFromList(memberId);
    }
}

