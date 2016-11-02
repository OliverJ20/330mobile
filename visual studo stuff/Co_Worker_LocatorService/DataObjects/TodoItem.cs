using Microsoft.Azure.Mobile.Server;

namespace Co_Worker_LocatorService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}