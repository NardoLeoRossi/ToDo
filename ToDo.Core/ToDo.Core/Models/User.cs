﻿namespace ToDo.Core.Models;

public class User
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public int Salt { get; set; }

    public string Password { get; set; } = string.Empty;
}
