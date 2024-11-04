using System.Threading.Tasks;
using TabTabGo.WebStream.Model;
using TabTabGo.WebStream.Services.Contract;

namespace TabTabGo.WebStream.Services.PushEventsServices
{
    public class RedirectReciveEvent(IPushEvent pushEvent) : IReceiveEvent
    {
        public async Task OnEventReceived(UserIdData userId, WebStreamMessage message)
        {
            await pushEvent.PushToUserAsync(userId, message);
        }
    }
}
