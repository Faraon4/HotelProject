// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "<Pending> removing header", Scope = "namespace", Target = "~N:MyHotel.Web.Models")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "<Pending> removing the header", Scope = "namespace", Target = "~N:MyHotel.Web.Controllers")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "<Pending> error in globalsupression.")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:Field names should not begin with underscore", Justification = "<Pending> want to change the name of variable", Scope = "member", Target = "~F:MyHotel.Web.Controllers.HomeController._logger")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "<Pending >", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsController.Index~Microsoft.AspNetCore.Mvc.ActionResult")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:Code analysis suppression should have justification", Justification = "<Pending> ")]
[assembly: SuppressMessage("", "CA1014", Justification ="<NikGitStats> ", Scope = "module")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending> ", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsApiController.AddOneRoom(MyHotel.Web.Models.Rooms)~MyHotel.Web.Controllers.ApiResult")]
[assembly: SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "<Pending> not simplifying", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsApiController.AddOneRoom(MyHotel.Web.Models.Rooms)~MyHotel.Web.Controllers.ApiResult")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "<Pending> make it non static", Scope = "type", Target = "~T:MyHotel.Web.Models.MapperFactory")]
[assembly: SuppressMessage("Design", "CA1002:Do not expose generic lists", Justification = "<Pending> expose generic list", Scope = "member", Target = "~P:MyHotel.Web.Models.RoomsListViewModel.ListOfRooms")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending>not read only ", Scope = "member", Target = "~P:MyHotel.Web.Models.RoomsListViewModel.ListOfRooms")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending> do not dispose", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsController.#ctor")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending> don't validate", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsController.Edit(MyHotel.Web.Models.Rooms,System.String)~Microsoft.AspNetCore.Mvc.ActionResult")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending>don't dispose", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsApiController.#ctor")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>don't validate", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsApiController.AddOneRoom(MyHotel.Web.Models.Rooms)~MyHotel.Web.Controllers.ApiResult")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending> don't validate", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RoomsApiController.ModOneRoom(MyHotel.Web.Models.Rooms)~MyHotel.Web.Controllers.ApiResult")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "<Pending> not static", Scope = "type", Target = "~T:MyHotel.Web.Program")]
[assembly: SuppressMessage("Performance", "CA1805:Do not initialize unnecessarily", Justification = "<Pending> initialize.", Scope = "member", Target = "~F:MyHotel.Web.Controllers.RandomController.countUnSELECTED")]
[assembly: SuppressMessage("Performance", "CA1805:Do not initialize unnecessarily", Justification = "<Pending> initialize", Scope = "member", Target = "~F:MyHotel.Web.Controllers.RandomController.countSelected")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending> do not dispose.", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RandomController.#ctor")]
[assembly: SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "<Pending> do it insecure.", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RandomController.GetOne~MyHotel.Web.Models.Rooms")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Pending> do not specify.", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RandomController.Select(System.Int32)~System.String")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Pending> do not specify", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RandomController.UnSelect(System.Int32)~System.String")]
[assembly: SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "<Pending>", Scope = "member", Target = "~M:MyHotel.Web.Controllers.RandomController.GetOne~Microsoft.AspNetCore.Mvc.JsonResult")]
