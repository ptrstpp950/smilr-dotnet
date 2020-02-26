/*
 * Smilr API
 *
 * Smilr microservice, RESTful data API
 *
 * OpenAPI spec version: 6.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class HealthInfo : IEquatable<HealthInfo>
    { 
        /// <summary>
        /// Health string 
        /// </summary>
        /// <value>Health string </value>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// Version number 
        /// </summary>
        /// <value>Version number </value>
        [Required]
        [DataMember(Name="version")]
        public string Version { get; set; }

        /// <summary>
        /// Additional release information
        /// </summary>
        /// <value>Additional release information</value>
        [DataMember(Name="releaseID")]
        public string ReleaseID { get; set; }

        /// <summary>
        /// Description of the API 
        /// </summary>
        /// <value>Description of the API </value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Further runtime information
        /// </summary>
        /// <value>Further runtime information</value>
        [DataMember(Name="debug")]
        public Object Debug { get; set; }

        /// <summary>
        /// Details of the host
        /// </summary>
        /// <value>Details of the host</value>
        [DataMember(Name="debug.hostInfo")]
        public Object DebugHostInfo { get; set; }

        /// <summary>
        /// Details of the Node version
        /// </summary>
        /// <value>Details of the Node version</value>
        [DataMember(Name="debug.nodeInfo")]
        public Object DebugNodeInfo { get; set; }

        /// <summary>
        /// Details of the runtime environment
        /// </summary>
        /// <value>Details of the runtime environment</value>
        [DataMember(Name="debug.runtimeInfo")]
        public Object DebugRuntimeInfo { get; set; }

        /// <summary>
        /// Details of the MonogDB connection and DB
        /// </summary>
        /// <value>Details of the MonogDB connection and DB</value>
        [DataMember(Name="debug.mongoInfo")]
        public Object DebugMongoInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthInfo {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ReleaseID: ").Append(ReleaseID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  DebugHostInfo: ").Append(DebugHostInfo).Append("\n");
            sb.Append("  DebugNodeInfo: ").Append(DebugNodeInfo).Append("\n");
            sb.Append("  DebugRuntimeInfo: ").Append(DebugRuntimeInfo).Append("\n");
            sb.Append("  DebugMongoInfo: ").Append(DebugMongoInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((HealthInfo)obj);
        }

        /// <summary>
        /// Returns true if HealthInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of HealthInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
                ) && 
                (
                    ReleaseID == other.ReleaseID ||
                    ReleaseID != null &&
                    ReleaseID.Equals(other.ReleaseID)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Debug == other.Debug ||
                    Debug != null &&
                    Debug.Equals(other.Debug)
                ) && 
                (
                    DebugHostInfo == other.DebugHostInfo ||
                    DebugHostInfo != null &&
                    DebugHostInfo.Equals(other.DebugHostInfo)
                ) && 
                (
                    DebugNodeInfo == other.DebugNodeInfo ||
                    DebugNodeInfo != null &&
                    DebugNodeInfo.Equals(other.DebugNodeInfo)
                ) && 
                (
                    DebugRuntimeInfo == other.DebugRuntimeInfo ||
                    DebugRuntimeInfo != null &&
                    DebugRuntimeInfo.Equals(other.DebugRuntimeInfo)
                ) && 
                (
                    DebugMongoInfo == other.DebugMongoInfo ||
                    DebugMongoInfo != null &&
                    DebugMongoInfo.Equals(other.DebugMongoInfo)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                    if (ReleaseID != null)
                    hashCode = hashCode * 59 + ReleaseID.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Debug != null)
                    hashCode = hashCode * 59 + Debug.GetHashCode();
                    if (DebugHostInfo != null)
                    hashCode = hashCode * 59 + DebugHostInfo.GetHashCode();
                    if (DebugNodeInfo != null)
                    hashCode = hashCode * 59 + DebugNodeInfo.GetHashCode();
                    if (DebugRuntimeInfo != null)
                    hashCode = hashCode * 59 + DebugRuntimeInfo.GetHashCode();
                    if (DebugMongoInfo != null)
                    hashCode = hashCode * 59 + DebugMongoInfo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HealthInfo left, HealthInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HealthInfo left, HealthInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
