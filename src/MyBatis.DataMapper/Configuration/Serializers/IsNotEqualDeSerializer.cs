#region Apache Notice
/*****************************************************************************
 * $Header: $
 * $Revision: 408164 $
 * $Date: 2008-06-28 09:26:16 -0600 (Sat, 28 Jun 2008) $
 * 
 * iBATIS.NET Data Mapper
 * Copyright (C) 2008/2005 - The Apache Software Foundation
 *  
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 ********************************************************************************/
#endregion

#region Using

using System.Collections.Specialized;
using System.Xml;
using MyBatis.DataMapper.Model.Sql.Dynamic.Elements;
using MyBatis.DataMapper.Scope;
using MyBatis.DataMapper.DataExchange;
using MyBatis.Common.Configuration;
using MyBatis.Common.Utilities.Objects.Members;

#endregion 


namespace MyBatis.DataMapper.Configuration.Serializers
{
	/// <summary>
	/// Summary description for IsNotEqualDeSerializer.
	/// </summary>
    public sealed class IsNotEqualDeSerializer : BaseDynamicDeSerializer
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="IsNotEqualDeSerializer"/> class.
        /// </summary>
        /// <param name="accessorFactory">The accessor factory.</param>
        public IsNotEqualDeSerializer(AccessorFactory accessorFactory)
            : base(accessorFactory)
        { }

        #region IDeSerializer Members

        /// <summary>
        /// Deserializes the specified configuration in an <see cref="IsNotEqual"/> object
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        public override SqlTag Deserialize(IConfiguration configuration)
		{
            IsNotEqual isNotEqual = new IsNotEqual(accessorFactory);

			isNotEqual.Prepend = ConfigurationUtils.GetStringAttribute(configuration.Attributes, "prepend");
			isNotEqual.Property = ConfigurationUtils.GetStringAttribute(configuration.Attributes, "property");
            isNotEqual.CompareProperty = ConfigurationUtils.GetStringAttribute(configuration.Attributes, "compareProperty");
			isNotEqual.CompareValue = ConfigurationUtils.GetStringAttribute(configuration.Attributes, "compareValue");
            isNotEqual.BindName = ConfigurationUtils.GetStringAttribute(configuration.Attributes, "bindName");

			return isNotEqual;
		}

		#endregion
	}
}
