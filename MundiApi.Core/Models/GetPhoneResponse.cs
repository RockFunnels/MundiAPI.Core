/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    public class GetPhoneResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string countryCode;
        private string number;
        private string areaCode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode 
        { 
            get 
            {
                return this.countryCode; 
            } 
            set 
            {
                this.countryCode = value;
                onPropertyChanged("CountryCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("area_code")]
        public string AreaCode 
        { 
            get 
            {
                return this.areaCode; 
            } 
            set 
            {
                this.areaCode = value;
                onPropertyChanged("AreaCode");
            }
        }
    }
} 