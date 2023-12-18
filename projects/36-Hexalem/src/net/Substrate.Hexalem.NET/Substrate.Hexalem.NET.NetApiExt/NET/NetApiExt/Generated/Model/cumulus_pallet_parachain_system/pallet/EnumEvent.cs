//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.pallet
{
    
    
    public enum Event
    {
        
        ValidationFunctionStored = 0,
        
        ValidationFunctionApplied = 1,
        
        ValidationFunctionDiscarded = 2,
        
        UpgradeAuthorized = 3,
        
        DownwardMessagesReceived = 4,
        
        DownwardMessagesProcessed = 5,
        
        UpwardMessageSent = 6,
    }
    
    /// <summary>
    /// >> 30 - Variant[cumulus_pallet_parachain_system.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, BaseVoid, Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr32U8>>
    {
    }
}
