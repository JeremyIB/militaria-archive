namespace Militaria.Domain.Tests;

public class ItemVisibilityTests
{
    [Fact]
    public void ItemVisibility_Default_IsPrivate()
    {
        var visibility = default(ItemVisibility);

        Assert.Equal(ItemVisibility.Private, visibility);
    }
}
