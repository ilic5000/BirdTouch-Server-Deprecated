//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BirdTouch_Server.EntityFrameworkModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_info
    {
        public int id_user_private { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string adress { get; set; }
        public string fbLink { get; set; }
        public string twLink { get; set; }
        public string gPlusLink { get; set; }
        public string linkedInLink { get; set; }
        public byte[] profilePictureData { get; set; }
    }
}
