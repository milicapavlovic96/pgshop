using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Na čekanju")]
        Pending,

        [EnumMember(Value = "Uplata uspešna")]
        PaymentReceived,

        [EnumMember(Value = "Uplata neuspešna")]
        PaymentFailed
    }
}