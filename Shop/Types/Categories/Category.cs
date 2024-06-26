namespace Shop.Types.Categories;

public sealed record Category(
    Guid Id,
    Guid? ParentId,
    string Name,
    List<Category> Children )
{
    public static Category From( CategoryDto dto ) =>
        new( dto.Id, dto.ParentId, dto.Name, [] );
}