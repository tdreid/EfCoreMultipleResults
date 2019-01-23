﻿using EfCoreMultipleResults.Model;
using EfCoreMultipleResults.SampleContext;
using System;
using System.Collections.Generic;

namespace EfCoreMultipleResults
{
    public class DataAccess
    {

        public void GetDBResults()
        {
            //create an instance of the dbcontext
            SampleEntities sampleEntities = new SampleEntities(new Microsoft.EntityFrameworkCore.DbContextOptions<SampleEntities>());

            //This should be added in the exact order of the output of the stored procedure
            List<Type> returnTypes = new List<Type>();
            returnTypes.Add(typeof(Result1));
            returnTypes.Add(typeof(Result2));

            var results = sampleEntities.QueryMultipleResults(sql: "YOUR_STORE_PROC_NAME").ExecuteMultipleResults(parameters: null, returnTypes: returnTypes);

        }
    }
}