using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Mvvm.Views;
using Kanelbullen.Services;

namespace Kanelbullen.Mvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{

    private readonly MemberService _memberService;

    public MainViewModel(MemberService memberService)
    {
        _memberService = memberService;
        Members = new ObservableCollection<MemberModel>();
        _memberService.MembersUpdated += GetMembers;
    }

    private void GetMembers()
    {
        Members.Clear();
        foreach (var member in _memberService.GetMembersFromList())
        {
            Members.Add(member);
        }
    }


    [ObservableProperty]
    private ObservableCollection<MemberModel> members;


    [RelayCommand]
    public async Task GoToDetail(MemberModel member)
    {
        /*
        var viewModel = new DetailViewModel(member.Id);
        var detailPage = new DetailPage(viewModel);
        await Shell.Current.Navigation.PushAsync(detailPage);

        //await Shell.Current.GoToAsync($"{nameof(DetailPage)}?memberId={member.Id}");
        */
        await Shell.Current.GoToAsync(nameof(DetailPage));
    }

    [RelayCommand]
    public async Task GoToEdit()
    {
        await Shell.Current.GoToAsync(nameof(EditPage));
    }


}

