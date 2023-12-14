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
    
    
    public enum Error
    {
        
        AlreadyPlaying = 0,
        
        GameNotInitialized = 1,
        
        HexBoardNotInitialized = 2,
        
        GameAlreadyStarted = 3,
        
        GameAlreadyCreated = 4,
        
        InternalError = 5,
        
        NumberOfPlayersIsTooSmall = 6,
        
        NumberOfPlayersIsTooLarge = 7,
        
        MathOverflow = 8,
        
        NotEnoughResources = 9,
        
        NotEnoughPopulation = 10,
        
        BuyIndexOutOfBounds = 11,
        
        PlaceIndexOutOfBounds = 12,
        
        PlayerNotOnTurn = 13,
        
        PlayerNotInGame = 14,
        
        CurrentPlayerCannotForceFinishTurn = 15,
        
        GameNotPlaying = 16,
        
        BadGridSize = 17,
        
        TileIsNotEmpty = 18,
        
        TileOnMaxLevel = 19,
        
        CannotLevelUpEmptyTile = 20,
        
        CannotLevelUp = 21,
        
        TileSurroundedByEmptyTiles = 22,
        
        BlocksToPlayLimitNotPassed = 23,
    }
    
    /// <summary>
    /// >> 142 - Variant[pallet_hexalem.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
