/* 
 * Square Connect API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
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

namespace Square.Connect.Model
{
    /// <summary>
    /// Indicates the method used to enter the card's details.
    /// </summary>
    /// <value>Indicates the method used to enter the card's details.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TenderCardDetailsEntryMethod
    {
        
        /// <summary>
        /// Enum SWIPED for "SWIPED"
        /// </summary>
        [EnumMember(Value = "SWIPED")]
        SWIPED,
        
        /// <summary>
        /// Enum KEYED for "KEYED"
        /// </summary>
        [EnumMember(Value = "KEYED")]
        KEYED,
        
        /// <summary>
        /// Enum EMV for "EMV"
        /// </summary>
        [EnumMember(Value = "EMV")]
        EMV,
        
        /// <summary>
        /// Enum ONFILE for "ON_FILE"
        /// </summary>
        [EnumMember(Value = "ON_FILE")]
        ONFILE,
        
        /// <summary>
        /// Enum CONTACTLESS for "CONTACTLESS"
        /// </summary>
        [EnumMember(Value = "CONTACTLESS")]
        CONTACTLESS
    }

}