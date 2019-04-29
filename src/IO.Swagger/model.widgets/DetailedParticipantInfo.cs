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
    /// DetailedParticipantInfo
    /// </summary>
    [DataContract]
    public partial class DetailedParticipantInfo :  IEquatable<DetailedParticipantInfo>, IValidatableObject
    {
        /// <summary>
        /// The status of the participant. This cannot be changed as part of the PUT call. New participants will be ignored if added with a REPLACED status.
        /// </summary>
        /// <value>The status of the participant. This cannot be changed as part of the PUT call. New participants will be ignored if added with a REPLACED status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum REPLACED for value: REPLACED
            /// </summary>
            [EnumMember(Value = "REPLACED")]
            REPLACED = 1,
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 2
        }

        /// <summary>
        /// The status of the participant. This cannot be changed as part of the PUT call. New participants will be ignored if added with a REPLACED status.
        /// </summary>
        /// <value>The status of the participant. This cannot be changed as part of the PUT call. New participants will be ignored if added with a REPLACED status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedParticipantInfo" /> class.
        /// </summary>
        /// <param name="Company">The company of the participant, if available. This cannot be changed as part of the PUT call..</param>
        /// <param name="Email">Email of the participant. In case of modifying a participant set (PUT) this is a required field. In case of GET, this is the required field and will always be returned unless it is a fax workflow (legacy agreements) that were created using fax as input.</param>
        /// <param name="Fax">Fax of the participant. New Agreements can not be created with fax option. This is only returned for legacy agreements created with fax as participants.</param>
        /// <param name="Id">The unique identifier of the participant. This will be returned as part of Get call but is not mandatory to be passed as part of PUT call for agreements/{id}/members/participantSets/{id}..</param>
        /// <param name="Name">The name of the participant, if available. This cannot be changed as part of the PUT call..</param>
        /// <param name="PrivateMessage">The private message of the participant, if available. This cannot be changed as part of the PUT call..</param>
        /// <param name="SecurityOption">Security options that apply to the participant..</param>
        /// <param name="Self">True if this participant is the same user that is calling the API. Returned as part of Get. Ignored (not required) if modifying a participant set (PUT)..</param>
        /// <param name="Status">The status of the participant. This cannot be changed as part of the PUT call. New participants will be ignored if added with a REPLACED status..</param>
        public DetailedParticipantInfo(string Company = default(string), string Email = default(string), string Fax = default(string), string Id = default(string), string Name = default(string), string PrivateMessage = default(string), ParticipantSecurityOption SecurityOption = default(ParticipantSecurityOption), bool? Self = default(bool?), StatusEnum? Status = default(StatusEnum?))
        {
            this.Company = Company;
            this.Email = Email;
            this.Fax = Fax;
            this.Id = Id;
            this.Name = Name;
            this.PrivateMessage = PrivateMessage;
            this.SecurityOption = SecurityOption;
            this.Self = Self;
            this.Status = Status;
        }
        
        /// <summary>
        /// The company of the participant, if available. This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>The company of the participant, if available. This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Email of the participant. In case of modifying a participant set (PUT) this is a required field. In case of GET, this is the required field and will always be returned unless it is a fax workflow (legacy agreements) that were created using fax as input
        /// </summary>
        /// <value>Email of the participant. In case of modifying a participant set (PUT) this is a required field. In case of GET, this is the required field and will always be returned unless it is a fax workflow (legacy agreements) that were created using fax as input</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Fax of the participant. New Agreements can not be created with fax option. This is only returned for legacy agreements created with fax as participants
        /// </summary>
        /// <value>Fax of the participant. New Agreements can not be created with fax option. This is only returned for legacy agreements created with fax as participants</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// The unique identifier of the participant. This will be returned as part of Get call but is not mandatory to be passed as part of PUT call for agreements/{id}/members/participantSets/{id}.
        /// </summary>
        /// <value>The unique identifier of the participant. This will be returned as part of Get call but is not mandatory to be passed as part of PUT call for agreements/{id}/members/participantSets/{id}.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the participant, if available. This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>The name of the participant, if available. This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The private message of the participant, if available. This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>The private message of the participant, if available. This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="privateMessage", EmitDefaultValue=false)]
        public string PrivateMessage { get; set; }

        /// <summary>
        /// Security options that apply to the participant.
        /// </summary>
        /// <value>Security options that apply to the participant.</value>
        [DataMember(Name="securityOption", EmitDefaultValue=false)]
        public ParticipantSecurityOption SecurityOption { get; set; }

        /// <summary>
        /// True if this participant is the same user that is calling the API. Returned as part of Get. Ignored (not required) if modifying a participant set (PUT).
        /// </summary>
        /// <value>True if this participant is the same user that is calling the API. Returned as part of Get. Ignored (not required) if modifying a participant set (PUT).</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public bool? Self { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedParticipantInfo {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
            sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as DetailedParticipantInfo);
        }

        /// <summary>
        /// Returns true if DetailedParticipantInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedParticipantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedParticipantInfo input)
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
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrivateMessage == input.PrivateMessage ||
                    (this.PrivateMessage != null &&
                    this.PrivateMessage.Equals(input.PrivateMessage))
                ) && 
                (
                    this.SecurityOption == input.SecurityOption ||
                    (this.SecurityOption != null &&
                    this.SecurityOption.Equals(input.SecurityOption))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PrivateMessage != null)
                    hashCode = hashCode * 59 + this.PrivateMessage.GetHashCode();
                if (this.SecurityOption != null)
                    hashCode = hashCode * 59 + this.SecurityOption.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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