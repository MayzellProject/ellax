﻿using System.Collections.Generic;

namespace EllaX.Logic.Clients.Responses.Parity.NetPeers
{
    public class NetPeerResult
    {
        public int Active { get; set; }
        public int Connected { get; set; }
        public int Max { get; set; }
        public IList<PeerItem> Peers { get; set; }
    }
}
