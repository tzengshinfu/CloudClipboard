using LiteDB;
using System;
using System.ComponentModel.DataAnnotations;

namespace CloudClipboard.Data {
    public class Clipboard {
        /// <summary>"Filename=Data/Clipboard.db;Connection=shared"</summary>
        public static readonly string DBPath = @"Filename=Data/Clipboard.db;Connection=shared";
        /// <summary>"Clipboard"</summary>
        public static readonly string TableName = "Clipboard";
        [BsonId(false)]
        public Guid RowID { get; set; }
        [Required]
        public string AccountID { get; set; }
        [Required]
        public string VerificationCode { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
        [Required]
        public string TextContent { get; set; }
    }
}
