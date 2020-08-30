namespace FileTime.EFMApi.Entity
{
    public class EFMCaseCategoryLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string LocationCode { get; set; }
        public string Name { get; set; }
        public string ECFCaseType { get; set; }
        public string ProcedureRemedyInitial { get; set; }
        public string ProcedureRemedySubsequent { get; set; }
        public string DamageAmountInitial { get; set; }
        public string DamageAmountSubsequent { get; set; }
        public string EFSPCode { get; set; }
    }

    public class EFMCFilerTypeLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool DefaultValue { get; set; }
        public string EFSPCode { get; set; }
    }

    public class EFMProcedureRemedyLookup
    {
        public long Id { get; set; }
        public EFMCaseCategoryLookup Category { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Initial { get; set; }
        public string Subsequent { get; set; }
        public string EFSPCode { get; set; }

    }

    public class EFMDamageAmountLookup
    {
        public long Id { get; set; }
        public string CategoryCode { get; set; }
        public EFMCaseCategoryLookup Category { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Initial { get; set; }
        public string Subsequent { get; set; }
        public string EFSPCode { get; set; }
    }

    public class EFMArrestLocationLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EFMBondCodeLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EFMDegreeCodeLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EFMLawEnforcementUnitCodeLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EFMStatuteCodeLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EFMGeneralOffenseCodeLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

}