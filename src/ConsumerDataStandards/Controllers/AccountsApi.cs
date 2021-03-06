/*
 * Consumer Data Standards
 *
 * API sets created by the Australian Consumer Data Standards to meet the needs of the Consumer Data Right
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using ConsumerDataStandards.Attributes;
using ConsumerDataStandards.Models;

namespace ConsumerDataStandards.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class AccountsApiController : Controller
    { 
        /// <summary>
        /// Get Account Detail
        /// </summary>
        /// <remarks>Obtain detailed information on a single account</remarks>
        /// <param name="accountId">A tokenised identifier for the account which is unique but not shareable</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/accounts/{accountId}")]
        [ValidateModelState]
        [SwaggerOperation("GetAccountDetail")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingAccountById), description: "Success")]
        public virtual IActionResult GetAccountDetail([FromRoute][Required]string accountId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingAccountById));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : \"\",\n  \"meta\" : { },\n  \"links\" : {\n    \"self\" : \"self\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingAccountById>(exampleJson)
            : default(ResponseBankingAccountById);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Transaction Detail
        /// </summary>
        /// <remarks>Obtain detailed information on a transaction for a specific account</remarks>
        /// <param name="accountId">The account id token that is used to uniquely represent the account</param>
        /// <param name="transactionId">The unique identifier for the specific transaction for which details are being requested</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/accounts/{accountId}/transactions/{transactionId}")]
        [ValidateModelState]
        [SwaggerOperation("GetTransactionDetail")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingTransactionById), description: "Success")]
        public virtual IActionResult GetTransactionDetail([FromRoute][Required]string accountId, [FromRoute][Required]string transactionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingTransactionById));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : \"\",\n  \"meta\" : { },\n  \"links\" : {\n    \"self\" : \"self\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingTransactionById>(exampleJson)
            : default(ResponseBankingTransactionById);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Transactions For Account
        /// </summary>
        /// <remarks>Obtain transactions for a specific account Some general notes that apply to all end points that retrieve transactions:  - Where multiple transactions are returned transactions should be ordered according to effective date in descending order - As the date and time for a transaction can alter depending on status and transaction type two separate date/times are included in the payload. There are still some scenarios where neither of these time stamps is available. For the purpose of filtering and ordering it is expected that the provider will use the “effective” date/time which will be defined as:   - Posted date/time if available, then   - Execution date/time if available, then   - A reasonable date/time nominated by the data provider using internal data structures - For transaction amounts it should be assumed that a negative value indicates a reduction of the available balance on the account while a positive value indicates an increase in the available balance on the account</remarks>
        /// <param name="accountId">ID of the account to get transactions for.  Must have previously been returned by one of the account list end points.</param>
        /// <param name="startTime">Constrain the transaction history request to transactions with effective time at or after this date/time. If absent defaults to current time. Format is aligned to DateTimeString common type</param>
        /// <param name="endTime">Constrain the transaction history request to transactions with effective time at or before this date/time. If absent defaults to start-time plus 100 days. Format is aligned to DateTimeString common type</param>
        /// <param name="minAmount">Filter transactions to only transactions with amounts higher or equal to than this amount</param>
        /// <param name="maxAmount">Filter transactions to only transactions with amounts less than or equal to than this amount</param>
        /// <param name="text">Filter transactions to only transactions where this string value is found as a substring of either the reference or description fields. Format is arbitrary ASCII string</param>
        /// <param name="page">Page of results to request (standard pagination)</param>
        /// <param name="pageSize">Page size to request. Default is 25 (standard pagination)</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/accounts/{accountId}/transactions")]
        [ValidateModelState]
        [SwaggerOperation("GetTransactions")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingTransactionList), description: "Success")]
        public virtual IActionResult GetTransactions([FromRoute][Required]string accountId, [FromQuery]string startTime, [FromQuery]string endTime, [FromQuery]string minAmount, [FromQuery]string maxAmount, [FromQuery]string text, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingTransactionList));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"transactions\" : [ {\n      \"postingDateTime\" : \"postingDateTime\",\n      \"amount\" : \"amount\",\n      \"apcaNumber\" : \"apcaNumber\",\n      \"isDetailAvailable\" : true,\n      \"description\" : \"description\",\n      \"type\" : \"FEE\",\n      \"billerName\" : \"billerName\",\n      \"executionDateTime\" : \"executionDateTime\",\n      \"transactionId\" : \"transactionId\",\n      \"merchantName\" : \"merchantName\",\n      \"billerCode\" : \"billerCode\",\n      \"reference\" : \"reference\",\n      \"accountId\" : \"accountId\",\n      \"merchantCategoryCode\" : \"merchantCategoryCode\",\n      \"valueDateTime\" : \"valueDateTime\",\n      \"currency\" : \"currency\",\n      \"crn\" : \"crn\",\n      \"status\" : \"PENDING\"\n    }, {\n      \"postingDateTime\" : \"postingDateTime\",\n      \"amount\" : \"amount\",\n      \"apcaNumber\" : \"apcaNumber\",\n      \"isDetailAvailable\" : true,\n      \"description\" : \"description\",\n      \"type\" : \"FEE\",\n      \"billerName\" : \"billerName\",\n      \"executionDateTime\" : \"executionDateTime\",\n      \"transactionId\" : \"transactionId\",\n      \"merchantName\" : \"merchantName\",\n      \"billerCode\" : \"billerCode\",\n      \"reference\" : \"reference\",\n      \"accountId\" : \"accountId\",\n      \"merchantCategoryCode\" : \"merchantCategoryCode\",\n      \"valueDateTime\" : \"valueDateTime\",\n      \"currency\" : \"currency\",\n      \"crn\" : \"crn\",\n      \"status\" : \"PENDING\"\n    } ]\n  },\n  \"meta\" : {\n    \"totalRecords\" : 0,\n    \"totalPages\" : 6\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"last\",\n    \"prev\" : \"prev\",\n    \"self\" : \"self\",\n    \"first\" : \"first\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingTransactionList>(exampleJson)
            : default(ResponseBankingTransactionList);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Accounts
        /// </summary>
        /// <remarks>Obtain a list of accounts</remarks>
        /// <param name="openStatus">Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed</param>
        /// <param name="isOwned">Filters accounts based on whether they are owned by the authorised customer</param>
        /// <param name="productCategory">Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.</param>
        /// <param name="page">Page of results to request (standard pagination)</param>
        /// <param name="pageSize">Page size to request. Default is 25 (standard pagination)</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/accounts")]
        [ValidateModelState]
        [SwaggerOperation("ListAccounts")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingAccountList), description: "Success")]
        public virtual IActionResult ListAccounts([FromQuery]string openStatus, [FromQuery]string isOwned, [FromQuery]string productCategory, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingAccountList));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"accounts\" : [ {\n      \"accountId\" : \"accountId\",\n      \"maskedNumber\" : \"maskedNumber\",\n      \"openStatus\" : \"OPEN\",\n      \"displayName\" : \"displayName\",\n      \"isOwned\" : true,\n      \"nickname\" : \"nickname\",\n      \"productName\" : \"productName\",\n      \"productCategory\" : { }\n    }, {\n      \"accountId\" : \"accountId\",\n      \"maskedNumber\" : \"maskedNumber\",\n      \"openStatus\" : \"OPEN\",\n      \"displayName\" : \"displayName\",\n      \"isOwned\" : true,\n      \"nickname\" : \"nickname\",\n      \"productName\" : \"productName\",\n      \"productCategory\" : { }\n    } ]\n  },\n  \"meta\" : {\n    \"totalRecords\" : 0,\n    \"totalPages\" : 6\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"last\",\n    \"prev\" : \"prev\",\n    \"self\" : \"self\",\n    \"first\" : \"first\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingAccountList>(exampleJson)
            : default(ResponseBankingAccountList);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Bulk Balances
        /// </summary>
        /// <remarks>Obtain balances for multiple, filtered accounts</remarks>
        /// <param name="openStatus">Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed</param>
        /// <param name="isOwned">Filters accounts based on whether they are owned by the authorised customer</param>
        /// <param name="productCategory">Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.</param>
        /// <param name="page">Page of results to request (standard pagination)</param>
        /// <param name="pageSize">Page size to request. Default is 25 (standard pagination)</param>
        /// <response code="200">resource listing the financial balances for the account</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/accounts/balances")]
        [ValidateModelState]
        [SwaggerOperation("ListBalancesBulk")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingAccountsBalanceList), description: "resource listing the financial balances for the account")]
        public virtual IActionResult ListBalancesBulk([FromQuery]string openStatus, [FromQuery]string isOwned, [FromQuery]string productCategory, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingAccountsBalanceList));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"balances\" : [ {\n      \"accountId\" : \"accountId\",\n      \"purses\" : [ {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      }, {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      } ],\n      \"lending\" : {\n        \"amortisedLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"creditLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"accountBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"deposit\" : {\n        \"currentBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"balanceUType\" : \"deposit\"\n    }, {\n      \"accountId\" : \"accountId\",\n      \"purses\" : [ {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      }, {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      } ],\n      \"lending\" : {\n        \"amortisedLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"creditLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"accountBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"deposit\" : {\n        \"currentBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"balanceUType\" : \"deposit\"\n    } ]\n  },\n  \"meta\" : {\n    \"totalRecords\" : 0,\n    \"totalPages\" : 6\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"last\",\n    \"prev\" : \"prev\",\n    \"self\" : \"self\",\n    \"first\" : \"first\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingAccountsBalanceList>(exampleJson)
            : default(ResponseBankingAccountsBalanceList);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Balances For Specific Accounts
        /// </summary>
        /// <remarks>Obtain balances for a specified list of accounts</remarks>
        /// <param name="accountIds">The list of account IDs to obtain information for</param>
        /// <param name="page">Page of results to request (standard pagination)</param>
        /// <param name="pageSize">Page size to request. Default is 25 (standard pagination)</param>
        /// <response code="200">Success</response>
        /// <response code="422">The request was well formed but was unable to be processed due to business logic specific to the request</response>
        [HttpPost]
        [Route("/cds-au/v1/banking/accounts/balances")]
        [ValidateModelState]
        [SwaggerOperation("ListBalancesSpecificAccounts")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingAccountsBalanceList), description: "Success")]
        [SwaggerResponse(statusCode: 422, type: typeof(ResponseErrorList), description: "The request was well formed but was unable to be processed due to business logic specific to the request")]
        public virtual IActionResult ListBalancesSpecificAccounts([FromBody]RequestAccountIds accountIds, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingAccountsBalanceList));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ResponseErrorList));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"balances\" : [ {\n      \"accountId\" : \"accountId\",\n      \"purses\" : [ {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      }, {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      } ],\n      \"lending\" : {\n        \"amortisedLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"creditLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"accountBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"deposit\" : {\n        \"currentBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"balanceUType\" : \"deposit\"\n    }, {\n      \"accountId\" : \"accountId\",\n      \"purses\" : [ {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      }, {\n        \"amount\" : \"amount\",\n        \"currency\" : \"currency\"\n      } ],\n      \"lending\" : {\n        \"amortisedLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"creditLimit\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"accountBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"deposit\" : {\n        \"currentBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        },\n        \"availableBalance\" : {\n          \"amount\" : \"amount\",\n          \"currency\" : \"currency\"\n        }\n      },\n      \"balanceUType\" : \"deposit\"\n    } ]\n  },\n  \"meta\" : {\n    \"totalRecords\" : 0,\n    \"totalPages\" : 6\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"last\",\n    \"prev\" : \"prev\",\n    \"self\" : \"self\",\n    \"first\" : \"first\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingAccountsBalanceList>(exampleJson)
            : default(ResponseBankingAccountsBalanceList);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Transactions For Multiple Accounts
        /// </summary>
        /// <remarks>Obtain transactions for multiple, filtered accounts</remarks>
        /// <param name="openStatus">Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed</param>
        /// <param name="isOwned">Filters accounts based on whether they are owned by the authorised customer</param>
        /// <param name="productCategory">Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.</param>
        /// <param name="startTime">Constrain the transaction history request to transactions with effective time at or after this date/time. If absent defaults to current time. Format is aligned to DateTimeString common type</param>
        /// <param name="endTime">Constrain the transaction history request to transactions with effective time at or before this date/time. If absent defaults to start-time plus 100 days. Format is aligned to DateTimeString common type</param>
        /// <param name="minAmount">Filter transactions to only transactions with amounts higher or equal to than this amount</param>
        /// <param name="maxAmount">Filter transactions to only transactions with amounts less than or equal to than this amount</param>
        /// <param name="text">Filter transactions to only transactions where this string value is found as a substring of either the reference or description fields. Format is arbitrary ASCII string</param>
        /// <param name="page">Page of results to request (standard pagination)</param>
        /// <param name="pageSize">Page size to request. Default is 25 (standard pagination)</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/cds-au/v1/banking/accounts/transactions")]
        [ValidateModelState]
        [SwaggerOperation("ListTransactionsBulk")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingTransactionList), description: "Success")]
        public virtual IActionResult ListTransactionsBulk([FromQuery]string openStatus, [FromQuery]string isOwned, [FromQuery]string productCategory, [FromQuery]string startTime, [FromQuery]string endTime, [FromQuery]string minAmount, [FromQuery]string maxAmount, [FromQuery]string text, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingTransactionList));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"transactions\" : [ {\n      \"postingDateTime\" : \"postingDateTime\",\n      \"amount\" : \"amount\",\n      \"apcaNumber\" : \"apcaNumber\",\n      \"isDetailAvailable\" : true,\n      \"description\" : \"description\",\n      \"type\" : \"FEE\",\n      \"billerName\" : \"billerName\",\n      \"executionDateTime\" : \"executionDateTime\",\n      \"transactionId\" : \"transactionId\",\n      \"merchantName\" : \"merchantName\",\n      \"billerCode\" : \"billerCode\",\n      \"reference\" : \"reference\",\n      \"accountId\" : \"accountId\",\n      \"merchantCategoryCode\" : \"merchantCategoryCode\",\n      \"valueDateTime\" : \"valueDateTime\",\n      \"currency\" : \"currency\",\n      \"crn\" : \"crn\",\n      \"status\" : \"PENDING\"\n    }, {\n      \"postingDateTime\" : \"postingDateTime\",\n      \"amount\" : \"amount\",\n      \"apcaNumber\" : \"apcaNumber\",\n      \"isDetailAvailable\" : true,\n      \"description\" : \"description\",\n      \"type\" : \"FEE\",\n      \"billerName\" : \"billerName\",\n      \"executionDateTime\" : \"executionDateTime\",\n      \"transactionId\" : \"transactionId\",\n      \"merchantName\" : \"merchantName\",\n      \"billerCode\" : \"billerCode\",\n      \"reference\" : \"reference\",\n      \"accountId\" : \"accountId\",\n      \"merchantCategoryCode\" : \"merchantCategoryCode\",\n      \"valueDateTime\" : \"valueDateTime\",\n      \"currency\" : \"currency\",\n      \"crn\" : \"crn\",\n      \"status\" : \"PENDING\"\n    } ]\n  },\n  \"meta\" : {\n    \"totalRecords\" : 0,\n    \"totalPages\" : 6\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"last\",\n    \"prev\" : \"prev\",\n    \"self\" : \"self\",\n    \"first\" : \"first\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingTransactionList>(exampleJson)
            : default(ResponseBankingTransactionList);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Transactions For Specific Accounts
        /// </summary>
        /// <remarks>Obtain transactions for a specified list of transactions.</remarks>
        /// <param name="accountIds">The list of account IDs to obtain information for</param>
        /// <param name="startTime">Constrain the transaction history request to transactions with effective time at or after this date/time. If absent defaults to current time. Format is aligned to DateTimeString common type</param>
        /// <param name="endTime">Constrain the transaction history request to transactions with effective time at or before this date/time. If absent defaults to start-time plus 100 days. Format is aligned to DateTimeString common type</param>
        /// <param name="minAmount">Filter transactions to only transactions with amounts higher or equal to than this amount</param>
        /// <param name="maxAmount">Filter transactions to only transactions with amounts less than or equal to than this amount</param>
        /// <param name="text">Filter transactions to only transactions where this string value is found as a substring of either the reference or description fields. Format is arbitrary ASCII string</param>
        /// <param name="page">Page of results to request (standard pagination)</param>
        /// <param name="pageSize">Page size to request. Default is 25 (standard pagination)</param>
        /// <response code="200">Success</response>
        /// <response code="422">The request was well formed but was unable to be processed due to business logic specific to the request</response>
        [HttpPost]
        [Route("/cds-au/v1/banking/accounts/transactions")]
        [ValidateModelState]
        [SwaggerOperation("ListTransactionsSpecificAccounts")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingTransactionList), description: "Success")]
        [SwaggerResponse(statusCode: 422, type: typeof(ResponseErrorList), description: "The request was well formed but was unable to be processed due to business logic specific to the request")]
        public virtual IActionResult ListTransactionsSpecificAccounts([FromBody]RequestAccountIds accountIds, [FromQuery]string startTime, [FromQuery]string endTime, [FromQuery]string minAmount, [FromQuery]string maxAmount, [FromQuery]string text, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingTransactionList));

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422, default(ResponseErrorList));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"transactions\" : [ {\n      \"postingDateTime\" : \"postingDateTime\",\n      \"amount\" : \"amount\",\n      \"apcaNumber\" : \"apcaNumber\",\n      \"isDetailAvailable\" : true,\n      \"description\" : \"description\",\n      \"type\" : \"FEE\",\n      \"billerName\" : \"billerName\",\n      \"executionDateTime\" : \"executionDateTime\",\n      \"transactionId\" : \"transactionId\",\n      \"merchantName\" : \"merchantName\",\n      \"billerCode\" : \"billerCode\",\n      \"reference\" : \"reference\",\n      \"accountId\" : \"accountId\",\n      \"merchantCategoryCode\" : \"merchantCategoryCode\",\n      \"valueDateTime\" : \"valueDateTime\",\n      \"currency\" : \"currency\",\n      \"crn\" : \"crn\",\n      \"status\" : \"PENDING\"\n    }, {\n      \"postingDateTime\" : \"postingDateTime\",\n      \"amount\" : \"amount\",\n      \"apcaNumber\" : \"apcaNumber\",\n      \"isDetailAvailable\" : true,\n      \"description\" : \"description\",\n      \"type\" : \"FEE\",\n      \"billerName\" : \"billerName\",\n      \"executionDateTime\" : \"executionDateTime\",\n      \"transactionId\" : \"transactionId\",\n      \"merchantName\" : \"merchantName\",\n      \"billerCode\" : \"billerCode\",\n      \"reference\" : \"reference\",\n      \"accountId\" : \"accountId\",\n      \"merchantCategoryCode\" : \"merchantCategoryCode\",\n      \"valueDateTime\" : \"valueDateTime\",\n      \"currency\" : \"currency\",\n      \"crn\" : \"crn\",\n      \"status\" : \"PENDING\"\n    } ]\n  },\n  \"meta\" : {\n    \"totalRecords\" : 0,\n    \"totalPages\" : 6\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"last\",\n    \"prev\" : \"prev\",\n    \"self\" : \"self\",\n    \"first\" : \"first\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseBankingTransactionList>(exampleJson)
            : default(ResponseBankingTransactionList);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
