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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_hexalem.pallet
{
    
    
    public enum Call
    {
        
        create_game = 0,
        
        play = 1,
        
        finish_turn = 2,
    }
    
    /// <summary>
    /// >> 122 - Variant[pallet_hexalem.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_hexalem.pallet.Move, BaseVoid>
    {
    }
}
