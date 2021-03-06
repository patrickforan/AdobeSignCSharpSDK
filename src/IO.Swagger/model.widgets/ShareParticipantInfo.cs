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

namespace IO.Swagger.model.widgets
{
    /// <summary>
    /// ShareParticipantInfo
    /// </summary>
    [DataContract]
    public partial class ShareParticipantInfo :  IEquatable<ShareParticipantInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareParticipantInfo" /> class.
        /// </summary>
        /// <param name="Company">Company of the sharee participant of the widget, if available..</param>
        /// <param name="Email">Email of the sharee participant of the widget..</param>
        /// <param name="Name">Name of the sharee participant of the widget, if available..</param>
        /// <param name="ParticipantId">The unique identifier of the sharee participant of the widget..</param>
        /// <param name="SharerParticipantId">The unique identifier of the participant who shared the widget..</param>
        public ShareParticipantInfo(string Company = default(string), string Email = default(string), string Name = default(string), string ParticipantId = default(string), string SharerParticipantId = default(string))
        {
            this.Company = Company;
            this.Email = Email;
            this.Name = Name;
            this.ParticipantId = ParticipantId;
            this.SharerParticipantId = SharerParticipantId;
        }
        
        /// <summary>
        /// Company of the sharee participant of the widget, if available.
        /// </summary>
        /// <value>Company of the sharee participant of the widget, if available.</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Email of the sharee participant of the widget.
        /// </summary>
        /// <value>Email of the sharee participant of the widget.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Name of the sharee participant of the widget, if available.
        /// </summary>
        /// <value>Name of the sharee participant of the widget, if available.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of the sharee participant of the widget.
        /// </summary>
        /// <value>The unique identifier of the sharee participant of the widget.</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// The unique identifier of the participant who shared the widget.
        /// </summary>
        /// <value>The unique identifier of the participant who shared the widget.</value>
        [DataMember(Name="sharerParticipantId", EmitDefaultValue=false)]
        public string SharerParticipantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareParticipantInfo {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  SharerParticipantId: ").Append(SharerParticipantId).Append("\n");
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
            return this.Equals(input as ShareParticipantInfo);
        }

        /// <summary>
        /// Returns true if ShareParticipantInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareParticipantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareParticipantInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParticipantId == input.ParticipantId ||
                    (this.ParticipantId != null &&
                    this.ParticipantId.Equals(input.ParticipantId))
                ) && 
                (
                    this.SharerParticipantId == input.SharerParticipantId ||
                    (this.SharerParticipantId != null &&
                    this.SharerParticipantId.Equals(input.SharerParticipantId))
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParticipantId != null)
                    hashCode = hashCode * 59 + this.ParticipantId.GetHashCode();
                if (this.SharerParticipantId != null)
                    hashCode = hashCode * 59 + this.SharerParticipantId.GetHashCode();
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
