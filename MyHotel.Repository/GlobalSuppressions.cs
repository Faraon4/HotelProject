using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = " I did not do it", Scope = "type", Target = "~T:MyHotel.Repository.ExtraRepException")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = " It does not have a header", Scope = "namespace", Target = "~N:MyHotel.Repository")]
[assembly: SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = " I did not implement", Scope = "type", Target = "~T:MyHotel.Repository.PeopleRepException")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = " It does not have a header.")]
[assembly: SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = " I did not implement it", Scope = "type", Target = "~T:MyHotel.Repository.RoomRepException")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = " But it is not", Scope = "member", Target = "~F:MyHotel.Repository.RepositoryClass`1.ctx")]
[assembly: SuppressMessage("Maintainability", "CA9998:FxCopAnalyzers package has been deprecated", Justification = " FxCopAnalyzer", Scope = "module")]
[assembly: SuppressMessage("Design", "CA1012:Abstract types should not have public constructors", Justification = " but it has.", Scope = "type", Target = "~T:MyHotel.Repository.RepositoryClass`1")]
[assembly: SuppressMessage("", "CA1014", Justification = "<NikGitStats> ", Scope = "module")]