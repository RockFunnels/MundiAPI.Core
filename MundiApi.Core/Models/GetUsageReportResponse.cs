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
    public class GetUsageReportResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string url;
        private string usageReportUrl;
        private string groupedReportUrl;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("usage_report_url")]
        public string UsageReportUrl 
        { 
            get 
            {
                return this.usageReportUrl; 
            } 
            set 
            {
                this.usageReportUrl = value;
                onPropertyChanged("UsageReportUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("grouped_report_url")]
        public string GroupedReportUrl 
        { 
            get 
            {
                return this.groupedReportUrl; 
            } 
            set 
            {
                this.groupedReportUrl = value;
                onPropertyChanged("GroupedReportUrl");
            }
        }
    }
} 