﻿namespace EmployeeAdminPortal.modals
{
    public class AddEmployeeDTO
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salar { get; set; }
    }
}
