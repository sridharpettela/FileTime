using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.Redaction
{
    public class TylerRedactionDocument
    {
        public string DocumentNumber { get; set; }
        public string DocumentType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Stream Data { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Stream RedactedData { get; set; }
        public bool PDFAOutputRequested { get; set; }
        public List<DateTime> MinorDOB { get; set; }
        public bool IsDocumentPDFA { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ApplyRedactionsWarnings { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TylerRedactionEntity> Redactions { get; set; }
        public List<TylerRedactionPersonName> Minor { get; set; }
        public List<TylerRedactionPersonAddress> MinorAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OcrData { get; set; }
    }
}
