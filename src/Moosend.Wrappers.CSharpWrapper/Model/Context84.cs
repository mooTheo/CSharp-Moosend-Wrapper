/* 
 * Moosend API
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
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
using SwaggerDateConverter = Moosend.Wrappers.CSharpWrapper.Client.SwaggerDateConverter;

namespace Moosend.Wrappers.CSharpWrapper.Model
{
    /// <summary>
    /// Context84
    /// </summary>
    [DataContract]
    public partial class Context84 :  IEquatable<Context84>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context84" /> class.
        /// </summary>
        /// <param name="ABCampaignData">.</param>
        /// <param name="ConfirmationTo">.</param>
        /// <param name="CreatedOn">.</param>
        /// <param name="DeliveredOn">.</param>
        /// <param name="FormatType">.</param>
        /// <param name="HTMLContent">.</param>
        /// <param name="ID">.</param>
        /// <param name="IsTransactional">.</param>
        /// <param name="MailingLists">.</param>
        /// <param name="Name">.</param>
        /// <param name="PlainContent">.</param>
        /// <param name="ReplyToEmail">ReplyToEmail.</param>
        /// <param name="ScheduledFor">.</param>
        /// <param name="Sender">Sender.</param>
        /// <param name="Status">.</param>
        /// <param name="Subject">.</param>
        /// <param name="Timezone">.</param>
        /// <param name="UpdatedOn">.</param>
        /// <param name="WebLocation">.</param>
        public Context84(string ABCampaignData = default(string), string ConfirmationTo = default(string), string CreatedOn = default(string), string DeliveredOn = default(string), double? FormatType = default(double?), string HTMLContent = default(string), string ID = default(string), bool? IsTransactional = default(bool?), List<MailingList85> MailingLists = default(List<MailingList85>), string Name = default(string), string PlainContent = default(string), ReplyToEmail ReplyToEmail = default(ReplyToEmail), string ScheduledFor = default(string), Sender Sender = default(Sender), double? Status = default(double?), string Subject = default(string), string Timezone = default(string), string UpdatedOn = default(string), string WebLocation = default(string))
        {
            this.ABCampaignData = ABCampaignData;
            this.ConfirmationTo = ConfirmationTo;
            this.CreatedOn = CreatedOn;
            this.DeliveredOn = DeliveredOn;
            this.FormatType = FormatType;
            this.HTMLContent = HTMLContent;
            this.ID = ID;
            this.IsTransactional = IsTransactional;
            this.MailingLists = MailingLists;
            this.Name = Name;
            this.PlainContent = PlainContent;
            this.ReplyToEmail = ReplyToEmail;
            this.ScheduledFor = ScheduledFor;
            this.Sender = Sender;
            this.Status = Status;
            this.Subject = Subject;
            this.Timezone = Timezone;
            this.UpdatedOn = UpdatedOn;
            this.WebLocation = WebLocation;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ABCampaignData", EmitDefaultValue=false)]
        public string ABCampaignData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ConfirmationTo", EmitDefaultValue=false)]
        public string ConfirmationTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CreatedOn", EmitDefaultValue=false)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="DeliveredOn", EmitDefaultValue=false)]
        public string DeliveredOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="FormatType", EmitDefaultValue=false)]
        public double? FormatType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="HTMLContent", EmitDefaultValue=false)]
        public string HTMLContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="IsTransactional", EmitDefaultValue=false)]
        public bool? IsTransactional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MailingLists", EmitDefaultValue=false)]
        public List<MailingList85> MailingLists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PlainContent", EmitDefaultValue=false)]
        public string PlainContent { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToEmail
        /// </summary>
        [DataMember(Name="ReplyToEmail", EmitDefaultValue=false)]
        public ReplyToEmail ReplyToEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ScheduledFor", EmitDefaultValue=false)]
        public string ScheduledFor { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="Sender", EmitDefaultValue=false)]
        public Sender Sender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public double? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="UpdatedOn", EmitDefaultValue=false)]
        public string UpdatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="WebLocation", EmitDefaultValue=false)]
        public string WebLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Context84 {\n");
            sb.Append("  ABCampaignData: ").Append(ABCampaignData).Append("\n");
            sb.Append("  ConfirmationTo: ").Append(ConfirmationTo).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DeliveredOn: ").Append(DeliveredOn).Append("\n");
            sb.Append("  FormatType: ").Append(FormatType).Append("\n");
            sb.Append("  HTMLContent: ").Append(HTMLContent).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  IsTransactional: ").Append(IsTransactional).Append("\n");
            sb.Append("  MailingLists: ").Append(MailingLists).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlainContent: ").Append(PlainContent).Append("\n");
            sb.Append("  ReplyToEmail: ").Append(ReplyToEmail).Append("\n");
            sb.Append("  ScheduledFor: ").Append(ScheduledFor).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  WebLocation: ").Append(WebLocation).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Context84);
        }

        /// <summary>
        /// Returns true if Context84 instances are equal
        /// </summary>
        /// <param name="other">Instance of Context84 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Context84 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ABCampaignData == other.ABCampaignData ||
                    this.ABCampaignData != null &&
                    this.ABCampaignData.Equals(other.ABCampaignData)
                ) && 
                (
                    this.ConfirmationTo == other.ConfirmationTo ||
                    this.ConfirmationTo != null &&
                    this.ConfirmationTo.Equals(other.ConfirmationTo)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.DeliveredOn == other.DeliveredOn ||
                    this.DeliveredOn != null &&
                    this.DeliveredOn.Equals(other.DeliveredOn)
                ) && 
                (
                    this.FormatType == other.FormatType ||
                    this.FormatType != null &&
                    this.FormatType.Equals(other.FormatType)
                ) && 
                (
                    this.HTMLContent == other.HTMLContent ||
                    this.HTMLContent != null &&
                    this.HTMLContent.Equals(other.HTMLContent)
                ) && 
                (
                    this.ID == other.ID ||
                    this.ID != null &&
                    this.ID.Equals(other.ID)
                ) && 
                (
                    this.IsTransactional == other.IsTransactional ||
                    this.IsTransactional != null &&
                    this.IsTransactional.Equals(other.IsTransactional)
                ) && 
                (
                    this.MailingLists == other.MailingLists ||
                    this.MailingLists != null &&
                    this.MailingLists.SequenceEqual(other.MailingLists)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlainContent == other.PlainContent ||
                    this.PlainContent != null &&
                    this.PlainContent.Equals(other.PlainContent)
                ) && 
                (
                    this.ReplyToEmail == other.ReplyToEmail ||
                    this.ReplyToEmail != null &&
                    this.ReplyToEmail.Equals(other.ReplyToEmail)
                ) && 
                (
                    this.ScheduledFor == other.ScheduledFor ||
                    this.ScheduledFor != null &&
                    this.ScheduledFor.Equals(other.ScheduledFor)
                ) && 
                (
                    this.Sender == other.Sender ||
                    this.Sender != null &&
                    this.Sender.Equals(other.Sender)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.UpdatedOn == other.UpdatedOn ||
                    this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(other.UpdatedOn)
                ) && 
                (
                    this.WebLocation == other.WebLocation ||
                    this.WebLocation != null &&
                    this.WebLocation.Equals(other.WebLocation)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ABCampaignData != null)
                    hash = hash * 59 + this.ABCampaignData.GetHashCode();
                if (this.ConfirmationTo != null)
                    hash = hash * 59 + this.ConfirmationTo.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.DeliveredOn != null)
                    hash = hash * 59 + this.DeliveredOn.GetHashCode();
                if (this.FormatType != null)
                    hash = hash * 59 + this.FormatType.GetHashCode();
                if (this.HTMLContent != null)
                    hash = hash * 59 + this.HTMLContent.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                if (this.IsTransactional != null)
                    hash = hash * 59 + this.IsTransactional.GetHashCode();
                if (this.MailingLists != null)
                    hash = hash * 59 + this.MailingLists.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PlainContent != null)
                    hash = hash * 59 + this.PlainContent.GetHashCode();
                if (this.ReplyToEmail != null)
                    hash = hash * 59 + this.ReplyToEmail.GetHashCode();
                if (this.ScheduledFor != null)
                    hash = hash * 59 + this.ScheduledFor.GetHashCode();
                if (this.Sender != null)
                    hash = hash * 59 + this.Sender.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.UpdatedOn != null)
                    hash = hash * 59 + this.UpdatedOn.GetHashCode();
                if (this.WebLocation != null)
                    hash = hash * 59 + this.WebLocation.GetHashCode();
                return hash;
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