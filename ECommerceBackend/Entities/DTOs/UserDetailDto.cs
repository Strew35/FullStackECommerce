using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserDetailDto: IDto
    {
        public uint UserId { get; set; }
        public DateTime UserCreateTime { get; set; }
        public string UserEmail { get; set; }

        public string UserTypeName { get; set; }
        public uint UserTypeId { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
    }
}
