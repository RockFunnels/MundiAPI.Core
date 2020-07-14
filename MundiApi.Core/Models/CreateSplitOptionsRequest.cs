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
    public class CreateSplitOptionsRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool? liable;
        private bool? chargeProcessingFee;

        /// <summary>
        /// Liable options
        /// </summary>
        [JsonProperty("liable")]
        public bool? Liable 
        { 
            get 
            {
                return this.liable; 
            } 
            set 
            {
                this.liable = value;
                onPropertyChanged("Liable");
            }
        }

        /// <summary>
        /// Charge processing fee
        /// </summary>
        [JsonProperty("charge_processing_fee")]
        public bool? ChargeProcessingFee 
        { 
            get 
            {
                return this.chargeProcessingFee; 
            } 
            set 
            {
                this.chargeProcessingFee = value;
                onPropertyChanged("ChargeProcessingFee");
            }
        }
    }
} 