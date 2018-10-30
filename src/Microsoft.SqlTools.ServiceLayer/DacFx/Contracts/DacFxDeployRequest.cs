﻿using Microsoft.SqlTools.Hosting.Protocol.Contracts;
using Microsoft.SqlTools.ServiceLayer.Utility;

namespace Microsoft.SqlTools.ServiceLayer.DacFx.Contracts
{
    /// <summary>
    /// Parameters for a DacFx deploy request.
    /// </summary>
    public class DacFxDeployParams
    {
        /// <summary>
        /// Gets or sets connection string of the target database the deploy operation will run against.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets dacpac package filepath
        /// </summary>
        public string PackageFilePath { get; set; }

        /// <summary>
        /// Gets or sets name for deployed database
        /// </summary>
        public string TargetDatabaseName { get; set; }
    }

    /// <summary>
    /// Parameters returned from a DacFx deploy request.
    /// </summary>
    public class DacFxDeployResult : ResultStatus
    {
        public string OperationId { get; set; }
    }

    /// <summary>
    /// Defines the DacFx deploy request type
    /// </summary>
    class DacFxDeployRequest
    {
        public static readonly RequestType<DacFxDeployParams, DacFxDeployResult> Type =
            RequestType<DacFxDeployParams, DacFxDeployResult>.Create("dacfx/deploy");
    }
}
