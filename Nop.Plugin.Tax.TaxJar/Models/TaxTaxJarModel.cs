﻿using System.Collections.Generic;
using System.Web.Mvc;
using Nop.Web.Framework;

namespace Nop.Plugin.Tax.TaxJar.Models
{
    public class TaxTaxJarModel
    {
        public TaxTaxJarModel()
        {
            TestAddress = new TestAddressModel();
        }

        [NopResourceDisplayName("Plugins.Tax.TaxJar.Fields.ApiToken")]
        public string ApiToken { get; set; }
        [NopResourceDisplayName("Plugins.Tax.TaxJar.Fields.StateProviceTable")]
        public string StateProviceTable { get; set; }

        public TestAddressModel TestAddress { get; set; }
        public string TestingResult { get; set; }
    }

    public class TestAddressModel
    {
        public TestAddressModel()
        {
            AvailableCountries = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Admin.Address.Fields.Country")]
        public int CountryId { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }

        [NopResourceDisplayName("Admin.Address.Fields.City")]
        public string City { get; set; }

        [NopResourceDisplayName("Admin.Address.Fields.ZipPostalCode")]
        public string Zip { get; set; }
    }

    public class TaxJarAllowedStateProvice
    {
        public string [] AbbrvList { get; set; }
    }
}