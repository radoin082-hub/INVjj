﻿namespace INV.Domain.Entities.SupplierEntity

{
    public class Supplier
    {
        public Guid ID { set; get; }
        public string RC { set; get; }

        public long NIS { set; get; }

        public string RIB { set; get; }

        public string SupplierName { set; get; }
        public string CompanyName { set; get; }

        public string AccountName { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public long ART { set; get; }
        public long NIF { set; get; }
        public string BankAgency { set; get; }

        public SupplierState State { set; get; }
    }
}