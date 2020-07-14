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
    public class CreateRecipientRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string email;
        private string description;
        private string document;
        private string type;
        private Models.CreateBankAccountRequest defaultBankAccount;
        private Dictionary<string, string> metadata;
        private Models.CreateTransferSettingsRequest transferSettings;

        /// <summary>
        /// Recipient name
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Recipient email
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Recipient description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Recipient document number
        /// </summary>
        [JsonProperty("document")]
        public string Document 
        { 
            get 
            {
                return this.document; 
            } 
            set 
            {
                this.document = value;
                onPropertyChanged("Document");
            }
        }

        /// <summary>
        /// Recipient type
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Bank account
        /// </summary>
        [JsonProperty("default_bank_account")]
        public Models.CreateBankAccountRequest DefaultBankAccount 
        { 
            get 
            {
                return this.defaultBankAccount; 
            } 
            set 
            {
                this.defaultBankAccount = value;
                onPropertyChanged("DefaultBankAccount");
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// Receiver Transfer Information
        /// </summary>
        [JsonProperty("transfer_settings")]
        public Models.CreateTransferSettingsRequest TransferSettings 
        { 
            get 
            {
                return this.transferSettings; 
            } 
            set 
            {
                this.transferSettings = value;
                onPropertyChanged("TransferSettings");
            }
        }
    }
} 