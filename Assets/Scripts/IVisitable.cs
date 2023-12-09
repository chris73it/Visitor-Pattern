public interface IVisitable
{
    // The advantage of the visitor pattern is that the Accept function
    // delegates 100% of the business logic to the visitor, that can
    // do its job because it know the type of the 'this' reference.

    void Accept(IVisitor visitor);
}
