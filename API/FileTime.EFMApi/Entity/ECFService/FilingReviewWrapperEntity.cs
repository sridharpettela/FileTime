using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
	public class GetSCSMTPLogRequestEntity : BaseWrapperEntity
	{
		public string FilingEFMID { get; set; }
		public string LocationCode { get; set; }
		public string ServiceContactEMFId { get; set; }
	}

	public class GetFilingListRequestEntity : BaseWrapperEntity
	{
		public string LocationCode { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
	}

	public class GetFilingListResponseEntity //: BaseTotalRowModel
	{
		public IList<EFMFilingEntity> EFMFilings { get; set; }
	}

	public class EFMFilingEntity
	{
		public long Id { get; set; }
		public string FiletimeFilingId { get; set; }
		public string SubmissionId { get; set; }
		public string OrginialSubmissionId { get; set; }
		public DateTime? FiledDocumentedDate { get; set; }
		public DateTime? SubmittedDate { get; set; }
		public string CaseTitle { get; set; }
		public string CaseDocketId { get; set; }
		public string FilingAttorney { get; set; }
		public string CaseTrackingId { get; set; }
		public string Location { get; set; }
		public string EFMDocumentedId { get; set; }
		public string EnvelopeId { get; set; }
		public string FilingDescription { get; set; }
		public string FilingCodeDescription { get; set; }
		public string FilingType { get; set; }
		public string FilerName { get; set; }
		public string DocumentSubmitterId { get; set; }
		public string FilingStatusDesc { get; set; }
		public string FilingStatusCode { get; set; }
		public bool IsArchived { get; set; }
		public string ReferenceNumber { get; set; }
	}
}
