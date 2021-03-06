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
using System.Text.Json.Serialization;
using System.Xml;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Topic : IEquatable<Topic>
    { 
        /// <summary>
        /// Id of this topic 
        /// </summary>
        /// <value>Id of this topic </value>
        [Required]
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Description of the topic 
        /// </summary>
        /// <value>Description of the topic </value>
        [Required]
        [DataMember(Name="desc")]
        public string Desc { get; set; }
        
        public string EventId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Topic {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Topic)obj);
        }

        /// <summary>
        /// Returns true if Topic instances are equal
        /// </summary>
        /// <param name="other">Instance of Topic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Topic other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Desc == other.Desc ||
                    Desc != null &&
                    Desc.Equals(other.Desc)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Desc != null)
                    hashCode = hashCode * 59 + Desc.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Topic left, Topic right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Topic left, Topic right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
