
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;


namespace Mozu.Api.Contracts.Content
{
		public class DocumentListType
		{
			public string DocumentListTypeFQN { get; set; }

			public List<string> DocumentTypeFQNs { get; set; }

			public bool? EnablePublishing { get; set; }

			public string InstallationPackage { get; set; }

			public string LocalizationType { get; set; }

			public string Name { get; set; }

			public string Namespace { get; set; }

			public string ScopeType { get; set; }

			public string Security { get; set; }

			public bool SupportsPublishing { get; set; }

			public List<string> Usages { get; set; }

			public string Version { get; set; }

			public List<DocumentInstallation> DefaultDocuments { get; set; }

			public JObject Metadata { get; set; }

			public List<View> Views { get; set; }

		}

}