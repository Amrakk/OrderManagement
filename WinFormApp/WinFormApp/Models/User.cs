using System;
using System.Collections.Generic;

namespace GUI.Models;

public partial class User
{
    public string UserId { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public override string ToString()
    {
        return "User{" +
                "userId='" + UserId + '\'' +
                ", email='" + Email + '\'' +
                ", password='" + Password + '\'' +
                '}';
    }
}
