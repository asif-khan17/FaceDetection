using System;

namespace FaceDetection.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string ImageId { get; set; }
        public string ImageBase64String { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Name { get; set; }
    }
}