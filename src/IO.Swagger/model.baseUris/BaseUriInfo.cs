/**
*  Copyright 2019 Adobe Systems Incorporated. All rights reserved.
*  This file is licensed to you under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License. You may obtain a copy
*  of the License at http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software distributed under
*  the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
*  OF ANY KIND, either express or implied. See the License for the specific language
*  governing permissions and limitations under the License.
*
*
**/


/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 6.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.model.baseUris
{
    /// <summary>
    /// BaseUriInfo
    /// </summary>
    [DataContract]
    public partial class BaseUriInfo :  IEquatable<BaseUriInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUriInfo" /> class.
        /// </summary>
        /// <param name="ApiAccessPoint">The access point from where other APIs need to be accessed. In case other APIs are accessed from a different end point, it will be considered an invalid request.</param>
        /// <param name="WebAccessPoint">The access point from where Adobe Sign website can be be accessed.</param>
        public BaseUriInfo(string ApiAccessPoint = default(string), string WebAccessPoint = default(string))
        {
            this.ApiAccessPoint = ApiAccessPoint;
            this.WebAccessPoint = WebAccessPoint;
        }
        
        /// <summary>
        /// The access point from where other APIs need to be accessed. In case other APIs are accessed from a different end point, it will be considered an invalid request
        /// </summary>
        /// <value>The access point from where other APIs need to be accessed. In case other APIs are accessed from a different end point, it will be considered an invalid request</value>
        [DataMember(Name="apiAccessPoint", EmitDefaultValue=false)]
        public string ApiAccessPoint { get; set; }

        /// <summary>
        /// The access point from where Adobe Sign website can be be accessed
        /// </summary>
        /// <value>The access point from where Adobe Sign website can be be accessed</value>
        [DataMember(Name="webAccessPoint", EmitDefaultValue=false)]
        public string WebAccessPoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseUriInfo {\n");
            sb.Append("  ApiAccessPoint: ").Append(ApiAccessPoint).Append("\n");
            sb.Append("  WebAccessPoint: ").Append(WebAccessPoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseUriInfo);
        }

        /// <summary>
        /// Returns true if BaseUriInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseUriInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseUriInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiAccessPoint == input.ApiAccessPoint ||
                    (this.ApiAccessPoint != null &&
                    this.ApiAccessPoint.Equals(input.ApiAccessPoint))
                ) && 
                (
                    this.WebAccessPoint == input.WebAccessPoint ||
                    (this.WebAccessPoint != null &&
                    this.WebAccessPoint.Equals(input.WebAccessPoint))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApiAccessPoint != null)
                    hashCode = hashCode * 59 + this.ApiAccessPoint.GetHashCode();
                if (this.WebAccessPoint != null)
                    hashCode = hashCode * 59 + this.WebAccessPoint.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
