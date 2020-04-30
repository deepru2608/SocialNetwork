using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FriendsForever_Library.ViewModels
{
    public class BankDetailsRazorModel
    {
        [Required]
        public string AccountHolderName { get; set; }
        [Required]
        public string AccountType { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string AccountNo { get; set; }
        [Required]
        public string IFSCCode { get; set; }
        [Required]
        public string PanCard { get; set; }
        [Required]
        public string NomineeName { get; set; }
        [Required]
        public string NomineeRelation { get; set; }
        public string UpiId { get; set; }
    }
}
