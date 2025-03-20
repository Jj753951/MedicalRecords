using System.ComponentModel.DataAnnotations.Schema;

namespace medicationred.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime DateCreated { get; set; }
        public string DoctorId { get; set; }
    }
}
