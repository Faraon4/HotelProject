// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "<Pending> ", Scope = "namespace", Target = "~N:MyHotel.WpfClient")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "<Pending> ")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1115:Parameter should follow comma", Justification = "<Pending> ")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<Pending> not correct order", Scope = "member", Target = "~M:MyHotel.WpfClient.MainVM.#ctor")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "<Pending> not correct order.", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.ApiGetRooms~System.Collections.Generic.List{MyHotel.WpfClient.RoomVM}")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "<Pending> not correct order.", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.EditRoom(MyHotel.WpfClient.RoomVM,System.Func{MyHotel.WpfClient.RoomVM,System.Boolean})")]
[assembly: SuppressMessage("", "CA1014", Justification = "<NikGitStats> ", Scope = "module")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<Pending>not correct order", Scope = "member", Target = "~M:MyHotel.WpfClient.MainVM.#ctor(MyHotel.WpfClient.IMainLogic)")]
[assembly: SuppressMessage("Design", "CA1002:Do not expose generic lists", Justification = "<Pending> not generic list", Scope = "member", Target = "~M:MyHotel.WpfClient.IMainLogic.ApiGetRooms~System.Collections.Generic.List{MyHotel.WpfClient.RoomVM}")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "<Pending> they are not", Scope = "type", Target = "~T:MyHotel.WpfClient.MainLogic")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending> don't make it static", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.SendMessage(System.Boolean)")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> use string", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.ApiGetRooms~System.Collections.Generic.List{MyHotel.WpfClient.RoomVM}")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> use tring", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.ApiDelRoom(MyHotel.WpfClient.RoomVM)")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Pending> don't specify", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.ApiEditRoom(MyHotel.WpfClient.RoomVM,System.Boolean)~System.Boolean")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> use string", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.ApiEditRoom(MyHotel.WpfClient.RoomVM,System.Boolean)~System.Boolean")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending> we do not do this", Scope = "member", Target = "~M:MyHotel.WpfClient.MainLogic.ApiEditRoom(MyHotel.WpfClient.RoomVM,System.Boolean)~System.Boolean")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending> they are not read only", Scope = "member", Target = "~P:MyHotel.WpfClient.MainVM.AllRooms")]
