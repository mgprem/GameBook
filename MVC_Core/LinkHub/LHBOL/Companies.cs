using System;
using System.Collections.Generic;
using System.Text;

namespace LHBOL
{
    public partial class Companies
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime StatusExpire { get; set; }
        public byte Ab { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Cif { get; set; }
        public string Reg { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Domain { get; set; }
        public string Website1 { get; set; }
        public string Website2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Email4 { get; set; }
        public string Email5 { get; set; }
        public short? Discount { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string StripeId { get; set; }
       // public string CardBrand { get; set; }
        public string CardLastFour { get; set; }
        public DateTimeOffset? TrialEndsAt { get; set; }
    }
}
