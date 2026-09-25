namespace Militaria.Domain;

// Explicit values: these integers are stored in the database from week 2,
// so reordering the names must never change what a stored row means.
public enum ItemVisibility
{
    Private = 0,
    Unlisted = 1,
    Public = 2,
}
