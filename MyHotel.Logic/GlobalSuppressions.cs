using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = " But is has not a header.", Scope = "namespace", Target = "~N:MyHotel.Logic")]
[assembly: SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = " Did not implement this.", Scope = "member", Target = "~M:MyHotel.Logic.ExtraNumber.GetHashCode~System.Int32")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = " It has no header.")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = " I did not do this.", Scope = "member", Target = "~M:MyHotel.Logic.Managers.AddNewExtra(MyHotel.Models.Extra)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = " I did not do this.", Scope = "member", Target = "~M:MyHotel.Logic.Managers.AddNewPeople(MyHotel.Models.People)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = " I did not do this.", Scope = "member", Target = "~M:MyHotel.Logic.Managers.AddNewRoom(MyHotel.Models.Rooms)~System.Int32")]
[assembly: SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = " Do not know how to do it.", Scope = "member", Target = "~M:MyHotel.Logic.RoomNr.GetHashCode~System.Int32")]
[assembly: SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = " Did not do this, because I don't know how.", Scope = "member", Target = "~M:MyHotel.Logic.PriceResult.GetHashCode~System.Int32")]
[assembly: SuppressMessage("Maintainability", "CA9998:FxCopAnalyzers package has been deprecated", Justification = " FxCopAnalyzer.", Scope = "module")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending> ", Scope = "member", Target = "~F:MyHotel.Logic.Managers.extraRepo")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending> ", Scope = "member", Target = "~F:MyHotel.Logic.Managers.roomRepo")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending> ", Scope = "member", Target = "~F:MyHotel.Logic.Managers.peopleRepo")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending> ", Scope = "member", Target = "~F:MyHotel.Logic.Reception.peopleRepository")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending> ", Scope = "member", Target = "~F:MyHotel.Logic.Reception.roomRepository")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending> ", Scope = "member", Target = "~F:MyHotel.Logic.Reception.extraRepository")]
[assembly: SuppressMessage("", "CA1014", Justification = "<NikGitStats> ", Scope = "module")]
