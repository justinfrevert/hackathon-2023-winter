//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue
{
    
    
    /// <summary>
    /// >> 407 - Composite[cumulus_pallet_dmp_queue.PageIndexData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PageIndexData : BaseType
    {
        
        /// <summary>
        /// >> begin_used
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _beginUsed;
        
        /// <summary>
        /// >> end_used
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _endUsed;
        
        /// <summary>
        /// >> overweight_count
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U64 _overweightCount;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 BeginUsed
        {
            get
            {
                return this._beginUsed;
            }
            set
            {
                this._beginUsed = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 EndUsed
        {
            get
            {
                return this._endUsed;
            }
            set
            {
                this._endUsed = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U64 OverweightCount
        {
            get
            {
                return this._overweightCount;
            }
            set
            {
                this._overweightCount = value;
            }
        }
        
        public override string TypeName()
        {
            return "PageIndexData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BeginUsed.Encode());
            result.AddRange(EndUsed.Encode());
            result.AddRange(OverweightCount.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BeginUsed = new Substrate.NetApi.Model.Types.Primitive.U32();
            BeginUsed.Decode(byteArray, ref p);
            EndUsed = new Substrate.NetApi.Model.Types.Primitive.U32();
            EndUsed.Decode(byteArray, ref p);
            OverweightCount = new Substrate.NetApi.Model.Types.Primitive.U64();
            OverweightCount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
