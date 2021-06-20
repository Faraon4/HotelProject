// <copyright file="GlobalSuppressions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1115:Parameter should follow comma", Justification = "<Pending> It does not follow comma")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> don't pass", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.GetOneRoom~MyHotel.NewWPF.RoomVM")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Pending> do not specify.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.SelectionRoom(MyHotel.NewWPF.RoomVM,System.Int32)~System.Boolean")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> do not pass.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.SelectionRoom(MyHotel.NewWPF.RoomVM,System.Int32)~System.Boolean")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending> do not dispose.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.SelectionRoom(MyHotel.NewWPF.RoomVM,System.Int32)~System.Boolean")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>do not make static.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.SendMessage(System.Boolean)")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "<Pending> it is not disposal.", Scope = "type", Target = "~T:MyHotel.NewWPF.MainLogic")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending> it is not readonly.", Scope = "member", Target = "~P:MyHotel.NewWPF.MainVM.GeneratedRooms")]
[assembly: SuppressMessage("", "CA1014", Justification = "<NikGitStats> ", Scope = "module")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element should begin with upper-case letter", Justification = "<Pending> not upper case.", Scope = "member", Target = "~P:MyHotel.NewWPF.SecondWindow.svm")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<Pending> not correct order.", Scope = "member", Target = "~M:MyHotel.NewWPF.SecondWindow.#ctor(MyHotel.NewWPF.MainVM)")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> pass string.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.SelectLogic(System.Int32)")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> pass string.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.UnselectLogic(System.Int32)")]
[assembly: SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "<Pending> pass string", Scope = "member", Target = "~M:MyHotel.NewWPF.MainLogic.DeleteRoom(System.Int32)")]
[assembly: SuppressMessage("Style", "IDE0090:Use 'new(...)'", Justification = "<Pending>don use like this.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainVM.#ctor")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending>Don't call", Scope = "member", Target = "~M:MyHotel.NewWPF.MainVM.#ctor")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<Pending>it follows.", Scope = "member", Target = "~F:MyHotel.NewWPF.MainVM.count")]
[assembly: SuppressMessage("Security", "CA2109:Review visible event handlers", Justification = "<Pending> don't review", Scope = "member", Target = "~M:MyHotel.NewWPF.MainVM.Helper(System.Object,System.EventArgs)")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<Pending> Is follows.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainVM.#ctor")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending>it is not read-only.", Scope = "member", Target = "~P:MyHotel.NewWPF.MainVM.RandomRooms")]
[assembly: SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "<Pending>use insecure", Scope = "member", Target = "~M:MyHotel.NewWPF.MainWindow.Switch(System.Object,System.EventArgs)")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<Pending> It is not in correct order.", Scope = "member", Target = "~M:MyHotel.NewWPF.MainVM.#ctor(MyHotel.NewWPF.IMainLogic)")]
