// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Facility.Core.Http;

namespace Facility.GeneratorApi.Http
{
	/// <summary>
	/// Generates code from Facility Service Definitions.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class FacilityGeneratorApiHttpHandler : ServiceHttpHandler
	{
		/// <summary>
		/// Creates the handler.
		/// </summary>
		public FacilityGeneratorApiHttpHandler(IFacilityGeneratorApi service, ServiceHttpHandlerSettings settings)
			: base(settings)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			m_service = service;
		}

		/// <summary>
		/// Attempts to handle the HTTP request.
		/// </summary>
		public override async Task<HttpResponseMessage> TryHandleHttpRequestAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken)
		{
			return await AdaptTask(TryHandleGenerateAsync(httpRequest, cancellationToken)).ConfigureAwait(true);
		}

		/// <summary>
		/// Generates code from a service definition.
		/// </summary>
		public Task<HttpResponseMessage> TryHandleGenerateAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken)
		{
			return TryHandleServiceMethodAsync(FacilityGeneratorApiHttpMapping.GenerateMapping, httpRequest, m_service.GenerateAsync, cancellationToken);
		}

		readonly IFacilityGeneratorApi m_service;
	}
}