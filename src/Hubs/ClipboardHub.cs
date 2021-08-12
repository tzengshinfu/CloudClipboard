using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using CloudClipboard.Data;

namespace CloudClipboard.Hubs {
    public class ClipboardHub : Hub {
        /// <summary>"SendRecord"</summary>
        public static readonly string SendMethodName = "SendRecord";
        /// <summary>"ReceiveRecord"</summary>
        public static readonly string ReceiveMethodName = "ReceiveRecord";
        /// <summary>"/clipboardhub"</summary>
        public static readonly string HubPath = "/clipboardhub";
        public async Task SendRecord(List<ClipboardRecord> recordList) {
            await Clients.All.SendAsync(ReceiveMethodName, recordList);
        }
    }
}
