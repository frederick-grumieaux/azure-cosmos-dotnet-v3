﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace CosmosBenchmark
{
    using Microsoft.Azure.Cosmos;

    internal class QueryStreamCrossPkWithPaginationV3BenchmarkOperation : QueryTV3BenchmarkOperation
    {
        public QueryStreamCrossPkWithPaginationV3BenchmarkOperation(
            CosmosClient cosmosClient,
            string dbName,
            string containerName,
            string partitionKeyPath,
            string sampleJson) : base(cosmosClient, dbName, containerName, partitionKeyPath, sampleJson)
        {
        }

        public override QueryDefinition QueryDefinition => new QueryDefinition("select * from T where T.id = @id")
                                                .WithParameter("@id", this.executionItemId);

        public override QueryRequestOptions QueryRequestOptions => new QueryRequestOptions()
        {
            MaxItemCount = 1
        };

        public override bool IsCrossPartitioned => true;

        public override bool IsPaginationEnabled => true;

        public override bool IsQueryStream => true;
    }
}
