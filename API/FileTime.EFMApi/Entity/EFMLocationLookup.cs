using System.Collections.Generic;

namespace FileTime.EFMApi.Entity
{
	public class EFMShortLocationLookup
	{
		public string Code { get; set; }
		public string Name { get; set; }
	}

	public class EFMLocationLookup
	{
		public string Code { get; set; }
		public string Name { get; set; }
		//public LocationType FilingType { get; set; }
		public bool AllowInitial { get; set; }
		public bool AllowSubsequent { get; set; }
		public bool AllowMultipleAttorneys { get; set; }
		public string OdysseyNodeId { get; set; }
		public string CMSId { get; set; }
		public IList<EFMSupportedCaseType> SupportedCaseType { get; set; }
		public bool AllowNonIndexCase { get; set; }
		public IList<EFMLocationUrl> LookupURL { get; set; }
		public IList<EFMCaseTypeLookup> CaseTypeLookups { get; set; }
		public string AllowableCardTypes { get; set; }
		public bool SendServiceBeforeReview { get; set; }
		public string ParentNodeID { get; set; }
		public bool IsCounty { get; set; }
		public bool RestrictBankAccountPayment { get; set; }
		public bool SendServiceContactRemovedNotfications { get; set; }
		public bool AllowMaxFeeAmount { get; set; }
		public bool SkipPreAuth { get; set; }
		public bool AllowHearing { get; set; }
		public bool AllowReturnDate { get; set; }
		public bool ShowDamageAmount { get; set; }
		public bool HasConditionalServiceTypes { get; set; }
		public bool HasProtectedCaseTypes { get; set; }
		public string ProtectedCaseTypes { get; set; }
		public bool IsActive { get; set; }
	}

	public class EFMSupportedCaseType
	{
		public long Id { get; set; }

		public string Type { get; set; }

		public EFMLocationLookup Location { get; set; }
	}

	public class EFMLocationUrl
	{
		public long Id { get; set; }
		public string LocationCode { get; set; }
		public string code { get; set; }
		public string Name { get; set; }

	}

	public class EFMCodeVersionLookup
	{
		public long Id { get; set; }
		public string LocationCode { get; set; }
		public string CodeList { get; set; }
		public string PrevVersion { get; set; }
		public string Version { get; set; }
		public string EFMCodeUrl { get; set; }
		public System.DateTime? UpdatedDate { get; set; }
		public System.DateTime? DataUpdatedDate { get; set; }
	}


}