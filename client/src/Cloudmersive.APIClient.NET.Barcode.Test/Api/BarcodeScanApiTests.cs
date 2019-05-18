/* 
 * barcodeapi
 *
 * Barcode APIs let you generate barcode images, and recognize values from images of barcodes.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.Barcode.Client;
using Cloudmersive.APIClient.NET.Barcode.Api;
using Cloudmersive.APIClient.NET.Barcode.Model;

namespace Cloudmersive.APIClient.NET.Barcode.Test
{
    /// <summary>
    ///  Class for testing BarcodeScanApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BarcodeScanApiTests
    {
        private BarcodeScanApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BarcodeScanApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BarcodeScanApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BarcodeScanApi
            //Assert.IsInstanceOfType(typeof(BarcodeScanApi), instance, "instance is a BarcodeScanApi");
        }

        
        /// <summary>
        /// Test BarcodeScanImage
        /// </summary>
        [Test]
        public void BarcodeScanImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.BarcodeScanImage(imageFile);
            //Assert.IsInstanceOf<BarcodeScanResult> (response, "response is BarcodeScanResult");
        }
        
    }

}