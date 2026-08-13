namespace Ordering.Domain.ValueObjects;

public record Payment
{
    public string? CardName { get; }
    public string CardNumber { get; }
    public string Expiration { get; }
    public string CVV { get; }
    public int PaymentMethod { get; }
}