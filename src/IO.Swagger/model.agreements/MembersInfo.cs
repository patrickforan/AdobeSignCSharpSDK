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

namespace IO.Swagger.model.agreements
{
    /// <summary>
    /// MembersInfo
    /// </summary>
    [DataContract]
    public partial class MembersInfo :  IEquatable<MembersInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MembersInfo" /> class.
        /// </summary>
        /// <param name="CcsInfo">Information of CC participants of the agreement..</param>
        /// <param name="NextParticipantSets">Information of next participant sets..</param>
        /// <param name="ParticipantSets">Information about the participant Sets..</param>
        /// <param name="SenderInfo">Information of the sender of the agreement..</param>
        /// <param name="SharesInfo">Information of the participants with whom the agreement has been shared..</param>
        public MembersInfo(List<CCParticipantInfo> CcsInfo = default(List<CCParticipantInfo>), List<DetailedParticipantSetInfo> NextParticipantSets = default(List<DetailedParticipantSetInfo>), List<DetailedParticipantSetInfo> ParticipantSets = default(List<DetailedParticipantSetInfo>), SenderInfo SenderInfo = default(SenderInfo), List<ShareParticipantInfo> SharesInfo = default(List<ShareParticipantInfo>))
        {
            this.CcsInfo = CcsInfo;
            this.NextParticipantSets = NextParticipantSets;
            this.ParticipantSets = ParticipantSets;
            this.SenderInfo = SenderInfo;
            this.SharesInfo = SharesInfo;
        }
        
        /// <summary>
        /// Information of CC participants of the agreement.
        /// </summary>
        /// <value>Information of CC participants of the agreement.</value>
        [DataMember(Name="ccsInfo", EmitDefaultValue=false)]
        public List<CCParticipantInfo> CcsInfo { get; set; }

        /// <summary>
        /// Information of next participant sets.
        /// </summary>
        /// <value>Information of next participant sets.</value>
        [DataMember(Name="nextParticipantSets", EmitDefaultValue=false)]
        public List<DetailedParticipantSetInfo> NextParticipantSets { get; set; }

        /// <summary>
        /// Information about the participant Sets.
        /// </summary>
        /// <value>Information about the participant Sets.</value>
        [DataMember(Name="participantSets", EmitDefaultValue=false)]
        public List<DetailedParticipantSetInfo> ParticipantSets { get; set; }

        /// <summary>
        /// Information of the sender of the agreement.
        /// </summary>
        /// <value>Information of the sender of the agreement.</value>
        [DataMember(Name="senderInfo", EmitDefaultValue=false)]
        public SenderInfo SenderInfo { get; set; }

        /// <summary>
        /// Information of the participants with whom the agreement has been shared.
        /// </summary>
        /// <value>Information of the participants with whom the agreement has been shared.</value>
        [DataMember(Name="sharesInfo", EmitDefaultValue=false)]
        public List<ShareParticipantInfo> SharesInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembersInfo {\n");
            sb.Append("  CcsInfo: ").Append(CcsInfo).Append("\n");
            sb.Append("  NextParticipantSets: ").Append(NextParticipantSets).Append("\n");
            sb.Append("  ParticipantSets: ").Append(ParticipantSets).Append("\n");
            sb.Append("  SenderInfo: ").Append(SenderInfo).Append("\n");
            sb.Append("  SharesInfo: ").Append(SharesInfo).Append("\n");
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
            return this.Equals(input as MembersInfo);
        }

        /// <summary>
        /// Returns true if MembersInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MembersInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembersInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CcsInfo == input.CcsInfo ||
                    this.CcsInfo != null &&
                    this.CcsInfo.SequenceEqual(input.CcsInfo)
                ) && 
                (
                    this.NextParticipantSets == input.NextParticipantSets ||
                    this.NextParticipantSets != null &&
                    this.NextParticipantSets.SequenceEqual(input.NextParticipantSets)
                ) && 
                (
                    this.ParticipantSets == input.ParticipantSets ||
                    this.ParticipantSets != null &&
                    this.ParticipantSets.SequenceEqual(input.ParticipantSets)
                ) && 
                (
                    this.SenderInfo == input.SenderInfo ||
                    (this.SenderInfo != null &&
                    this.SenderInfo.Equals(input.SenderInfo))
                ) && 
                (
                    this.SharesInfo == input.SharesInfo ||
                    this.SharesInfo != null &&
                    this.SharesInfo.SequenceEqual(input.SharesInfo)
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
                if (this.CcsInfo != null)
                    hashCode = hashCode * 59 + this.CcsInfo.GetHashCode();
                if (this.NextParticipantSets != null)
                    hashCode = hashCode * 59 + this.NextParticipantSets.GetHashCode();
                if (this.ParticipantSets != null)
                    hashCode = hashCode * 59 + this.ParticipantSets.GetHashCode();
                if (this.SenderInfo != null)
                    hashCode = hashCode * 59 + this.SenderInfo.GetHashCode();
                if (this.SharesInfo != null)
                    hashCode = hashCode * 59 + this.SharesInfo.GetHashCode();
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
