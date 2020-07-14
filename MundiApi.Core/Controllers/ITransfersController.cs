/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;
using MundiAPI.PCL.Http.Request;
using MundiAPI.PCL.Http.Response;
using MundiAPI.PCL.Http.Client;

namespace MundiAPI.PCL.Controllers
{
    public partial interface ITransfersController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        Models.GetTransfer CreateTransfer(Models.CreateTransfer request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        Task<Models.GetTransfer> CreateTransferAsync(Models.CreateTransfer request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="transferId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        Models.GetTransfer GetTransferById(string transferId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="transferId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        Task<Models.GetTransfer> GetTransferByIdAsync(string transferId);

        /// <summary>
        /// Gets all transfers
        /// </summary>
        /// <return>Returns the Models.ListTransfers response from the API call</return>
        Models.ListTransfers GetTransfers();

        /// <summary>
        /// Gets all transfers
        /// </summary>
        /// <return>Returns the Models.ListTransfers response from the API call</return>
        Task<Models.ListTransfers> GetTransfersAsync();

    }
} 