// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System.Diagnostics;
using System.CodeDom.Compiler;

namespace T4MVC
{
    public class SharedController
    {

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _Layout = "_Layout";
                public readonly string _LoginPartial = "_LoginPartial";
                public readonly string _NavBar = "_NavBar";
                public readonly string _SiteInfo = "_SiteInfo";
                public readonly string Error = "Error";
            }
            public readonly string _Layout = "~/Views/Shared/_Layout.cshtml";
            public readonly string _LoginPartial = "~/Views/Shared/_LoginPartial.cshtml";
            public readonly string _NavBar = "~/Views/Shared/_NavBar.cshtml";
            public readonly string _SiteInfo = "~/Views/Shared/_SiteInfo.cshtml";
            public readonly string Error = "~/Views/Shared/Error.cshtml";
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591
