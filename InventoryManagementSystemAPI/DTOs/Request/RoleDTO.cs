﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystemAPI.DTOs
{
    public class RoleDTO
    {
        public string Rolename { get; set; }
    }

    public class ManageRoleUserDTO
    {
        [Required]
        public string RoleName { get; set; }

        [Required]
        public string UserId { get; set; }
    }

    public class UpdateRolesDTO
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public List<string> Roles { get; set; }
    }


}