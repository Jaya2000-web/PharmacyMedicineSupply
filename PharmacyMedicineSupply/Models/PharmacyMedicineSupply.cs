using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyMedicineSupply
{
    [Table("PharmacyMedicineSupply")]
    public class PharmacyMedicineSupply
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string PharmacyName { get; set; }
        public string MedicineName { get; set; }
        public int SupplyCount { get; set; }
    }
}
