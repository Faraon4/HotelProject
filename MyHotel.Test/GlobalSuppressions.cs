using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = " Don't need a header.", Scope = "namespace", Target = "~N:MyHotel.Test")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = " It is not so importat  ,if it contains or no", Scope = "type", Target = "~T:MyHotel.Test.CRUD_Test")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name should match first type name", Justification = "It is not so importat , if it contains or no ", Scope = "type", Target = "~T:MyHotel.Test.CRUD_Test")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = " Did not really specify", Scope = "member", Target = "~M:MyHotel.Test.CRUD_Test.TestGetOnePeople")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = " Didnot really specify", Scope = "member", Target = "~M:MyHotel.Test.CRUD_Test.TestPeopleAdd")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "It is not so importat ")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = " It is not so importat, if contains or no", Scope = "type", Target = "~T:MyHotel.Test.NON_CRUD_Test")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name should match first type name", Justification = " It is not so importat , if it contains or no", Scope = "type", Target = "~T:MyHotel.Test.NON_CRUD_Test")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "Didnot really specify", Scope = "member", Target = "~M:MyHotel.Test.NON_CRUD_Test.CreateLogicWithMocks~MyHotel.Logic.Reception")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = " I did not use", Scope = "member", Target = "~M:MyHotel.Test.NON_CRUD_Test.TestTotalPrice")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = " I did not use", Scope = "member", Target = "~M:MyHotel.Test.NON_CRUD_Test.RoomNr")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = " I did not use", Scope = "member", Target = "~M:MyHotel.Test.NON_CRUD_Test.PeopleExtra")]
[assembly: SuppressMessage("Maintainability", "CA9998:FxCopAnalyzers package has been deprecated", Justification = " After Update.", Scope = "module")]
[assembly: SuppressMessage("", "CA1014", Justification = "<NikGitStats> ", Scope = "module")]