public interface IVisitor
{
    // The visitor is the one that implements the business
    // logic on behafe of the visitables, freeing them
    // from having to know anything about it.

    void Visit(HealthComponent healthComponent);
    void Visit(ManaComponent manaComponeent);
}
