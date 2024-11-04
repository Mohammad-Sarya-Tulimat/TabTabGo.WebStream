using TabTabGo.WebStream.Model;

namespace TabTabGo.WebStream.AMQP.Model
{
    public class QueueMessage
    { 
        public IEnumerable<UserIdData>? UserIdData { get; set; }
        public WebStreamMessage WebStreamMessage { get; set; }
    }
}
