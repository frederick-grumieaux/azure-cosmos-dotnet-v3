﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.Query.Core.ClientDistributionPlan.Cql
{
    using System;
    using System.Collections.Generic;

    internal class CqlDistinctEnumerableExpression : CqlEnumerableExpression
    {
        public CqlDistinctEnumerableExpression(CqlEnumerableExpression sourceExpression, CqlVariable declaredVariable, IReadOnlyList<CqlScalarExpression> expression) 
            : base(CqlEnumerableExpressionKind.Distinct)
        {
            this.SourceExpression = sourceExpression ?? throw new ArgumentNullException(nameof(sourceExpression));
            this.DeclaredVariable = declaredVariable ?? throw new ArgumentNullException(nameof(declaredVariable));
            this.Expression = expression ?? throw new ArgumentNullException(nameof(expression));
        }

        public CqlEnumerableExpression SourceExpression { get; }

        public CqlVariable DeclaredVariable { get; }
        
        public IReadOnlyList<CqlScalarExpression> Expression { get; }
    }
}