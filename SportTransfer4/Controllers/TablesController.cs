﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;

namespace SportTransfer4.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateTable()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("<trytablestorage>_AzureStorageConnectionString"));

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable table = tableClient.GetTableReference("TestTable");

            ViewBag.Success = table.CreateIfNotExists();

            ViewBag.TableName = table.Name;

            return View();
        }
    }
}