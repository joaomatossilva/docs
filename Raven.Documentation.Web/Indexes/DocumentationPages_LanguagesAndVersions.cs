﻿using System.Linq;
using Raven.Client.Indexes;
using Raven.Documentation.Parser.Data;

namespace Raven.Documentation.Web.Indexes
{
	public class DocumentationPages_LanguagesAndVersions : AbstractIndexCreationTask<DocumentationPage, DocumentationPages_LanguagesAndVersions.DocumentationLanguageAndVersion>
	{
		public class DocumentationLanguageAndVersion
		{
            public string Language { get; set; }

            public string Version { get; set; }
		}

		public DocumentationPages_LanguagesAndVersions()
		{
			Map =
				pages =>
				from page in pages
                select new DocumentationLanguageAndVersion()
				{
                    Language = page.Language.ToString(),
                    Version = page.Version
				};

            Store("Language", Raven.Abstractions.Indexing.FieldStorage.Yes);
		}
	}
}
