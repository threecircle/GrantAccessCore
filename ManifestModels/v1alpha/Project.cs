using System;
using GrantAccessCore.Models;

namespace GrantAccessCore.ManifestModels.v1alpha
{
	public class ProjectManifest
	{
		public string ApiVersion { get; set; }
		public string Kind { get; set; }

		public Project Definition { get; set; }

	}
}

