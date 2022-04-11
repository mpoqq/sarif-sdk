﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif.WorkItems {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WorkItemsResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WorkItemsResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.WorkItems.WorkItemsResources", typeof(WorkItemsResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;br&gt;&lt;br&gt;For another viewing option, load the attached SARIF log file in: &lt;br&gt;
        ///&lt;li&gt;The &lt;a href=&quot;https://marketplace.visualstudio.com/items?itemName=WDGIS.MicrosoftSarifViewer&quot;&gt;Visual Studio SARIF add-in&lt;/a&gt;.&lt;/li&gt;
        ///&lt;li&gt;The &lt;a href=&quot;https://marketplace.visualstudio.com/items?itemName=WDGIS.MicrosoftSarifViewer2022&quot;&gt;Visual Studio 2022 SARIF add-in&lt;/a&gt;.&lt;/li&gt;
        ///&lt;li&gt;The &lt;a href=&quot;https://marketplace.visualstudio.com/items?itemName=MS-SarifVSCode.sarif-viewer&quot;&gt;VS Code SARIF extension&lt;/a&gt;.&lt;/li&gt;
        ///&lt;li&gt;The browser-hoste [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AzureDevOpsDefaultDescriptionFooter {
            get {
                return ResourceManager.GetString("AzureDevOpsDefaultDescriptionFooter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to **For another viewing option, load the referenced SARIF log file in:**
        ///- The [Visual Studio SARIF add-in](https://marketplace.visualstudio.com/_apis/public/gallery/publishers/WDGIS/vsextensions/MicrosoftSarifViewer/2.1.7/vspackage)
        ///- The [VS Code SARIF extension](https://marketplace.visualstudio.com/items?itemName=MS-SarifVSCode.sarif-viewer)
        ///- The browser-hosted [SARIF web control](&quot;https://microsoft.github.io/sarif-web-component/).
        /// </summary>
        internal static string GitHubDefaultDescriptionFooter {
            get {
                return ResourceManager.GetString("GitHubDefaultDescriptionFooter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;a href=&quot;{1}&quot;&gt;{0}&lt;/a&gt;.
        /// </summary>
        internal static string HtmlLinkTemplate {
            get {
                return ResourceManager.GetString("HtmlLinkTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inconsistent URIs were provided in &apos;filingContext&apos; and &apos;filingUri&apos; arguments..
        /// </summary>
        internal static string InconsistentHostUrisProvided {
            get {
                return ResourceManager.GetString("InconsistentHostUrisProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{0}]({1}).
        /// </summary>
        internal static string MarkdownLinkTemplate {
            get {
                return ResourceManager.GetString("MarkdownLinkTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  (and other locations).
        /// </summary>
        internal static string MultipleToolsFooter {
            get {
                return ResourceManager.GetString("MultipleToolsFooter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This work item contains {0} {1} issue(s) detected in {2}{3}. Click the &apos;Scans&apos; tab to review results..
        /// </summary>
        internal static string WorkItemBodyTemplateText {
            get {
                return ResourceManager.GetString("WorkItemBodyTemplateText", resourceCulture);
            }
        }
    }
}
