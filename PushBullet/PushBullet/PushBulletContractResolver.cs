﻿/*
 *	 PushBullet Package for Constellation
 *	 Web site: http://www.myConstellation.io
 *	 Copyright (C) 2014-2016 - Sebastien Warin <http://sebastien.warin.fr>	   	  
 *	
 *	 Licensed to Constellation under one or more contributor
 *	 license agreements. Constellation licenses this file to you under
 *	 the Apache License, Version 2.0 (the "License"); you may
 *	 not use this file except in compliance with the License.
 *	 You may obtain a copy of the License at
 *	
 *	 http://www.apache.org/licenses/LICENSE-2.0
 *	
 *	 Unless required by applicable law or agreed to in writing,
 *	 software distributed under the License is distributed on an
 *	 "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 *	 KIND, either express or implied. See the License for the
 *	 specific language governing permissions and limitations
 *	 under the License.
 */

namespace PushBullet
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Used by Newtonsoft.Json.JsonSerializer to resolves a Newtonsoft.Json.Serialization.JsonContract for a given System.Type.
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.Serialization.DefaultContractResolver" />
    public class PushBulletContractResolver : DefaultContractResolver
    {
        /// <summary>
        /// Gets the JsonSerializerSettings that use the PushBulletContractResolver.
        /// </summary>
        /// <value>
        /// The JsonSerializerSettings.
        /// </value>
        public static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings() { ContractResolver = new PushBulletContractResolver() };

        /// <summary>
        /// Creates properties for the given <see cref="T:Newtonsoft.Json.Serialization.JsonContract" />.
        /// </summary>
        /// <param name="type">The type to create properties for.</param>
        /// <param name="memberSerialization">The member serialization mode for the type.</param>
        /// <returns>
        /// Properties for the given <see cref="T:Newtonsoft.Json.Serialization.JsonContract" />.
        /// </returns>
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            IList<JsonProperty> list = base.CreateProperties(type, memberSerialization);
            foreach (JsonProperty prop in list)
            {
                var attribute = prop.AttributeProvider.GetAttributes(typeof(PushBulletPropertyAttribute), true).FirstOrDefault() as PushBulletPropertyAttribute;
                if (attribute != null)
                {
                    prop.PropertyName = attribute.PropertyName;
                }
            }
            return list;
        }
    }

    /// <summary>
    /// Maps a JSON property to a .NET member or constructor parameter.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class PushBulletPropertyAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        /// <value>
        /// The name of the property.
        /// </value>
        public string PropertyName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushBulletPropertyAttribute"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public PushBulletPropertyAttribute(string propertyName)
        {
            this.PropertyName = propertyName;
        }
    }
}
