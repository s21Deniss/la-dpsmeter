using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class ProjectileInfo
    {
        public void SteamDecode(BitReader reader)
        {
            SkillEffect = reader.ReadUInt32();
            SkillId = reader.ReadUInt32();
            ProjectileId = reader.ReadUInt64();
            u32_0 = reader.ReadUInt32();
            b_0 = reader.ReadByte();
            if (b_2 == 1)
                u32_1 = reader.ReadUInt32();
            u32_2 = reader.ReadUInt32();
            u64_1 = reader.ReadUInt64();
            SkillLevel = reader.ReadByte();
            b_4 = reader.ReadByte();
            if (b_4 == 1)
                blist_0 = reader.ReadList<Byte>();
            u32_3 = reader.ReadUInt32();
            u16_0 = reader.ReadUInt16();
            OwnerId = reader.ReadUInt64();
            Tripods = reader.ReadBytes(3);
            b_1 = reader.ReadByte();
            b_2 = reader.ReadByte();
            b_3 = reader.ReadByte();
            if (b_3 == 1)
                u64_0 = reader.ReadUInt64();
            b_5 = reader.ReadByte();
            u64_2 = reader.ReadUInt64();
            u64_3 = reader.ReadUInt64();
            bytearray_0 = reader.ReadBytes(6);
            u32_4 = reader.ReadUInt32();
            u16_1 = reader.ReadUInt16();
        }
    }
}
