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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.pallet
{
    
    
    public enum Error
    {
        
        OrganizerNotSet = 0,
        
        CollectionIdNotSet = 1,
        
        EarlyStartTooEarly = 2,
        
        EarlyStartTooLate = 3,
        
        SeasonStartTooLate = 4,
        
        SeasonEndTooLate = 5,
        
        PeriodConfigOverflow = 6,
        
        PeriodsIndivisible = 7,
        
        UnknownSeason = 8,
        
        UnknownAvatar = 9,
        
        UnknownAvatarForSale = 10,
        
        UnknownTier = 11,
        
        UnknownTreasurer = 12,
        
        UnknownPreparation = 13,
        
        NonSequentialSeasonId = 14,
        
        SingleMintProbsOverflow = 15,
        
        BatchMintProbsOverflow = 16,
        
        IncorrectRarityPercentages = 17,
        
        TooManyRarityPercentages = 18,
        
        BaseProbTooHigh = 19,
        
        DuplicatedRarityTier = 20,
        
        MintClosed = 21,
        
        ForgeClosed = 22,
        
        TransferClosed = 23,
        
        TradeClosed = 24,
        
        NftTransferClosed = 25,
        
        SeasonClosed = 26,
        
        PrematureSeasonEnd = 27,
        
        MaxOwnershipReached = 28,
        
        MaxStorageTierReached = 29,
        
        Ownership = 30,
        
        AlreadyOwned = 31,
        
        IncorrectDna = 32,
        
        IncorrectData = 33,
        
        IncorrectAvatarId = 34,
        
        IncorrectSeasonId = 35,
        
        MintCooldown = 36,
        
        MaxComponentsTooLow = 37,
        
        MaxComponentsTooHigh = 38,
        
        MaxVariationsTooLow = 39,
        
        MaxVariationsTooHigh = 40,
        
        InsufficientFreeMints = 41,
        
        InsufficientBalance = 42,
        
        TooLowFreeMints = 43,
        
        TooFewSacrifices = 44,
        
        TooManySacrifices = 45,
        
        LeaderSacrificed = 46,
        
        AvatarCannotBeTraded = 47,
        
        AvatarInTrade = 48,
        
        AvatarLocked = 49,
        
        AvatarUnlocked = 50,
        
        IncorrectAvatarSeason = 51,
        
        IncompatibleAvatarVersions = 52,
        
        InsufficientStorageForForging = 53,
        
        CannotTransferToSelf = 54,
        
        CannotTransferFromInactiveAccount = 55,
        
        CannotClaimDuringSeason = 56,
        
        CannotClaimZero = 57,
        
        IncompatibleMintComponents = 58,
        
        IncompatibleForgeComponents = 59,
        
        InsufficientSacrifices = 60,
        
        ExcessiveSacrifices = 61,
        
        AlreadyPrepared = 62,
        
        NotPrepared = 63,
        
        NoServiceAccount = 64,
        
        EmptyIpfsUrl = 65,
    }
    
    /// <summary>
    /// >> 343 - Variant[pallet_ajuna_awesome_avatars.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
