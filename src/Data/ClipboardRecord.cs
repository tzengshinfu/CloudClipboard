using System;

namespace CloudClipboard.Data {
    public class ClipboardRecord {
        public Guid RowID { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string TextContent { get; set; }
    }
}
