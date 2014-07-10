﻿using NUnit.Framework;
using Nest.Tests.MockData.Domain;

namespace Nest.Tests.Integration.Core.Map.TimestampField
{
	[TestFixture]
	public class TimestampFieldTests : BaseMappingTests
	{
		[Test]
		public void TimestampFieldUsingExpression()
		{
			var result = this._client.Map<ElasticsearchProject>(m => m
				.TimestampField(a => a
					.SetPath(p => p.Name)
					.SetDisabled()
				)
			);
			this.DefaultResponseAssertations(result);
		}
		[Test]
		public void TimestampFieldUsingString()
		{
			var result = this._client.Map<ElasticsearchProject>(m => m
				.TimestampField(a => a
					.SetPath("my_difficult_field_name")
					.SetDisabled(false)
				)
			);
			this.DefaultResponseAssertations(result);
		}
	}
}
