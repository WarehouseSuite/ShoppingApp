using Microsoft.AspNetCore.Components;
using Shop.Infrastructure.Http;
using Shop.Shared;
using ShopApplication.Common;

namespace ShopWeb.Shared;

public abstract class PageComponentOld : ComponentBase
{
    [Inject] protected IHttpService Http { get; init; } = default!;
    [Parameter] public Action<bool, string?> ToggleLoadingAction { get; set; } = default!;
    [Parameter] public EventCallback<PushAlertArgs> PushAlertCallback { get; init; } = default!;
    [Parameter] public EventCallback<NavigateToArgs> NavigateToCallback { get; init; } = default!;
    
    protected void StartLoading( string? loadingMessage = null )
    {
        ToggleLoadingAction.Invoke( true, loadingMessage );
    }
    protected void StopLoading()
    {
        ToggleLoadingAction.Invoke( false, null );
    }
    protected async Task CallPushAlert( AlertType type, string message )
    {
        await PushAlertCallback.InvokeAsync( PushAlertArgs.With( type, message ) );
    }
    protected async Task CallNavigateTo( string url, bool forceReload )
    {
        await NavigateToCallback.InvokeAsync( NavigateToArgs.With( url, forceReload ) );
    }
}