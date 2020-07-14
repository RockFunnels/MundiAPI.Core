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
    public class CreateApplePayHeaderRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string publicKeyHash;
        private string ephemeralPublicKey;
        private string transactionId;

        /// <summary>
        /// SHA–256 hash, Base64 string codified
        /// </summary>
        [JsonProperty("public_key_hash")]
        public string PublicKeyHash 
        { 
            get 
            {
                return this.publicKeyHash; 
            } 
            set 
            {
                this.publicKeyHash = value;
                onPropertyChanged("PublicKeyHash");
            }
        }

        /// <summary>
        /// X.509 encoded key bytes, Base64 encoded as a string
        /// </summary>
        [JsonProperty("ephemeral_public_key")]
        public string EphemeralPublicKey 
        { 
            get 
            {
                return this.ephemeralPublicKey; 
            } 
            set 
            {
                this.ephemeralPublicKey = value;
                onPropertyChanged("EphemeralPublicKey");
            }
        }

        /// <summary>
        /// Transaction identifier, generated on Device
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId 
        { 
            get 
            {
                return this.transactionId; 
            } 
            set 
            {
                this.transactionId = value;
                onPropertyChanged("TransactionId");
            }
        }
    }
} 