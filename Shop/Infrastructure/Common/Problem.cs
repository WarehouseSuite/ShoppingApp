namespace Shop.Infrastructure.Common;

public enum Problem
{
    None,
    BadRequest,
    Validation,
    LockedOut,
    Unauthorized,
    Internal,
    Network,
    NotFound,
    Conflict,
    IO
}